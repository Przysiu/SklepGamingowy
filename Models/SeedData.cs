using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;



namespace SklepGamingowy.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Acer Predator",
                        Description = "PH315-53 15.6 IPS 144Hz i7-10750H 32GB RAM 1TB SSD GeForce RTX3060y",
                        Category = "PC",
                        Price = 6200
                    },
                    new Product
                    {
                        Name = "MAD DOG",
                        Description = "MD5600X-A03 R5-5600X 16GB RAM 500GB SSD 1TB HDD Radeon RX6600XT",
                        Category = "PC",
                        Price = 6300
                    },
                    new Product
                    {
                        Name = "Xbox Series X",
                        Description = "Series S - 512GB",
                        Category = "Konsole",
                        Price = 1400
                    },
                    new Product
                    {
                        Name = "PS5",
                        Description = "Sony PlayStation 5 Digital Edition",
                        Category = "Konsole",
                        Price = 2900
                    },
                    new Product
                    {
                        Name = "Nintendo Switch OLED",
                        Description = "OLED 7 cali, rozdzielczość 1280 x 720 pikseli, 10 punktowy multi-touch",
                        Category = "Konsole",
                        Price = 1900
                    },
                    new Product
                    {
                        Name = "7 Cudów Świata",
                        Description = "W 7 Cudów Świata może grać od trzech do siedmiu osób. Przeciętna runda zajmuje ok. 30 minut.",
                        Category = "Planszówki",
                        Price = 140
                    },
                    new Product
                    {
                        Name = "Carcassonne",
                        Description = "Carcassonne to gra dla dwóch do pięciu osób. Pojedyncza rozgrywka trwa ok. 30-45 minut.",
                        Category = "Planszówki",
                        Price = 98
                    },
                    new Product
                    {
                        Name = "DIXIT",
                        Description = "W Dixit może grać od trzech do siedmiu osób. Przeciętna runda zajmuje ok. 30 minut.",
                        Category = "Planszówki",
                        Price = 98
                    },
                    new Product
                    {
                        Name = "Na skrzydłach",
                        Description = "Na skrzydłach to gra dla 1-5 graczy, a pojedyncza runda zajmuje ok. 40-70 minut.",
                        Category = "Planszówki",
                        Price = 142
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
