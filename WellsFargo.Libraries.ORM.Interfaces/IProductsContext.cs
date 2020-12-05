 using System;
using System.Collections.Generic;
using MongoDB.Driver;
using WellsFargo.Libraries.Models;

namespace WellsFargo.Libraries.ORM.Interfaces
{
    public interface IProductsContext
    {
        IMongoCollection<ProductsModel> ProductsModels { get; }

        //List<ProductsModel> ProductsModels { get; }
    }
}
