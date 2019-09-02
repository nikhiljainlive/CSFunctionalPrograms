// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LeapYear.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// ---------------------------------------------------------------------------------------------------------

namespace FunctionalPrograms
{
    using System;

    /// <summary>
    /// Checks weather a given year is a Leap Year or no.
    /// </summary>
    public class LeapYear
    {
        /// <summary>
        /// Checks the leap year.
        /// </summary>
        public static void CheckLeapYear()
        {
            int year;
            bool keepLooping = true;
            while (keepLooping)
            {
                Console.WriteLine("Enter the year you want to check");
                string syear = Console.ReadLine();

                if (Utility.IsNumber(syear) == false)
                {
                    Console.WriteLine("Invalid year");
                }
                else
                {
                    year = Convert.ToInt32(syear);

                    if (year % 4 == 0 && year % 100 != 0)
                    {
                        Console.WriteLine("Year " + year + " is a Leap Year");
                    }
                    else
                    {
                        if (year % 400 == 0)
                        {
                            Console.WriteLine("Year " + year + " is a Leap Year");
                        }
                        else
                        {
                            Console.WriteLine("Year " + year + " is not a Leap Year");
                        }
                    }
                }

                keepLooping = false;
            }
        }
    }
}
