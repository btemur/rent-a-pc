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
        protected string connString = "server=localhost;port=3306;database=rent_a_pc;uid=root;pwd=";
        public DataManagementSQL()
        {

        }
        //Modulare ausführung eines MySql Statements, kann variabel benutzt werden.
        public bool MySqlRequest(string query)
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection(connString);
                MySqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlCommand.CommandText = query;
                mySqlCommand.ExecuteNonQuery();
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
            string query = String.Format("DELETE FROM `pc` WHERE `pcid` = {0};", pcid);
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
            string query = String.Format("DELETE FROM `user` WHERE `userid` = {0};", userid);
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
            int pcid = pcs.Id;
            string pcname = pcs.Name;
            int leasedto = pcs.leasedTo;
            string query = String.Format("INSERT INTO `pc` (id, pc, leasedto) VALUES ({0}, `{1}`, {2});", pcid, pcname, leasedto);
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
            int userid = users.Id;
            string username = users.Name;
            string query = String.Format("INSERT INTO `user` (id, user) VALUES ({0}, `{1}`);", userid, username);
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

        public void Update(Pc pc)
        {
            //TODO
        }

        public void Update(User users)
        {
            //TODO
        }

        public List<User> AllUsers()
        {
            List<User> AllUsersFromDB = new List<User>();
            MySqlConnection mySqlConnection = new MySqlConnection(connString);
            MySqlCommand mySqlCommand = mySqlConnection.CreateCommand();
            mySqlCommand.CommandText = "SELECT * FROM user";
            MySqlDataReader reader = mySqlCommand.ExecuteReader();

            while (reader.Read())
            {
                User newUser = new User();
                newUser.Id = int.Parse(reader["userid"].ToString());
                newUser.Name = reader["user"].ToString();
                AllUsersFromDB.Add(newUser);
            }
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
                string leased = String.Empty;
                
                if (!reader.IsDBNull(2))
                {
                    leased = reader[2].ToString();
                }
                newPc.Id = int.Parse(reader[0].ToString());
                newPc.Name = reader[1].ToString();
                newPc.leasedTo = int.Parse(leased);
                AllPcsFromDB.Add(newPc);
            }

            reader.Close();
            mySqlConnection.Close();
            return AllPcsFromDB;
        }
    }
}
