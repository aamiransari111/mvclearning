namespace OdeToFood.Migrations
{
    using OdeToFood.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OdeToFood.Models.OdeToFoodDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "OdeToFood.Models.OdeToFoodDB";
        }

        protected override void Seed(OdeToFood.Models.OdeToFoodDB context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Restaurants.AddOrUpdate(r => r.Name,

                new Restaurant { Name = "Test 1", City = "Mumbai", Country = "India" },
                    new Restaurant { Name = "Test 2", City = "Mumbai", Country = "India" },
                    new Restaurant {
                        Name="Test 3",
                        City="Mumbai",
                        Country="India",
                        Reviews= new List<RestaurantReview>
                        {
                            new RestaurantReview{Rating=9, Body="teslkjkjs jdla skld",ReviewerName="Aamir"}
                        }
                    });
        }
    }
}
