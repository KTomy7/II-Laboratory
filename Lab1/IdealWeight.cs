namespace Lab1
{
    // Exercitiul 4:
    class IdealWeight
    {
        int height;
        int age;
        char sex; // f or m

        public IdealWeight()
        {
            Console.Write("Enter your height in cm: ");
            this.height = int.Parse(Console.ReadLine()!);
            Console.Write("Enter your age: ");
            this.age = int.Parse(Console.ReadLine()!);
            Console.Write("Enter your sex: ");
            this.sex = char.Parse(Console.ReadLine()!);
        }

        public void ComputeIdealWeight()
        {
            if (sex == 'f')
            {
                ComputeForFemale();
            }
            else
            {
                ComputeForMale();
            }
        }

        private void ComputeForMale()
        {
            double idealWeight = ((height - 100) - (height - 150) / 4) + (age - 20) / 10;
            Print(idealWeight);
        }

        private void ComputeForFemale()
        {
            double idealWeight = ((height - 100) - (height - 150) / 2.5) + (age - 20) / 6;
            Print(idealWeight);
        }

        private static void Print(double idealWeight)
        {
            Console.WriteLine("Your ideal weight is: {0}", idealWeight);
            Console.WriteLine();
        }

    }
}
