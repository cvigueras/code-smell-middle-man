namespace MiddleMan.App.Tests
{
    public class Calculator
    {
        public int Multiply(Number number1, Number number2)
        {
            return number1.Value * number2.Value;
        }

        public int Split(Number number1, Number number2)
        {
            return number1.Value / number2.Value;
        }

        public int Subtract(Number number1, Number number2)
        {
            return number1.Value - number2.Value;
        }

        public int Sum(Number number1, Number number2)
        {
            return number1.Value + number2.Value;
        }
    }
}