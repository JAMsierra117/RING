using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using RING.Compras.Model;

namespace RING.Compras.Data
{
    public class ComprasContext : DbContext
    {
        public ComprasContext(DbContextOptions<ComprasContext> options) : base(options)
        {
        }

        public DbSet<Proveedor> Proveedores { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Proveedor>()
                .HasKey(k => k.ID_Proveedor);         
        }
    }
}
