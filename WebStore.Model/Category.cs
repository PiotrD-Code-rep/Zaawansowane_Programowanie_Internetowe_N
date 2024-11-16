namespace WebStore.Model
{
    public class Category
    {
        
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
