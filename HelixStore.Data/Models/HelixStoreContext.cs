using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace HelixStore.Data.Models
{
    public partial class HelixStoreContext : DbContext
    {
        public HelixStoreContext()
        {
        }

        public HelixStoreContext(DbContextOptions<HelixStoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<DeliveryAddress> DeliveryAddresses { get; set; }
        public virtual DbSet<InventoryDeliveryVoucher> InventoryDeliveryVouchers { get; set; }
        public virtual DbSet<InventoryReceivingVoucher> InventoryReceivingVouchers { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductImg> ProductImgs { get; set; }
        public virtual DbSet<ProductType> ProductTypes { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=HelixStore;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("customer");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.CustomerFullname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("customer_fullname");

                entity.Property(e => e.CustomerGender)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("customer_gender");

                entity.Property(e => e.CustomerPassword)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("customer_password")
                    .HasDefaultValueSql("('e10adc3949ba59abbe56e057f20f883e')");

                entity.Property(e => e.CustomerPhone)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("customer_phone");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_customer_role");
            });

            modelBuilder.Entity<DeliveryAddress>(entity =>
            {
                entity.ToTable("delivery_address");

                entity.Property(e => e.DeliveryAddressId).HasColumnName("delivery_address_id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DeliveryAddressAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("delivery_address_address");

                entity.Property(e => e.DeliveryAddressPhone)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("delivery_address_phone");

                entity.Property(e => e.DeliveryAddressRecipient)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("delivery_address_recipient");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.DeliveryAddresses)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_delivery_address_customer");
            });

            modelBuilder.Entity<InventoryDeliveryVoucher>(entity =>
            {
                entity.HasKey(e => e.IdvId)
                    .HasName("PK__inventor__1517667CFE21C7D5");

                entity.ToTable("inventory_delivery_voucher");

                entity.Property(e => e.IdvId).HasColumnName("idv_id");

                entity.Property(e => e.IdvAmount).HasColumnName("idv_amount");

                entity.Property(e => e.IdvDate)
                    .HasColumnType("datetime")
                    .HasColumnName("idv_date");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.InventoryDeliveryVouchers)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_inventory_delivery_voucher_product");
            });

            modelBuilder.Entity<InventoryReceivingVoucher>(entity =>
            {
                entity.HasKey(e => e.IrvId)
                    .HasName("PK__inventor__7DDB7A6C725D0088");

                entity.ToTable("inventory_receiving_voucher");

                entity.Property(e => e.IrvId).HasColumnName("irv_id");

                entity.Property(e => e.IrvAmount).HasColumnName("irv_amount");

                entity.Property(e => e.IrvDate)
                    .HasColumnType("datetime")
                    .HasColumnName("irv_date");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.InventoryReceivingVouchers)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_inventory_receiving_voucher_product");
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.ToTable("invoice");

                entity.Property(e => e.InvoiceId).HasColumnName("invoice_id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DeliveryAddressId).HasColumnName("delivery_address_id");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnType("datetime")
                    .HasColumnName("invoice_date");

                entity.Property(e => e.InvoiceDiscount)
                    .HasColumnType("money")
                    .HasColumnName("invoice_discount");

                entity.Property(e => e.InvoiceProvisionalAmount)
                    .HasColumnType("money")
                    .HasColumnName("invoice_provisional_amount");

                entity.Property(e => e.InvoiceTotal)
                    .HasColumnType("money")
                    .HasColumnName("invoice_total");

                entity.Property(e => e.StaffId).HasColumnName("staff_id");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_invoice_customer");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_invoice_staff");
            });

            modelBuilder.Entity<InvoiceDetail>(entity =>
            {
                entity.ToTable("invoice_detail");

                entity.Property(e => e.InvoiceDetailId).HasColumnName("invoice_detail_id");

                entity.Property(e => e.InvoiceDetailAmount).HasColumnName("invoice_detail_amount");

                entity.Property(e => e.InvoiceDetailTotal)
                    .HasColumnType("money")
                    .HasColumnName("invoice_detail_total");

                entity.Property(e => e.InvoiceId).HasColumnName("invoice_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.InvoiceDetails)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_invoice_detail_invoice");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.InvoiceDetails)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_invoice_detail_product");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("product");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.ProductAmount).HasColumnName("product_amount");

                entity.Property(e => e.ProductDescription)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("product_description");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("product_name");

                entity.Property(e => e.ProductPrice)
                    .HasColumnType("money")
                    .HasColumnName("product_price");

                entity.Property(e => e.ProductTypeId).HasColumnName("product_type_id");

                entity.HasOne(d => d.ProductType)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ProductTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_product_product_type");
            });

            modelBuilder.Entity<ProductImg>(entity =>
            {
                entity.ToTable("product_img");

                entity.Property(e => e.ProductImgId).HasColumnName("product_img_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.ProductImgUrl).HasColumnName("product_img_url");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductImgs)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_product_img_product");
            });

            modelBuilder.Entity<ProductType>(entity =>
            {
                entity.ToTable("product_type");

                entity.Property(e => e.ProductTypeId).HasColumnName("product_type_id");

                entity.Property(e => e.ProductTypeName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("product_type_name");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("role");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("role_name");
            });

            modelBuilder.Entity<Staff>(entity =>
            {
                entity.ToTable("staffs");

                entity.Property(e => e.StaffId).HasColumnName("staff_id");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.StaffAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("staff_address");

                entity.Property(e => e.StaffFullname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("staff_fullname");

                entity.Property(e => e.StaffGender)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("staff_gender");

                entity.Property(e => e.StaffPassword)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("staff_password")
                    .HasDefaultValueSql("('e10adc3949ba59abbe56e057f20f883e')");

                entity.Property(e => e.StaffPhone)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("staff_phone");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.staff)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_staff_role");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
