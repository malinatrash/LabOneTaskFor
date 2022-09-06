using System;

namespace TaskFor
{
   public class Logic
    {
        public static int Calculate(int number)
        {
            int numberSquared = 0;
            for (int iteration = 1; iteration <= number; iteration += 1)
            {
                numberSquared += (2 * iteration - 1);
            }

            return (numberSquared);
        }
    }
    class Programm
    {
        static void Main()
        {

            Console.WriteLine("Please enter a number: ");
            var number = int.Parse(Console.ReadLine());

            var numberSquared = Logic.Calculate(number);

            Console.WriteLine(numberSquared);
        }
    }
}
