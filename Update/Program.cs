using System;
using System.Data.SqlClient;

namespace Update
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

                // Создание команды для обновления данных в таблице "Friends"
                string sqlExpression = "UPDATE Friends SET Age=20 WHERE Name='Tom'";
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                int number = command.ExecuteNonQuery();
                Console.WriteLine($"Обновлено объектов: {number}");
            }
            Console.Read();
        }
    }
}
