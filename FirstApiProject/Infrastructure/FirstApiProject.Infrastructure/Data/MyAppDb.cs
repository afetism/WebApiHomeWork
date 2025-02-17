
using FirstApiProject.Domain.Entites.Concretes;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace FirstApiProject.Infrastructure.Data;

public class MyAppDb : DbContext
{
    public MyAppDb(DbContextOptions options) : base(options)
    {
    }
   
   public DbSet<Category> Categories { get; set; }
   public DbSet<Shipper> Shippers { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(e =>
           {
               e.ToTable("Categories")
               .HasKey(e => e.Id)
               .HasName("PK_Categories");

               e.Property(e => e.Id)
                .HasColumnName("CategoryID")
                .ValueGeneratedOnAdd();

               e.Property(e => e.Name)
                .HasColumnName("CategoryName")
                .HasColumnType("NVARCHAR(15)")
                .IsRequired();

               e.Property(e => e.Description)
                .HasColumnName("Description")
                .HasColumnType("NTEXT")
                .IsRequired(false);

               e.Property(e => e.Image)
                .HasColumnName("Picture")
                .HasColumnType("IMAGE");

           });

        modelBuilder.Entity<Shipper>(e =>
        {
            e.ToTable("Shippers")
            .HasKey(e => e.Id)
            .HasName("PK_Shippers");

            e.Property(e => e.Id)
             .HasColumnName("ShipperID")
             .ValueGeneratedOnAdd();


            e.Property(e => e.CompanyName)
             .HasColumnName("CompanyName")
             .HasColumnType("NVARCHAR(40)")
             .IsRequired();

            e.Property(e => e.Phone)
             .HasColumnName("Phone")
             .HasColumnType("NVARCHAR(24)")
             .IsRequired(false);    

        });

               
    }
}
