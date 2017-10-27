using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE2_Project_Employee_Hours.Domain
{
    public class EmployeeHours : IComparable
    {
        public int EmployeeHoursId { get; set; }
        public int EmployeeId { get; set; }
        public string FullName { get; set; }
        public DateTime WorkDate { get; set; }
        public double HoursWorked { get; set; }

        //Override compare to-- Default sort is by full name
        int IComparable.CompareTo(object obj)
        {
            //Declare a new employee Hours object cast object to employee Hours
            EmployeeHours eh = (EmployeeHours)obj;

            //Define which property to use for comparison
            return string.Compare(this.FullName, eh.FullName);
        }

        //Implement sort by Id

        private class SortIdHelper : IComparer<EmployeeHours>
        {
            public int Compare(EmployeeHours eh1, EmployeeHours eh2)
            {


                if (eh1.EmployeeHoursId > eh2.EmployeeHoursId)
                {
                    return 1;
                }
                if (eh1.EmployeeHoursId < eh2.EmployeeHoursId)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }

        public static IComparer<EmployeeHours> sortEmployeeHoursById()
        {
            return new SortIdHelper();
        }

        //Implement sort by  Id descending
        private class SortIdDescHelper : IComparer<EmployeeHours>
        {
            public int Compare(EmployeeHours eh2, EmployeeHours eh1)
            {


                if (eh1.EmployeeHoursId > eh2.EmployeeHoursId)
                {
                    return 1;
                }
                if (eh1.EmployeeHoursId < eh2.EmployeeHoursId)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }

        public static IComparer<EmployeeHours> sortEmployeeHoursByIdDesc()
        {
            return new SortIdDescHelper();
        }

        //Implement sort by Employee Id 
        private class SortEmployeeHoursEmpIdHelper : IComparer<EmployeeHours>
        {
            public int Compare(EmployeeHours eh1, EmployeeHours eh2)
            {


                if (eh1.EmployeeId > eh2.EmployeeId)
                {
                    return 1;
                }
                if (eh1.EmployeeId < eh2.EmployeeId)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }

        public static IComparer<EmployeeHours> sortEmployeeHoursByEmpId()
        {
            return new SortEmployeeHoursEmpIdHelper();
        }

        //Implement sort by Employee Id Desc
        private class SortEmployeeHoursEmpIdDescHelper : IComparer<EmployeeHours>
        {
            public int Compare(EmployeeHours eh2, EmployeeHours eh1)
            {


                if (eh1.EmployeeId > eh2.EmployeeId)
                {
                    return 1;
                }
                if (eh1.EmployeeId < eh2.EmployeeId)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }

        public static IComparer<EmployeeHours> sortEmployeeHoursByEmpIdDesc()
        {
            return new SortEmployeeHoursEmpIdDescHelper();
        }

        //Implement sort by Hours worked
        private class SortEmployeeHoursHrsWkdHelper : IComparer<EmployeeHours>
        {
            public int Compare(EmployeeHours eh1, EmployeeHours eh2)
            {


                if (eh1.HoursWorked > eh2.HoursWorked)
                {
                    return 1;
                }
                if (eh1.HoursWorked < eh2.HoursWorked)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }

        public static IComparer<EmployeeHours> sortEmployeeHoursByHrsWkd()
        {
            return new SortEmployeeHoursHrsWkdHelper();
        }

        //Implement sort by Hours worked Desc
        private class SortEmployeeHoursHrsWkdDescHelper : IComparer<EmployeeHours>
        {
            public int Compare(EmployeeHours eh2, EmployeeHours eh1)
            {


                if (eh1.HoursWorked > eh2.HoursWorked)
                {
                    return 1;
                }
                if (eh1.HoursWorked < eh2.HoursWorked)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }

        public static IComparer<EmployeeHours> sortEmployeeHoursByHrsWkdDesc()
        {
            return new SortEmployeeHoursHrsWkdDescHelper();
        }

        //Implement sort by Date worked
        private class SortEmployeeHoursDateHelper : IComparer<EmployeeHours>
        {
            public int Compare(EmployeeHours eh1, EmployeeHours eh2)
            {


                if (eh1.WorkDate > eh2.WorkDate)
                {
                    return 1;
                }
                if (eh1.WorkDate < eh2.WorkDate)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }

        public static IComparer<EmployeeHours> sortEmployeeHoursByDate()
        {
            return new SortEmployeeHoursDateHelper();
        }

        //Implement sort by Date worked Desc
        private class SortEmployeeHoursDateDescHelper : IComparer<EmployeeHours>
        {
            public int Compare(EmployeeHours eh2, EmployeeHours eh1)
            {


                if (eh1.WorkDate > eh2.WorkDate)
                {
                    return 1;
                }
                if (eh1.WorkDate < eh2.WorkDate)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }

        public static IComparer<EmployeeHours> sortEmployeeHoursByDateDesc()
        {
            return new SortEmployeeHoursDateDescHelper();
        }

    }

    


}

