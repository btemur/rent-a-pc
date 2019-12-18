using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rent_A_PC.Model;

namespace Rent_A_PC.TechConcepts
{
    public class TechConceptDesc : ITechConcept
    {
        private static TechConceptDesc techConceptDesc;
        IDataManagement dm;
        private TechConceptDesc(IDataManagement dm)
        {
            this.dm = dm;
        }

        public static TechConceptDesc GetInstance(IDataManagement dm)
        {
            if (techConceptDesc == null)
            {
                techConceptDesc = new TechConceptDesc(dm);
            }
            return techConceptDesc;
        }

        public List<User> SortCustomer()
        {
            List<User> sortedList = dm.AllUsers().OrderBy(o => o.Name).ToList();
            sortedList.Reverse();
            return sortedList;
        }

        public List<Pc> SortPc()
        {
            List<Pc> sortedList = dm.AllPcs().OrderBy(o => o.Name).ToList();
            sortedList.Reverse();
            return sortedList;
        }


        public Pc GetSelectedPc(string name)
        {
            Pc selectedPc = new Pc();
            foreach(var item in dm.AllPcs())
            {
                if(item.Name.ToString() == name)
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
            userHasLeased.Reverse();
            return userHasLeased;
            //dm.AllUsers().Where(x => x.Id == item.Id).ToList();
        }

        public List<Pc> LeasedPc()
        {
            List<Pc> pcsLeased = dm.AllPcs().Where(x => x.leasedTo >= 1).ToList();
            pcsLeased.Reverse();
            return pcsLeased;
        }
        public List<User> NonLeasedUser()
        {
            List<Pc> pcsUnLeased = dm.AllPcs().Where(x => x.leasedTo == 0).ToList();
            List<User> allUsers = dm.AllUsers();
            List<User> userHasNonLeased = new List<User>();

            foreach (var item in pcsUnLeased)
            {
                userHasNonLeased = dm.AllUsers().Where(x => x.Id != item.leasedTo).ToList();
                //User tempUser = allUsers.Where(x => x.Id == item.Id).FirstOrDefault();
                //userHasNonLeased.Add(tempUser);
            }
            userHasNonLeased.Reverse();
            return userHasNonLeased;
        }

        public List<Pc> NonLeasedPc()
        {
            List<Pc> pcsNonLeased = dm.AllPcs().Where(x => x.leasedTo == 0).ToList();
            pcsNonLeased.Reverse();
            return pcsNonLeased;
        }

        public void DeletePcFromDb(string name)
        {
            Pc selectedPc = new Pc();
            foreach (var item in dm.AllPcs())
            {
                if (item.Name.ToString() == name)
                {
                    selectedPc.Id = item.Id;
                    selectedPc.Name = item.Name;
                    selectedPc.leasedTo = item.leasedTo;
                    dm.Delete(selectedPc);
                }
            }
        }

        public void DeleteUserFromDb(string name)
        {
            User selecteduser = new User();
            foreach (var item in dm.AllUsers())
            {
                if (item.Name.ToString() == name)
                {
                    selecteduser.Id = item.Id;
                    selecteduser.Name = item.Name;
                    dm.Delete(selecteduser);
                }
            }
        }

        public void UpdatePcFromDb(string oldName, string newName)
        {
            Pc newPc = new Pc();
            Pc oldPc = new Pc();
            foreach (var item in dm.AllPcs())
            {
                if (item.Name.ToString() == oldName)
                {
                    oldPc.Id = item.Id;
                    oldPc.Name = item.Name;
                    oldPc.leasedTo = item.leasedTo;
                }
            }
            newPc.Id = oldPc.Id;
            newPc.Name = newName;
            newPc.leasedTo = oldPc.leasedTo;

            dm.Update(oldPc, newPc);
        }

        public void UpdateUserFromDb(string oldName, string newName)
        {
            User newUser = new User();
            User oldUser = new User();
            foreach (var item in dm.AllUsers())
            {
                if (item.Name.ToString() == oldName)
                {
                    oldUser.Id = item.Id;
                    oldUser.Name = item.Name;
                }
            }
            newUser.Id = oldUser.Id;
            newUser.Name = newName;

            dm.Update(oldUser, newUser);
        }
        public void InsertPcIntoDb(string pcname)
        {
            Pc newPc = new Pc();
            newPc.Name = pcname;
            newPc.leasedTo = 0;
            dm.Insert(newPc);
        }
        public void InsertUserIntoDb(string username)
        {
            User newUser = new User();
            newUser.Name = username;
            dm.Insert(newUser);
        }
    }
}
