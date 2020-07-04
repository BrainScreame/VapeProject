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
