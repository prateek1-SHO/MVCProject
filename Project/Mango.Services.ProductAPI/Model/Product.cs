using System.ComponentModel.DataAnnotations;

namespace Mango.Services.ProductAPI.Model
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [Required]
        public string ProductName { get; set; }       
        public string ProductDescription { get; set; }
        [Range(1,1000)]
        public double Price { get; set; }
        public string CotegoryName { get; set; }
        public string ImageUrl { get; set; }



    }
}
