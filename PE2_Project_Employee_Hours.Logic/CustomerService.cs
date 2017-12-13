﻿using PE2_Project_Employee_Hours.Data;
using PE2_Project_Employee_Hours.Domain;
using System;
using System.Collections.Generic;
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
                result = ResultEnum.Fail;
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
    }
}
