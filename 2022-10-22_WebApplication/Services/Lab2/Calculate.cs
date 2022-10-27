namespace _2022_10_22_WebApplication.Services.Lab2
{
    public class Calculate
    {
        private int Value { get; set; }
        public Calculate(int value)
        {
            Value = value;
        }
        public void increaseValue(int value)
        {
            Value += value;
        }
        public void decreaseValue(int value)
        {
            Value -= value;
        }
        public int getValue()
        {
            return Value;
        }
    }
}
