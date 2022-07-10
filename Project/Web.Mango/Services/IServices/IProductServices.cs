using Web.Mango.Models;
using System.Threading.Tasks;


namespace Web.Mango.Services.IServices
{
    public interface IProductServices:IBaseServices
    {
        Task<T> GetALLProductAsync<T>();
        Task<T> GetProductByIdAsync<T>(int productId);
        Task<T> CreateProductAsync<T>(ProductDtos productDTO);
        Task<T> UpdateProductAsync<T>(ProductDtos productDTO);
        Task<T> DeleteProductAsync<T>(int productId);
        
    }
}
