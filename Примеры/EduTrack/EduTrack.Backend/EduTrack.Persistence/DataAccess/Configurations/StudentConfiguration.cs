using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using EduTrack.Infrastructure.Persistence.DataAccess.EntityConstraints;
using EduTrack.Persistence.DataAccess.Entities;

namespace EduTrack.Persistence.DataAccess.Configurations;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.FirstName)
            .IsRequired()
            .HasMaxLength(Constraints.Student.FirstNameMaxLength);

        builder.Property(x => x.LastName)
            .IsRequired()
            .HasMaxLength(Constraints.Student.LastNameMaxLength);

        builder.Property(x => x.Patronymic)
            .HasMaxLength(Constraints.Student.PatronymicMaxLength);

        builder.Property(x => x.Email)
            .IsRequired()
            .HasMaxLength(Constraints.Student.EmailMaxLength);

        builder.Property(x => x.Phone)
            .IsRequired()
            .HasMaxLength(Constraints.Student.PhoneMaxLength);

        builder.HasOne(x => x.Group)
            .WithMany(y => y.Students)
            .HasForeignKey(x => x.GroupId);
    }
}
