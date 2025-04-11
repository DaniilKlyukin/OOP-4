using MeetingScheduler.Application;
using MeetingScheduler.Application.Common;
using MeetingScheduler.Application.Interfaces.Services;
using MeetingScheduler.Application.Services.Meetings;
using MeetingScheduler.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;

namespace MeetingScheduler.Api;

public class Program
{
    public static async Task Main(string[] args)
    {
        var provider = new ServiceCollection()
            .AddApplication()
            .AddInfrastructure()
            .BuildServiceProvider();

        try
        {
            await Loop(provider);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }

    private static async Task Loop(ServiceProvider provider)
    {
        using var scope = provider.CreateScope();
        var meetingService = scope.ServiceProvider.GetRequiredService<MeetingService>();
        await meetingService.EnableNotificationsAsync();

        while (true)
        {
            Console.Clear();
            ShowMenu();
            var command = Console.ReadLine();

            switch (command)
            {
                case "1": await CreateMeetingAsync(meetingService); break;
                case "2": await DeleteMeetingAsync(meetingService); break;
                case "3": await ExportDailyScheduleAsync(meetingService); break;
            }

            Console.WriteLine($"Нажмите любую клавишу, чтобы продолжить");
            Console.ReadKey();
        }
    }

    private static void ShowMenu()
    {
        Console.WriteLine("Введите команду");
        Console.WriteLine("1. Создать встречу");
        Console.WriteLine("2. Удалить встречу");
        Console.WriteLine("3. Экспортировать расписание встреч на день");
        Console.WriteLine();
    }

    private static async Task CreateMeetingAsync(IMeetingService meetingService)
    {
        Console.WriteLine("Введите название встречи");
        var title = Console.ReadLine();

        Console.WriteLine("Введите описание встречи");
        var description = Console.ReadLine();

        DateTime startTime;
        DateTime endTime;
        TimeSpan notificationTime;

        while (true)
        {
            Console.WriteLine("Введите дату и время начала встречи (формат: dd.MM.yyyy HH:mm)");
            if (DateTime.TryParseExact(Console.ReadLine(), "dd.MM.yyyy HH:mm",
                CultureInfo.InvariantCulture, DateTimeStyles.None, out startTime))
            {
                if (startTime > DateTime.Now)
                    break;
                Console.WriteLine("Дата начала должна быть в будущем!");
            }
            else
            {
                Console.WriteLine("Неверный формат даты!");
            }
        }

        while (true)
        {
            Console.WriteLine("Введите дату и время окончания встречи (формат: dd.MM.yyyy HH:mm)");
            if (DateTime.TryParseExact(Console.ReadLine(), "dd.MM.yyyy HH:mm",
                CultureInfo.InvariantCulture, DateTimeStyles.None, out endTime))
            {
                if (endTime > startTime)
                    break;
                Console.WriteLine("Дата окончания должна быть позже даты начала!");
            }
            else
            {
                Console.WriteLine("Неверный формат даты!");
            }
        }

        while (true)
        {
            Console.WriteLine("Введите за сколько минут до встречи нужно уведомить");
            if (int.TryParse(Console.ReadLine(), out var minutes) && minutes >= 0)
            {
                notificationTime = TimeSpan.FromMinutes(minutes);
                break;
            }
            Console.WriteLine("Неверный формат! Введите целое число минут.");
        }

        var command = new ScheduleMeetingCommand(title,
                                                 description,
                                                 startTime,
                                                 endTime,
                                                 Guid.NewGuid(),
                                                 notificationTime);

        var meeting = await meetingService.ScheduleMeetingAsync(command);

        Console.WriteLine($"Встреча '{meeting.Title}' успешно создана на {meeting.StartTime:g}");
    }

    private static async Task DeleteMeetingAsync(IMeetingService meetingService)
    {
        var meetings = (await meetingService.GetAllMeetings()).ToList();

        Console.WriteLine("Введите номер встречи, которую нужно удалить");

        for (int i = 0; i < meetings.Count; i++)
            Console.WriteLine($"{i}\t{meetings[i].StartTime}\t{meetings[i].Title}");

        var meetingIndex = int.Parse(Console.ReadLine());

        var command = new DeleteMeetingCommand(meetings[meetingIndex].Id);

        await meetingService.DeleteMeetingAsync(command);
    }

    private static async Task ExportDailyScheduleAsync(IMeetingService meetingService)
    {
        DateTime date;

        while (true)
        {
            Console.WriteLine("Введите на какую дату нужно экспортировать расписание встреч (формат: dd.MM.yyyy)");

            if (DateTime.TryParseExact(Console.ReadLine(), "dd.MM.yyyy",
                CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                break;
            }
            else
            {
                Console.WriteLine("Неверный формат даты!");
            }
        }

        Console.WriteLine("Введите путь до папки, куда нужо сохранить расписание");

        var folderPath = Console.ReadLine();

        var command = new ExportDailyScheduleCommand(date, Path.Combine(folderPath, $"Расписание {date:d}.txt"));

        await meetingService.ExportDailyScheduleAsync(command);

        Console.WriteLine("Расписание экспортировано!");
    }
}