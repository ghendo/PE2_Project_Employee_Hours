using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using PE2_Project_Employee_Hours.Domain;

namespace PE2_Project_Employee_Hours.Data
{
    public class EmployeeHoursDAO
    {
        public void InsertEmployeeHours(EmployeeHours emp)
        {
            //connection object
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=127.0.0.1;Initial Catalog=PE2_Project_Employee_Hours;User ID=sa;Password=vRdoZJPoyev4KAx7vLB";

            //open connection
            conn.Open();

            //create command object
            SqlCommand cmd = new SqlCommand("sp_EmployeeHours_Insert", conn); //sp_EmployeeHours_Insert
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@EmployeeId", emp.EmployeeId));//@EmployeeId
            cmd.Parameters.Add(new SqlParameter("@WorkDate", emp.WorkDate));//@WorkDate
            cmd.Parameters.Add(new SqlParameter("@WorkHours", emp.HoursWorked)); //@WorkHours

            //excute command
            cmd.ExecuteNonQuery();

            //close connection
            conn.Close();

        }

        public void UpdateEmployeeHours(EmployeeHours emp)
        {
            //2. Create a connection object
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=127.0.0.1;Initial Catalog=PE2_Project_Employee_Hours;User ID=sa;Password=vRdoZJPoyev4KAx7vLB";
            conn.Open();

            //3.Create a command object
            SqlCommand cmd = new SqlCommand("sp_EmployeeHours_Update", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@EmployeeHoursId", emp.EmployeeHoursId));
            cmd.Parameters.Add(new SqlParameter("@EmployeeHoursEmpId", emp.EmployeeId));
            cmd.Parameters.Add(new SqlParameter("@WorkDate", emp.WorkDate));
            cmd.Parameters.Add(new SqlParameter("@HoursWorked", emp.HoursWorked));


            //4.Execute the command - insert, update, delete
            cmd.ExecuteNonQuery();

            //5.Handle the results

            conn.Close();
        }

        public EmployeeHours EmployeeHoursLastChanged()
        {
            // declare object for data
            EmployeeHours eh = new EmployeeHours();
           //2. Create a connection object
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=127.0.0.1;Initial Catalog=PE2_Project_Employee_Hours;User ID=sa;Password=vRdoZJPoyev4KAx7vLB";
            conn.Open();

            //3.Create a command object
            SqlCommand cmd = new SqlCommand("sp_EmployeeHours_lastUpdated", conn);

            //4.Execute the command - insert, update, delete
            SqlDataReader reader = cmd.ExecuteReader();

            //5.Handle the results
            if (reader.Read())
            {
                eh = new EmployeeHours();
                eh.EmployeeHoursId = Convert.ToInt32(reader["EmployeeHoursId"]);
                eh.EmployeeId = Convert.ToInt32(reader["EmployeeId"]);
                eh.FullName = Convert.ToString(reader["FullName"]);
                eh.WorkDate = Convert.ToDateTime(reader["WorkDate"]);
                eh.HoursWorked = Convert.ToDouble(reader["HoursWorked"]);
            }

            conn.Close();
            return eh;
        }

        public List<EmployeeHours> GetAllEmployeeHours()
        {
            List<EmployeeHours> listOfEmps = new List<EmployeeHours>();

            //2. Create a connection object
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=127.0.0.1;Initial Catalog=PE2_Project_Employee_Hours;User ID=sa;Password=vRdoZJPoyev4KAx7vLB";
            conn.Open();

            //3.Create a command object
            SqlCommand cmd = new SqlCommand("sp_EmployeeHours_SelectAll", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            //4.Execute the command - select
            SqlDataReader reader = cmd.ExecuteReader();

            //5.Handle the results
            while (reader.Read())
            {
                EmployeeHours e = new EmployeeHours();
                e.EmployeeHoursId = Convert.ToInt32(reader["EmployeeHoursId"]);
                e.EmployeeId = Convert.ToInt32(reader["EmployeeId"]);
                e.FullName = Convert.ToString(reader["FullName"]);
                e.WorkDate = Convert.ToDateTime(reader["WorkDate"]);
                e.HoursWorked = Convert.ToDouble(reader["HoursWorked"]);
                listOfEmps.Add(e);
            }

            conn.Close();

            return listOfEmps;
        }

        public EmployeeHours FindEmployeeHoursByID(int id)
        {
            EmployeeHours eh = null;

            //2. Create a connection object
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=127.0.0.1;Initial Catalog=PE2_Project_Employee_Hours;User ID=sa;Password=vRdoZJPoyev4KAx7vLB";
            conn.Open();

            //3.Create a command object
            SqlCommand cmd = new SqlCommand("sp_EmployeeHours_FindById", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@EmployeeHoursId", id));

            //4.Execute the command - select
            SqlDataReader reader = cmd.ExecuteReader();

            //5.Handle the results
            if (reader.Read())
            {
                eh = new EmployeeHours();
                eh.EmployeeId = Convert.ToInt32(reader["EmployeeId"]);
                eh.FullName = Convert.ToString(reader["FullName"]);
                eh.WorkDate = Convert.ToDateTime(reader["WorkDate"]);
                eh.HoursWorked = Convert.ToDouble(reader["HoursWorked"]);
            }

            conn.Close();

            return eh;
        }

        public List<EmployeeHours> FindEmployeeHoursByAny(string s)
        {
            List<EmployeeHours> listOfEmpHours = new List<EmployeeHours>();

            //2. Create a connection object
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=127.0.0.1;Initial Catalog=PE2_Project_Employee_Hours;User ID=sa;Password=vRdoZJPoyev4KAx7vLB";
            conn.Open();

            //3.Create a command object
            SqlCommand cmd = new SqlCommand("sp_EmployeeHours_FindByAny", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@EmployeeHoursFind", s));

            //4.Execute the command - select
            SqlDataReader reader = cmd.ExecuteReader();

            //5.Handle the results
            while (reader.Read())
            {
                EmployeeHours eh = new EmployeeHours();
                //eh = new EmployeeHours();
                eh.EmployeeId = Convert.ToInt32(reader["EmployeeId"]);
                eh.EmployeeHoursId = Convert.ToInt32(reader["EmployeeHoursId"]);
                eh.FullName = Convert.ToString(reader["FullName"]);
                eh.HoursWorked = Convert.ToDouble(reader["HoursWorked"]);
                eh.WorkDate = Convert.ToDateTime(reader["WorkDate"]);

                listOfEmpHours.Add(eh);

            }

            conn.Close();

            return listOfEmpHours;
        }
    }
}
