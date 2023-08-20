using System;
using HR.LeaveManagement.Domain;
using HR.LeaveManagement.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace HR.LeaveManagement.Persistence.DatabaseContext;

public class HrDatabaseContext : DbContext
{
    public HrDatabaseContext(DbContextOptions<HrDatabaseContext> options) : base(options)
    {

    }

    public DbSet<LeaveType> LeaveTypes { get; set; }
    public DbSet<LeaveAllocation> LeaveAllocations { get; set; }
    public DbSet<LeaveRequest> LeaveRequests { get; set; }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        foreach (var entry in base.ChangeTracker.Entries<BaseDomainEntity>()
            .Where(q => q.State == EntityState.Added || q.State == EntityState.Modified))
        {
            entry.Entity.LastModified = DateTime.Now;

            if (entry.State == EntityState.Added)
                entry.Entity.DateCreated = DateTime.Now;
        }
        return base.SaveChangesAsync(cancellationToken);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(HrDatabaseContext).Assembly);
        //modelBuilder.Entity<LeaveType>()
        //    .HasData(
        //            new LeaveType
        //            {
        //                Id = 1,
        //                Name = "Vacation",
        //                DefaultDays = 30,
        //                DateCreated = DateTime.Now,
        //                LastModified = DateTime.Now
        //            }
        //    );
        base.OnModelCreating(modelBuilder);
    }
}

public class HRDbContextFactory : IDesignTimeDbContextFactory<HrDatabaseContext>
{
    public HrDatabaseContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<HrDatabaseContext>();
        optionsBuilder.UseSqlServer("server=localhost;database=HrManagement;User Id=sa;Password=reallyStrongPwd123;TrustServerCertificate=true;");

        return new HrDatabaseContext(optionsBuilder.Options);
    }
}

