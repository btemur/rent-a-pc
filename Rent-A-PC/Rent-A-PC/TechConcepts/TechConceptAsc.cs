﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rent_A_PC.Model;

namespace Rent_A_PC.TechConcepts
{
    class TechConceptAsc : ITechConcept
    {
        public TechConceptAsc()
        {
        }

        public List<User> SortCustomer(List<User> users)
        {
            List<User> sortedList = users.OrderBy(o => o.Name).ToList();
            return sortedList;
        }

        public List<Pc> SortPc(List<Pc> pcs)
        {
            List<Pc> sortedList = pcs.OrderBy(o => o.Name).ToList();
            return sortedList;
        }
    }
}
