using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VitalTrackAI.Api.Entities.Postgre;
using VitalTrackAI.Api.Models.Identity;

namespace VitalTrackAI.Api.Data;

public class VitalTrackAi_DbContext : IdentityDbContext<ApplicationUser>
{
    public VitalTrackAi_DbContext(DbContextOptions<VitalTrackAi_DbContext> options) : base(options) {}

    public DbSet<User> Users { get; set; }
    public DbSet<DailyMeasures> DailyMeasures { get; set; }
    public DbSet<MeasureType> MeasureTypes { get; set; }
    public DbSet<MedicalTest> MedicalTests { get; set; }
    public DbSet<MedicalTestResult> MedicalTestResults { get; set; }
    public DbSet<MenstrualCycleEntry> MenstrualCycleEntries { get; set; }
    public DbSet<SecurityLog> SecurityLogs { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}