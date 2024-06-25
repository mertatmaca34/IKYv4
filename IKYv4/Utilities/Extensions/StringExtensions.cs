using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKYv4.Utilities.Extensions
{
    public static class StringExtensions
    {
        public static string DidTheyWork(this string str)
        {
            if (string.IsNullOrEmpty(str) || str == "X")
            {
                return "X";
            }
            return str;
        }
    }
}
