using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rent_A_PC.Model;

namespace Rent_A_PC
{
    interface ITechConcept
    {
        List<Pc> SortPc();
        List<Customer> SortCustomer();
    }
}
