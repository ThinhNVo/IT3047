namespace GuitarShop.Models
{
    // Thinh Vo
    public class ProductListViewModel
    {
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public string SelectedCategory { get; set; }
        public string CheckedActiveCategory (string category)
        {
            return category == SelectedCategory ? "active" : "";
        }
    }
}
