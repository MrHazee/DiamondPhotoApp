using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class MyExtensions
    {

        public static string FirstCharToUpper(this string input)
        {
            if (input != null)
            {
                return input.First().ToString().ToUpper() + input.Substring(1);
            }
            else
            {
                throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input));

            }
        }
      
    }
}
