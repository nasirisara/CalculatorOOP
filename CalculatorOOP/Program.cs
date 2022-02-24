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
            operation.numbersArray = new double[5] { -9, 10, -6.6, 7, 10 };
            Console.WriteLine("please insert + , *, /, - as a operators");
            op = (Console.ReadLine()[0]);
            

            
            
            switch (op)
            {
                case '*':
                    Console.WriteLine("insert number1 , insert number2");
                    operation.number1 = Convert.ToDouble(Console.ReadLine());
                    operation.number2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(operation .Multiplation(operation.number1, operation.number2));
            break;
                case '/':
                    operation.number1 = Convert.ToDouble(Console.ReadLine());
                    operation.number2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(operation .Divition(operation.number1, operation.number2));
                    break;
                case '+':
                    Console.WriteLine(operation.Addition(operation.numbersArray));
                    break;
                case '-':
                    Console.WriteLine(operation.Substraction (operation.numbersArray));
                    break;









            }
            

            



        }
    }
}
