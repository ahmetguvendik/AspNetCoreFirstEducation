namespace WebApplication1.Data.Entities
{
    public class SaleHistory
    {
       public int Id { get; set; } 
       public int ProductId { get; set; } 

        public int Adet { get; set; }

        public Product Product { get; set; }    
    }
}
