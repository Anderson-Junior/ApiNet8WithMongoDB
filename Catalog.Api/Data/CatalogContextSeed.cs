using Catalog.Api.Entities;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Catalog.Api.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(x => true).Any();
            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetMyProducts());
            }
        }

        private static IEnumerable<Product> GetMyProducts()
        {
            var products = new List<Product>()
            {
                new Product()
                {
                    Id = ObjectId.GenerateNewId().ToString(),
                    Name = "Smartphone",
                    Category = "Eletrônicos",
                    Description = "Smartphone com 128GB de armazenamento e câmera de alta resolução",
                    Image = "https://example.com/images/smartphone.jpg",
                    Price = 1299.99m
                },
                new Product()
                {
                    Id = ObjectId.GenerateNewId().ToString(),
                    Name = "Fone de Ouvido Bluetooth",
                    Category = "Acessórios",
                    Description = "Fone de ouvido sem fio com cancelamento de ruído",
                    Image = "https://example.com/images/fone-de-ouvido.jpg",
                    Price = 249.99m
                },
                new Product()
                {
                    Id = ObjectId.GenerateNewId().ToString(),
                    Name = "Notebook",
                    Category = "Informática",
                    Description = "Notebook com 16GB de RAM e 512GB SSD",
                    Image = "https://example.com/images/notebook.jpg",
                    Price = 4599.99m
                },
                new Product()
                {
                    Id = ObjectId.GenerateNewId().ToString(),
                    Name = "Smart TV 4K",
                    Category = "Eletrônicos",
                    Description = "TV de 55 polegadas com resolução 4K e HDR",
                    Image = "https://example.com/images/smart-tv.jpg",
                    Price = 3299.99m
                }
            };

            return products;
        }
    }
}
