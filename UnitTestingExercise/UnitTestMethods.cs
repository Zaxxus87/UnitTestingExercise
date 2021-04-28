using System;
namespace UnitTestingExercise
{
    public class UnitTestMethods
    {
        // Make sure your references are set properly
        // Righ-click on Dependencies in your .Tests project and set your reference
        public int Add(int one, int two, int three)
        {
            return one + two + three;
        }


        // Create an Add method that passes 3 integers

        // Create a Subtract method that passes 2 integers
            // Keep track of which number is getting passed as minuend and subtrahend
        public int Subtract(int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }
        // Create a Multiply method that passes 2 integers
        public int Multiply(int one, int two)
        {
            return one * two;
        }
        // Create a Divide method that passes 2 integers
        public double Divide(int dividend, int divisor)
        {
            double num = dividend;
            return dividend / divisor;
        }


        // Create 2 methods that will utilize the [Fact] tests you wrote
        public string Happy()
        {
            return ":)";
        }

        public bool Successful()
        {
            return true;
        }
        
    }
}
