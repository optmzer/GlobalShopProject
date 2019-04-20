namespace GlobalShopProject.Models
{
    public class CatalogItemViewModel
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public string ItemPictureUri { get; set; }
        public decimal Price { get; set; }
    }
}
