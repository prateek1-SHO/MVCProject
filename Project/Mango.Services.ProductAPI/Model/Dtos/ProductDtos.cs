namespace Mango.Services.ProductAPI.Model.Dtos
{
    public class ProductDtos
    {
        public int ProductID { get; set; } 
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }       
        public double Price { get; set; }
        public string CotegoryName { get; set; }
        public string ImageUrl { get; set; }
    }
}
