
using System.Data.SqlClient;

namespace SupplyTracker.Models.Database
{
    public class DBHelper
    {
        /// <summary>
        /// To get the connection to the database
        /// </summary>
        /// <returns>SQLConnection object</returns>
        public static SqlConnection GetConnection()
        {
            // connect to database
            string connectionString = "Data Source=BLUESTAR7589;Initial Catalog=SupplyTracker;Integrated Security=True;";
            SqlConnection connect = new SqlConnection(connectionString);
            return connect;
        }
    }
}
