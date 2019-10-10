using Dapper;
using Microsoft.Extensions.Configuration;
using NorthwindLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace NorthwindLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        private IConfiguration _config;

        public SqlConnector(IConfiguration config)
        {
            _config = config;
        }

        public List<CategoryModel> GetAll_Categories()
        {
            List<CategoryModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(_config.GetConnectionString("DefaultConnection")))
            {
                output = connection.Query<CategoryModel>("dbo.spCategories_GetAll").ToList();
            }

            return output;
        }
    }
}
