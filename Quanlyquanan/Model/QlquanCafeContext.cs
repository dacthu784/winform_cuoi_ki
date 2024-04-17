using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Quanlyquanan.Model;

public partial class QlquanCafeContext : DbContext
{
    public QlquanCafeContext()
    {
    }

    public QlquanCafeContext(DbContextOptions<QlquanCafeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<Table> Bans { get; set; }

    public virtual DbSet<Bill> Bills { get; set; }

    public virtual DbSet<BillInfor> BillInfors { get; set; }

    public virtual DbSet<Category> Categorys { get; set; }

    public virtual DbSet<Food> Foods { get; set; }

    public virtual DbSet<TypeAccount> Roles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-FIM4FKG5;Initial Catalog = QuanLyQuanCafe;Integrated Security=True; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("[PK__Account__3213E83F116EED0F]");

            entity.ToTable("Account");

            entity.Property(e => e.Id).HasColumnName("Id");
            entity.Property(e => e.IdRole).HasColumnName("IdTypeAccount");
            entity.Property(e => e.Passwords)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("Passwords");
            entity.Property(e => e.UsersName)
                .HasMaxLength(200)
                .HasColumnName("UsersName");
            entity.Property(e => e.DisplayName)
                .HasMaxLength(200)
                .HasColumnName("DisplayName");

            entity.HasOne(d => d.IdRoleNavigation).WithMany(p => p.Accounts)
                .HasForeignKey(d => d.IdRole)
                .HasConstraintName("[FK__Account__idRole__5535A963]");
        });

        modelBuilder.Entity<Table>(entity =>
        {
            entity.HasKey(e => e.IdTable).HasName("[PK__Ban__716BDE247E351A88]");

            entity.ToTable("Table");

            entity.Property(e => e.IdTable).HasColumnName("idTable");
            entity.Property(e => e.NameTable)
                .HasMaxLength(200)
                .HasColumnName("TableName");
        });

        modelBuilder.Entity<Bill>(entity =>
        {
            entity.HasKey(e => e.IdBill).HasName("[PK__Bill__E6F9339812707F32]");

            entity.ToTable("Bill");

            entity.Property(e => e.IdBill)
                .ValueGeneratedNever()
                .HasColumnName("IdBill");
            entity.Property(e => e.Status).HasColumnName("billStatus");
            entity.Property(e => e.DateCheckIn)
                .HasColumnType("DateTime")
                .HasColumnName("DateCheckIn");
            entity.Property(e => e.DateCheckOut)
                .HasColumnType("datetime")
                .HasColumnName("DateCheckOut");
            entity.Property(e => e.IdTable).HasColumnName("idTable");
            entity.Property(e => e.TotalPrice)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("TotalPrice");

            entity.HasOne(d => d.IdTableNavigation).WithMany(p => p.Bills)
                .HasForeignKey(d => d.IdTable)
                .HasConstraintName("[FK__Bill__idTable__5629CD9C]");
        });

        modelBuilder.Entity<BillInfor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("[PK__BillInfo__3213E83F6153BA9C]");

            entity.ToTable("BillInfor");

            entity.Property(e => e.Id).HasColumnName("Id");
            entity.Property(e => e.IdBill).HasColumnName("IdBill");
            entity.Property(e => e.IdFood).HasColumnName("IdFood");
            entity.Property(e => e.Count)
                .HasColumnType("Decimal(18, 0)")
                .HasColumnName("Count");

            entity.HasOne(d => d.IdBillNavigation).WithMany(p => p.BillInfors)
                .HasForeignKey(d => d.IdBill)
                .HasConstraintName("[FK__BillInfor__idBil__571DF1D5]");

            entity.HasOne(d => d.IdFoodNavigation).WithMany(p => p.BillInfors)
                .HasForeignKey(d => d.IdFood)
                .HasConstraintName("[FK__BillInfor__idFoo__5812160E]");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.IdCategory).HasName("[PK__Category__79D361B63C70F4F0]");

            entity.Property(e => e.IdCategory).HasColumnName("IdCategory");
            entity.Property(e => e.NameCategory).HasMaxLength(100);
        });

        modelBuilder.Entity<Food>(entity =>
        {
            entity.HasKey(e => e.IdFood).HasName("[PK__Foods__69D92BAA13C312B3]");

            entity.Property(e => e.IdFood).HasColumnName("IdFood");
            entity.Property(e => e.IdCategory).HasColumnName("IdCategory");
            entity.Property(e => e.NameFood).HasMaxLength(200);
            entity.Property(e => e.Price).HasColumnType("decimal(28, 0)")
                .HasColumnName("Price");

            entity.HasOne(d => d.IdCategoryNavigation).WithMany(p => p.Foods)
                .HasForeignKey(d => d.IdCategory)
                .HasConstraintName("[FK__Foods__idCategor__59063A47]");
        });

        modelBuilder.Entity<TypeAccount>(entity =>
        {
            entity.HasKey(e => e.IdTypeAccount).HasName("[PK__TypeAccount__E5045C543A04E247]");

            entity.Property(e => e.IdTypeAccount).HasColumnName("IdTypeAccount");
            entity.Property(e =>e.NameTypeAccount)
                .HasMaxLength(200)
                .HasColumnName("NameTypeAccount");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
