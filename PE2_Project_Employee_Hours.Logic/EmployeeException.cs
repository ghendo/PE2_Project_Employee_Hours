using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE2_Project_Employee_Hours.Logic
{
    public class EmployeeException: Exception
    {
        public EmployeeValidateEnum ValidateEnum { get; set; }

        public EmployeeException(string message) : base(message)
        {

        }

        public EmployeeException(EmployeeValidateEnum ValidateEnum):base()
        {
            this.ValidateEnum = ValidateEnum;
        }
    }
}
