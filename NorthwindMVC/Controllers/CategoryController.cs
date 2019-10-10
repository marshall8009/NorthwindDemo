using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//...
using NorthwindLibrary;
using NorthwindLibrary.DataAccess;
using NorthwindLibrary.Models;

namespace NorthwindMVC.Controllers
{
    public class CategoryController : Controller
    {
        private IDataConnection _categoryConnection;

        public CategoryController(IDataConnection categoryConnection)
        {
            _categoryConnection = categoryConnection;
        }
        // Get: Categories
        public IActionResult Index()
        {
            List<CategoryModel> cat = _categoryConnection.GetAll_Categories();
            return View(cat);   
        }
    }
}