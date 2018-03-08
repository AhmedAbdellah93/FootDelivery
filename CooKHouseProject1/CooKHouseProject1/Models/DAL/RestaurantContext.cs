using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CookHouseDB.DAL
{
    public class RestaurantContext : DbContext
    {

        public RestaurantContext() : base("ResturantConnectionString")
        {

        }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Meals> Meals { get; set; }
        public virtual DbSet<Meals_Order> Meals_Orders { get; set; }
       // public virtual DbSet<offer> offers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Restaurant> Restaurants { get; set; }
        public virtual DbSet<Restaurant_Branch> Restaurant_Branchs { get; set; }
        public virtual DbSet<Governorate> Governorates { get; set; }
        public virtual DbSet<Quarter> Quarters { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //  modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Entity<Meals>()
          .HasRequired(p => p.Restaurant)
          .WithMany()
          .WillCascadeOnDelete(false);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();


            modelBuilder.Entity<Meals>()
        .HasRequired(p => p.Category)
        .WithMany()
        .WillCascadeOnDelete(false);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();


            modelBuilder.Entity<Meals_Order>()
        .HasRequired(p => p.Meals)
        .WithMany()
        .WillCascadeOnDelete(false);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();


            modelBuilder.Entity<Meals_Order>()
        .HasRequired(p => p.Order)
        .WithMany()
        .WillCascadeOnDelete(false);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();





          modelBuilder.Entity<Order>()
        .HasRequired(p => p.Restaurant_Branch)
        .WithMany()
        .WillCascadeOnDelete(false);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();


         modelBuilder.Entity<Order>()
        .HasRequired(p => p.Client)
        .WithMany()
        .WillCascadeOnDelete(false);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();





          modelBuilder.Entity<Quarter>()
        .HasRequired(p => p.Governorate)
        .WithMany()
        .WillCascadeOnDelete(false);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();



         modelBuilder.Entity<Restaurant_Branch>()
        .HasRequired(p => p.Restaurant)
        .WithMany()
        .WillCascadeOnDelete(false);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();


         modelBuilder.Entity<Restaurant_Branch>()
        .HasRequired(p => p.Quarter)
        .WithMany()
        .WillCascadeOnDelete(false);


           // modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}
