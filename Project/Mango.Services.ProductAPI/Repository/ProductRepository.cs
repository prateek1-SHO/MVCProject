using AutoMapper;
using Mango.Services.ProductAPI.DBContexts;
using Mango.Services.ProductAPI.Model;
using Mango.Services.ProductAPI.Model.Dtos;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mango.Services.ProductAPI.Repository
{
    public class ProductRepository : IProductReposioty
    {
        private readonly ApplictionDbContexts dbCon;
        private IMapper mapper;
        public ProductRepository(ApplictionDbContexts dbtos,IMapper _mapper)
        {
            dbCon = dbtos;
            mapper = _mapper;
        }
        public Task<ProductDtos> CreateProductDtos(ProductDtos ProductDtos)
        {
            Product product = mapper.Map(ProductDtos,Product)  
        }

        public async Task<bool> DeleteProductDtos(int productID)
        {
            try
            {
                Product product = await dbCon.Products.FirstOrDefaultAsync(u => u.ProductID == productID);
                if (product==null)
                {
                    return false;
                }
                dbCon.Products.Remove(product);
                 await dbCon.SaveChangesAsync();
                return true;
            }
            catch (System.Exception)
            {

                return false;
            }
        }

        public Task<ProductDtos> GetProductByID(int productsID)
        {
            throw new System.NotImplementedException();
        }

        public Task<ProductDtos> GetProductByName(string productName)
        {
            throw new System.NotImplementedException();
        }

        public async Task<ProductDtos> GetProductByProductID(int productID)
        {
            Product product = await dbCon.Products.Where(x => x.ProductID == productID).FirstOrDefaultAsync();
            return mapper.Map<ProductDtos>(product);

        }

        public async Task<IEnumerable<ProductDtos>> Getproducts()
        {
            List<Product> products = await dbCon.Products.ToListAsync();
            return mapper.Map<List<ProductDtos>>(products); 
        }

        public Task<ProductDtos> UpdateProductDtos(ProductDtos productDtos)
        {
            throw new System.NotImplementedException();
        }
    }
}
