using Dapper;
using Microsoft.Extensions.Configuration;
using NorthwindLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace NorthwindLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        private IConfiguration _config;
        

        public SqlConnector(IConfiguration config)
        {
            _config = config;
        }

        //TODO - find a way to refactor this line of code
        //public IDbConnection connection = new SqlConnection(_config.GetConnectionString("DefaultConnection"));

        public List<CategoryModel> GetAll_Categories()
        {
            List<CategoryModel> output;

            using (IDbConnection connection = new SqlConnection(_config.GetConnectionString("DefaultConnection")))
            {
                output = connection.Query<CategoryModel>("dbo.spCategories_GetAll").ToList();
            }

            return output;
        }

        public List<ProductModel> GetAll_Products()
        {
            List<ProductModel> output;

            using (IDbConnection connection = new SqlConnection(_config.GetConnectionString("DefaultConnection")))
            {
                output = connection.Query<ProductModel>("dbo.spProducts_GetAll").ToList();
            }

            return output;
        }
    }
}
