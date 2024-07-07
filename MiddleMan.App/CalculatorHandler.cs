﻿using MiddleMan.App.Tests;

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
            Number1 = GetRandomNumber();
            Number2 = GetRandomNumber();
            if (IsSumOperation())
            {
                return SumNumbers();
            }
            return SplitNumbers();
        }
        private Number GetRandomNumber()
        {
            var random = new Random();
            return Number.Create(random.Next(1, 21));
        }
        private bool IsSumOperation()
        {
            return Number1.Value % 2 == 0;
        }

        private int SplitNumbers()
        {
            return Calculator.Split(Number1, Number2);
        }

        private int SumNumbers()
        {
            return Calculator.Sum(Number1, Number2);
        }
    }
}