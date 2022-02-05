using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class UserForm
    {
        public const string FIRST_NAME = "^[A-Z][a-zA-Z]{2}";
        public const string LAST_NAME = "^[A-Z][a-zA-Z]{2}";
        public const string MOBILE = "^([9][1])+[ ]+[789]{1}[0-9]{9}$";
        public const string PASSWORD_R1 = "^[a-z]{8}";
        public const string PASSWORD_R2 = "^(?=.*[a-z])(?=.*[A-Z]).{8,}$";
        public const string PASSWORD_R3 = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9]).{8,}$";
        public const string PASSWORD_R4 = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[@#$%^&-+=()]).{8,}$";
        public const string EMAIL = "^[a-zA-z]{3}([+-_ .]*[a-zA-Z0-9]+)*[@][a-zA-z0-9]+(.[a-z]{2,3})*$";

        public bool ValidateFName(string fName)
        {
            // create regex object & initialize pattern to it
            Regex regex = new Regex(FIRST_NAME);

            //check if pattern match with string
            if (regex.IsMatch(fName))
            {
                return true;
            }
            else
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_FIRSTNAME, "Inavlid First Name");
            }

        }
        public bool ValidateLName(string lName)
        {
            // create regex object & initialize pattern to it
            Regex regex = new Regex(LAST_NAME);

            //check if pattern match with string
            if (regex.IsMatch(lName))
            {
                return true;
            }
            else
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_LASTNAME, "Invalid Last Name");
            }
        }

        public bool ValidateEmail(string email)
        {
            // create regex object & initialize pattern to it
            Regex regex = new Regex(EMAIL);

            //check if pattern match with string
            if (regex.IsMatch(email))
            {
                return true;
            }
            else
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_EMAIL, "Invalid Email ID");
            }
        }
        public bool ValidateMobile(string number)
        {
            // create regex object & initialize pattern to it
            Regex regex = new Regex(MOBILE);

            //check if pattern match with string
            if (regex.IsMatch(number))
            {
                return true;
            }
            else
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_MOBILE, "Invalid Mobile Number");
            }
        }

        public bool ValidatePasswordR1(string password)
        {
            // create regex object & initialize pattern to it
            Regex regex = new Regex(PASSWORD_R1);

            //check if pattern match with string
            if (regex.IsMatch(password))
            {
                return true;
            }
            else
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_PASSWORD, "Invalid Password");
            }
        }

        // atleast one uppercase
        public bool ValidatePasswordR2()
        {
            Regex regex = new Regex(PASSWORD_R2);
            if (regex.IsMatch("akXyb302"))
            {
                return true;
            }
            else
            {

                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_PASSWORD, "Invalid Password");
            }

        }
        //atleast one number
        public bool ValidatePasswordR3()
        {
            Regex regex = new Regex(PASSWORD_R3);
            if( regex.IsMatch("akXybxy3"))
            {
                return true;
            }
             else
            {

                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_PASSWORD, "Invalid Password");
            }
        }
        // atleast one special character
        public bool ValidatePasswordR4(string pass)
        {
            Regex regex = new Regex(PASSWORD_R4);
            if (regex.IsMatch(pass))
            {
                return true;
            }
            else
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_PASSWORD, "Invalid Password");
            }
        }

    }
}
