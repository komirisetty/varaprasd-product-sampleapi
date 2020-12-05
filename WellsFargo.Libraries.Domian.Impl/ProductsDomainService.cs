using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WellsFargo.Libraries.DataAccess.Interfaces;
using WellsFargo.Libraries.Domain.Interfaces;
using WellsFargo.Libraries.Models;

namespace WellsFargo.Libraries.Domian.Impl
{
    public class ProductsDomainService : IProductsDomainService
    {
        private IProductsRepositories productsRepository = default(IProductsRepositories);
        public ProductsDomainService(IProductsRepositories productsRepository)
        {
            if (productsRepository == default(IProductsRepositories))
                throw new ArgumentNullException(nameof(productsRepository));

            this.productsRepository = productsRepository;
        }

        public bool AddNewProduct(ProductsModel productsModel)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductsModel>> GetProductsByID(int productId = 0)
        {

            var result = default(IEnumerable<ProductsModel>);
            if(productId != default(int))
            {
                result = await this.productsRepository.GetProductByID(productId);
            }

            return result;
        }

        public async Task<IEnumerable<ProductsModel>> GetProductsByName(string searchString)
        {
            var result = default(IEnumerable<ProductsModel>);
            if (searchString != null)
            {
                result = await this.productsRepository.GetProductByName(searchString);
            }

            return result;
        }
    }
}
