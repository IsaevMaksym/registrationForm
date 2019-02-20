using System;
using System.Globalization;

namespace WebSignInRegistrationForm.Helpers
{

    public class LingvaException : Exception
    {
        public LingvaException() : base() { }

        public LingvaException(string message) : base(message) { }

        public LingvaException(string message, params object[] args)
            : base(String.Format(CultureInfo.CurrentCulture, message, args))
        {
        }
    }
}