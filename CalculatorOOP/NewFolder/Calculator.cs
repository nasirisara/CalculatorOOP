using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorOOP.NewFolder
{
    public class Calculator
    {
        
        

        public  static double Multiplation(double num1, double num2)

        {
            double multiple = num1 * num2;
            return multiple;
        }
        public static double Divition(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("num2 can not be zero");

            }
            else
            {
                double divide = num1 / num2;
                return divide;

            }
            
        }
        public  static double Addition (double[] numbersArray)
        {
            
            double result = Calculator.Addition(numbersArray);
            double sum = 0;
            for (int i = 0; i < numbersArray.Length; i++)
            {
                sum = sum + numbersArray[i];

            }

            return sum;
           
        }
        public static  double Substraction (double[] numbersArray)
        {
            double sub = numbersArray [0];
            for (int i = 1; i < numbersArray.Length ; i++)
            {
                sub = sub - (numbersArray[i]);
            }
            return sub;
        }
        


        
        



    }
}
