namespace Lab1
{
    // Exercitiul 2:
    static class Calculator
    {
        private static int Add(int a, int b)
        {
            return a + b;
        }

        private static int Subtract(int a, int b)
        {
            return a - b;
        }

        private static int Multiply(int a, int b)
        {
            return a * b;
        }

        private static int Divide(int a, int b)
        {
            return a / b;
        }

        public static void Print(int x, int y)
        {
            Console.WriteLine("Add: {0}", Add(x, y));
            Console.WriteLine("Subtract: {0}", Subtract(x, y));
            Console.WriteLine("Multiply: {0}", Multiply(x, y));
            Console.WriteLine("Divide: {0}", Divide(x, y));
            Console.WriteLine();
        }
    }
}
