using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using eshop.Models;

namespace eshop.DAL
{
    public class eshopContext : DbContext

    {
        public eshopContext() : base("eshop")
        {

        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<CustomerOrder> CustomerOrders { get; set; }

        public DbSet<OrderedProduct> Orderedproducts { get; set; }

        public DbSet<Cart> Carts { get; set; }

    }
}