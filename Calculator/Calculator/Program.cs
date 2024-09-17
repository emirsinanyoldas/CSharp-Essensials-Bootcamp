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

        private double Factorial(int number)
        {
            if (number < 0)
            {
                throw new InvalidOperationException("Factorial can not be negative.");
            }

            double result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        public double Calculate()
        {
            if (operations.ContainsKey(Operation))
            {
                return operations[Operation]();
            }
            else
            {
                throw new InvalidOperationException("Invalid operation.");
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the first number: ");
                double number1 = Convert.ToDouble(Console.ReadLine());
                
                Console.Write("Enter the second number: ");
                double number2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the operation (+, -, *, /, %, !): ");
                double operation = Convert.ToDouble(Console.ReadLine());

                Calculator calculator = new Calculator(number1, number2, operation1);
                double result = calculator.Calculate();

                Console.WriteLine("Result: ", result);
            }
            // I take some help, for these
            catch(Expection ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
