using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using EduTrack.Infrastructure.Persistence.DataAccess.EntityConstraints;
using EduTrack.Persistence.DataAccess.Entities;

namespace EduTrack.Persistence.DataAccess.Configurations;

public class GroupConfiguration : IEntityTypeConfiguration<Group>
{
    public void Configure(EntityTypeBuilder<Group> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(Constraints.Group.NameMaxLength);

        builder.Property(x => x.Specialization)
            .IsRequired()
            .HasMaxLength(Constraints.Group.SpecializationMaxLength);

        builder.HasMany(x => x.Students)
            .WithOne(y => y.Group)
            .HasForeignKey(y => y.GroupId);
    }
}