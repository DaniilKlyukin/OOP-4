using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using EduTrack.Infrastructure.Persistence.DataAccess.EntityConstraints;
using EduTrack.Persistence.DataAccess.Entities;

namespace EduTrack.Persistence.DataAccess.Configurations;

public class LessonConfiguration : IEntityTypeConfiguration<Lesson>
{
    public void Configure(EntityTypeBuilder<Lesson> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Topic)
            .IsRequired()
            .HasMaxLength(Constraints.Lesson.TopicMaxLength);

        builder.HasOne(x => x.Subject);

        builder.HasOne(x => x.Teacher);

        builder.HasOne(x => x.Group);

        builder.HasMany(x => x.Attendances)
            .WithOne(y => y.Lesson)
            .HasForeignKey(y => y.LessonId);
    }
}