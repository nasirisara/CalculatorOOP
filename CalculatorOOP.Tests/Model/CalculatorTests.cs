using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CalculatorOOP.NewFolder;

namespace CalculatorOOP.Tests.Model
{
    public class CalculatorTests
    {

        [Fact]
        public void MultiplationTest()
        {
            double number1 = 6;
            double number2 = 5;
            double result = Calculator.Multiplation(number1, number2);

            Assert.Equal(30, result);
        }

        [Fact]
        public void DivitonTest()
        {
            double number1 = 40;
            double number2 = 8;
            double result = Calculator.Divition(number1, number2);

            Assert.Equal(5, result);

        }

        [Fact]
        public void DivideByZeroExceptionTest() 
        { double number1 = 56;
            double number2 = 0;
            Calculator calc = new Calculator();
            Assert.Throws<DivideByZeroException>(() => Calculator.Divition(number1,number2)); 

        }

        [Fact]
        public void AdditionTest( )
            
        {
            double[] numbersArray = new double[2] {-3.3,12 };
            double result = Calculator.Addition(numbersArray);

            Assert.Equal(8.7, result);
        }
        


        [Fact]
        public void SubstractionTest()
        {
            double[] numbersArray = new double[2] { -3.3, 12 };
            double result = Calculator.Substraction(numbersArray);

            Assert.Equal(-15.3 , result );

        }

    }
}
