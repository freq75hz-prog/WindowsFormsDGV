using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsDGV
{
    internal class DBConnection
    {
        private static SqlConnection _instance = null;
        public static SqlConnection GetInstance()
        {            
            if (_instance is null || _instance.State != ConnectionState.Open)
            {
                _instance = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
                _instance.Open();
            }
            return _instance;
        }
        private DBConnection() {}        
    }
}
