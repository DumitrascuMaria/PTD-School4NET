using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SchoolOf.Common;
using SchoolOf.Data.Models;
using SchoolOf.Data.Seed;
using System;

namespace SchoolOf.Data
{
    public class DatabaseContext: DbContext //comunicare cu baza de date
    {
        //avem nevoie de un connection string
        //orm care iti permite sa comunici cu mai multe tipuri de bd 
        //db set= ofera contextul necesar pt a aplica dif functii pe modelul nostru

        public DbSet<Product> Products { get; set; }

        private readonly DbSettings dbSettings;
        public DatabaseContext(IOptions<DbSettings> optionSettings) //ctor dublu tab
        {
            this.dbSettings = optionSettings.Value; 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=shoppingcart;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasKey(x=>x.Id);
            modelBuilder.Entity<Product>().Property(x => x.Name).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Product>().Property(x => x.Description).IsRequired().HasMaxLength(2000);
            modelBuilder.Entity<Product>().Property(x => x.Price).IsRequired();
            modelBuilder.Entity<Product>().Property(x => x.Image).IsRequired();
            modelBuilder.Entity<Product>().Property(x => x.Category).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Product>().HasData(ProductInitialData.GetData());
        }

        //migrarea te ajuta sa tii sincronizata bd si modelul
        //add-migration Initial -v
        

    }
}
