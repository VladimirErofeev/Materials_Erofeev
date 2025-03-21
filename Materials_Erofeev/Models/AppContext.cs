using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Materials_Erofeev.Models;

public partial class AppContext : DbContext
{
    public AppContext() { }

    public AppContext(DbContextOptions<AppContext> options) : base(options) { }

    public virtual DbSet<HistoryProduct> HistoryProducts { get; set; }

    public virtual DbSet<HistorySupply> HistorySupplies { get; set; }

    public virtual DbSet<Material> Materials { get; set; }

    public virtual DbSet<Partner> Partners { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<TypesMaterial> TypesMaterials { get; set; }

    public virtual DbSet<TypesPartner> TypesPartners { get; set; }

    public virtual DbSet<TypesProduct> TypesProducts { get; set; }

    public virtual DbSet<TypesSupplier> TypesSuppliers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=DBforPW_2;Username=postgres;Password=1111");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<HistoryProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_history_products");

            entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"FromProductsToPartners_Id_seq\"'::regclass)");

            entity.HasOne(d => d.IdPartnerNavigation).WithMany(p => p.HistoryProducts)
                .HasForeignKey(d => d.IdPartner)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_partner");

            entity.HasOne(d => d.IdProductNavigation).WithMany(p => p.HistoryProducts)
                .HasForeignKey(d => d.IdProduct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_product");
        });

        modelBuilder.Entity<HistorySupply>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_history_supplier");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('\"HistoryOfSupplies_id_seq\"'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.AmountOfPackages).HasColumnName("amountOfPackages");
            entity.Property(e => e.AmountOnePackage).HasColumnName("amountOnePackage");
            entity.Property(e => e.CostPerPackage)
                .HasColumnType("money")
                .HasColumnName("costPerPackage");
            entity.Property(e => e.Date)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("date");
            entity.Property(e => e.IdMaterial).HasColumnName("idMaterial");
            entity.Property(e => e.IdSupplier).HasColumnName("idSupplier");
            entity.Property(e => e.QualitySupply).HasColumnName("qualitySupply");

            entity.HasOne(d => d.IdMaterialNavigation).WithMany(p => p.HistorySupplies)
                .HasForeignKey(d => d.IdMaterial)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_historySuppliers_materials");

            entity.HasOne(d => d.IdSupplierNavigation).WithMany(p => p.HistorySupplies)
                .HasForeignKey(d => d.IdSupplier)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_historySuppliers_suppliers");
        });

        modelBuilder.Entity<Material>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Materials_pkey");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IdTypeMaterial).HasColumnName("idTypeMaterial");
            entity.Property(e => e.Image).HasColumnName("image");
            entity.Property(e => e.Name).HasColumnName("name");

            entity.HasOne(d => d.IdTypeMaterialNavigation).WithMany(p => p.Materials)
                .HasForeignKey(d => d.IdTypeMaterial)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_material_type");
        });

        modelBuilder.Entity<Partner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Partners_pkey");

            entity.Property(e => e.Rating).HasDefaultValue((short)1);
            entity.Property(e => e.Tin).HasColumnName("TIN");

            entity.HasOne(d => d.IdTypePartnerNavigation).WithMany(p => p.Partners)
                .HasForeignKey(d => d.IdTypePartner)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_partner_type");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Products_pkey");

            entity.Property(e => e.MinCostForPartner).HasColumnType("money");

            entity.HasOne(d => d.IdTypeProductNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.IdTypeProduct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_product_type");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Suppliers_pkey");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdTypeSupplier).HasColumnName("idTypeSupplier");
            entity.Property(e => e.IsWorking)
                .HasDefaultValue(true)
                .HasColumnName("isWorking");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Tin).HasColumnName("tin");

            entity.HasOne(d => d.IdTypeSupplierNavigation).WithMany(p => p.Suppliers)
                .HasForeignKey(d => d.IdTypeSupplier)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_supplier_type");
        });

        modelBuilder.Entity<TypesMaterial>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("TypesMaterial_pkey");

            entity.ToTable("TypesMaterial");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.TypeMaterial).HasColumnName("typeMaterial");
        });

        modelBuilder.Entity<TypesPartner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("TypesOfPartner_pkey");

            entity.ToTable("TypesPartner");

            entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"TypesOfPartner_Id_seq\"'::regclass)");
        });

        modelBuilder.Entity<TypesProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("TypesOfProduct_pkey");

            entity.ToTable("TypesProduct");

            entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"TypesOfProduct_Id_seq\"'::regclass)");
        });

        modelBuilder.Entity<TypesSupplier>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("TypesSuppliers_pkey");

            entity.ToTable("TypesSupplier");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('\"TypesSuppliers_id_seq\"'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.TypeSupplier).HasColumnName("typeSupplier");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
