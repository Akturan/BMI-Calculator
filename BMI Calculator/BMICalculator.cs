using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator
{
    public class BMICalculator
    {
        public double Height { get; set; }
        public double Weight { get; set; }

        private double _result { get; set; }

        public double Calculate()
        {
            if (Height <= 0 || Weight <= 0)
                throw new Exception("Please check Height and Weight params");

            Height = Height / 100;

            var _height = Height * Height;
            var result = Math.Round(Weight / _height, 2);

            _result = result;

            return result;
        }

        public string Categories()
        {
            string categories = null;

            if(_result > 0)
            {
                if (_result < 18.5)
                    categories = "Underweight";
                else if (_result > 18.4 && _result < 25)
                    categories = "Normal weight";
                else if (_result > 24.9 && _result < 30)
                    categories = "Overweight";
                else
                    categories = "Obesity";
            }

            return categories;
        }
    }
}
