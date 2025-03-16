using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestCSharp.Strings
{
    public class EmailValidaotr
    {
        public bool IsValidEmail(string emailAddr)
        {
            if (string.IsNullOrEmpty(emailAddr))
            {
                return false;
            }
            if (!emailAddr.Contains("@"))
            {
                return false;
            }

            if (!emailAddr.Contains("."))
            {
                return false;
            }

            return true;
        }
    }
}
