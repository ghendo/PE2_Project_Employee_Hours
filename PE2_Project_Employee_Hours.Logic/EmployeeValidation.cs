using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PE2_Project_Employee_Hours.Logic
{
    public enum EmployeeValidateEnum
    {
        success,
        nullValue,
        containsNumber,
        tooShort,
        tooLong,
        notEmail,
        notPhone,
        notDate,
        startsSpace
    }

    public class EmployeeValidation
    {
        public EmployeeValidateEnum ValidateFirstName(string s)
        {

            EmployeeValidateEnum validateEnum = EmployeeValidateEnum.success;

            if (String.IsNullOrWhiteSpace(s))
            {
                validateEnum = EmployeeValidateEnum.nullValue;
                throw new EmployeeException(validateEnum);
                
            }

            if (s[0].ToString() == " ")
            {
                validateEnum = EmployeeValidateEnum.startsSpace;
                throw new EmployeeException(validateEnum);
            }

            foreach (var item in s)
            {
                if (char.IsNumber(item))
                {
                    validateEnum = EmployeeValidateEnum.containsNumber;
                    throw new EmployeeException(validateEnum);
                }
            }

            if (s.Length < 3)
            {
                validateEnum = EmployeeValidateEnum.tooShort;
                throw new EmployeeException(validateEnum);
            }

            if (s.Length > 49)
            {
                validateEnum = EmployeeValidateEnum.tooLong;
                throw new EmployeeException(validateEnum);
            }

            return validateEnum;

        }

        public EmployeeValidateEnum ValidateLastName(string s)
        {

            EmployeeValidateEnum validateEnum = EmployeeValidateEnum.success;


            if (String.IsNullOrWhiteSpace(s))
            {
                validateEnum = EmployeeValidateEnum.nullValue;
                throw new EmployeeException(validateEnum);

            }
            else
            {
                foreach (var item in s)
                {
                    if (char.IsNumber(item))
                    {
                        validateEnum = EmployeeValidateEnum.containsNumber;
                        throw new EmployeeException(validateEnum);
                    }
                }
            }

            if (s[0].ToString() == " ")
            {
                validateEnum = EmployeeValidateEnum.startsSpace;
                throw new EmployeeException(validateEnum);
            }

            if (s.Length < 3)
            {
                validateEnum = EmployeeValidateEnum.tooShort;
                throw new EmployeeException(validateEnum);
            }

            if (s.Length > 49)
            {
                validateEnum = EmployeeValidateEnum.tooLong;
                throw new EmployeeException(validateEnum);
            }

            return validateEnum;

        }

        public EmployeeValidateEnum ValidateDateOfBirth(string s)
        {
            DateTime date;

            EmployeeValidateEnum validateEnum = EmployeeValidateEnum.success;

            if (String.IsNullOrWhiteSpace(s))
            {
                validateEnum = EmployeeValidateEnum.nullValue;
                throw new EmployeeException(validateEnum);

            }

            if( DateTime.TryParse(s, out  date))
            {

            }
            else
            {
                validateEnum = EmployeeValidateEnum.notDate;
                throw new EmployeeException(validateEnum);
            }



            return validateEnum;

        }

        public EmployeeValidateEnum ValidateEmail(string s)
        {

            EmployeeValidateEnum validateEnum = EmployeeValidateEnum.success;

            if (String.IsNullOrWhiteSpace(s))
            {
                validateEnum = EmployeeValidateEnum.nullValue;
                throw new EmployeeException(validateEnum);

            }

            if (new EmailAddressAttribute().IsValid(s) == false)
            {
                validateEnum = EmployeeValidateEnum.notEmail;
                throw new EmployeeException(validateEnum);
            }
            return validateEnum;

        }

        public EmployeeValidateEnum ValidatePhone(string s)
        {

            EmployeeValidateEnum validateEnum = EmployeeValidateEnum.success;

            if (String.IsNullOrWhiteSpace(s))
            {
                validateEnum = EmployeeValidateEnum.nullValue;
                throw new EmployeeException(validateEnum);

            }

            if (new PhoneAttribute().IsValid(s) == false)
            {
                validateEnum = EmployeeValidateEnum.notPhone;
                throw new EmployeeException(validateEnum);
            }
            return validateEnum;
        }

    }
}
