using System;

namespace MethodExcersize2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            
            Console.WriteLine("Please use 1 - 4 to choose \n1: Add \n2: Subtract \n3: Multiply \n4: Divide");
            
            int choice;

            choice = int.Parse(Console.ReadLine());
            while (choice > 4 || choice < 0)
            {
                Console.WriteLine("Please use 1 - 4 to choose \n1: Add \n2: Subtract \n3: Multiply \n4: Divide");
                choice = int.Parse(Console.ReadLine());
            }

            if (choice == 1)
            {
                Console.WriteLine("Please Enter 6 Numbers to add (enter 0 for unused spaces)");
                int a1 = int.Parse(Console.ReadLine());

                int a2 = int.Parse(Console.ReadLine());

                int a3 = int.Parse(Console.ReadLine());

                int a4 = int.Parse(Console.ReadLine());

                int a5 = int.Parse(Console.ReadLine());

                int a6 = int.Parse(Console.ReadLine());

                int result = Methods.Sum(a1, a2, a3, a4, a5, a6);

                Console.WriteLine($"Result is : " + result);
            }
            else if (choice == 2)
            {
                Console.WriteLine("Please Enter 6 Numbers to Subtract (enter 0 for unused spaces)");
                int a1 = int.Parse(Console.ReadLine());

                int a2 = int.Parse(Console.ReadLine());

                int a3 = int.Parse(Console.ReadLine());

                int a4 = int.Parse(Console.ReadLine());

                int a5 = int.Parse(Console.ReadLine());

                int a6 = int.Parse(Console.ReadLine());

                int result = Methods.Minus(a1, a2, a3, a4, a5, a6);

                Console.WriteLine($"Result is : " + result);
            }
            else if (choice == 3)
            {
                Console.WriteLine("Please Enter 4 Numbers to Multiply (enter 1 for unused spaces)");
                int a1 = int.Parse(Console.ReadLine());

                int a2 = int.Parse(Console.ReadLine());

                int a3 = int.Parse(Console.ReadLine());

                int a4 = int.Parse(Console.ReadLine());

                double result = Methods.Multiply(a1, a2, a3, a4);

                Console.WriteLine($"Result is : " + result);
            }
            else 
            {
                Console.WriteLine("Please Enter 2 Numbers to Divide (enter 1 for unused spaces)");
                int a1 = int.Parse(Console.ReadLine());

                int a2 = int.Parse(Console.ReadLine());

                double result = Methods.Divide(a1, a2);

                Console.WriteLine($"Result is : " + result);
            }
       
        }
    }
}
