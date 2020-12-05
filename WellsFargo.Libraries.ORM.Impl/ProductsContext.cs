using MongoDB.Driver;
using System;
using WellsFargo.Libraries.Models;
using WellsFargo.Libraries.ORM.Interfaces;

namespace WellsFargo.Libraries.ORM.Impl
{
    public class ProductsContext : IProductsContext

    {
        private IProductsDatabaseSettings productsDatabaseSettings = default(IProductsDatabaseSettings);
        private IMongoCollection<ProductsModel> productsModel = default(IMongoCollection<ProductsModel>);

        public ProductsContext(IProductsDatabaseSettings productsDatabaseSettings)
        {
            if (productsDatabaseSettings == default(IProductsDatabaseSettings))
            {
                throw new ArgumentNullException(nameof(productsDatabaseSettings));
            }
            this.productsDatabaseSettings = productsDatabaseSettings;

            var mongoClient = new MongoClient(this.productsDatabaseSettings.ConnectionString);
            var database = mongoClient.GetDatabase(this.productsDatabaseSettings.DatabaseName);
            this.productsModel = database.GetCollection<ProductsModel>(this.productsDatabaseSettings.CollectionName);
        }
        public IMongoCollection<ProductsModel> ProductsModels 
        {
            get 
            {
                return this.productsModel;
            }
        }

        //public IMongoCollection<ProductsModel> ProductsModels => throw new NotImplementedException();
    }
}
