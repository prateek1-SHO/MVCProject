using System.Net.Http;
using System.Threading.Tasks;
using Web.Mango.Models;
using Web.Mango.Services.IServices;

namespace Web.Mango.Services
{
    public class ProductServices : BaseServices, IProductServices
    {
        private readonly IHttpClientFactory _ihttpclientFatory;
        public ProductServices(IHttpClientFactory ihttpclientFatory) : base(ihttpclientFatory)
        {

            this._ihttpclientFatory = ihttpclientFatory;
        }

        public async Task<T> CreateProductAsync<T>(ProductDtos productDTO)
        {
            return await this.SendAsync<T>(new APIREquest()

            {
                aPI_Type=SD.API_Type.POST,
                data=productDTO,
                URL=SD.ProductAPIBase+"api/products",
                AccessTocken=""
            });
        }

        public async Task<T> DeleteProductAsync<T>(int productId)
        {
            return await this.SendAsync<T>(new APIREquest()

            {
                aPI_Type = SD.API_Type.DELETE,
              
                URL = SD.ProductAPIBase + "api/products"+productId,
                AccessTocken = ""
            });
        }

        public async Task<T> GetALLProductAsync<T>()
        {
            return  await this.SendAsync<T>(new APIREquest()

            {
                aPI_Type = SD.API_Type.GET,
                
                URL = SD.ProductAPIBase + "api/products",
                AccessTocken = ""
            });
        }

        public async Task<T> GetProductByIdAsync<T>(int productId)
        {
            return await this.SendAsync<T>(new APIREquest()

            {
                aPI_Type = SD.API_Type.GET,

                URL = SD.ProductAPIBase + "api/products"+productId,
                AccessTocken = ""
            });
        }

        public async Task<T> UpdateProductAsync<T>(ProductDtos productDTO)
        {
            return await this.SendAsync<T>(new APIREquest()

            {
                aPI_Type = SD.API_Type.PUT,
                data = productDTO,
                URL = SD.ProductAPIBase + "api/products",
                AccessTocken = ""
            });
        }
    }
}
