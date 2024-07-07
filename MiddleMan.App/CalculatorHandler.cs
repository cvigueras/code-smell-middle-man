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

        public int? Handle()
        {
            Number1 = Number.Create();
            Number2 = Number.Create();
            if (IsSumOperation())
            {
                return Calculator.Sum(Number1, Number2);
            }
            return Calculator.Split(Number1, Number2);
        }

        private bool IsSumOperation()
        {
            return Number1.Value % 2 == 0;
        }
    }
}