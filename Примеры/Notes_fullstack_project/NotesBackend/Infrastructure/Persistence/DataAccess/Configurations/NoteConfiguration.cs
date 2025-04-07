using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.DataAccess.Entities;

namespace Persistence.DataAccess.Configurations;

public class NoteConfiguration : IEntityTypeConfiguration<Entities.Note>
{
    public void Configure(EntityTypeBuilder<Entities.Note> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(n => n.Title)
            .HasMaxLength(Domain.Models.Note.MAX_TITLE_LENGTH)
            .IsRequired();

        builder.Property(n => n.Description)
            .IsRequired();

        builder.Property(n => n.CreatedAt)
            .IsRequired();
    }
}