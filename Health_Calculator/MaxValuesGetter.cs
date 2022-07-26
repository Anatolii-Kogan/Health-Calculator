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
                    SetMinValueIndex(maxValues, ref minValueIndex);
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
                    SetMinValueIndex(maxValues, ref minValueIndex);
                }
            }

            return maxValuesIndexes;            
        }

        //O(array.Length / 2)
        private static void SetMinValueIndex(int[] array, ref int minValueIndex)
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
