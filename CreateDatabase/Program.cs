using System;
using System.Data.SqlClient;

namespace CreateDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            // Подключение к базе данных
            string connectionString = "Data Source=.\\MYSQLEXPRESS;Database=master;Integrated Security=SSPI";

            // Создание подключения к базе данных
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Открываем соединение
                connection.Open();

                // Создание команды для создания базы данных "MyFriends"
                SqlCommand command = new SqlCommand();
                command.CommandText = "CREATE DATABASE MyFriends";
                command.Connection = connection;
                command.ExecuteNonQuery();

                // Вывод сообщения о создании базы данных
                Console.WriteLine("База данных создана");
            }
            Console.Read();
        }
    }
}
