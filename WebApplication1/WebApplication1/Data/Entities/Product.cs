namespace WebApplication1.Data.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }
        public ProductDetail ProductDetail { get; set; }
        
        public List<SaleHistory> SaleHistory { get; set; }

        public List<ProductCategory> ProductCategory { get; set; }
    }
}
