using System;
using System.Data.SqlClient;

namespace CreateTable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Подключение к базе данных
            string connectionString = "Data Source=.\\MYSQLEXPRESS;Database=Test1;Integrated Security=SSPI";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Открываем соединение
                connection.Open();

                // Создание команды для создания таблицы "Users"
                SqlCommand command = new SqlCommand();
                command.CommandText = "CREATE TABLE Users (Id INT PRIMARY KEY IDENTITY, Age INT NOT NULL, Name NVARCHAR(100) NOT NULL)";
                command.Connection = connection;
                command.ExecuteNonQuery();

                // Вывод сообщения о создании таблицы
                Console.WriteLine("Таблица Users создана");
            }
            Console.Read();
        }
    }
}
