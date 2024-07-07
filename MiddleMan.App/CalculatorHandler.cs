using MiddleMan.App.Tests;

namespace MiddleMan.App
{
    public class CalculatorHandler
    {
        private Calculator Calculator;
        private Number Number1;
        private Number Number2;

        public CalculatorHandler()
        {
            Calculator = new Calculator();
        }

        public int Handle()
        {
            var random = new Random();
            Number1 = Number.Create(random.Next(1, 21));
            Number2 = Number.Create(random.Next(1, 21));
            if (Number1.Value % 2 == 0)
            {
                return Calculator.Sum(Number1, Number2);
            }
            else
            {
                return Calculator.Split(Number1, Number2);
            }
        }
    }
}