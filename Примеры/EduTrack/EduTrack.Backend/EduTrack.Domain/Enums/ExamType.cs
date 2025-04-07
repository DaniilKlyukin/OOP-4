using System.ComponentModel.DataAnnotations;

namespace EduTrack.Domain.Enums;

/// <summary>
/// Тип аттестационного мероприятия
/// </summary>
public enum ExamType
{
    /// <summary>Экзамен (письменный или устный)</summary>
    [Display(Name = "Экзамен", ShortName = "Экз", Description = "Письменный или устный экзамен")]
    Exam = 1,

    /// <summary>Зачёт (без оценки)</summary>
    [Display(Name = "Зачёт", ShortName = "Зач", Description = "Зачёт без оценки")]
    Test = 2,

    /// <summary>Зачёт с оценкой</summary>
    [Display(Name = "Диф.зачёт", ShortName = "Диф", Description = "Зачёт с дифференцированной оценкой")]
    GradedTest = 3,

    /// <summary>Курсовая работа</summary>
    [Display(Name = "Курсовая", ShortName = "КР", Description = "Курсовая работа")]
    Coursework = 4,

    /// <summary>Лабораторный практикум</summary>
    [Display(Name = "Лабораторная", ShortName = "ЛР", Description = "Лабораторная работа")]
    LabWork = 5,

    /// <summary>Рубежный контроль</summary>
    [Display(Name = "Рубежный контроль", ShortName = "РК", Description = "Промежуточный контроль знаний")]
    Midterm = 6,

    /// <summary>Выпускная квалификационная работа</summary>
    [Display(Name = "Дипломная работа", ShortName = "ВКР", Description = "Выпускная квалификационная работа")]
    FinalThesis = 7,

    /// <summary>Практика</summary>
    [Display(Name = "Практика", ShortName = "Прак", Description = "Учебная или производственная практика")]
    Internship = 8
}