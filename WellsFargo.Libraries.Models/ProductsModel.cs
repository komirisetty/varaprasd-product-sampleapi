using System;

namespace WellsFargo.Libraries.Models
{
    public class ProductsModel
    {
        public int ProductId { get; set; }
        public string ProductTitle { get; set; }
        public string ProductDescription { get; set; }
        public int UnitCost { get; set; }
        public int UnitDiscount { get; set; }
        public int StockAvailable { get; set; }
        public int Rating { get; set; }

    }
}
