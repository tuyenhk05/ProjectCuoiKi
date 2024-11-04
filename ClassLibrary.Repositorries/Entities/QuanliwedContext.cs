using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary.Repositorries.Entities;

public partial class QuanliwedContext : DbContext
{
    public QuanliwedContext()
    {
    }

    public QuanliwedContext(DbContextOptions<QuanliwedContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CartDetail> CartDetails { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<KoiFish> KoiFishes { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<ShoppingCart> ShoppingCarts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-HH0VFQ0\\SQLEXPRESS;Initial Catalog=quanliwed;Integrated Security=True;Trust Server Certificate=True");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CartDetail>(entity =>
        {
            entity.HasKey(e => e.CartDetailId).HasName("PK__CartDeta__01B6A6D4E33B032F");

            entity.Property(e => e.CartDetailId).HasColumnName("CartDetailID");
            entity.Property(e => e.CartId).HasColumnName("CartID");
            entity.Property(e => e.FishId).HasColumnName("FishID");

            entity.HasOne(d => d.Cart).WithMany(p => p.CartDetails)
                .HasForeignKey(d => d.CartId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__CartDetai__CartI__46E78A0C");

            entity.HasOne(d => d.Fish).WithMany(p => p.CartDetails)
                .HasForeignKey(d => d.FishId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__CartDetai__FishI__47DBAE45");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__Customer__A4AE64B848924439");

            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CustomerType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FullName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK__Employee__7AD04FF179EAFA16");

            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FullName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<KoiFish>(entity =>
        {
            entity.HasKey(e => e.FishId).HasName("PK__KoiFish__F82A5BF9C96CFA4B");

            entity.ToTable("KoiFish");

            entity.Property(e => e.FishId).HasColumnName("FishID");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Origin)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Size).HasColumnType("decimal(5, 2)");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PK__Orders__C3905BAF57E64900");

            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.OrderStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Customer).WithMany(p => p.Orders)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Orders__Customer__3D5E1FD2");
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.HasKey(e => e.OrderDetailId).HasName("PK__OrderDet__D3B9D30CDE2E6BB5");

            entity.Property(e => e.OrderDetailId).HasColumnName("OrderDetailID");
            entity.Property(e => e.FishId).HasColumnName("FishID");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Fish).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.FishId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__OrderDeta__FishI__412EB0B6");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__OrderDeta__Order__403A8C7D");
        });

        modelBuilder.Entity<ShoppingCart>(entity =>
        {
            entity.HasKey(e => e.CartId).HasName("PK__Shopping__51BCD797EDFC6A5E");

            entity.ToTable("ShoppingCart");

            entity.Property(e => e.CartId).HasColumnName("CartID");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

            entity.HasOne(d => d.Customer).WithMany(p => p.ShoppingCarts)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__ShoppingC__Custo__440B1D61");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
