using System.ComponentModel.DataAnnotations;

namespace EduTrack.Domain.Enums;

/// <summary>
/// Дни недели
/// </summary>
public enum DayOfWeek
{
    /// <summary>Понедельник</summary>
    [Display(Name = "Пн", ShortName = "Пн", Description = "Понедельник")]
    Monday = 1,

    /// <summary>Вторник</summary>
    [Display(Name = "Вт", ShortName = "Вт", Description = "Вторник")]
    Tuesday = 2,

    /// <summary>Среда</summary>
    [Display(Name = "Ср", ShortName = "Ср", Description = "Среда")]
    Wednesday = 3,

    /// <summary>Четверг</summary>
    [Display(Name = "Чт", ShortName = "Чт", Description = "Четверг")]
    Thursday = 4,

    /// <summary>Пятница</summary>
    [Display(Name = "Пт", ShortName = "Пт", Description = "Пятница")]
    Friday = 5,

    /// <summary>Суббота</summary>
    [Display(Name = "Сб", ShortName = "Сб", Description = "Суббота")]
    Saturday = 6,

    /// <summary>Воскресенье</summary>
    [Display(Name = "Вс", ShortName = "Вс", Description = "Воскресенье")]
    Sunday = 7
}
