using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rent_A_PC.Model;
using Rent_A_PC.DataManagement;

namespace Rent_A_PC.TechConcepts
{
    public class TechConceptDesc : ITechConcept
    {
        IDataManagement dm;
        public TechConceptDesc(IDataManagement dm)
        {
            this.dm = dm;
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
    }
}
