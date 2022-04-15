using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace task__2.Models
{
    public partial class masterContext : DbContext
    {
        public masterContext()
        {
        }

        public masterContext(DbContextOptions<masterContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Productdet> Productdet { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-UD670AD\\SQLEXPRESS;Database=master;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Productdet>(entity =>
            {
                entity.HasKey(e => e.Pcode)
                    .HasName("PK__productd__293812AA0DCE3269");

                entity.ToTable("productdet");

                entity.Property(e => e.Pcode)
                    .HasColumnName("pcode")
                    .ValueGeneratedNever();

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pdesc)
                    .HasColumnName("pdesc")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pname)
                    .HasColumnName("pname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Stockinhand).HasColumnName("stockinhand");

                entity.Property(e => e.Unitprice)
                    .HasColumnName("unitprice")
                    .HasColumnType("money");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
