using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using EduTrack.Infrastructure.Persistence.DataAccess.Entities;
using EduTrack.Infrastructure.Persistence.DataAccess.EntityConstraints;

namespace EduTrack.Infrastructure.Persistence.DataAccess.Configurations;

public class CabinetConfiguration : IEntityTypeConfiguration<Cabinet>
{
    public void Configure(EntityTypeBuilder<Cabinet> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(n => n.Building)
            .HasMaxLength(Constraints.Cabinet.BuildingMaxLength)
            .IsRequired();

        builder.Property(n => n.Audience)
            .HasMaxLength(Constraints.Cabinet.AudienceMaxLength)
            .IsRequired();

        builder.Property(n => n.Description)
            .HasMaxLength(Constraints.Cabinet.DescriptionMaxLength)
            .HasMaxLength(500);
    }
}