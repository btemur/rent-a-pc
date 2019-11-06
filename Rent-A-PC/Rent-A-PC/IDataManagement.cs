using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rent_A_PC.Model;

namespace Rent_A_PC
{
    interface IDataManagement
    {
        //Pc
        //bool Save();
        bool Insert(List<Pc> pcs);
        bool Update(Pc pc);
        bool Delete(Pc pc);

        //Customer
        //bool Save();
        bool Insert(List<Customer> customers);
        bool Update(Customer customers);
        bool Delete(Customer custormers);
    }
}
