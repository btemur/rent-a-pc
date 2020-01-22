using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rent_A_PC.Model;
using Rent_A_PC.DataManagement;

namespace Rent_A_PC
{
    class ReverseStrategy : IStrategy
    {

        // eine abstracte methode zum sortieren verwenden.
        public List<Pc>SortPc(List<Pc> listPc)
        {
            return listPc.OrderByDescending(x => x.Name).ToList();
            
        }
        public List<User>SortUser(List<User> listUser)
        {
            return listUser.OrderByDescending(x => x.Name).ToList();

        }

    }
}
