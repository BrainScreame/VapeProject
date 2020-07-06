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
        public int getSaller(string login, string password)
        {
            int number = 0;
            String expression = "SELECT id FROM sellers WHERE @login = LOGIN and sha1(@password) = PASSWORD";
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

                number = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (MySqlException e) { MessageBox.Show(e.Message); }
            finally
            {
                // закрываем подключение
                closeConnection();
            }
            return number;
        }

        // получаем список категорий товаров
        public CategityList getCategityList()
        {
            CategityList list = new CategityList();
            String expression = "SELECT id, name FROM `category`";
            try
            {
                openConnection();
                MySqlCommand command = new MySqlCommand(expression, connection);
                MySqlDataReader reader = command.ExecuteReader();
                list = new CategityList();
                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        list.id.Add(reader.GetInt32(0));
                        list.name.Add(reader.GetString(1));
                    }
                }
            }
            catch (MySqlException e) { MessageBox.Show(e.Message); }
            finally
            {
                // закрываем подключение
                closeConnection();
            }
            return list;
        }

        // Добавляет товар в БД
        public bool addProduct(string name, float price, float discount, int quantity,
            int category, Image image, string description)
        {
            bool result = false;
            string mySqlExpression = "INSERT INTO `products`" +
                " (`id`, `name`, `categoryId`, `quantity`, `price`, `discount`, `description`, `image`)" +
                " VALUES (NULL, @name, @category, @quantity, @price, @discount, @description, @image)";
            try
            {
                openConnection();
                MySqlCommand command = new MySqlCommand(mySqlExpression, connection);

                MySqlParameter nameParam = new MySqlParameter
                {
                    ParameterName = "@name",
                    Value = name,
                    MySqlDbType = MySqlDbType.VarChar
                };
                command.Parameters.Add(nameParam);

                MySqlParameter categoryParam = new MySqlParameter
                {
                    ParameterName = "@category",
                    Value = category
                };
                categoryParam.Direction = System.Data.ParameterDirection.Input;
                command.Parameters.Add(categoryParam);


                MySqlParameter quantityParam = new MySqlParameter
                {
                    ParameterName = "@quantity",
                    Value = quantity
                };
                command.Parameters.Add(quantityParam);

                MySqlParameter priceParam = new MySqlParameter
                {
                    ParameterName = "@price",
                    Value = price
                };
                command.Parameters.Add(priceParam);

                MySqlParameter discountParam = new MySqlParameter
                {
                    ParameterName = "@discount",
                    Value = discount
                };
                command.Parameters.Add(discountParam);

                MySqlParameter descriptionParam = new MySqlParameter
                {
                    ParameterName = "@description",
                    Value = description
                };
                command.Parameters.Add(descriptionParam);

                byte[] imageData;
                ImageConverter converter = new ImageConverter();
                imageData = (byte[])converter.ConvertTo(image, typeof(byte[]));
                MySqlParameter imageParam = new MySqlParameter
                {
                    ParameterName = "@image",
                    Value = imageData
                };
                command.Parameters.Add(imageParam);
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
