namespace WebApplication1.Data.Entities
{
    public class ProductDetail
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Details { get; set; }
        
        public Product Product { get; set; }
    }
}
