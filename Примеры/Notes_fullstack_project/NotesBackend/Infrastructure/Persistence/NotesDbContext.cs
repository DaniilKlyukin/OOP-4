using Microsoft.EntityFrameworkCore;
using Persistence.DataAccess.Configurations;
using Persistence.DataAccess.Dto;

namespace Persistence;

public class NotesDbContext : DbContext
{
    public NotesDbContext(DbContextOptions<NotesDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new NoteConfiguration());
    }

    public DbSet<NoteDto> Notes => Set<NoteDto>();
}