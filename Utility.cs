// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Nikhil Jain"/>
// ------

using System;

namespace FunctionalPrograms
{
    /// <summary>
    /// Utility class has methods that are required to use multiple times. 
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// Checks the string.
        /// return true if String is Not Empty or Null and Vice versa. 
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public static bool CheckString(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name cant be empty, Enter proper name");
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Determines whether the specified input is number.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>
        ///   <c>true</c> if the specified input is number; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsNumber(String input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]) == false)
                {
                    return false;
                }
            }
            return true;
        }       
    }
}
