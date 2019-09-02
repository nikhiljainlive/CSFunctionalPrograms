// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CoinFlip.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Nikhil Jain"/>
// ----------------------
namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Calculates percentage of Heads and tails
    /// </summary>
    public class CoinFlip
    {
        /// <summary>
        /// Flips the coin.
        ///  Ask's user the Number of times to flipCoin and Calculates Percentage of Heads or Tails ,
        ///  based on the Random Number generated.
        /// </summary>
        public static void FlipCoin()
        {
            int heads = 0;
            int tails = 0;
            int numberOfFlips;
            Random randomNumber = new Random();

            Console.WriteLine("Enter the number of times to Flip the Coin");

            string timeOfFlips = Console.ReadLine();
            if (Utility.IsNumber(timeOfFlips) == false)
            {
                Console.WriteLine("wrong input,give an number");
                return;
            }
            else
            {
                numberOfFlips = Convert.ToInt32(timeOfFlips);
                //// this iterates as many as number of flips ,given by the user.
                for (int i = 0; i < numberOfFlips; i++)
                {
                    if (randomNumber.NextDouble() > 0.5)
                    {
                        tails++;
                    }
                    else
                    {
                        heads++;
                    }
                }

                Console.WriteLine("Heads Percentage = " + ((heads * 100) / numberOfFlips) + "%");
                Console.WriteLine("Tails Percentage = " + ((tails * 100) / numberOfFlips) + "%");
            }
        }
    }
}
