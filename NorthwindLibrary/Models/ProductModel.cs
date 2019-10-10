using System;
using System.Collections.Generic;
using System.Text;

namespace NorthwindLibrary.Models
{
    public class ProductModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int SupplierID { get; set; }
        public int CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public ushort UnitsInStock { get; set; }
        public ushort UnitsOnOrder { get; set; }
        public ushort ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
    }
}
