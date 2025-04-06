using System.ComponentModel.DataAnnotations;

namespace EduTrack.Domain.Enums;

/// <summary>
/// Статус посещаемости занятия
/// </summary>
public enum AttendanceStatus
{
    /// <summary>Присутствовал на занятии</summary>
    [Display(Name = "Присутствовал", ShortName = "П", Description = "Студент присутствовал на занятии")]
    Present = 1,

    /// <summary>Отсутствовал без уважительной причины</summary>
    [Display(Name = "Отсутствовал", ShortName = "Н", Description = "Неявка без уважительной причины")]
    Absent = 2,

    /// <summary>Опоздал на занятие</summary>
    [Display(Name = "Опоздал", ShortName = "О", Description = "Опоздание")]
    Late = 3,

    /// <summary>Отсутствовал по уважительной причине</summary>
    [Display(Name = "Уважительная", ShortName = "У", Description = "Подтверждённое отсутствие (болезнь, справка)")]
    Excused = 4,

    /// <summary>Занятие отменено</summary>
    [Display(Name = "Отменено", ShortName = "Отм", Description = "Занятие не проводилось")]
    Canceled = 5,

    /// <summary>Дистанционное участие</summary>
    [Display(Name = "Онлайн", ShortName = "Дист", Description = "Участие дистанционно")]
    Remote = 6
}
