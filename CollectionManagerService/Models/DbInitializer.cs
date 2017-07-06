using System;
using System.Linq;

namespace CollectionManagerService.Models
{
    public class DbInitializer
    {
        public static void Initialize(DatabaseContext context) {
            context.Database.EnsureCreated();

            if(context.Collections.Any()) {
                // return;
            }

            var collections = new Collection[] {
                new Collection { Name = "Software", Description = "Software Collection" },
                new Collection { Name = "Hardware", Description = "Hardware Collection" },
                new Collection { Name = "Video Games", Description = "Video Game Collection" }
            };

            foreach (var collection in collections) {
                context.Collections.Add(collection);
                context.SaveChanges();
            }
        }
    }
}
