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

            var players = new int[GetArrayLengthByUserInput()];

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
                topPlayersNamber = GetArrayLengthByUserInput();
            }
            while (topPlayersNamber > players.Length);

            int[] topPlayers = GetMaxValues(players, topPlayersNamber);

            DisplayArray(topPlayers);


            Console.WriteLine("\nPress any button...");
            Console.ReadKey();
        }

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

        public static int[] GetMaxValues(int[] array, int getValues)
        {
            int[] maxValues = new int[getValues];

            int minValueIndex = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if(maxValues[minValueIndex] < array[i])
                {
                    maxValues[minValueIndex] = array[i];
                    SetMinValueIndex();
                }
            }

            return maxValues;

            void SetMinValueIndex()
            {
                minValueIndex = 0;
                for(int i = 1; i < maxValues.Length; i++)
                {
                    if (maxValues[i] < maxValues[minValueIndex])
                    {
                        minValueIndex = i;
                    }
                }
            }
        }
    }
}
