using PE2_Project_Employee_Hours.Data;
using PE2_Project_Employee_Hours.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE2_Project_Employee_Hours.Logic
{
    public class CustomerService
    {
        public ResultEnum InsertCustomer(Customer customer)
        {
            ResultEnum result = ResultEnum.Success;
            try
            {
                CustomerDAO dao = new CustomerDAO();
                dao.InsertCustomer(customer);
            
            }
            catch
            {
                result = ResultEnum.Fail;
            }
            return result;
        }

        public async Task<ResultEnum> InsertCustomerAsync(Customer customer)
        {
            ResultEnum result = ResultEnum.Success;

            try
            {
                CustomerDAO dao = new CustomerDAO();
                await dao.InsertCustomerAsync(customer);


            }
            catch
            {

                result = ResultEnum.Fail;
            }
            return result;
        }

        public ResultEnum UpdateCustomer(Customer customer)
        {
            ResultEnum result = ResultEnum.Success;
            try
            {
                CustomerDAO dao = new CustomerDAO();
                dao.UpdateCustomer(customer);
              
            }
            catch
            {
                result = ResultEnum.Fail;
            }
            return result;
        }

        public async Task<ResultEnum> UpdateCustomerAsync(Customer customer)
        {
            ResultEnum result = ResultEnum.Success;
            try
            {
                CustomerDAO dao = new CustomerDAO();
                await dao.UpdateCustomerAsync(customer);

            }
            catch
            {
                result = ResultEnum.Fail;
            }
            return result;
        }

        public ResultEnum DeleteCustomer(Customer customer)
        {
            ResultEnum result = ResultEnum.Success;
            try
            {
                CustomerDAO dao = new CustomerDAO();
                dao.DeleteCustomer(customer);

            }
            catch
            {
                result = ResultEnum.Fail;
            }
            return result;
        }

        public Result<List<Customer>> getAllCustomers()
        {
            Result<List<Customer>> result = new Result<List<Customer>>();
            try
            {
                CustomerDAO dao = new CustomerDAO();
                result.Data = dao.GetAllCustomers();
                result.Status = ResultEnum.Success;
            }
            catch (Exception)
            {

                result.Status = ResultEnum.Fail;
            }
            return result;
        }

        public async Task<Result<DataTable>> GetAllCustomersDtASYNC()
        {
            Result<DataTable> result = new Result<DataTable>();
            try
            {
                CustomerDAO dao = new CustomerDAO();
                result.Data = await dao.GetAllCustomersDtASYNC();
                result.Status = ResultEnum.Success;
            }
            catch (Exception)
            {

                result.Status = ResultEnum.Fail;
            }
            return result;
        }

        public async Task<Result<List<Customer>>> GetAllCustomersListASYNC()
        {
            Result<List<Customer>> result = new Result<List<Customer>>();
            try
            {
                CustomerDAO dao = new CustomerDAO();
                result.Data = await dao.GetAllCustomersListASYNC();
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
