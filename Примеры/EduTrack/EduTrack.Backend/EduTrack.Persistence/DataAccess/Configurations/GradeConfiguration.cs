using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using EduTrack.Infrastructure.Persistence.DataAccess.EntityConstraints;
using System.ComponentModel.DataAnnotations;
using EduTrack.Persistence.DataAccess.Entities;

namespace EduTrack.Persistence.DataAccess.Configurations;

public class GradeConfiguration : IEntityTypeConfiguration<Grade>
{
    public void Configure(EntityTypeBuilder<Grade> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Value)
            .HasAnnotation("Range", new RangeAttribute(2, 5));

        builder.Property(x => x.Comment)
            .HasMaxLength(Constraints.Grade.CommentMaxLength);

        builder.HasOne(x => x.Subject);

        builder.HasOne(x => x.Student);
    }
}