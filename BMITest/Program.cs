using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMI_Calculator;

namespace BMITest
{
    class Program
    {
        static void Main(string[] args)
        {
            BMICalculator calculator = new BMICalculator();
            calculator.Height = 168; // Centimeter
            calculator.Weight = 76; // Kilogram
            var result = calculator.Calculate();

            var _categories = calculator.Categories();

            Console.WriteLine(result + " : " + _categories);
            Console.ReadLine();
        }
    }
}
