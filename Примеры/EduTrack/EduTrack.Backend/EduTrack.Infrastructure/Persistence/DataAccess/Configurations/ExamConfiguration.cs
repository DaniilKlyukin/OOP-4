using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using EduTrack.Infrastructure.Persistence.DataAccess.Entities;
using EduTrack.Infrastructure.Persistence.DataAccess.EntityConstraints;

namespace EduTrack.Infrastructure.Persistence.DataAccess.Configurations;

public class ExamConfiguration : IEntityTypeConfiguration<Exam>
{
    public void Configure(EntityTypeBuilder<Exam> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Description)
            .IsRequired()
            .HasMaxLength(Constraints.Exam.DescriptionMaxLength);

        builder.HasOne(x => x.Subject);

        builder.HasOne(x => x.Group);
    }
}
