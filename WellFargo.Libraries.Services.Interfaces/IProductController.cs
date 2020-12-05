using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WellsFargo.Libraries.Models;

namespace WellFargo.Libraries.Services.Interfaces
{
    public interface IProductController
    {
        //IActionResult GetAllProducts();
        Task<IActionResult> GetProductsListByName(string searchString);
        Task<IActionResult> GetProductsListByID(int productId);       
        IActionResult AddNewProduct(ProductsModel newProductModel);
        IActionResult UpdateProduct(int customerProfileId);
    }
}
