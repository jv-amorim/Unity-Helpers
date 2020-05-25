using System;
using System.Net.Mail;

namespace UnityHelpers.EmailHelpers
{
    public static class EmailValidator
    {
        public static bool Validate(string emailAddress)
        {
            try
            {
                new MailAddress(emailAddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}