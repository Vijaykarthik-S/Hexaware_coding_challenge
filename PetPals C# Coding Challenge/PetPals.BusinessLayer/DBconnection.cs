using System.Configuration;
using System;

namespace PetPals.BusinessLayer.DBUtil
{
    public static class DBConnection
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;
        }
    }
}
