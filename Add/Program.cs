using System;
using System.Data.SqlClient;

namespace Add
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

                // Создание команды для добавления данных в таблицу "Users"
                string sqlExpression = "INSERT INTO Users (Name, Age) VALUES ('Tom', 36)";
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                int number = command.ExecuteNonQuery();
                Console.WriteLine($"Добавлено объектов: {number}");
            }
            Console.Read();
        }
    }
}
