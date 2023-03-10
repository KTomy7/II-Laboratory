namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercitiul 1:
            FibonacciSequence(10);

            // Exercitiul 2:
            Console.Write("Enter two numbers: ");
            string[] numbers = Console.ReadLine().Split(' ');
            Calculator.Print(int.Parse(numbers[0]), int.Parse(numbers[1]));

            // Exercitiul 3:
            CelsiusToFahrenheit();
            FahrenheitToCelsius();

            // Exercitiul 4:
            IdealWeight idealWeightMark = new IdealWeight();
            idealWeightMark.ComputeIdealWeight();

            // Exercitiul 5:
            ComputeMean();

            Console.ReadKey();
        }

        // Exercitiul 1:
        public static void FibonacciSequence(int n)
        {
            if (n == 0)
            {
                Console.WriteLine("Fibonacci sequence: 0");
                Console.WriteLine();
            }
            else if (n == 1)
            {
                Console.WriteLine("Fibonacci sequence: 0, 1");
                Console.WriteLine();
            }
            else
            {
                int[] f = new int[n];
                f[0] = 0;
                f[1] = 1;

                for (int i = 2; i < n; i++)
                {
                    f[i] = f[i - 2] + f[i - 1];
                }
                Console.WriteLine("Fibonacci sequence: {0}", string.Join(", ", f));
                Console.WriteLine();
            }
        }

        // Exercitiul 3:
        public static void CelsiusToFahrenheit()
        {
            Console.Write("Enter the temperature in Celsius: ");
            float celcius = float.Parse(Console.ReadLine());
            float fahrenheit = celcius * 9 / 5 + 32;
            Console.WriteLine("Temperature in Fahrenheit is: {0}", fahrenheit.ToString("0.00"));
            Console.WriteLine();
        }
        public static void FahrenheitToCelsius()
        {
            Console.Write("Enter the temperature in Fahrenheit: ");
            float fahrenheit = float.Parse(Console.ReadLine());
            float celcius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Temperature in Celcius is: {0}", celcius.ToString("0.00"));
            Console.WriteLine();
        }

        // Exercitiul 5:
        public static void ComputeMean()
        {
            Console.Write("Enter a string of numbers: ");
            var numbers = Console.ReadLine().Split(' ').ToList();

            double geometricMean = 1;
            double arithmeticMean = 0;

            foreach (var number in numbers)
            {
                geometricMean *= double.Parse(number);
                arithmeticMean += double.Parse(number);
            }

            geometricMean = Math.Pow(geometricMean, 1.0 / numbers.Count());
            arithmeticMean = arithmeticMean / numbers.Count();

            Console.WriteLine("The geometric mean is: {0}", geometricMean.ToString("0.00"));
            Console.WriteLine("The arithmetic mean is: {0}", arithmeticMean.ToString("0.00"));
        }
    }
}
