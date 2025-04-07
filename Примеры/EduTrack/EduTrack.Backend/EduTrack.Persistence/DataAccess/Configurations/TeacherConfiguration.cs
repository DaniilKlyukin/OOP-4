using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using EduTrack.Infrastructure.Persistence.DataAccess.EntityConstraints;
using EduTrack.Persistence.DataAccess.Entities;

namespace EduTrack.Persistence.DataAccess.Configurations;

public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
{
    public void Configure(EntityTypeBuilder<Teacher> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.FirstName)
            .IsRequired()
            .HasMaxLength(Constraints.Teacher.FirstNameMaxLength);

        builder.Property(x => x.LastName)
            .IsRequired()
            .HasMaxLength(Constraints.Teacher.LastNameMaxLength);

        builder.Property(x => x.Email)
            .IsRequired()
            .HasMaxLength(Constraints.Teacher.EmailMaxLength);

        builder.Property(x => x.Phone)
            .IsRequired()
            .HasMaxLength(Constraints.Teacher.PhoneMaxLength);

        builder.HasOne(x => x.Department)
            .WithMany(y => y.Teachers)
            .HasForeignKey(x => x.DepartmentId);
    }
}