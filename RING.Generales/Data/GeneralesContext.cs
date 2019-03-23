using Microsoft.EntityFrameworkCore;
using RING.Generales.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RING.Generales.Data
{
    public class GeneralesContext : DbContext
    {
        public GeneralesContext(DbContextOptions<GeneralesContext> options) : base(options)
        {
        }

        public DbSet<Clasificacion> Clasificaciones { get; set; }
        public DbSet<Producto> Productos { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Clasificacion>()
                .ToTable("Clasificaciones","Generales")
                .HasKey(k => k.ID_Clasificacion);

            builder.Entity<Producto>()
                .ToTable("Productos", "Generales")
                .HasKey(k => k.ID_Producto);

            builder.Entity<Producto>()
                .HasOne(u => u.Clasificacion)
                .WithMany(u => u.Productos)
                .HasForeignKey(u => u.ID_Clasificacion)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
