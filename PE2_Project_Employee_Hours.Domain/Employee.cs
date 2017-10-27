using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE2_Project_Employee_Hours.Domain
{
    public class Employee : IComparable
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string FullName { get; set; }


        //constructors
        public Employee()
        {

        }

        public Employee(
            int employeeId, 
            string firstName, 
            string lastName, 
            string email,
            string phone,
            DateTime dateOfBirth)
        {
            this.EmployeeId = employeeId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Phone = phone;
            this.DateOfBirth = dateOfBirth;
        }



        //Override compare to-- Deafult sort is by last name
        int IComparable.CompareTo(object obj)
        {
            //Declare a new employee object cast object to employee
            Employee emp = (Employee)obj;

            //Define which property to use for comparison
            return string.Compare(this.LastName, emp.LastName);
        }

        //Implement sort by Id
        
        private class SortIdHelper : IComparer<Employee>
        {
            public int Compare(Employee emp1, Employee emp2)
            {


                if (emp1.EmployeeId > emp2.EmployeeId)
                {
                    return 1;
                }
                if (emp1.EmployeeId < emp2.EmployeeId)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }

        public static IComparer<Employee> sortEmployeeById()
        {
            return new SortIdHelper();
        }

        //Implement sort by Id descending
        private class SortIdDescHelper : IComparer<Employee>
        {
            public int Compare(Employee emp2, Employee emp1)
            {


                if (emp1.EmployeeId > emp2.EmployeeId)
                {
                    return 1;
                }
                if (emp1.EmployeeId < emp2.EmployeeId)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }

        public static IComparer<Employee> sortEmployeeByIdDesc()
        {
            return new SortIdDescHelper();
        }

        //Implement sort by Email
        private class SortEmailHelper : IComparer<Employee>
        {
            public int Compare(Employee emp1, Employee emp2)
            {

                return string.Compare(emp1.Email, emp2.Email);

            }
        }

        public static IComparer<Employee> sortEmployeeByEmail()
        {
            return new SortEmailHelper();
        }

        //Implement sort by Email Descending
        private class SortEmailDescHelper : IComparer<Employee>
        {
            public int Compare(Employee emp2, Employee emp1)
            {

                return string.Compare(emp1.Email, emp2.Email);

            }
        }

        public static IComparer<Employee> sortEmployeeByEmailDesc()
        {
            return new SortEmailDescHelper();
        }

        //Implement sort by First name
        private class SortFirstNameHelper : IComparer<Employee>
        {
            public int Compare(Employee emp1, Employee emp2)
            {

                return string.Compare(emp1.FirstName, emp2.FirstName);

            }
        }

        public static IComparer<Employee> sortEmployeeByFirstName()
        {
            return new SortFirstNameHelper();
        }

        //Implement sort by First name Descending
        private class SortFirstNameDescHelper : IComparer<Employee>
        {
            public int Compare(Employee emp2, Employee emp1)
            {

                return string.Compare(emp1.FirstName, emp2.FirstName);

            }
        }

        public static IComparer<Employee> sortEmployeeByFirstNameDesc()
        {
            return new SortFirstNameDescHelper();
        }

        //Implement sort by Last name Descending
        private class SortLastNameDescHelper : IComparer<Employee>
        {
            public int Compare(Employee emp2, Employee emp1)
            {

                return string.Compare(emp1.LastName, emp2.LastName);

            }
        }

        public static IComparer<Employee> sortEmployeeByLastNameDesc()
        {
            return new SortLastNameDescHelper();
        }

        //Implement sort by Phone
        private class SortPhoneHelper : IComparer<Employee>
        {
            public int Compare(Employee emp1, Employee emp2)
            {

                return string.Compare(emp1.Phone, emp2.Phone);

            }
        }

        public static IComparer<Employee> sortEmployeeByPhone()
        {
            return new SortPhoneHelper();
        }

        //Implement sort by Phone Descending
        private class SortPhoneDescHelper : IComparer<Employee>
        {
            public int Compare(Employee emp2, Employee emp1)
            {

                return string.Compare(emp1.Phone, emp2.Phone);

            }
        }

        public static IComparer<Employee> sortEmployeeByPhoneDesc()
        {
            return new SortPhoneDescHelper();
        }

        //Implement sort by Date of birth
        private class SortDateOfBirthHelper : IComparer<Employee>
        {
            public int Compare(Employee emp1, Employee emp2)
            {

                return DateTime.Compare(emp1.DateOfBirth, emp2.DateOfBirth);

            }
        }

        public static IComparer<Employee> sortEmployeeByDateOfBirth()
        {
            return new SortDateOfBirthHelper();
        }

        //Implement sort by Date of birth Descending
        private class SortDateOfBirthDescHelper : IComparer<Employee>
        {
            public int Compare(Employee emp2, Employee emp1)
            {

                return DateTime.Compare(emp1.DateOfBirth, emp2.DateOfBirth);

            }
        }

        public static IComparer<Employee> sortEmployeeByDateOfBirthDesc()
        {
            return new SortDateOfBirthDescHelper();
        }
    }

   
}



