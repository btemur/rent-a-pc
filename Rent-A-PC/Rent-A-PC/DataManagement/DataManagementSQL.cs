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
        protected string connString = "server=localhost;port=3306;database=rent_a_pc;uid=rent-a-pc-admin;pwd=admin";
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

            if(requestResult == true)
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

        public void Insert(List<Pc> pcs)
        {
            foreach(var item in pcs)
            {
                int pcid = item.Id;
                string pcname = item.Name;
                int leasedto = item.leasedTo;
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
        }

        public void Insert(List<User> users)
        {
            foreach (var item in users)
            {
                int userid = item.Id;
                string username = item.Name;
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
        }

        public void Update(Pc pc)
        {
            //TODO
        }

        public void Update(User users)
        {
            //TODO
        }
    }
}
