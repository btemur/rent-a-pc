using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rent_A_PC.Model;
using Rent_A_PC.DataManagement;

namespace Rent_A_PC
{
    class StandardStrategy : IStrategy
    {
        public List<Pc> SortPc(List<Pc> sortedList)
        {
            return sortedList.OrderBy(x => x.Name).ToList();
        }
        public List<User> SortUser(List<User> sortedList)
        {
            return sortedList.OrderBy(x => x.Name).ToList();
        }
    }
}
