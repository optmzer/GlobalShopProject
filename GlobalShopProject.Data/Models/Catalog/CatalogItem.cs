using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalShopProject.Data.Models.Catalog
{
    public class CatalogItem : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string PictureUri { get; set; }
        // Product Branding and Types
        public virtual CatalogBrand CatalogBrands {get; set;}
        public virtual CatalogType CatalogTypes{get; set;}
    }
}
