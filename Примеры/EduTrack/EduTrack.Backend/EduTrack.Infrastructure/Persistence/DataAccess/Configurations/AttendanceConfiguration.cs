using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using EduTrack.Infrastructure.Persistence.DataAccess.Entities;

namespace EduTrack.Infrastructure.Persistence.DataAccess.Configurations;

public class AttendanceConfiguration : IEntityTypeConfiguration<Attendance>
{
    public void Configure(EntityTypeBuilder<Attendance> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.Lesson)
            .WithMany(y => y.Attendances)
            .HasForeignKey(x => x.LessonId);

        builder.Property(n => n.Status)
            .IsRequired();
    }
}