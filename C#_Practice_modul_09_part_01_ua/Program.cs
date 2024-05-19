namespace C__Practice_modul_09_part_01_ua
{
    public delegate void MessageDelegate(string message);

    public delegate double ArithmeticOperation(double x, double y);

    public delegate bool Predicate(int number);
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Task1: ");

            MessageDelegate messageDelegate;

            messageDelegate = DisplayMessage1;
            messageDelegate("This is the first message.");

            messageDelegate = DisplayMessage2;
            messageDelegate("This is the second message.");

            messageDelegate = DisplayMessage3;
            messageDelegate("This is the third message.");

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

            Predicate isEven = IsEven;
            Predicate isOdd = IsOdd;
            Predicate isPrime = IsPrime;
            Predicate isFibonacci = IsFibonacci;

            int number = 13;

            Console.WriteLine($"{number} is even: {CheckNumber(isEven, number)}");
            Console.WriteLine($"{number} is odd: {CheckNumber(isOdd, number)}");
            Console.WriteLine($"{number} is prime: {CheckNumber(isPrime, number)}");
            Console.WriteLine($"{number} is a Fibonacci number: {CheckNumber(isFibonacci, number)}");
        }

    
        static void DisplayMessage1(string message)
        {
            Console.WriteLine(message);
        }


        static void DisplayMessage2(string message)
        {
            Console.WriteLine(message);
        }


        static void DisplayMessage3(string message)
        {
            Console.WriteLine(message);
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

        public static bool CheckNumber(Predicate predicate, int number)
        {
            return predicate(number);
        }
    }
}
