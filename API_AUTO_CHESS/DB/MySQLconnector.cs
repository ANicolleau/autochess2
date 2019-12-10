using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;


namespace API_Auto_Chess.DB
{
    public class MySQLconnector
    {
        //public static MySqlCommand cmd = new MySqlCommand();
        private MySqlConnection connection;

        public MySQLconnector()
        {
            this.GetDBConnection();
        }

        public void GetDBConnection()
        {
            try
            {
                String connString = "Server=localhost;port=3306;User Id=root;password=root";

                this.connection = new MySqlConnection(connString);
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
        }

        // Modifier fonction pour quelle colle à l'éxécution du script sql
        public List<string> InitBDD(string line)
        {
            List<string> name = new List<string>();

            try
            {
                connection.Open();
                MySqlCommand cmd = this.connection.CreateCommand();
                cmd.CommandText = line;
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            return name;
        }

        /// <summary>
        /// / Useless actuellement 
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        public List<string> DB_Select_All_VAlues(string line)
        {
            List<string> name = new List<string>();
            try
            {
                this.connection.Open();
                MySqlCommand cmd = this.connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM champions";
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();
                var count = 0;
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                        name.Add(reader.GetValue(i).ToString());

                    count++;
                }
                reader.Close();
                connection.Close();
            }
            catch (InvalidOperationException e)
            {
                Console.Write(e.Message);
            }
            return name;
        }
    }
}
