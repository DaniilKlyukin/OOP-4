using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using EduTrack.Infrastructure.Persistence.DataAccess.Entities;
using EduTrack.Infrastructure.Persistence.DataAccess.EntityConstraints;

namespace EduTrack.Infrastructure.Persistence.DataAccess.Configurations;

public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
{
    public void Configure(EntityTypeBuilder<Subject> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(Constraints.Subject.NameMaxLength);

        builder.Property(x => x.Description)
            .IsRequired()
            .HasMaxLength(Constraints.Subject.DescriptionMaxLength);
    }
}
