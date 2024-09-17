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
        public string operation { get; set; }

        private Dictionary<string, Func<double>> operations;

    }


    internal class Program
    {

    }
}
