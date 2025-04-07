namespace EduTrack.Infrastructure.Persistence.DataAccess.EntityConstraints;

public static partial class Constraints
{
    public static class Student
    {
        public const int FirstNameMaxLength = 100;
        public const int LastNameMaxLength = 100;
        public const int PatronymicMaxLength = 100;
        public const int EmailMaxLength = 50;
        public const int PhoneMaxLength = 50;
    }
}