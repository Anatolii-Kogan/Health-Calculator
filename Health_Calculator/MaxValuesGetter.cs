/*
 * author: Anatolii Kogan
 * e-mail: kogan.1anatoli@gmail.com
 */

namespace Health_Calculator
{
    public class MaxValuesGetter
    {
        public static int[] GetMaxValues(int[] array, int getValues)
        {
            int[] maxValues = new int[getValues];

            int minValueIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (maxValues[minValueIndex] < array[i])
                {
                    maxValues[minValueIndex] = array[i];
                    SetMinValueIndexO_N_divide_4(maxValues, ref minValueIndex);
                }
            }

            return maxValues;
        }

        /// <param name="offset">you can take, that array's indexes start from 0, into account</param>
        public static int[] GetMaxValuesIndexes(int[] array, int getValues, int offset = 0)
        {
            int[] maxValues = new int[getValues];
            int[] maxValuesIndexes = new int[getValues];

            int minValueIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (maxValues[minValueIndex] < array[i])
                {
                    maxValues[minValueIndex] = array[i];
                    maxValuesIndexes[minValueIndex] = i + offset;
                    SetMinValueIndexO_N_divide_4(maxValues, ref minValueIndex);
                }
            }

            return maxValuesIndexes;            
        }

        //O(array.Length / 4)
        private static void SetMinValueIndexO_N_divide_4(int[] array, ref int minValueIndex)
        {
            int leftIndex = array.Length - 1;
            int rightIndex = 0;

            int middleIndexLeft = leftIndex + (rightIndex - leftIndex) / 2;
            int middleIndexRight = middleIndexLeft;

            int minIndexLeft = leftIndex;
            int minIndexRight = rightIndex;

            while (leftIndex >= middleIndexLeft)
            {
                minIndexLeft = array[leftIndex] < array[middleIndexLeft] ? leftIndex : middleIndexLeft;
                leftIndex--;
                middleIndexLeft++;

                minIndexRight = array[rightIndex] < array[middleIndexRight] ? rightIndex : middleIndexRight;
                rightIndex++;
                middleIndexRight--;
            }

            minValueIndex = array[minIndexLeft] < array[minIndexRight] ? minIndexLeft : minIndexRight;
        }

        //O(array.Length / 2)
        private static void SetMinValueIndexO_N_divide_2(int[] array, ref int minValueIndex)
        {
            int leftIndex = array.Length - 1;
            int rightIndex = 0;

            int middleIndex = leftIndex + (rightIndex - leftIndex) / 2;

            while (leftIndex >= middleIndex)
            {
                if (array[leftIndex] < array[minValueIndex])
                {
                    minValueIndex = leftIndex;
                }
                if (array[rightIndex] < array[minValueIndex])
                {
                    minValueIndex = rightIndex;
                }

                leftIndex--;
                rightIndex++;
            }
        }
    }
}
