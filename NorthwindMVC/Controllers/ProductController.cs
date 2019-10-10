using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NorthwindLibrary.DataAccess;
using NorthwindLibrary.Models;

namespace NorthwindMVC.Controllers
{
    public class ProductController : Controller
    {
        private IDataConnection _productConnection;

        public ProductController(IDataConnection productConnection)
        {
            _productConnection = productConnection;
        }

        // Get: Products
        public IActionResult Index()
        {
            List<ProductModel> products = _productConnection.GetAll_Products();
            return View(products);
        }
    }
}