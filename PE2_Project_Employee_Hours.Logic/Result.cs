using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE2_Project_Employee_Hours.Logic
{
    public enum ResultEnum
    {
        Success,
        Fail

    }
    public class  Result<T>
    {
        public ResultEnum Status { get; set; }
        public T Data { get; set; }
        //tostring method
        public string ResultString
        {
            get
            {
                return Status.ToString();
            }
        }
    }
}
