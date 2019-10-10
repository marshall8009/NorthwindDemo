using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
//...
using NorthwindLibrary.DataAccess;

namespace NorthwindLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connections { get; private set; }

        //public static void InitializeConnections()
        //{
        //    SqlConnector sql = new SqlConnector();
        //    Connections = sql;
        //}

        public static string ConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
