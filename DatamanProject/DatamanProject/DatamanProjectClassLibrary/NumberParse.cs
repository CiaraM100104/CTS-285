using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatamanProjectClassLibrary
{
    public static class NumberParse
    {
        public static int ParseInt(string stringNum)
        {
            int number;
            int.TryParse(stringNum, out number);
            return number;
        }

        public static double ParseDouble (string stringNum)
        {
            double number;
            double.TryParse(stringNum, out number);
            return number;
        }
    }
}
