using System;
using System.Data.SqlClient;

namespace Delete
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

                // Создание команды для удаления данных из таблицы "Friends"
                string sqlExpression = "DELETE FROM Friends WHERE Name='Tom'";
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                int number = command.ExecuteNonQuery();
                Console.WriteLine($"Удалено объектов: {number}");
            }
            Console.Read();
        }
    }
}
