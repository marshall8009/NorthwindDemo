using NorthwindLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
//...
using NorthwindLibrary.Models;

namespace NorthwindLibrary.DataAccess
{
    public interface IDataConnection
    {
        List<CategoryModel> GetAll_Categories();
        List<ProductModel> GetAll_Products();
    }
}
