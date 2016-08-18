# BMI Calculator
BMI Calculator

```
using BMI_Calculator;
```

```
BMICalculator calculator = new BMICalculator();
calculator.Height = 168; // Centimeter
calculator.Weight = 76; // Kilogram
var result = calculator.Calculate();

var _categories = calculator.Categories();

Console.WriteLine(result + " : " + _categories);
```
