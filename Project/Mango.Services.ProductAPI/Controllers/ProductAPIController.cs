using Mango.Services.ProductAPI.Model.Dtos;
using Mango.Services.ProductAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mango.Services.ProductAPI.Controllers
{
    [Route("API/Product")]
    public class ProductAPIController : ControllerBase
    {
        protected ResponceDtos responceDtos;
        private readonly IProductReposioty product;
        public ProductAPIController(IProductReposioty productReposioty)
        {
            product = productReposioty;
            this.responceDtos = new ResponceDtos();
        }
        [HttpGet]
        public async Task<object> GetProduct()
        {
            try
            {
                IEnumerable<ProductDtos> dtos = await product.Getproducts();
                responceDtos.Result = dtos;
            }
            catch (System.Exception ex)
            {
                responceDtos.IsSuccess = false;
                responceDtos.ErrorMessage = new List<string> { ex.ToString() };

            }

            return responceDtos;
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<object> GetProduct(int id)
        {
            try
            {
                ProductDtos dtos = await product.GetProductByProductID(id);
                responceDtos.Result = dtos;
            }
            catch (System.Exception ex)
            {
                responceDtos.IsSuccess = true;
                responceDtos.ErrorMessage = new List<string> { ex.ToString() };

            }

            return responceDtos;
        }
        [HttpPost]
        
        public async Task<object> Post([FromBody] ProductDtos productDtos)
        {
            try
            {
                ProductDtos dtos = await product.CreateProductDtos(productDtos);
                responceDtos.Result = dtos;
            }
            catch (System.Exception ex)
            {
                responceDtos.IsSuccess = true;
                responceDtos.ErrorMessage = new List<string> { ex.ToString() };

            }

            return responceDtos;
        }
        [HttpPut]
        public async Task<object> Put([FromBody] ProductDtos productDtos)
        {
            try
            {
                ProductDtos dtos = await product.CreateProductDtos(productDtos);
                responceDtos.Result = dtos;
            }
            catch (System.Exception ex)
            {
                responceDtos.IsSuccess = true;
                responceDtos.ErrorMessage = new List<string> { ex.ToString() };

            }

            return responceDtos;
        }

        [HttpDelete]
        public async Task<object> Delete(int id)
        {
            try
            {
                bool dtos = await product.DeleteProductDtos(id);
                responceDtos.Result = dtos;
            }
            catch (System.Exception ex)
            {
                responceDtos.IsSuccess = true;
                responceDtos.ErrorMessage = new List<string> { ex.ToString() };

            }

            return responceDtos;
        }
    }
    
}

