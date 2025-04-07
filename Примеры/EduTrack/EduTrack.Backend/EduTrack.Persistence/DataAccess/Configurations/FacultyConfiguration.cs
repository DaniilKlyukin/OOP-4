using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using EduTrack.Infrastructure.Persistence.DataAccess.EntityConstraints;
using EduTrack.Persistence.DataAccess.Entities;

namespace EduTrack.Persistence.DataAccess.Configurations;

public class FacultyConfiguration : IEntityTypeConfiguration<Faculty>
{
    public void Configure(EntityTypeBuilder<Faculty> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(Constraints.Faculty.NameMaxLength);

        builder.Property(x => x.Phone)
            .IsRequired()
            .HasMaxLength(Constraints.Faculty.PhoneMaxLength);

        builder.HasMany(x => x.Departments)
            .WithOne(y => y.Faculty)
            .HasForeignKey(y => y.FacultyId);
    }
}
