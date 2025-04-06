using EduTrack.Infrastructure.Persistence.DataAccess.Configurations;
using EduTrack.Infrastructure.Persistence.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace EduTrack.Infrastructure.Persistence;

public class EduTrackDbContext : DbContext
{
    public EduTrackDbContext(DbContextOptions<EduTrackDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AttendanceConfiguration());
    }

    public DbSet<Attendance> Attendances => Set<Attendance>();
    public DbSet<Cabinet> Cabinets => Set<Cabinet>();
}