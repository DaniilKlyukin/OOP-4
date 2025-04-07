using Microsoft.EntityFrameworkCore;
using Persistence.DataAccess.Configurations;
using Persistence.DataAccess.Entities;

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

    public DbSet<Note> Notes => Set<Note>();
}