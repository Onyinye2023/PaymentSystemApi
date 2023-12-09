using Microsoft.EntityFrameworkCore;
using PaymentSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystem.Dal
{
    public class DatabaseContext :DbContext
    {
        public DatabaseContext(DbContextOptions options) : base (options)
        {
          
        }

        public DbSet<Merchant> Merchants { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Specify the column type and precision for 'AverageTransactionVolume'
            modelBuilder.Entity<Merchant>()
                .Property(b => b.AverageTransactionVolume)
                .HasPrecision(18, 2); 

           

            base.OnModelCreating(modelBuilder);
        }
    }
}
