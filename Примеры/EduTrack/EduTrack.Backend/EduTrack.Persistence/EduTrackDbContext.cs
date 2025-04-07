using EduTrack.Persistence.DataAccess.Configurations;
using EduTrack.Persistence.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace EduTrack.Persistence;

public class EduTrackDbContext : DbContext
{
    public EduTrackDbContext(DbContextOptions<EduTrackDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AttendanceConfiguration());
        modelBuilder.ApplyConfiguration(new CabinetConfiguration());
        modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
        modelBuilder.ApplyConfiguration(new ExamConfiguration());
        modelBuilder.ApplyConfiguration(new FacultyConfiguration());
        modelBuilder.ApplyConfiguration(new GradeConfiguration());
        modelBuilder.ApplyConfiguration(new GroupConfiguration());
        modelBuilder.ApplyConfiguration(new HomeworkConfiguration());
        modelBuilder.ApplyConfiguration(new LessonConfiguration());
        modelBuilder.ApplyConfiguration(new ScheduleConfiguration());
        modelBuilder.ApplyConfiguration(new StudentConfiguration());
        modelBuilder.ApplyConfiguration(new SubjectConfiguration());
        modelBuilder.ApplyConfiguration(new TeacherConfiguration());
    }

    public DbSet<Attendance> Attendances => Set<Attendance>();
    public DbSet<Cabinet> Cabinets => Set<Cabinet>();
    public DbSet<Department> Departments => Set<Department>();
    public DbSet<Exam> Exams => Set<Exam>();
    public DbSet<Faculty> Faculties => Set<Faculty>();
    public DbSet<Grade> Grades => Set<Grade>();
    public DbSet<Group> Groups => Set<Group>();
    public DbSet<Homework> Homeworks => Set<Homework>();
    public DbSet<Lesson> Lessons => Set<Lesson>();
    public DbSet<Schedule> Schedules => Set<Schedule>();
    public DbSet<Student> Students => Set<Student>();
    public DbSet<Subject> Subjects => Set<Subject>();
    public DbSet<Teacher> Teachers => Set<Teacher>();
}