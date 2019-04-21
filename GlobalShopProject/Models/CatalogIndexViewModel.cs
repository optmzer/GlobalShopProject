using GlobalShopProject.Data.Models.Catalog;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalShopProject.Models
{
    public class CatalogIndexViewModel
    {
        // Data
        public IEnumerable<CatalogItemViewModel> CatalogItemsList { get; set; }

        // Filters
        public IEnumerable<SelectListItem> ItemBrands { get; set; }
        public IEnumerable<SelectListItem> ItemTypes { get; set; }

        // Search Queries
        public int? BrandFilterApplied { get; set; }
        public int? TypeFilterApplied { get; set; }
        public string SearchQuery { get; set; } = "";

        // Pagination Info
        public PaginationViewModel PaginationInfoModel { get; set; }
    }
}
