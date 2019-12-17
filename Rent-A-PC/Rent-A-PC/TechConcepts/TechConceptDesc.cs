using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rent_A_PC.Model;

namespace Rent_A_PC.TechConcepts
{
    class TechConceptDesc : ITechConcept
    {
        IDataManagement dm;
        public TechConceptDesc(IDataManagement dm)
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
