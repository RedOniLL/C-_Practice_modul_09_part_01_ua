namespace C__Practice_modul_09_part_01_ua
{
    public delegate void MessageDelegate(string message);

    public delegate double ArithmeticOperation(double x, double y);

    public delegate bool Predicate<T>(T number);
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Task1: ");

            MessageDelegate messageDelegate;

            messageDelegate = DisplayMessage;
            messageDelegate("This is the first message.");

            messageDelegate = DisplayUppercaseMessage;
            messageDelegate("This is the uppercase message.");

            messageDelegate = DisplayLowercaseMessage;
            messageDelegate("This is the lowercase message.");

            Console.WriteLine("-----------------------");

            Console.WriteLine("Task2: ");

            ArithmeticOperation add = Add;
            ArithmeticOperation subtract = Subtract;
            ArithmeticOperation multiply = Multiply;

            double a = 10;
            double b = 5;

            Console.WriteLine($"{a} + {b} = {ShowOperation(add, a, b)}");
            Console.WriteLine($"{a} - {b} = {ShowOperation(subtract, a, b)}");
            Console.WriteLine($"{a} * {b} = {ShowOperation(multiply, a, b)}");

            Console.WriteLine("-----------------------");

            Console.WriteLine("Task3: ");

            Predicate<int> isEven = IsEven;
            Predicate<int> isOdd = IsOdd;
            Predicate<int> isPrime = IsPrime;
            Predicate<int> isFibonacci = IsFibonacci;

            int number = 13;

            Console.WriteLine($"{number} is even: {CheckNumber(isEven, number)}");
            Console.WriteLine($"{number} is odd: {CheckNumber(isOdd, number)}");
            Console.WriteLine($"{number} is prime: {CheckNumber(isPrime, number)}");
            Console.WriteLine($"{number} is a Fibonacci number: {CheckNumber(isFibonacci, number)}");
        }


        public static void DisplayMessage(string message)
        {
            Console.WriteLine("Original Message: " + message);
        }

        public static void DisplayUppercaseMessage(string message)
        {
            Console.WriteLine("Uppercase Message: " + message.ToUpper());
        }

        public static void DisplayLowercaseMessage(string message)
        {
            Console.WriteLine("Lowercase Message: " + message.ToLower());
        }

        public static double Add(double x, double y)
        {
            return x + y;
        }

        public static double Subtract(double x, double y)
        {
            return x - y;
        }

        public static double Multiply(double x, double y)
        {
            return x * y;
        }

        public static double ShowOperation(ArithmeticOperation operation, double x, double y)
        {
            return operation(x, y);
        }

        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        public static bool IsFibonacci(int number)
        {
            if (number < 0) return false;
            int a = 0, b = 1;
            while (b < number)
            {
                int temp = b;
                b = a + b;
                a = temp;
            }
            return b == number || number == 0;
        }

        public static bool CheckNumber(Predicate<int> predicate, int number)
        {
            return predicate(number);
        }
    }
}
