using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rent_A_PC.Model;
namespace Rent_A_PC
{
    public interface IStrategy
    {
        List<Pc> SortPc(List<Pc> sortedList);
        List<User> SortUser(List<User> sortedList);
    }
}
