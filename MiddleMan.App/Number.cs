namespace MiddleMan.App
{
    public class Number
    {
        public int Value { get; private set; }
        private Number(int value)
        {
            Value = value;
        }

        public static Number Create(int value)
        {
            return new Number(value);
        }
    }
}
