namespace Operators
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var d = new Digit(7);

            byte number = d;
            Assert.Equal(7, number);

            Digit digit = (Digit)number;
            Assert.Equal(new Digit(7), digit);
        }
    }

public readonly struct Digit
    {
        private readonly byte digit;

        public Digit(byte digit)
        {
            if (digit > 9)
            {
                throw new ArgumentOutOfRangeException(nameof(digit), "Digit cannot be greater than nine.");
            }
            this.digit = digit;
        }

        public static implicit operator byte(Digit d) => d.digit;
        public static explicit operator Digit(byte b) => new Digit(b);     

        public override string ToString() => $"{digit}";
    }
}