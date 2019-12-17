using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rent_A_PC.Model;

namespace Rent_A_PC
{
    public interface ITechConcept
    {
        //Weitergabe an GUI
        List<Pc> SortPc();
        List<User> SortCustomer();
        User GetSelectedUser(string name);
        Pc GetSelectedPc(string name);
        List<User> LeasedUser();
        List<Pc> LeasedPc();
        List<User> NonLeasedUser();
        List<Pc> NonLeasedPc();

        //Datenbank Zeug
        void InsertPcIntoDb(string pcname);
        void DeletePcFromDb(string name);
        void DeleteUserFromDb(string name);
        void UpdatePcFromDb(string oldName, string newName);
        void UpdateUserFromDb(string oldName, string newName);
    }
}
