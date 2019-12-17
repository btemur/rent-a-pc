using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rent_A_PC.Model;
using Rent_A_PC.DataManagement;

namespace Rent_A_PC.TechConcepts
{
    class TechConceptAsc : ITechConcept
    {
        IDataManagement dm;
        public TechConceptAsc(IDataManagement dm)
        {
            this.dm = dm;
        }
        public List<User> SortCustomer(List<User> users)
        {
            throw new NotImplementedException();
        }

        public List<Pc> SortPc(List<Pc> pcs)
        {
            throw new NotImplementedException();
        }
    }
}
