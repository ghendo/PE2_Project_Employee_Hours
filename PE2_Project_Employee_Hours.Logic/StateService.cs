using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PE2_Project_Employee_Hours.Data;
using PE2_Project_Employee_Hours.Domain;

namespace PE2_Project_Employee_Hours.Logic
{
    public class StateService
    {
        public ResultEnum InsertState(States state)
        {
            ResultEnum result = ResultEnum.Success;
            try
            {
                StateDAO dao = new StateDAO();
                dao.InsertState(state);
                result = ResultEnum.Fail;
            }
            catch
            {
                result = ResultEnum.Fail;
            }
            return result;
        }
    }
}
