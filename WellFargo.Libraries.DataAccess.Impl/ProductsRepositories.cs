using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WellsFargo.Libraries.DataAccess.Interfaces;
using WellsFargo.Libraries.Models;
using WellsFargo.Libraries.ORM.Interfaces;

namespace WellFargo.Libraries.DataAccess.Impl
{
    public class ProductsRepositories : IProductsRepositories
    {
        private readonly IProductsContext productsContext = default(IProductsContext);
        public ProductsRepositories(IProductsContext productsContext)
        {
            if(productsContext == default(IProductsContext))
            
                throw new ArgumentNullException(nameof(productsContext));
            
            this.productsContext = productsContext;
        }
        public List<ProductsModel> GetAllProducts()
        {
            //var result = this.productsContext.ProductsModels.FindAll();
            //var productsList = result;

            //return productsList.;

            throw new NotImplementedException();

        }

        public async Task<IEnumerable<ProductsModel>> GetProductByID(int productID)
        {
            var result = await this.productsContext.ProductsModels.FindAsync(p => p.ProductId == productID);

            var productResults = result.ToListAsync();

            return productResults;
        }

        public async Task< IEnumerable<ProductsModel>> GetProductByName(string productName)
        {
            var result = await this.productsContext.ProductsModels.FindAsync<ProductsModel>(r => r.ProductTitle == productName);

            var productResults = result.ToListAsync();

            return productResults;
            
        }
    }
}
