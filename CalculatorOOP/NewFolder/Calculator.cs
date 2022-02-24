using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorOOP.NewFolder
{
    class Calculator
    {
        public double number1 { get; set; }
        public double number2 { get; set; }
        public double[] numbersArray = new double [5];
        public  double Multiplation(double num1, double num2)

        {
            double multiple = num1 * num2;
            return multiple;
        }
        public double Divition(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("num2 can not be zero");

            }
            double divide = num1 / num2;
            return divide;
        }
        public  double Addition (double[] numbersArray)
        {
            double sum = 0;
            for (int i = 0; i < numbersArray.Length; i++)
            {
                sum = sum + numbersArray[i];

            }

            return sum;
           
        }
        public double Substraction (double[] numbersArray)
        {
            double sub = 0;
            for (int i = 0; i < numbersArray.Length ; i++)
            {
                sub = sub - numbersArray[i];
            }
            return sub;
        }
        


        
        



    }
}
