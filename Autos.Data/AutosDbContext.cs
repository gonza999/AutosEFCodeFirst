using Autos.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Autos.Data
{
    public class AutosDbContext : DbContext
    {
        public AutosDbContext()
            : base("name=AutosDbContext")
        {
        }

        public virtual DbSet<Auto> Autos { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Localidad> Localidades { get; set; }
        public virtual DbSet<Marca> Marcas { get; set; }
        public virtual DbSet<PaisDeOrigen> PaisesDeOrigen { get; set; }
        public virtual DbSet<Provincia> Provincias { get; set; }
        public virtual DbSet<SituacionIva> SituacionesIvas { get; set; }
        public virtual DbSet<Sucursal> Sucursales { get; set; }
        public virtual DbSet<TipoDeVehiculo> TiposDeVehiculos { get; set; }
        public virtual DbSet<Vendedor> Vendedores { get; set; }
        public virtual DbSet<Venta> Ventas { get; set; }

        public virtual DbSet<CategoriaDeVendedor> CategoriasDeVendedores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Auto>()
                .Property(e => e.Modelo)
                .IsUnicode(false);

            modelBuilder.Entity<Marca>()
                .Property(e => e.NombreMarca)
                .IsUnicode(false);

            modelBuilder.Entity<Marca>()
                .HasMany(e => e.Autos)
                .WithRequired(e => e.Marca)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoDeVehiculo>()
                .HasMany(e => e.Autos)
                .WithRequired(e => e.TipoDeVehiculo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Venta>()
                .Property(e => e.Monto)
                .HasPrecision(19, 4);
        }
    }
}
