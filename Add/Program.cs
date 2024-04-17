using System;
using System.Data.SqlClient;

namespace Add
{
    class Program
    {
        static void Main(string[] args)
        {
            // Подключение к базе данных
            string connectionString = "Data Source=.\\MYSQLEXPRESS;Database=MyFriends;Integrated Security=SSPI";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Открываем соединение
                connection.Open();

                // Создание команды для добавления данных в таблицу "Friends"
                string sqlExpression = "INSERT INTO Friends (Name, Age) VALUES ('Tom', 36)";
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                int number = command.ExecuteNonQuery();
                Console.WriteLine($"Добавлено объектов: {number}");
            }
            Console.Read();
        }
    }
}
