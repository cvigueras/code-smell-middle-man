namespace MiddleMan.App.Tests
{
    public class CalculatorShould
    {
        private Number givenNumber1;
        private Number givenNumber2;
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            givenNumber1 = Number.Create(10);
            givenNumber2 = Number.Create(20); 
            calculator = new Calculator();
        }

        [Test]
        public void SumTwoNumbersSuccessfully()
        {
            var result = calculator.Sum(givenNumber1, givenNumber2);

            Assert.IsTrue(result == givenNumber1.Value + givenNumber2.Value);
        }

        [Test]
        public void SubstractTwoNumbersSuccessfully()
        {
            var result = calculator.Subtract(givenNumber1, givenNumber2);

            Assert.IsTrue(result == givenNumber1.Value - givenNumber2.Value);
        }

        [Test]
        public void MultiplyTwoNumbersSuccessfully()
        {
            var result = calculator.Multiply(givenNumber1, givenNumber2);

            Assert.IsTrue(result == givenNumber1.Value * givenNumber2.Value);
        }

        [Test]
        public void SplitTwoNumbersSuccessfully()
        {
            var result = calculator.Split(givenNumber1, givenNumber2);

            Assert.IsTrue(result == givenNumber1.Value / givenNumber2.Value);
        }
    }
}