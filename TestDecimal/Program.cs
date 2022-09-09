using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TestDecimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "3.7";

            try
            {
                var a = float.Parse(input, System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.CultureInfo.InvariantCulture);
                Console.WriteLine(a.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-GB")));

                File.WriteAllText("a.txt", a.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-GB")));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
