﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_A_PC.Model
{
    public class Pc
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int leasedTo { get; set; }
    }
}
