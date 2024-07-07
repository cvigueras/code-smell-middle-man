namespace MiddleMan.App
{
    public class Number
    {
        public int? Value { get; private set; }
        private Number(int? value)
        {
            Value = value;
        }

        public static Number Create(int? value = null)
        {
            if(value == null)
            {
                return new Number(GetRandomNumber());
            }
            return new Number(value);
        }

        private static int? GetRandomNumber()
        {
            return new Random().Next(1, 21);
        }
    }
}
