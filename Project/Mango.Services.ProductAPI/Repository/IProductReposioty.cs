using Mango.Services.ProductAPI.Model.Dtos;
using System.Linq;
using System.Threading.Tasks;

namespace Mango.Services.ProductAPI.Repository
{
    public interface IProductReposioty
    {
        Task<Enumerable<ProductDtos>> GetProducts();
        Task<ProductDtos> GetProductByID( int productsID);
        Task<ProductDtos> GetProductByName( string productName );
        Task<ProductDtos> GetProductByProductID( int productID );
        Task<ProductDtos> CreateProductDtos(ProductDtos productDtos);
        Task<ProductDtos> UpdateProductDtos(ProductDtos productDtos);
        Task<bool> DeleteProductDtos(int productID);


    }
}
