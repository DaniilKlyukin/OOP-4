using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using EduTrack.Infrastructure.Persistence.DataAccess.Entities;
using EduTrack.Infrastructure.Persistence.DataAccess.EntityConstraints;

namespace EduTrack.Infrastructure.Persistence.DataAccess.Configurations;

public class HomeworkConfiguration : IEntityTypeConfiguration<Homework>
{
    public void Configure(EntityTypeBuilder<Homework> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Content)
            .IsRequired()
            .HasMaxLength(Constraints.Homework.ContentMaxLength);

        builder.HasOne(x => x.Subject);

        builder.HasOne(x => x.Group);
    }
}