
using System.Data.SqlClient;

namespace SupplyTracker.Models.Database
{
    public class CustomerDB
    {
        /// <summary>
        /// This method to add the information of customer to database
        /// </summary>
        /// <param name="cus"></param>
        public static void Add(Customers cus)
        {
            // get connection
            SqlConnection connect = DBHelper.GetConnection();

            // Insert the customer to the database
            String insertStatement = "INSERT INTO Customers (FirstName, LastName, DepartmentCode, PhoneNumber, Position) VALUES (@fName, @lName, @dptCode, @phoneNumber, @position)";
            SqlCommand insertCommand = new SqlCommand();
            insertCommand.Connection = connect;
            insertCommand.CommandText = insertStatement;
            // add values for parametter
            insertCommand.Parameters.AddWithValue("@fName", cus.FirstName);
            insertCommand.Parameters.AddWithValue("@lName", cus.LastName);
            insertCommand.Parameters.AddWithValue("@dptCode", cus.DepartmentCode);
            insertCommand.Parameters.AddWithValue("@phoneNumber", cus.PhoneNumber);
            insertCommand.Parameters.AddWithValue("@position", cus.Position);

            // Open the connection
            connect.Open();

            // Execute the query
            insertCommand.ExecuteNonQuery();

            connect.Close();
        }
    }
}
