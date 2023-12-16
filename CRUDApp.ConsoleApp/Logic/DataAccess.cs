using Microsoft.Data.SqlClient;

namespace CRUDApp.ConsoleApp.Logic
{
    public class DataAccess : IDataAccess
    {
        string connectionString;
        ConnectionManager connectionManager = new ConnectionManager();
        public DataAccess()
        {
            connectionString = connectionManager.GetConnectionString();
        }
        public void InsertData(int id, string name)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string insertQuery = "INSERT INTO test (id, name) VALUES (@Value1, @Value2)";
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Value1", id);
                    command.Parameters.AddWithValue("@Value2", name);
                    // Execute the query
                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Data inserted successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Data insert failed!");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
            }
        }
        public void ReadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string selectQuery = "SELECT id, name FROM test";

                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Access the data using reader
                            string value1 = reader["id"].ToString();
                            string value2 = reader["name"].ToString();

                            // Process the retrieved data as needed
                            Console.WriteLine($"Id: {value1}, Name: {value2}");
                        }
                    }
                }
            }
        }

        public void UpdateData(int id, string newName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string updateQuery = "UPDATE test SET name = @Value2 WHERE id = @value1";

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@Value1", id);
                    command.Parameters.AddWithValue("@Value2", newName);
                    try
                    {
                        // Execute the update query
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Data updated successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Data update failed!");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
            }
        }
        public void DeleteData(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string deleteQuery = "DELETE FROM test WHERE id = @value";
                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@value", id);
                    try
                    {
                        // Execute the delete query
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Data deleted successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Data update failed!");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
            }
        }
    }
}
