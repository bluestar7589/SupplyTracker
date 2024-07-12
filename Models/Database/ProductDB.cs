
using System.Data.SqlClient;

namespace SupplyTracker.Models.Database
{
    public class ProductDB
    {
        /// <summary>
        /// This method to add information of product to database
        /// </summary>
        /// <param name="p"></param>
        /// <exception cref="NotImplementedException"></exception>
        public static void Add(Products p)
        {
            // get connection
            SqlConnection connect = DBHelper.GetConnection();

            // Insert the customer to the database
            String insertStatement = "INSERT INTO Products (ProductName, LotNumber, Price, UnitOfSupply, DateOfProduct, DateOfExpire, ProductCategoryCode, VendorCode) " +
                                     "VALUES (@productName, @lotNumber, @price, @unitOfSupply, @productionDate, @expirationDate, @productCategoryCode, @vendorCode)";
            SqlCommand insertCommand = new SqlCommand();
            insertCommand.Connection = connect;
            insertCommand.CommandText = insertStatement;
            // add values for parametter
            insertCommand.Parameters.AddWithValue("@productName", p.ProductName);
            insertCommand.Parameters.AddWithValue("@lotNumber", p.LotNumber);
            insertCommand.Parameters.AddWithValue("@price", p.Price);
            insertCommand.Parameters.AddWithValue("@unitOfSupply", p.UnitOfSupply);
            insertCommand.Parameters.AddWithValue("@productionDate", p.DateOfProduct);
            insertCommand.Parameters.AddWithValue("@expirationDate", p.DateOfExpire);
            insertCommand.Parameters.AddWithValue("@productCategoryCode", p.ProductCategoryCode);
            insertCommand.Parameters.AddWithValue("@vendorCode", p.VendorCode);

            // Open the connection
            connect.Open();

            // Execute the query
            insertCommand.ExecuteNonQuery();

            connect.Close();
        }
    }
}
