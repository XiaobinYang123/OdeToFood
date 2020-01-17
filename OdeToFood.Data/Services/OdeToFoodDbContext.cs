using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data.Services
{
    public class OdeToFoodDbContext : DbContext
    {   
        // 1st restaurant: the model we use is restaurant
        // 2nd restaurant: a table named restaurant
        public DbSet<Restaurant> Restaurants { get; set; }



    }
}
