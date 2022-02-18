namespace FibonacciApi.Entities
{
    public partial class FibonacciNumber
    {
        public int Number { get; set; }
        public bool IsFibonnaci => CheckIsFibonacci(Number);

        public bool IsPrime => CheckIsPrime(Number);

        private bool CheckIsFibonacci(int number)
        {
            if (number == 0) return true;

            int a = 0;
            int b = 1;

            for (int i = 0; i < 52; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;

                if (a == number)
                {
                    return true;
                }
            }

            return false;
        }
        private bool CheckIsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }

}
