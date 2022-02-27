using CalculatorOOP.NewFolder;
using System;

namespace CalculatorOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator operation = new Calculator();
            char op;
            double[] numbersArray = new double[5] { (-9), 10, (-6.6), 7, 10 };
            Console.WriteLine("please insert + , *, /, - as a operators");
            op = (Console.ReadLine()[0]);
            

            
            
            switch (op)
            {
                case '*':
                    {
                        Console.WriteLine("insert number1 , insert number2");
                        double number1 = Convert.ToDouble(Console.ReadLine());
                        double number2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(Calculator.Multiplation(number1, number2));
                        break;
                    }
                case '/':
                    { 
                     double number1 = Convert.ToDouble(Console.ReadLine());
                    double  number2 = Convert.ToDouble(Console.ReadLine());
                    try
                    {
                        Console.WriteLine(Calculator.Divition(number1, number2));

                    }
                    catch (DivideByZeroException )
                    {

                        Console.WriteLine("num2 can not be zero");
                    }
                    Console.WriteLine(Calculator.Multiplation(number1, number2));
                    break;
                    }
                case '+':

                    Console.WriteLine(Calculator.Addition(numbersArray));
                    break;
                case '-':
                    Console.WriteLine(Calculator.Substraction (numbersArray));
                    break;









            }
            

            



        }
    }
}
