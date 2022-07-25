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
                    SetMinValueIndex();
                }
            }

            return maxValues;

            void SetMinValueIndex()
            {
                minValueIndex = 0;
                for (int i = 1; i < maxValues.Length; i++)
                {
                    if (maxValues[i] < maxValues[minValueIndex])
                    {
                        minValueIndex = i;
                    }
                }
            }
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
                    SetMinValueIndex();
                }
            }

            return maxValuesIndexes;

            void SetMinValueIndex()
            {
                minValueIndex = 0;
                for (int i = 1; i < maxValues.Length; i++)
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
