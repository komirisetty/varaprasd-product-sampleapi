using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WellsFargo.Libraries.Models;

namespace WellsFargo.Libraries.Domain.Interfaces
{
    public interface IProductsDomainService
    {
        Task<IEnumerable<ProductsModel>> GetProductsByName(string searchString);

        Task<IEnumerable<ProductsModel>> GetProductsByID(int productProfileId);
        
        bool AddNewProduct(ProductsModel productsModel);

       //Task<IEnumerable<ProductReview>> GetProductReviews(int productId = default(int), int customerId = default(int));
    }
}
