using System;
using System.Data.SqlClient;

namespace CreateDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Создание строки подключения
                string connectionString = "Data Source=.\\MYSQLEXPRESS;Database=master;Integrated Security=SSPI";

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
            }
            catch
            {
                // Если возникла ошибка, запрашиваем название экземпляра SQL Server у пользователя
                Console.Write("Введите название экземпляра SQL Server (например, MYSQLEXPRESS): ");
                string instanceName = Console.ReadLine();

                // Создание строки подключения с учетом названия экземпляра
                string connectionString = $"Data Source=.\\{instanceName};Database=master;Integrated Security=SSPI";

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
            }
            Console.Read();
        }
    }
}
