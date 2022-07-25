/*
 * author: Anatolii Kogan
 * e-mail: kogan.1anatoli@gmail.com
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Health_Calculator
{
    public static class Helpers
    {
        public static void DisplayArray<T>(T[] players)
        {
            Console.WriteLine("\n");
            Console.Write($"{players[0]}");
            for (int i = 1; i < players.Length; i++)
            {
                Console.Write($", {players[i]}");
            }
        }

        public static int GetArrayLengthByUserInput()
        {
            int length;
            while (int.TryParse(Console.ReadLine(), out length) == false || length <= 0)
            {
                Console.WriteLine("Invalid input; Try again");
            }

            return length;
        }
    }
}
