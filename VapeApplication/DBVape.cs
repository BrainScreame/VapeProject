using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
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

        // ищем продавца по логину и паролю
        public void getSaller(string login, string password)
        {
            String expression = "SELECT * FROM sellers WHERE @login = LOGIN and sha1(@password) = PASSWORD";
            try
            {
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

                MySqlDataReader reader = command.ExecuteReader();
                
                if (reader.HasRows) // если есть данные
                {
                    reader.Read();
                    Seller.CreateSeller(reader.GetInt32(0), reader.GetString(1), reader.GetString(2)
                        , reader.GetString(3), login, password);
                }
            }
            catch (MySqlException e) { MessageBox.Show(e.Message); }
            finally
            {
                // закрываем подключение
                closeConnection();
            }
           
        }

        // получаем список категорий товаров
        public List<Category> getCategoryList()
        {
            List<Category> list = new List<Category>();
            String expression = "SELECT id, name FROM `category`";
            try
            {
                openConnection();
                MySqlCommand command = new MySqlCommand(expression, connection);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows) // если есть данные
                    while (reader.Read()) // построчно считываем данные
                        list.Add(new Category(reader.GetInt32(0), reader.GetString(1)));
            }
            catch (MySqlException e) { MessageBox.Show(e.Message); }
            finally
            {
                // закрываем подключение
                closeConnection();
            }
            return list;
        }

        public bool deleteProduct(Product product)
        {
            bool result = false;
            String mySqlExpression = "DELETE FROM `products` WHERE `id` = @id";
            try
            {
                openConnection();
                MySqlCommand command = new MySqlCommand(mySqlExpression, connection);

                MySqlParameter idParam = new MySqlParameter
                {
                    ParameterName = "@id",
                    Value = product.Id,
                };
                command.Parameters.Add(idParam);

                if (command.ExecuteNonQuery() > 0)
                    result = true;
            }
            catch (MySqlException e) { MessageBox.Show(e.Message); }
            finally
            {
                // закрываем подключение
                closeConnection();
            }
            return result;
        }

        // Добавляет товар в БД
        public bool addProduct(Product product)
        {
            string mySqlExpression = "INSERT INTO `products`" +
                " (`id`, `name`, `categoryId`, `quantity`, `price`, `discount`, `description`, `image`)" +
                " VALUES (NULL, @name, @category, @quantity, @price, @discount, @description, @image)";

            return execute_the_command_update_or_insert(mySqlExpression, product);
        }

        public bool updateProduct(Product product)
        {
            string mySqlExpression = "UPDATE `products` SET `categoryId` = @category," +
                "`name` = @name, `quantity` = @quantity, `price` = @price, `discount` = @discount, " +
                "`description` = @description, `image` = @image  WHERE `id` =  @id";

            return execute_the_command_update_or_insert(mySqlExpression, product);
        }

        private bool execute_the_command_update_or_insert(string mySqlExpression,Product product)
        {
            bool result = false;
            try
            {
                openConnection();
                MySqlCommand command = new MySqlCommand(mySqlExpression, connection);

                createParameters(command, product);

                if (command.ExecuteNonQuery() > 0)
                    result = true;
            }
            catch (MySqlException e) { MessageBox.Show(e.Message); }
            finally
            {
                // закрываем подключение
                closeConnection();
            }
            return result;
        }


        private void createParameters(MySqlCommand command, Product product)
        {
            MySqlParameter nameParam = new MySqlParameter
            {
                ParameterName = "@name",
                Value = product.Name,
                MySqlDbType = MySqlDbType.VarChar
            };
            command.Parameters.Add(nameParam);

            MySqlParameter categoryParam = new MySqlParameter
            {
                ParameterName = "@category",
                Value = product.CategoryId
            };
            categoryParam.Direction = System.Data.ParameterDirection.Input;
            command.Parameters.Add(categoryParam);


            MySqlParameter quantityParam = new MySqlParameter
            {
                ParameterName = "@quantity",
                Value = product.Quantity
            };
            command.Parameters.Add(quantityParam);

            MySqlParameter priceParam = new MySqlParameter
            {
                ParameterName = "@price",
                Value = product.Price
            };
            command.Parameters.Add(priceParam);

            MySqlParameter discountParam = new MySqlParameter
            {
                ParameterName = "@discount",
                Value = product.Discount
            };
            command.Parameters.Add(discountParam);

            MySqlParameter descriptionParam = new MySqlParameter
            {
                ParameterName = "@description",
                Value = product.Description
            };
            command.Parameters.Add(descriptionParam);

            byte[] imageData;
            ImageConverter converter = new ImageConverter();
            imageData = (byte[])converter.ConvertTo(product.Image, typeof(byte[]));
            MySqlParameter imageParam = new MySqlParameter
            {
                ParameterName = "@image",
                Value = imageData
            };
            command.Parameters.Add(imageParam);

            if (command.CommandText.Contains("@id")){
                MySqlParameter idParam = new MySqlParameter
                {
                    ParameterName = "@id",
                    Value = product.Id
                };
                command.Parameters.Add(idParam);
            }
        }

        public void openConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    connection.Open();
                }
                catch (MySqlException e) { MessageBox.Show(e.Message); }
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
