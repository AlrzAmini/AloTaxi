using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Metadata;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AloTaxi.Domain.Entities.Log;
using AloTaxi.Domain.Entities.User;
using AloTaxi.Domain.Entities.User.Car;
using Microsoft.EntityFrameworkCore;

namespace AloTaxi.Data.Context
{
    public class AloTaxiDbContext : DbContext
    {
        public AloTaxiDbContext(DbContextOptions<AloTaxiDbContext> options) : base(options)
        {

        }

        #region dbsets

        #region user & car

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarColor> CarColors { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<DriverCar> DriverCars { get; set; }

        #endregion

        #region log

        public DbSet<LogModel> Logs { get; set; }

        #endregion

        #endregion

        #region model creator : overrides

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var rel in modelBuilder.Model.GetEntityTypes().SelectMany(s => s.GetForeignKeys()))
            {
                rel.DeleteBehavior = DeleteBehavior.Restrict;
            }

            #region query filters

            modelBuilder.Entity<Customer>()
                .HasQueryFilter(e => !e.IsDeleted);
            
            modelBuilder.Entity<Driver>()
                .HasQueryFilter(e => !e.IsDeleted);

            modelBuilder.Entity<Manager>()
                .HasQueryFilter(e => !e.IsDeleted);

            modelBuilder.Entity<Address>()
                .HasQueryFilter(e => !e.IsDeleted);

            modelBuilder.Entity<Car>()
                .HasQueryFilter(e => !e.IsDeleted);

            modelBuilder.Entity<CarColor>()
                .HasQueryFilter(e => !e.IsDeleted);

            modelBuilder.Entity<DriverCar>()
                .HasQueryFilter(e => !e.IsDeleted);

            #endregion

            base.OnModelCreating(modelBuilder);
        }

        #endregion
    }
}
