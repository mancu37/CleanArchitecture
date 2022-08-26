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

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        /// <summary>
        /// Utilizamos Fluent API para configurar el modelo
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(c => c.Id)
                .HasMaxLength(5)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(40);

            modelBuilder.Entity<Product>()
                .Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(40);

            modelBuilder.Entity<Order>()
                .Property(c => c.CustomerId)
                .IsRequired()
                .HasMaxLength(5)
                .IsFixedLength();

            modelBuilder.Entity<Order>()
                .Property(c => c.Address)
                .IsRequired()
                .HasMaxLength(60);

            modelBuilder.Entity<Order>()
                .Property(c => c.City)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<OrderDetail>()
                .HasKey(c => new { c.OrderId, c.ProductId });

            modelBuilder.Entity<Order>()
                .HasOne<Customer>()
                .WithMany()
                .HasForeignKey(c => c.CustomerId);

            modelBuilder.Entity<OrderDetail>()
                .HasOne<Product>()
                .WithMany()
                .HasForeignKey(c => c.ProductId);

            modelBuilder.Entity<Product>()
                .HasData(
                    new Product { Id = 1, Name = "Notebook" },
                    new Product { Id = 2, Name = "Teclado" },
                    new Product { Id = 3, Name = "Mouse" }
                );

            modelBuilder.Entity<Customer>()
                .HasData(
                new Customer { Id = 1, Name = "Martin" },
                new Customer { Id = 2, Name = "Carolina" }
                );


        }

    }
}
