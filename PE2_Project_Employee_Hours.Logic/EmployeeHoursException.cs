using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE2_Project_Employee_Hours.Logic
{
    public class EmployeeHoursException: Exception
    {
        public EmployeeHoursValidateEnum ValidateEnum { get; set; }

        public EmployeeHoursException(string message) : base(message)
        {

        }

        public EmployeeHoursException(EmployeeHoursValidateEnum ValidateEnum):base()
        {
            this.ValidateEnum = ValidateEnum;
        }
    }
}

