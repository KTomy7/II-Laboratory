namespace Lab1
{
    // Exercitiul 2:
    class Calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Substract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static int Divide(int a, int b)
        {
            return a / b;
        }

        public static void Print(int x, int y)
        {
            Console.WriteLine("Add: {0}", Add(x, y));
            Console.WriteLine("Substract: {0}", Substract(x, y));
            Console.WriteLine("Multiply: {0}", Multiply(x, y));
            Console.WriteLine("Divide: {0}", Divide(x, y));
            Console.WriteLine();
        }
    }
}
