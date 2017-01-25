using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4281.Vasilov.Lib
{
    public static class EmployeeControl
    {
        public static bool InfoControl(Employee employee)
        {
            int res;
            bool isInt;

            if (string.IsNullOrWhiteSpace(employee.surname) || string.IsNullOrWhiteSpace(employee.initials))
            {
                return false;
            }
            /*else if (isInt = Int32.TryParse(employee.surname, out res))
            {
                return false;
            }*/
            else if (isInt = Int32.TryParse(employee.initials, out res))
            {
                return false;
            }
            else if(employee.birth<1900 || employee.birth>2010)
            {
                return false;
            }
            else if (employee.salary<0)
            {
                return false;
            }
            return true;
        }
    }
}
