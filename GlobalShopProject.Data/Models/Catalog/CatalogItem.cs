using System;

/// <summary>
/// This Entity is for Catalog display only
/// </summary>
namespace GlobalShopProject.Data.Models.Catalog
{
    public class CatalogItem : BaseEntity
    {
        public string ItemName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string PictureUri { get; set; }
        public DateTime DateIntroduced { get; set; } = DateTime.Now;
        // Product Branding and Types
        public virtual CatalogBrand CatalogBrands {get; set;}
        public virtual CatalogType CatalogTypes{get; set;}
    }
}
