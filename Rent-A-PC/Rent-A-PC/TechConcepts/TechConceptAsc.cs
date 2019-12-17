using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rent_A_PC.Model;

namespace Rent_A_PC.TechConcepts
{
    public class TechConceptAsc : ITechConcept
    {
        private static TechConceptAsc techConceptAsc;
        public IDataManagement dm;
        private TechConceptAsc(IDataManagement dm)
        {
            this.dm = dm;
        }

        public static TechConceptAsc GetInstance(IDataManagement dm)
        {
            if(techConceptAsc == null)
            {
                techConceptAsc = new TechConceptAsc(dm);
            }
            return techConceptAsc;
        }

        public List<User> SortCustomer()
        {
            List<User> sortedList = dm.AllUsers().OrderBy(o => o.Name).ToList();
            return sortedList;
        }

        public List<Pc> SortPc()
        {
            List<Pc> sortedList = dm.AllPcs().OrderBy(o => o.Name).ToList();
            return sortedList;
        }

        public Pc GetSelectedPc(string name)
        {
            Pc selectedPc = new Pc();
            foreach (var item in dm.AllPcs())
            {
                if (item.Name.ToString() == name)
                {
                    selectedPc.Id = item.Id;
                    selectedPc.Name = item.Name;
                    selectedPc.leasedTo = item.leasedTo;
                }
            }
            return selectedPc;
        }

        public User GetSelectedUser(string name)
        {
            User selectedUser = new User();
            foreach (var item in dm.AllUsers())
            {
                if (item.Name.ToString() == name)
                {
                    selectedUser.Id = item.Id;
                    selectedUser.Name = item.Name;
                }
            }
            return selectedUser;
        }

        public List<User> LeasedUser()
        {
            List<Pc> pcsLeased = dm.AllPcs().Where(x => x.leasedTo >= 1).ToList();

            List<User> userHasLeased = new List<User>();
            foreach (var item in pcsLeased)
            {
                User tempUser = dm.AllUsers().Where(x => x.Id == item.Id).FirstOrDefault();
                userHasLeased.Add(tempUser);
            }
            return userHasLeased;
        }

        public List<Pc> LeasedPc()
        {
            List<Pc> pcsLeased = dm.AllPcs().Where(x => x.leasedTo >= 1).ToList();
            return pcsLeased;
        }
        public List<User> NonLeasedUser()
        {
            List<Pc> pcsUnLeased = dm.AllPcs().Where(x => x.leasedTo == 0).ToList();

            List<User> userHasNonLeased = new List<User>();
            foreach (var item in pcsUnLeased)
            {
                User tempUser = dm.AllUsers().Where(x => x.Id == item.Id).FirstOrDefault();
                userHasNonLeased.Add(tempUser);
            }
            return userHasNonLeased;
        }

        public List<Pc> NonLeasedPc()
        {
            List<Pc> pcsNonLeased = dm.AllPcs().Where(x => x.leasedTo == 0).ToList();
            return pcsNonLeased;
        }

        public void InsertPcIntoDb(string pcname)
        {
            Pc newPc = new Pc();
            newPc.Name = pcname;
            newPc.leasedTo = 0;
            dm.Insert(newPc);
        }
    }
}
