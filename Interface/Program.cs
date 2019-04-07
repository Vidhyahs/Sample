using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Interface
{
    class Program
    {
        public static void Main(string[] args)
        {
            DbConnections dbConnections = new DbConnections();

            Console.Write(dbConnections.OpenConnection());

            //dbConnections.Insert();
            dbConnections.Get();
            Console.Write("Inserted Man");
            Console.Write(dbConnections.CloseConnection());

            Console.ReadLine();
        }

    }

   public class DbConnections
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        //Constructor
        public DbConnections()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "studentdb";
            uid = "root";
            password = "root";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }
        public bool OpenConnection()
        {
            try
            {
              this.CloseConnection();
             
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        public void  Get()
        {
            string query = "SELECT * FROM student";

            //Create a list to store the result
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command

                var dataReader = cmd.ExecuteReader().GetEnumerator();
           
                //close Connection
                this.CloseConnection();

            }
        }

                //Close connection
                public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public void Insert()
        {
//            ID int(10) PK
//Name varchar(500)
//Price decimal(4, 2)
            string query = "INSERT INTO student (ID, Name,Price) VALUES('3','John Smith', '33')";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

    }
}

    




   
