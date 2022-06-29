using Mango.Services.ProductAPI.Model.Dtos;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mango.Services.ProductAPI.Repository
{
    public interface IProductReposioty
    {
        Task<IEnumerable<ProductDtos>> Getproducts();
        Task<ProductDtos> GetProductByID( int productsID);
        Task<ProductDtos> GetProductByName( string productName );
        Task<ProductDtos> GetProductByProductID( int productID );
        Task<ProductDtos> CreateProductDtos(ProductDtos productDtos);
        Task<ProductDtos> UpdateProductDtos(ProductDtos productDtos);
        Task<bool> DeleteProductDtos(int productID);


    }
}
