using CarInsurance.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CarInsurance.Data
{
    public class InsuranceContext : DbContext
    {
        public InsuranceContext(DbContextOptions<InsuranceContext> options)
            : base(options)
        {
        }

        public DbSet<Insuree> Insurees { get; set; }
    }
}
