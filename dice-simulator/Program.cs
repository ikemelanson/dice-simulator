//Ike Melanson dice simulator game

using System;

namespace dice_simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            int[] rolled = new int[11];

            Console.WriteLine("Welcome to the dice throwing simulator!\n\n");
            Console.WriteLine("How many dice rolls would you like to simulate?\n");

            int rollsInt = Int32.Parse(Console.ReadLine());

            //generate two random numbers between 1-6 and add them together. increment the corosponding position in the array
            for (int x = 1; x <= rollsInt; x++)
            {
                int thisRoll = ran.Next(1, 7) + ran.Next(1, 7);
                rolled[thisRoll - 2]++;
            }

            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each '*' represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + rollsInt.ToString() + ".\n");

            //loop through the array, and find the percentage of times each number was rolled.
            for (int x = 0; x < rolled.Length; x++)
            {
                int stars = (int) Math.Round((rolled[x] / (double) rollsInt) * 100, 0);

                Console.Write((x + 2).ToString() + ':');

                //for each percentage point, write one '*'
                for (int count = 0; count < stars; count++)
                {
                    Console.Write('*');
                }

                Console.WriteLine();
            }

            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");

        }
    }
}
