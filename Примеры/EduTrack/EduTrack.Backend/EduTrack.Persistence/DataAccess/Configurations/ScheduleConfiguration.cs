using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using EduTrack.Infrastructure.Persistence.DataAccess.EntityConstraints;
using EduTrack.Persistence.DataAccess.Entities;

namespace EduTrack.Persistence.DataAccess.Configurations;

public class ScheduleConfiguration : IEntityTypeConfiguration<Schedule>
{
    public void Configure(EntityTypeBuilder<Schedule> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.Cabinet);

        builder.HasOne(x => x.Subject);

        builder.HasOne(x => x.Group);

        builder.HasOne(x => x.Teacher);
    }
}