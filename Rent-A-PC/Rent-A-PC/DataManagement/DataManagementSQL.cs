using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rent_A_PC.Model;
using System.Data;
using MySql.Data.MySqlClient;

namespace Rent_A_PC.DataManagement
{
    class DataManagementSQL : IDataManagement
    {
        private static DataManagementSQL dataManagementSQL;
        protected string connString = "server=localhost;port=3306;database=rent_a_pc;uid=root;pwd=";
        private DataManagementSQL()
        {

        }
        public static DataManagementSQL GetInstance()
        {
            if (dataManagementSQL == null)
            {
                dataManagementSQL = new DataManagementSQL();
            }
            return dataManagementSQL;
        }
        //Modulare ausführung eines MySql Statements, kann variabel benutzt werden.
        public bool MySqlRequest(string query)
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection(connString);
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlCommand.CommandText = query;
                mySqlCommand.ExecuteNonQuery();
                mySqlConnection.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //TODO: Exception handling.
                return false;
            }
        }
        public void Delete(Pc pcs)
        {
            int pcid = pcs.Id;
            string query = "DELETE FROM pc WHERE pcid = " + pcid + ";";
            bool requestResult = MySqlRequest(query);

            if (requestResult == true)
            {
                Console.WriteLine("Delete successful");
            }
            else
            {
                Console.WriteLine("Delete failed");
                //TODO: Handling.
            }
        }

        public void Delete(User users)
        {
            int userid = users.Id;
            string query = "DELETE FROM user WHERE userid = "+ userid +";";
            bool requestResult = MySqlRequest(query);

            if (requestResult == true)
            {
                Console.WriteLine("Delete successful");
            }
            else
            {
                Console.WriteLine("Delete failed");
                //TODO: Handling.
            }
        }

        public void Insert(Pc pcs)
        {
            string pcname = pcs.Name;
            string query = "INSERT INTO pc (pc) VALUES ('"+ pcname + "');";
            bool requestResult = MySqlRequest(query);

            if (requestResult == true)
            {
                Console.WriteLine("Insert successful");
            }
            else
            {
                Console.WriteLine("Insert failed");
                //TODO: Handling.
            }
        }

        public void Insert(User users)
        {
            string username = users.Name;
            string query = "INSERT INTO user (user) VALUES ('" + username + "');";
            bool requestResult = MySqlRequest(query);

            if (requestResult == true)
            {
                Console.WriteLine("Insert successful");
            }
            else
            {
                Console.WriteLine("Insert failed");
                //TODO: Handling.
            }
        }

        public void Update(Pc oldPc, Pc newPc)
        {
            int oldPcId = oldPc.Id;
            string pcNewName = newPc.Name;
            MySqlConnection mySqlConnection = new MySqlConnection(connString);
            mySqlConnection.Open();
            MySqlCommand mySqlCommand = mySqlConnection.CreateCommand();
            mySqlCommand.CommandText = "UPDATE pc SET pc = '" + pcNewName + "' WHERE pcid = " + oldPcId;
            mySqlCommand.ExecuteNonQuery();
            mySqlConnection.Close();
        }

        public void Update(User oldUser, User newUser)
        {
            int oldUserId = oldUser.Id;
            string userNewName = newUser.Name;
            MySqlConnection mySqlConnection = new MySqlConnection(connString);
            mySqlConnection.Open();
            MySqlCommand mySqlCommand = mySqlConnection.CreateCommand();
            mySqlCommand.CommandText = "UPDATE user SET user = '" + userNewName + "' WHERE userid = " + oldUserId;
            mySqlCommand.ExecuteNonQuery();
            mySqlConnection.Close();
        }

        public List<User> AllUsers()
        {
            List<User> AllUsersFromDB = new List<User>();
            MySqlConnection mySqlConnection = new MySqlConnection(connString);
            mySqlConnection.Open();
            MySqlCommand mySqlCommand = mySqlConnection.CreateCommand();
            mySqlCommand.CommandText = "SELECT * FROM user";
            MySqlDataReader reader = mySqlCommand.ExecuteReader();

            while (reader.Read())
            {
                User newUser = new User();
                newUser.Id = int.Parse(reader[0].ToString());
                newUser.Name = reader[1].ToString();
                AllUsersFromDB.Add(newUser);
            }
            reader.Close();
            mySqlConnection.Close();
            return AllUsersFromDB;
        }

        public List<Pc> AllPcs()
        {
            List<Pc> AllPcsFromDB = new List<Pc>();
            MySqlConnection mySqlConnection = new MySqlConnection(connString);
            mySqlConnection.Open();
            MySqlCommand mySqlCommand = mySqlConnection.CreateCommand();
            mySqlCommand.CommandText = "SELECT * FROM pc";
            MySqlDataReader reader = mySqlCommand.ExecuteReader();

            while (reader.Read())
            {
                Pc newPc = new Pc();
                int leased = 0;
                
                if (!reader.IsDBNull(2))
                {
                    leased = int.Parse(reader[2].ToString());
                }
                newPc.Id = int.Parse(reader[0].ToString());
                newPc.Name = reader[1].ToString();
                newPc.leasedTo = leased;
                AllPcsFromDB.Add(newPc);
            }

            reader.Close();
            mySqlConnection.Close();
            return AllPcsFromDB;
        }
    }
}
