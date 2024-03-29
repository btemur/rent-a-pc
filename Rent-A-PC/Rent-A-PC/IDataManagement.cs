﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rent_A_PC.Model;

namespace Rent_A_PC
{
    public interface IDataManagement
    {
        //Pc
        //bool Save();
        void Insert(Pc pcs);
        void Update(Pc oldPc, Pc newPc);
        void Delete(Pc pc);

        //Customer
        //bool Save();
        void Insert(User users);
        void Update(User oldUsers, User newUsers);
        void Delete(User users);

        //Values as List
        List<User> AllUsers();
        List<Pc> AllPcs();

        //Get Values
        //int Pc_id();
        //string Pc_name();
        //int Pc_leasedTo();
        //int User_id();
        //string User_name();
    }
}
