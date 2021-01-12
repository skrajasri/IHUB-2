using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Intra_Hub_v2.Models
{
    public partial class IntraHubv2Context : DbContext
    {
        public IntraHubv2Context()
        {
        }

        public IntraHubv2Context(DbContextOptions<IntraHubv2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<TblLogin> TblLogins { get; set; }
        public virtual DbSet<TblPortalAccess> TblPortalAccesses { get; set; }
        public virtual DbSet<TblPortalAccessMapping> TblPortalAccessMappings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=106.51.127.87,1433;Initial Catalog=Intra-Hub-v2;User ID=hrms;Password=hrms@123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginId, e.OrganizationCode, e.LoginEmployeeCode, e.LoginPassword })
                    .HasName("PK__tbl_logi__6685210570911712");

                entity.ToTable("tbl_login");

                entity.Property(e => e.LoginId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("login_id");

                entity.Property(e => e.OrganizationCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("organization_code");

                entity.Property(e => e.LoginEmployeeCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("login_employee_code");

                entity.Property(e => e.LoginPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("login_password");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.DelFlag).HasColumnName("del_flag");

                entity.Property(e => e.LastSignIn)
                    .HasColumnType("datetime")
                    .HasColumnName("last_sign_in");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<TblPortalAccess>(entity =>
            {
                entity.HasKey(e => new { e.PortalId, e.PortalName, e.PortalUrl })
                    .HasName("PK__tbl_port__C6A68B4BD2FB48B5");

                entity.ToTable("tbl_portal_access");

                entity.Property(e => e.PortalId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("portal_id");

                entity.Property(e => e.PortalName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("portal_name");

                entity.Property(e => e.PortalUrl)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("portal_url");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.DelFlag).HasColumnName("del_flag");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            modelBuilder.Entity<TblPortalAccessMapping>(entity =>
            {
                entity.HasKey(e => new { e.PortalMappingId, e.OrganizationCode, e.PortalId })
                    .HasName("PK__tbl_port__6015E3DF66420068");

                entity.ToTable("tbl_portal_access_mapping");

                entity.Property(e => e.PortalMappingId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("portal_mapping_id");

                entity.Property(e => e.OrganizationCode).HasColumnName("organization_code");

                entity.Property(e => e.PortalId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("portal_id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.DelFlag).HasColumnName("del_flag");

                entity.Property(e => e.EmployeeCode)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("employee_code");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
