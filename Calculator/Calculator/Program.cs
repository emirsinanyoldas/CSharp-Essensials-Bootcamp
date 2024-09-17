using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public double number1 { get; set; }
        public double number2 { get; set; }
        public string operation1 { get; set; }

        private Dictionary<string, Func<double>> operations;

        public Calculator(double num1, double num2,string opert1)
        {
            number1 = num1;
            number2 = num2;
            operation1 = opert1;

            operations = new Dictionary<string, Func<double>>()
            {
                { "+",()=>number1+number2},
                { "-",()=>number1-number2},
                { "*",()=>number1*number2},
                { "/",()=>number2==0?throw new DivideByZeroException("Cannot divide by zero."):number1/number2},
                { "%",()=>number2==0?throw new DivideByZeroException("Cannot divide by zero."):number1%number2},
                { "!",()=>Factorial((int)number1)}
            };
        }
    }


    internal class Program
    {

    }
}
