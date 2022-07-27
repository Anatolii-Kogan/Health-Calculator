/*
 * author: Anatolii Kogan
 * e-mail: kogan.1anatoli@gmail.com
 */
using System;

namespace Health_Calculator
{
    public class Test
    {
        public const int minValue = 1;
        public const int maxValue = int.MaxValue;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter players namber:\nLength:");

            var players = new int[Helpers.GetArrayLengthByUserInput()];

            #region "Fill array:"
            Random rnd = new Random();
            for (int i = 0; i < players.Length; i++)
            {
                players[i] = rnd.Next(minValue, maxValue);
            }
            #endregion

            int topPlayersNamber;
            do
            {
                Console.WriteLine("Enter top elements namber; It have to be greater then players namber:\nLength:");
                topPlayersNamber = Helpers.GetArrayLengthByUserInput();
            }
            while (topPlayersNamber > players.Length);

            int[] topPlayers = MaxValuesGetter.GetMaxValues(players, topPlayersNamber);

            Console.Write("\nMax values: ");
            Helpers.DisplayArray(topPlayers);

            Console.WriteLine("\nPress any button...");
            Console.ReadKey();
        }        
    }
}
