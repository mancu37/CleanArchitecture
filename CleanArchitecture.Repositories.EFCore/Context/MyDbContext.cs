using CleanArchitecture.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Repositories.EFCore.Context
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Orden> Ordenes { get; set; }
        public DbSet<DetalleOrden> DetalleOrdenes { get; set; }

        /// <summary>
        /// Utilizamos Fluent API para configurar el modelo
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .Property(c => c.Id)
                .HasMaxLength(5)
                .IsFixedLength();

            modelBuilder.Entity<Cliente>()
                .Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(40);

            modelBuilder.Entity<Producto>()
                .Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(40);

            modelBuilder.Entity<Orden>()
                .Property(c => c.ClienteId)
                .IsRequired()
                .HasMaxLength(5)
                .IsFixedLength();

            modelBuilder.Entity<Orden>()
                .Property(c => c.Direccion)
                .IsRequired()
                .HasMaxLength(60);

            modelBuilder.Entity<Orden>()
                .Property(c => c.Ciudad)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<DetalleOrden>()
                .HasKey(c => new { c.OrdenId, c.ProductoId });

            modelBuilder.Entity<Orden>()
                .HasOne<Cliente>()
                .WithMany()
                .HasForeignKey(c => c.ClienteId);

            modelBuilder.Entity<DetalleOrden>()
                .HasOne<Producto>()
                .WithMany()
                .HasForeignKey(c => c.ProductoId);

            modelBuilder.Entity<Producto>()
                .HasData(
                    new Producto { Id = 1, Name = "Notebook" },
                    new Producto { Id = 2, Name = "Teclado" },
                    new Producto { Id = 3, Name = "Mouse" }
                );

            modelBuilder.Entity<Cliente>()
                .HasData(
                new Cliente { Id = 1, Name = "Martin" },
                new Cliente { Id = 2, Name = "Carolina" }
                );


        }

    }
}
