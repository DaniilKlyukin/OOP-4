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

        builder.Property(x => x.Building)
            .IsRequired()
            .HasMaxLength(Constraints.Cabinet.BuildingMaxLength);

        builder.Property(x => x.Audience)
            .IsRequired()
            .HasMaxLength(Constraints.Cabinet.AudienceMaxLength);

        builder.Property(x => x.Description)
            .HasMaxLength(Constraints.Cabinet.DescriptionMaxLength);
    }
}
