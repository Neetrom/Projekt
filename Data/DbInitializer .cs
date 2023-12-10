using Store.Models;
using System;
using System.Linq;

namespace Store.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            context.Database.EnsureCreated();

            if (context.Users.Any())
            {
                return;
            }

            var users = new User[]
            {
            new User{ID=1,Name="Alexander",Password="123", Age= DateTime.Parse("2005-09-01"), Is_deleted=false, Is_admin=false}
            };
            foreach (User u in users)
            {
                context.Users.Add(u);
            }
            context.SaveChanges();

            var products = new Product[]
            {
            new Product{ID=1,Title="Weed",Description="wjat", CreationDate= DateTime.Parse("2005-09-01"), IsDeleted=false, ImageUrl="none", CreatorUserId=0},
            new Product{ID=2,Title="Stone",Description="2", CreationDate= DateTime.Parse("1999-09-01"), IsDeleted=false,  ImageUrl="none", CreatorUserId=0}
            };
            foreach (Product p in products)
            {
                context.Products.Add(p);
            }
            context.SaveChanges();

    
        }
    }
}