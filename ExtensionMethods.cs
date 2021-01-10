using System;
using System.Linq;


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
