using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Data.Entities
{
   // [Table(name:"Kategori",Schema ="c")] bu şekilde yapmaya DataAnnotations denir.
    public class Catagory
    {
        //[Column("category_id")]
        public int Id { get; set; }
      //  [Column("category_name",TypeName ="nvarchar(100")]
        public string Name { get; set; }

        public List<ProductCategory> ProductCategory { get; set; }
    }
}
