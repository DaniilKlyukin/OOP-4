using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using EduTrack.Infrastructure.Persistence.DataAccess.EntityConstraints;
using EduTrack.Persistence.DataAccess.Entities;

namespace EduTrack.Persistence.DataAccess.Configurations;

public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
{
    public void Configure(EntityTypeBuilder<Department> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(Constraints.Department.NameMaxLength);

        builder.Property(x => x.Phone)
            .IsRequired()
            .HasMaxLength(Constraints.Department.PhoneMaxLength);

        builder.HasOne(x => x.Faculty)
            .WithMany(y => y.Departments)
            .HasForeignKey(x => x.FacultyId);

        builder.HasOne(x => x.Cabinet);
    }
}
