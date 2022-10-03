using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatamanProjectClassLibrary
{
    public class Problem
    {
        public Problem(string number1, string operand, string number2, string answer)
        {
            Number1 = number1;
            Operand = operand;
            Number2 = number2;
            Answer = answer;
        }

        public Problem(string number1, string operand, string number2)
        {
            Number1 = number1;
            Operand = operand;
            Number2 = number2;
           
        }

        public string Number1 { get; set; }
        public string Number2 { get; set; }

        public string Answer { get; set; }

        public string Operand { get; set; }
    }
}
