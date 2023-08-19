using System;
using HR.LeaveManagement.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HR.LeaveManagement.Persistence.Configurations
{
    public class LeaveTypeConfiguration : IEntityTypeConfiguration<LeaveType>
    {
        public LeaveTypeConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<LeaveType> builder)
        {
            builder
            .HasData(
                    new LeaveType
                    {
                        Id = 1,
                        Name = "Vacation",
                        DefaultDays = 30,
                        DateCreated = DateTime.Now,
                        LastModified = DateTime.Now
                    }
            );


            builder.Property(q => q.Name)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}

