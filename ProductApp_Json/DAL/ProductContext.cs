using ProductApp_Json.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProductApp_Json.DAL
{
    public class ProductContext:DbContext
    {
        public ProductContext() 
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().ToTable("Product");
        }
        public DbSet<Product> products {  get; set; }   
    }
}