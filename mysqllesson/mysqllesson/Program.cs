using MySql.Data;
using MySql.Data.MySqlClient;


namespace mysqllesson
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=localhost;User=root;Password=1234;Database=library";
            MySqlConnection connection = new MySqlConnection(connectionString);
            
            bool isWork = true;
            

            string command=string.Empty;
            while (isWork)
            {
            connection.Open();

                MySqlCommand sqlcommand = new MySqlCommand();
                sqlcommand.Connection = connection;

                command = Console.ReadLine();

                if (command == "a")
                    isWork = false;
                switch (command)
                {
                    case "SELECT":
                        sqlcommand.CommandText = "SELECT * FROM author a";
                        MySqlDataReader reader = sqlcommand.ExecuteReader();

                        
                        while (reader.Read())
                        {
                            Console.WriteLine($"{reader.GetInt32("id")}, {reader.GetString("name")}");
                            Console.WriteLine();
                        }


                        break;
                    case "INSERT":
                        sqlcommand.CommandText = "INSERT author(name) VALUES(\"boba\")";
                        Console.WriteLine($"ДОБАВЛЕНО {sqlcommand.ExecuteNonQuery()}");


                        break;
                    case "UPDATE":
                        
                        Console.WriteLine($"ОБНОВЛЕНО {sqlcommand.ExecuteNonQuery()}");



                        break;
                    case "DELETE":
                        
                        Console.WriteLine($"УДАЛЕНО {sqlcommand.ExecuteNonQuery()}");


                        break;
                    default:
                        Console.WriteLine("Нет такой команды");
                        break;
                }
                Console.WriteLine();

            connection.Close();
            }


            Console.ReadLine();
        }
    }
}
