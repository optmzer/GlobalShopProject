using GlobalShopProject.Data.Models.Catalog;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalShopProject.Data
{
    public class CatalogContextSeed
    {
        public static async Task SeedCatalogAsync(ApplicationDbContext context,
            ILoggerFactory loggerFactory, int? retry = 0)
        {
            int retryAvailable = retry.Value;

            try
            {
                // Seed DB
                if (!context.CatalogBrands.Any())
                {
                    context.CatalogBrands.AddRange(GetPreconfiguredCatalogBrands());
                    await context.SaveChangesAsync();
                }

                if (!context.CatalogTypes.Any())
                {
                    context.CatalogTypes.AddRange(GetPreconfiguredCatalogTypes());
                    await context.SaveChangesAsync();
                }

                if (!context.CatalogItems.Any())
                {
                    context.CatalogItems.AddRange(GetPreconfiguredCatalogItems());
                    await context.SaveChangesAsync();
                }

            }catch(Exception ex)
            {
                // Retry 10 times
                if(retryAvailable < 10)
                {
                    ++retryAvailable;
                    // Log Error
                    var log = loggerFactory.CreateLogger<CatalogContextSeed>();
                    log.LogError(ex.Message);
                    // Retry Seeding Again
                    await SeedCatalogAsync(context, loggerFactory, retryAvailable);
                }
            }


        }// SeedCatalogAsync()

        static IEnumerable<CatalogBrand> GetPreconfiguredCatalogBrands()
        {
            return new List<CatalogBrand>()
            {
                new CatalogBrand() {BrandName = "Jimmy's Pottery", BrandPictureUri = ""},
                new CatalogBrand() {BrandName = "Potters", BrandPictureUri = ""},
                new CatalogBrand() {BrandName = "Nana's Art School", BrandPictureUri = ""},
                new CatalogBrand() {BrandName = "Dominos", BrandPictureUri = ""},
                new CatalogBrand() {BrandName = "Earth Gifts", BrandPictureUri = ""},
                new CatalogBrand() {BrandName = "Native Crafts", BrandPictureUri = ""}
            };
        }

        static IEnumerable<CatalogType> GetPreconfiguredCatalogTypes()
        {
            return new List<CatalogType>()
            {
                new CatalogType() {ItemType = "Mugs"},
                new CatalogType() {ItemType = "Plates"},
                new CatalogType() {ItemType = "Carved Pottery"},
                new CatalogType() {ItemType = "Tea Sets"},
                new CatalogType() {ItemType = "Casserole"},
                new CatalogType() {ItemType = "Pots"},
                new CatalogType() {ItemType = "Flower Pots"}
            };
        }

        static IEnumerable<CatalogItem> GetPreconfiguredCatalogItems()
        {
            return new List<CatalogItem>()
            {
                new CatalogItem() {ItemName = "Collection Of Plates", Description = "An original collection of hand made ceramic plates", Price = 120.50M, PictureUri = "/img/CatalogItems/art-arts-and-crafts-artsy-716107.jpg", CatalogBrandsId = 4, CatalogTypesId = 1 },
                new CatalogItem() {ItemName = "Covfefe cup", Description = "Awesome hand made ceramic coffee cup", Price = 30.50M, PictureUri = "/img/CatalogItems/art-close-up-coffee-cup-1670052.jpg", CatalogBrandsId = 1, CatalogTypesId = 2 },
                new CatalogItem() {ItemName = "Ancient Spice Cups", Description = "Collection of ancient spice cups from middle east", Price = 90M, PictureUri = "/img/CatalogItems/bowls-cayenne-chili-54453.jpg", CatalogBrandsId = 2, CatalogTypesId = 3 },
                new CatalogItem() {ItemName = "Designer Tea Set For Three", Description = "Hand made white ceramic tea set. Made by very expensive designer", Price = 200.00M, PictureUri = "/img/CatalogItems/ceramic-container-design-1470008.jpg", CatalogBrandsId = 2, CatalogTypesId = 4 },
                new CatalogItem() {ItemName = "traditional Ceramics", Description = "A set of ceramic plates made in traditional colors", Price = 150.00M, PictureUri = "/img/CatalogItems/ceramic-plate-craft-design-1368037.jpg", CatalogBrandsId = 1, CatalogTypesId = 4 },
                new CatalogItem() {ItemName = "Ceramic Art", Description = "A tea set for 2. Very original design.", Price = 300.50M, PictureUri = "/img/CatalogItems/ceramics-cups-porcelain-2133982.jpg", CatalogBrandsId = 1, CatalogTypesId = 5 },
                new CatalogItem() {ItemName = "White Ceramic Coffee set", Description = "Coffe set from rare white ceramic.", Price = 199.99M, PictureUri = "/img/CatalogItems/coffee-drink-hot-1212811.jpg", CatalogBrandsId = 3, CatalogTypesId = 1 },
            };
        }

    }// class
}
