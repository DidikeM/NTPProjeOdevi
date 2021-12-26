using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomation.Entities
{
    public class OrderAutomationContext : DbContext
    {
        public DbSet<Address> Addresses { get; set; }

        //public CarDBCtx() : base("CarDBCtxt")
        //{
        //    Database.SetInitializer(new DropCreateDatabaseIfModelChanges<CarDBCtxt>());
        //}

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        //}
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Tax> Taxes { get; set; }


    }
}
