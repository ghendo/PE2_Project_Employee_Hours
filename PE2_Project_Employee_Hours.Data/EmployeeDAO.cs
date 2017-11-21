using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using PE2_Project_Employee_Hours.Domain;

namespace PE2_Project_Employee_Hours.Data
{
    public class EmployeeDAO
    {
        public void InsertEmployee(Employee emp)
        {
            //connection object
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=altec.homeip.net;Initial Catalog=PE2_Project_Employee_Hours;User ID=sa;Password=vRdoZJPoyev4KAx7vLB";

            //open connection
            conn.Open();

            //create command object
            SqlCommand cmd = new SqlCommand("sp_Employees_Insert", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@FirstName", emp.FirstName));
            cmd.Parameters.Add(new SqlParameter("@LastName", emp.LastName));
            cmd.Parameters.Add(new SqlParameter("@Email", emp.Email));
            cmd.Parameters.Add(new SqlParameter("@Phone", emp.Phone)); 
            cmd.Parameters.Add(new SqlParameter("@DateOfBirth", emp.DateOfBirth));

            //excute command
            cmd.ExecuteNonQuery();

            //close connection
            conn.Close();

        }

        public void UpdateEmployee(Employee emp)
        {
            //2. Create a connection object
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=altec.homeip.net;Initial Catalog=PE2_Project_Employee_Hours;User ID=sa;Password=vRdoZJPoyev4KAx7vLB";
            conn.Open();

            //3.Create a command object
            SqlCommand cmd = new SqlCommand("sp_Employee_Update", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@EmployeeId", emp.EmployeeId));
            cmd.Parameters.Add(new SqlParameter("@FirstName", emp.FirstName));
            cmd.Parameters.Add(new SqlParameter("@LastName", emp.LastName));
            cmd.Parameters.Add(new SqlParameter("@Email", emp.Email));
            cmd.Parameters.Add(new SqlParameter("@Phone", emp.Phone));
            cmd.Parameters.Add(new SqlParameter("@DateOfBirth", emp.DateOfBirth));



            //4.Execute the command - insert, update, delete
            cmd.ExecuteNonQuery();

            //5.Handle the results

            conn.Close();
        }

        public List<Employee> GetAllEmployees()
        {
            List<Employee> listOfEmps = new List<Employee>();

            //2. Create a connection object
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=altec.homeip.net;Initial Catalog=PE2_Project_Employee_Hours;User ID=sa;Password=vRdoZJPoyev4KAx7vLB";
            conn.Open();

            //3.Create a command object
            SqlCommand cmd = new SqlCommand("sp_Employees_SelectAll", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            //4.Execute the command - select
            SqlDataReader reader = cmd.ExecuteReader();

            //5.Handle the results
            while (reader.Read())
            {
                Employee e = new Employee();
                e.EmployeeId = Convert.ToInt32(reader["EmployeeId"]);
                e.FirstName = Convert.ToString(reader["FirstName"]);
                e.LastName = Convert.ToString(reader["LastName"]);
                e.Email = Convert.ToString(reader["Email"]);
                e.Phone = Convert.ToString(reader["Phone"]);
                e.DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
                e.FullName = Convert.ToString(reader["FullName"]);
                listOfEmps.Add(e);
            }

            conn.Close();

            return listOfEmps;
        }

        public Employee FindEmployeeByID(int id)
        {
            Employee e = null;

            //2. Create a connection object
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=altec.homeip.net;Initial Catalog=PE2_Project_Employee_Hours;User ID=sa;Password=vRdoZJPoyev4KAx7vLB";
            conn.Open();

            //3.Create a command object
            SqlCommand cmd = new SqlCommand("sp_Employees_FindById", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@EmployeeId", id));

            //4.Execute the command - select
            SqlDataReader reader = cmd.ExecuteReader();

            //5.Handle the results
            if (reader.Read())
            {
                e = new Employee();
                e.EmployeeId = Convert.ToInt32(reader["EmployeeId"]);
                e.FirstName = Convert.ToString(reader["FirstName"]);
                e.LastName = Convert.ToString(reader["LastName"]);
                e.Email = Convert.ToString(reader["Email"]);
                e.Phone = Convert.ToString(reader["Phone"]);
                e.DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);

            }

            conn.Close();

            return e;
        }

        public List<Employee> FindEmployeeByAny(string s)
        {
            List<Employee> listOfEmps = new List<Employee>();

            //2. Create a connection object
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=altec.homeip.net;Initial Catalog=PE2_Project_Employee_Hours;User ID=sa;Password=vRdoZJPoyev4KAx7vLB";
            conn.Open();

            //3.Create a command object
            SqlCommand cmd = new SqlCommand("sp_Employees_FindByEmail", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@EmployeeEmail", s));

            //4.Execute the command - select
            SqlDataReader reader = cmd.ExecuteReader();

            //5.Handle the results
            while (reader.Read())
            {
                Employee e = new Employee();
                e = new Employee();
                e.EmployeeId = Convert.ToInt32(reader["EmployeeId"]);
                e.FirstName = Convert.ToString(reader["FirstName"]);
                e.LastName = Convert.ToString(reader["LastName"]);
                e.Email = Convert.ToString(reader["Email"]);
                e.Phone = Convert.ToString(reader["Phone"]);
                e.DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);

                listOfEmps.Add(e);

            }

            conn.Close();

            return listOfEmps;
        }

        public Employee EmployeeLastChanged()
        {
            Employee e = null;

            //2. Create a connection object
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=altec.homeip.net;Initial Catalog=PE2_Project_Employee_Hours;User ID=sa;Password=vRdoZJPoyev4KAx7vLB";
            conn.Open();

            //3.Create a command object
            SqlCommand cmd = new SqlCommand("sp_Employees_lastUpdated", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;



            //4.Execute the command - select
            SqlDataReader reader = cmd.ExecuteReader();

            //5.Handle the results
            if (reader.Read())
            {
                e = new Employee();
                e.EmployeeId = Convert.ToInt32(reader["EmployeeId"]);
                e.FirstName = Convert.ToString(reader["FirstName"]);
                e.LastName = Convert.ToString(reader["LastName"]);
                e.Email = Convert.ToString(reader["Email"]);
                e.Phone = Convert.ToString(reader["Phone"]);
                e.DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);

            }

            conn.Close();

            return e;
        }

        public int EmployeeGetNextId()
        {

            //1 null int to store result
            int i = 0;

            //2. Create a connection object
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=altec.homeip.net;Initial Catalog=PE2_Project_Employee_Hours;User ID=sa;Password=vRdoZJPoyev4KAx7vLB";
            conn.Open();

            //3.Create a command object
            SqlCommand cmd = new SqlCommand("sp_Employees_GetNextId", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            //4.Execute the command - select
            i = (int)cmd.ExecuteScalar();

            //5 Handle results
            conn.Close();

            return i;
        }
    }

}
