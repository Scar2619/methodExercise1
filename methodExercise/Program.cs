using System;

namespace methodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine("Enter your favorite activity.");
            var activity =Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            var animal = Console.ReadLine();
            Console.WriteLine("What is your favorite music?");
            var music = Console.ReadLine();
            Console.WriteLine($"My name is {name} and I enjoy {activity}. I love listening to {music} and my favorite animal is {animal}");
            Console.WriteLine();

            Console.WriteLine("Addition:");
            Console.WriteLine(Add(9, 4));
            Console.WriteLine("Subtraction:");
            Console.WriteLine(Sub(233, 76));
            Console.WriteLine("Multiplication:");
            Console.WriteLine(Mult(33, 6));
            Console.WriteLine("Division:");
            Console.WriteLine(Div(370, 5));
            Console.WriteLine();

            Console.WriteLine(ParamsAdd(2, 4));
            Console.WriteLine(ParamsAdd(2, 4, 6));
            Console.WriteLine(ParamsAdd(1, 1, 1, 1, 1));
        }

        public static int Add(int x, int y)
        {
            return x + y; 
        }

        public static int Sub(int x, int y)
        {
            return x - y;
        }

        public static int Mult(int x, int y)
        {
            return x * y;
        }

        public static int Div(int x, int y)
        {
            return x / y;
        }

        public static int ParamsAdd(params int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }
    }
}

