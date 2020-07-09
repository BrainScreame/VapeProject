using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace VapeApplication
{
    class DBVape
    {
        private static DBVape dbVape;

        public static string connectionString = "server=localhost;port=3306;username=root;password=;database=vapeapplication";
        MySqlConnection connection;

        public static DBVape getDBVape()
        {
            if (dbVape == null)
                dbVape = new DBVape();
            return dbVape;
        }

        private DBVape()
        {
           connection = new MySqlConnection(connectionString);
        }

        public int getSaller(string login, string password)
        {
            String expression = "SELECT id FROM sellers WHERE @login = LOGIN and sha1(@password) = PASSWORD";
            openConnection();

            MySqlCommand command = new MySqlCommand(expression, connection);
            // создаем параметр для логина
            MySqlParameter loginParam = new MySqlParameter("@login", login);
            // добавляем параметр к команде
            command.Parameters.Add(loginParam);
            // создаем параметр для пароля
            MySqlParameter passwordParam = new MySqlParameter("@password", password);
            // добавляем параметр к команде
            command.Parameters.Add(passwordParam);
            
            int number = Convert.ToInt32(command.ExecuteScalar());
            closeConnection();
            return number;
        }

        public List<Category> getCategory()
        {
            List<Category> categoryList = new List<Category>();

            String expression = "SELECT id, name FROM `category`";
            try
            {
                openConnection();
                MySqlCommand command = new MySqlCommand(expression, connection);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        categoryList.Add(new Category(reader.GetInt32(0), reader.GetString(1)));
                    }
                }
            }
            catch (MySqlException e) { MessageBox.Show(e.Message); }
            finally
            {
                // закрываем подключение
                closeConnection();
            }

            return categoryList;
        }

        public List<Product> getProdycts(int categoryId, int start, int count)
        {
            List<Product> prodyctList = new List<Product>();

            String expression = "SELECT id, name, categoryId, quantity, price, discount, description, image FROM `products` WHERE @categoryId = CATEGORYID LIMIT @start, @count";

            try
            {
                openConnection();
                MySqlCommand command = new MySqlCommand(expression, connection);
                MySqlParameter categoryParam = new MySqlParameter("@categoryId", categoryId);
                MySqlParameter startParam = new MySqlParameter("@start", start);
                MySqlParameter countParam = new MySqlParameter("@count", count);
                command.Parameters.Add(categoryParam);
                command.Parameters.Add(startParam);
                command.Parameters.Add(countParam);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        prodyctList.Add(new Product(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2),
                            reader.GetInt32(3), reader.GetFloat(4), reader.GetFloat(5), reader.GetString(6), 
                            Utils.byteArrayToImage((byte[])reader.GetValue(7))));
                    }
                }
            }
            catch (MySqlException e) { MessageBox.Show(e.Message); }
            finally
            {
                // закрываем подключение
                closeConnection();
            }

            return prodyctList;
        }

        public int getCountProdycts(int categoryId)
        {
            String expression = "SELECT COUNT(*) FROM `products` WHERE @categoryId = CATEGORYID";
            int count = 0;
            try
            {
                openConnection();
                MySqlCommand command = new MySqlCommand(expression, connection);
                MySqlParameter categoryParam = new MySqlParameter("@categoryId", categoryId);
                command.Parameters.Add(categoryParam);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        count = reader.GetInt32(0);
                    }
                }
            }
            catch (MySqlException e) { MessageBox.Show(e.Message); }
            finally
            {
                // закрываем подключение
                closeConnection();
            }

            return count;
        }

        public List<Product> getProdycts(int categoryId, string search)
        {
            List<Product> prodyctList = new List<Product>();

            String expression = "SELECT id, name, categoryId, quantity, price, discount, description, image FROM `products` WHERE @categoryId = CATEGORYID AND name LIKE @search";

            try
            {
                openConnection();
                MySqlCommand command = new MySqlCommand(expression, connection);
                MySqlParameter categoryParam = new MySqlParameter("@categoryId", categoryId);
                MySqlParameter searchParam = new MySqlParameter("@search", search);
                command.Parameters.Add(categoryParam);
                command.Parameters.Add(searchParam);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        prodyctList.Add(new Product(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2),
                            reader.GetInt32(3), reader.GetFloat(4), reader.GetFloat(5), reader.GetString(6),
                            Utils.byteArrayToImage((byte[])reader.GetValue(7))));
                    }
                }
            }
            catch (MySqlException e) { MessageBox.Show(e.Message); }
            finally
            {
                // закрываем подключение
                closeConnection();
            }

            return prodyctList;
        }

        public int getCountProdycts(int categoryId, string search)
        {
            String expression = "SELECT COUNT(*) FROM `products` WHERE @categoryId = CATEGORYID AND name LIKE @search";
            int count = 0;
            try
            {
                openConnection();
                MySqlCommand command = new MySqlCommand(expression, connection);
                MySqlParameter categoryParam = new MySqlParameter("@categoryId", categoryId);
                MySqlParameter searchParam = new MySqlParameter("@search", search);
                command.Parameters.Add(categoryParam);
                command.Parameters.Add(searchParam);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        count = reader.GetInt32(0);
                    }
                }
            }
            catch (MySqlException e) { MessageBox.Show(e.Message); }
            finally
            {
                // закрываем подключение
                closeConnection();
            }

            return count;
        }

        public void openConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
