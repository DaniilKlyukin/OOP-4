using System.ComponentModel.DataAnnotations;

namespace EduTrack.Domain.Enums;

/// <summary>
/// Пол
/// </summary>
public enum Gender
{
    /// <summary>Мужской пол</summary>
    [Display(Name = "Мужской", ShortName = "М", Description = "Мужской")]
    Male = 1,

    /// <summary>Женский< пол/summary>
    [Display(Name = "Женский", ShortName = "Ж", Description = "Женский")]
    Female = 2
}
