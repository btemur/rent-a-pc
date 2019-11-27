using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rent_A_PC.Model;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Rent_A_PC.DataManagement
{
    class DataManagementSQL : IDataManagement
    {
        private SqlConnection con = new SqlConnection();

        public DataManagementSQL()
        {
            this.con = con;
            con.ConnectionString = "Data Source=localhost;" +
                                   "Initial Catalog=rent_a_pc;" +
                                   "User id=root;" +
                                   "Password=;";
        }
        public bool Delete(Pc pc)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Customer custormers)
        {
            throw new NotImplementedException();
        }

        public bool Insert(List<Pc> pcs)
        {
            
            throw new NotImplementedException();
        }

        public bool Insert(List<Customer> customers)
        {
            throw new NotImplementedException();
        }

        public bool Update(Pc pc)
        {
            throw new NotImplementedException();
        }

        public bool Update(Customer customers)
        {
            throw new NotImplementedException();
        }

        public List<Pc> DbConnectTest()
        {
            List<Pc> pcs = new List<Pc>();
            Pc pc = new Pc();
            pc.Name = "Game Master";
            pcs.Add(pc);

            SqlCommand cmd = new SqlCommand("insert into pc", con);
            cmd.ExecuteNonQuery();
            return pcs;
        }
    }
}
