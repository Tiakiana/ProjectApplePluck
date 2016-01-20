using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProjectOrchard
{
    class Database
    {
        private SqlConnection connect = new SqlConnection();
        private SqlCommand command = new SqlCommand();

        public Database()
        {
            connect.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sam\Documents\GitHub\eal\plantage\ProjectOrchard\Resources.mdf;Integrated Security=True";
        }

        public bool Save(Sale item)
        {
            try
            {
                // Prepare Sql command
                command.Connection = connect;
                command.CommandText = "saveSale";
                command.CommandType = CommandType.StoredProcedure;

                // Bind parameters
                command.Parameters.AddWithValue("type", item.Type);
                command.Parameters.AddWithValue("price", item.Price);
                command.Parameters.AddWithValue("kg", item.Kg);
                command.Parameters.AddWithValue("location", item.Location);
                command.Parameters.AddWithValue("saledate", item.SaleDate);

                // Open for connection & commencing SQL
                connect.Open();
                command.ExecuteNonQuery();

                return true;
                
            }
            catch (Exception exc)
            {
                Console.WriteLine("Query: saveSale");
                Console.WriteLine("Message: " + exc.Message);
                return false;
            }
        }


        public bool Update(int id, Sale item)
        {
            try
            {
                // Prepare Sql command
                command.Connection = connect;
                command.CommandText = "editSale";
                command.CommandType = CommandType.StoredProcedure;

                // Bind parameters
                command.Parameters.AddWithValue("id", id);
                command.Parameters.AddWithValue("type", item.Type);
                command.Parameters.AddWithValue("price", item.Price);
                command.Parameters.AddWithValue("kg", item.Kg);
                command.Parameters.AddWithValue("location", item.Location);
                command.Parameters.AddWithValue("saledate", item.SaleDate);

                // Open for connection & commencing SQL
                connect.Open();
                command.ExecuteNonQuery();

                return true;

            }
            catch (Exception exc)
            {
                Console.WriteLine("Query: editSale");
                Console.WriteLine("Message: " + exc.Message);
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                // Prepare Sql command
                command.Connection = connect;
                command.CommandText = "removeSale";
                command.CommandType = CommandType.StoredProcedure;

                // Bind parameters
                command.Parameters.AddWithValue("id", id);

                // Open for connection & commencing SQL
                connect.Open();
                command.ExecuteNonQuery();

                return true;

            }
            catch (Exception exc)
            {
                Console.WriteLine("Query: editSale");
                Console.WriteLine("Message: " + exc.Message);
                return false;
            }
        }

        public List<Sale> GetSaleBetweenDates(DateTime start, DateTime end)
        {
            return new List<Sale> { };
        }

        private void procedure(string query)
        {
            
        }

        private void procedure(string query, Dictionary<string, object> param)
        {

        }
    }
}
