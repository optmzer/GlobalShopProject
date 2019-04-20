using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalShopProject.Data.Models.Catalog
{
    public class CatalogBrand: BaseEntity
    {
        public string BrandName { get; set; }
        public string BrandPictureUri { get; set; } = "Not Provided";
    }
}
