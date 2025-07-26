using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VitalTrackAI.Api.Entities.Postgre;
using VitalTrackAI.Api.Helpers;
using VitalTrackAI.Api.Models.Identity;

namespace VitalTrackAI.Api.Data;

public class VitalTrackAi_DbContext : IdentityDbContext<ApplicationUser>
{
    private readonly string _encryptionKey;

    public VitalTrackAi_DbContext(DbContextOptions<VitalTrackAi_DbContext> options) : base(options)
    {
        _encryptionKey = Environment.GetEnvironmentVariable("VitalTrackAi_EncryptAtRest");
    }
    
    public DbSet<DailyMeasures> DailyMeasures { get; set; }
    public DbSet<MeasureType> MeasureTypes { get; set; }
    public DbSet<MedicalTest> MedicalTests { get; set; }
    public DbSet<MedicalTestResult> MedicalTestResults { get; set; }
    public DbSet<MenstrualCycleEntry> MenstrualCycleEntries { get; set; }
    public DbSet<SecurityLog> SecurityLogs { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<MedicalTest>()
            .Property(m => m.Notes)
            .HasConversion(
                v => CryptoHelper.Encrypt(v, _encryptionKey),
                v => CryptoHelper.Decrypt(v, _encryptionKey));

        builder.Entity<MedicalTestResult>()
            .Property(m => m.Result)
            .HasConversion(
                v => CryptoHelper.Encrypt(v.ToString(), _encryptionKey),
                v => double.Parse(CryptoHelper.Decrypt(v, _encryptionKey))
            );
    }
}