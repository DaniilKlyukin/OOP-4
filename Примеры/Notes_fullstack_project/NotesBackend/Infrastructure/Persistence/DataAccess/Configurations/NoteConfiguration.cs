using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.DataAccess.Dto;

namespace Persistence.DataAccess.Configurations;

public class NoteConfiguration : IEntityTypeConfiguration<NoteDto>
{
    public void Configure(EntityTypeBuilder<NoteDto> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(n => n.Title)
            .HasMaxLength(Note.MAX_TITLE_LENGTH)
            .IsRequired();

        builder.Property(n => n.Description)
            .IsRequired();

        builder.Property(n => n.CreatedAt)
            .IsRequired();
    }
}