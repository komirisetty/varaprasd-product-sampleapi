using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WellsFargo.Libraries.Models;

namespace WellsFargo.Libraries.DataAccess.Interfaces
{
    public interface IProductsRepositories
    {
        Task<IEnumerable<ProductsModel>> GetProductByName(string productName);

        Task<IEnumerable<ProductsModel>> GetProductByID(int productID);

        

        public 

        //Task<IEnumerable<ProductsModel>> GetAllProducts();
        List<ProductsModel> GetAllProducts();
    }
}
