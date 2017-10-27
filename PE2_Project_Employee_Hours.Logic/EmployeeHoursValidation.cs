using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE2_Project_Employee_Hours.Logic
{
    public enum EmployeeHoursValidateEnum
    {
        success,
        nullValue,
        containsNumber,
        tooShort,
        tooLong,
        notEmail,
        notPhone,
        notDate,
        startsSpace,
        notNumber
    }
    public class EmployeeHoursValidation
    {
        public EmployeeHoursValidateEnum ValidateEmployeeHoursId(string s)
        {

            EmployeeHoursValidateEnum validateEnum = EmployeeHoursValidateEnum.success;

            if (String.IsNullOrWhiteSpace(s))
            {
                validateEnum = EmployeeHoursValidateEnum.nullValue;
                throw new EmployeeHoursException(validateEnum);

            }

            return validateEnum;

        }

        public EmployeeHoursValidateEnum ValidateEmployeeHoursEmployeeId(string s)
        {

            EmployeeHoursValidateEnum validateEnum = EmployeeHoursValidateEnum.success;

            if (String.IsNullOrWhiteSpace(s))
            {
                validateEnum = EmployeeHoursValidateEnum.nullValue;
                throw new EmployeeHoursException(validateEnum);

            }

            return validateEnum;

        }

        public EmployeeHoursValidateEnum ValidateWorkDate(string s)
        {

            EmployeeHoursValidateEnum validateEnum = EmployeeHoursValidateEnum.success;

            if (String.IsNullOrWhiteSpace(s))
            {
                validateEnum = EmployeeHoursValidateEnum.nullValue;
                throw new EmployeeHoursException(validateEnum);

            }

            if (DateTime.TryParse(s, out DateTime date))
            {

            }
            else
            {
                validateEnum = EmployeeHoursValidateEnum.notDate;
                throw new EmployeeHoursException(validateEnum);
            }

            return validateEnum;

        }

        public EmployeeHoursValidateEnum ValidateWorkHours(string s)
        {

            EmployeeHoursValidateEnum validateEnum = EmployeeHoursValidateEnum.success;

            if (String.IsNullOrWhiteSpace(s))
            {
                validateEnum = EmployeeHoursValidateEnum.nullValue;
                throw new EmployeeHoursException(validateEnum);

            }

            if (Decimal.TryParse(s, out Decimal num))
            {

            }
            else
            {
                validateEnum = EmployeeHoursValidateEnum.notEmail;
                throw new EmployeeHoursException(validateEnum);
            }
            return validateEnum;

        }
    }
}
