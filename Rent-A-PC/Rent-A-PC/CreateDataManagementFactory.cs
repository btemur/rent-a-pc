using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rent_A_PC.DataManagement;

namespace Rent_A_PC
{
    class CreateDataManagementFactory
    {
        public static IDataManagement createDataManagement(string description)
        {
            IDataManagement dataManagement;
            switch (description)
            {
                case "SQL":
                    return dataManagement = DataManagementSQL.GetInstance();
                case "JSON":
                    return dataManagement = DataManagementJsonPrototype.GetInstance();  
                default:
                    return null;
            }
        }
    }
}
