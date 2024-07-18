using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumber_Assignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("This program was written by Brandon Johnson for CSIS 209-D01");

            /*This section sets up the array for the dice,
             */
            Random dice = new Random();
            int[] diceRoll = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            
            
          /*This section sets up both dice, the amount of faces on the dice,
           * how many times it will roll, and the calculation to get the sum
           * of both dice. */

            for (int roll = 1; roll <= 36000; roll++)
            {
                int firstDie = dice.Next(1, 7);
                int secondDie = dice.Next(1, 7);
                int sum = firstDie + secondDie;
                diceRoll[sum - 2]++;
            }

            /* This section prints out the results in a 
             * column format, with the left side dictating the
             * sum and the right side dictating the count */

            Console.WriteLine("Sum\tCount\n");
            for (int roll = 0; roll < diceRoll.Length; roll++)
            {

                Console.WriteLine("{0,-5} {1,-5} ", (roll + 2), diceRoll[roll]);
                int cap = diceRoll.GetUpperBound(0);


            }

            Console.Write("Press any key to continue...");
            Console.ReadKey();

        }

    
    }

}



            
          


        
    

