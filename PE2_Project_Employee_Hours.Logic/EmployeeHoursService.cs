using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PE2_Project_Employee_Hours.Data;
using PE2_Project_Employee_Hours.Domain;

namespace PE2_Project_Employee_Hours.Logic
{
    public class EmployeeHoursService
    {
        public ResultEnum InsertEmployeeHours(EmployeeHours emp)
        {
            ResultEnum result = ResultEnum.Success;
            try
            {
                EmployeeHoursDAO dao = new EmployeeHoursDAO();
                dao.InsertEmployeeHours(emp);
            }
            catch
            {
                result = ResultEnum.Fail;
            }
            return result;
        }

        public ResultEnum UpdateEmployeeHours(EmployeeHours emp)
        {
            ResultEnum result = ResultEnum.Success;
            try
            {
                EmployeeHoursDAO dao = new EmployeeHoursDAO();
                dao.UpdateEmployeeHours(emp);
            }
            catch
            {
                result = ResultEnum.Fail;
            }
            return result;
        }

        public Result<List<EmployeeHours>> GetAllEmployeesHours()
        {
            //null result
            Result<List<EmployeeHours>> result = new Result<List<EmployeeHours>>();

            try
            {
                EmployeeHoursDAO dao = new EmployeeHoursDAO();
                result.Data = dao.GetAllEmployeeHours();
                result.Status = ResultEnum.Success;
            }
            catch
            {
                result.Status = ResultEnum.Fail;
            }
            return result;
        }

        public Result<EmployeeHours> FindEmployeeHoursByID(int id)
        {
            Result<EmployeeHours> result = new Result<EmployeeHours>();
            try
            {
                EmployeeHoursDAO dao = new EmployeeHoursDAO();
                result.Data = dao.FindEmployeeHoursByID(id);
                result.Status = ResultEnum.Success;
            }
            catch
            {
                result.Status = ResultEnum.Fail;
            }
            return result;
        }

        public Result<EmployeeHours> EmployeeHoursLastChanged()
        {
            Result<EmployeeHours> result = new Result<EmployeeHours>();
            try
            {
                EmployeeHoursDAO dao = new EmployeeHoursDAO();
                result.Data = dao.EmployeeHoursLastChanged();
                result.Status = ResultEnum.Success;
            }
            catch
            {
                result.Status = ResultEnum.Fail;
            }
            return result;
        }
    }
}
