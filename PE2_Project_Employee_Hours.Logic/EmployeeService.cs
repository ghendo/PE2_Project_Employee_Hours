using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PE2_Project_Employee_Hours.Data;
using PE2_Project_Employee_Hours.Domain;

namespace PE2_Project_Employee_Hours.Logic
{
    public class EmployeeService
    {
        public ResultEnum InsertEmployee(Employee emp)
        {
            ResultEnum result = ResultEnum.Success;
            try
            {
                EmployeeDAO dao = new EmployeeDAO();
                dao.InsertEmployee(emp);
            }
            catch
            {
                result = ResultEnum.Fail;
            }
            return result;
        }

        public ResultEnum UpdateEmployee(Employee emp)
        {
            ResultEnum result = ResultEnum.Success;
            try
            {
                EmployeeDAO dao = new EmployeeDAO();
                dao.UpdateEmployee(emp);
            }
            catch
            {
                result = ResultEnum.Fail;
            }
            return result;
        }

        public Result<List<Employee>> GetAllEmployees()
        {
            //null result
            Result<List<Employee>> result = new Result<List<Employee>>();

            try
            {
                EmployeeDAO dao = new EmployeeDAO();
                result.Data = dao.GetAllEmployees();
                result.Status = ResultEnum.Success;
            }
            catch
            {
                result.Status = ResultEnum.Fail;
            }
            return result;
        }

        public Result<Employee> FindEmployeeByID(int id)
        {
            Result<Employee> result = new Result<Employee>();
            try
            {
                EmployeeDAO dao = new EmployeeDAO();
                result.Data = dao.FindEmployeeByID(id);
                result.Status = ResultEnum.Success;
            }
            catch
            {
                result.Status = ResultEnum.Fail;
            }
            return result;
        }

        public Result<List<Employee>> FindEmployeesByAny(string s)
        {
            Result<List<Employee>> result = new Result<List<Employee>>();
            try
            {
                EmployeeDAO dao = new EmployeeDAO();
                result.Data = dao.FindEmployeeByAny(s);
                result.Status = ResultEnum.Success;
            }
            catch
            {
                result.Status = ResultEnum.Fail;
            }
            return result;
        }

        public Result<Employee> EmployeeLastChanged()
        {
            Result<Employee> result = new Result<Employee>();
            try
            {
                EmployeeDAO dao = new EmployeeDAO();
                result.Data = dao.EmployeeLastChanged();
                result.Status = ResultEnum.Success;
            }
            catch
            {
                result.Status = ResultEnum.Fail;
            }
            return result;
        }

        public Result<int> EmployeeGetNextId()
        {
            Result<int> result = new Result<int>();
            try
            {
                EmployeeDAO dao = new EmployeeDAO();
                result.Data = dao.EmployeeGetNextId();
                result.Status = ResultEnum.Success;
            }
            catch (Exception)
            {

                result.Status = ResultEnum.Fail;
            }
            return result;
        }


    }
}
