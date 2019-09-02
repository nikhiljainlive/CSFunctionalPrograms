// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Menu.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Nikhil Jain"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;

    /// <summary>
    /// Shows the list of programs you can choose from.
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
       public static void Main(string[] args)
        {
            int option = -1;
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Select the program from below .Enter 0 to exit");
                Console.WriteLine("1) Replace String Template");
                Console.WriteLine("2) CoinFlip");
                Console.WriteLine("3) LeapYear");
                Console.WriteLine("4) Power Of 2");
                try
                {
                    option = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Command");
                    continue;
                }

                switch (option)
                {
                    case 0:
                        {
                            flag = false;
                            break;
                        }

                    case 1:
                        {
                            ReplaceString.ReplaceName();
                            break;
                        }

                    case 2:
                        {
                            CoinFlip.FlipCoin();
                            break;
                        }

                    case 3:
                        {
                            LeapYear.CheckLeapYear();

                            break;
                        }

                    case 4:
                        {
                            PowerOf2.PowerOfTwo();
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Invalid Option");
                            break;
                        }
                }
            }
        }
    }
}
