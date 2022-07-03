using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
      
            public ApplicationDbContext()
            {

            }

            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
            {

            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<CarsParkings>(builder=>
                {
                    builder.HasKey(sc => new
                    {
                        sc.CarId,sc.ParkingId
                    });
                    builder.HasOne(sc => sc.Car)
                        .WithMany(s => s.CarsParkings);
                    builder.HasOne(sc => sc.Parking)
                        .WithMany(s => s.CarsParkings);
                });

            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=Parking;Trusted_Connection=True;");
                }
            }
            public DbSet<Owner> People { get; set; }
            public DbSet<Car> Cars { get; set; }
            public DbSet<Parking> Parkings { get; set; }

        }
    }

