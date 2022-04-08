namespace WebApplication1.Data.Entities
{
    public class ProductCategory
    {
        public int ProductId { get; set; }

        public Product Product { get; set; }    

        public int CategoryId { get; set; }

        public Catagory Catagory { get; set; }  
    }
}
