using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONetExercise
{
    class DBShop
    {
        private readonly string _connectionString;

        public DBShop(string connectionString)
        {
            _connectionString = connectionString;
        }

        public int GetProductCount()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var sql = "SELECT COUNT(Name) FROM [dbo].[Product];";

                using (var command = new SqlCommand(sql, connection))
                {
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public void CreateProduct(string name, int categoryId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var sql = "INSERT INTO [dbo].[Product](Name, Category_Id)" +
                    " VALUES(@name, @categoryId);";

                using (var command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add(new SqlParameter("@name", name) { SqlDbType = SqlDbType.NVarChar });

                    command.Parameters.Add(new SqlParameter("@categoryId", categoryId) { SqlDbType = SqlDbType.Int });

                    command.ExecuteNonQuery();
                }
            }
        }

        public void CreateCategory(string name)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var sql = "INSERT INTO [dbo].[Category1](Name)" +
                    " VALUES(@name);";

                using (var command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add(new SqlParameter("@name", name) { SqlDbType = SqlDbType.NVarChar });

                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateProductByName(string newName, int newCategoryId, string conditionName)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var sql = "UPDATE [dbo].[Product] SET [Name] = @name, [Category_Id] = @categoryId WHERE Name = @conditionName; ";

                using (var command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add(new SqlParameter("@name", newName) { SqlDbType = SqlDbType.NVarChar });

                    command.Parameters.Add(new SqlParameter("@categoryId", newCategoryId) { SqlDbType = SqlDbType.Int });

                    command.Parameters.Add(new SqlParameter("@conditionName", conditionName) {SqlDbType = SqlDbType.NChar});

                    command.ExecuteNonQuery();
                }
            }
        }

        public void RemoveProduct(string name)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var sql = "DELETE FROM [dbo].[Product] WHERE [NAME] = @name; ";

                using (var command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add(new SqlParameter("@name", name) {SqlDbType = SqlDbType.NChar});

                    var rowsAffected = command.ExecuteNonQuery();

                    Console.WriteLine(rowsAffected);
                }
            }
        }

        public void PrintProducts()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var sql = "SELECT [dbo].[Product].[Name], [dbo].[Category1].[Name]" +
                          "FROM[dbo].[Product]" +
                          "INNER JOIN[dbo].[Category1]" +
                          "ON[dbo].[Category1].Id = [dbo].[Product].Category_Id;";

                using (var command = new SqlCommand(sql, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"{reader[0]} {reader[1]}");
                        }
                    }
                }
            }
        }

        public void PrintProducts1()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var sql = "SELECT [dbo].[Product].[Name], [dbo].[Category1].[Name]" +
                          "FROM[dbo].[Product]" +
                          "INNER JOIN[dbo].[Category1]" +
                          "ON[dbo].[Category1].Id = [dbo].[Product].Category_Id;";

                var adapter = new SqlDataAdapter(sql, connection);

                var dataSet = new DataSet();

                adapter.Fill(dataSet);

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    Console.WriteLine($"{row[0]} {row[1]}");
                }
            }
        }

        public void Transaction()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var transaction = connection.BeginTransaction();
                try
                {
                    var sql = "INSERT INTO [dbo].Category1(Name) VALUES(N'Принтеры');";

                    var command = new SqlCommand(sql,connection);

                    command.Transaction = transaction;
                    command.ExecuteNonQuery();

                    throw new Exception("Ошибка");

                    transaction.Commit();
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                }
            }
        }

        public void BadTransaction()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                try
                {
                    var sql = "INSERT INTO [dbo].Category1(Name) VALUES(N'Принтеры');";

                    var command = new SqlCommand(sql, connection);

                    command.ExecuteNonQuery();

                    throw new Exception("Ошибка");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }
    }
}
