// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PowerOf2.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Nikhil Jain"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Prints the power of two
    /// </summary>
   public class PowerOf2
    {
        /// <summary>
        /// Powers the of two.
        /// </summary>
        public static void PowerOfTwo()
        {
            bool keepLooping = true;
            int number;
            ////keeps looping untill program executes completely.
            while (keepLooping)
            {
                Console.WriteLine("Enter a Number ");
                string snumber = Console.ReadLine();

                if (Utility.IsNumber(snumber) == false)
                {
                    Console.WriteLine("Enter a proper Number");
                    continue;
                }
                else
                {
                    number = Convert.ToInt32(snumber);
                    if (number > 31)
                    {
                        Console.WriteLine("Enter a number less then 31");
                        continue;
                    }
                    else
                    {
                        for (int i = 0; i < number; i++)
                        {
                            Console.WriteLine("Power of 2^" + i + "=" + Math.Pow(2, i));
                        }
                    }

                    keepLooping = false;
                }
            }              
        }
    }
}
