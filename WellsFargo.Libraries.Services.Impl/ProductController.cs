using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WellFargo.Libraries.Services.Interfaces;
using WellsFargo.Libraries.Domain.Interfaces;
using WellsFargo.Libraries.Models;

namespace WellsFargo.Libraries.Services.Impl
{

    [Route("api/products")]
    [ApiController]
    public class ProductController : ControllerBase, IProductController
    {
        private IProductsDomainService productsDomainService = default;

        public ProductController(IProductsDomainService productsDomainService)
        {
            if (productsDomainService == default(IProductsDomainService))
                throw new ArgumentNullException(nameof(productsDomainService));

            this.productsDomainService = productsDomainService;
        }
        public IActionResult AddNewProduct(ProductsModel newProductModel)
        {
            throw new NotImplementedException();
        }

        //public IActionResult GetAllProducts()
        //{
        //    throw new NotImplementedException();
        //}

        [HttpGet]
        [Route("products/search/{productId}")]
        public async Task<IActionResult> GetProductsListByID(int productId)
        {
            var productsListByID = default(IEnumerable<ProductsModel>);

            var result = default(IActionResult);

            productsListByID = await this.productsDomainService.GetProductsByID(productId);

            result = Ok(productsListByID);

            return result;

        }

        [HttpGet]
        [Route("products/search/{searchString}")]
        public async Task<IActionResult>GetProductsListByName(string searchString)
        {
            var productsListByName = default(IEnumerable<ProductsModel>);

            var result = default(IActionResult);

            productsListByName = await  this.productsDomainService.GetProductsByName(searchString);


            result = Ok(productsListByName);

            return result;

            

        }

        public IActionResult UpdateProduct(int customerProfileId)
        {
            throw new NotImplementedException();
        }
    }
}
