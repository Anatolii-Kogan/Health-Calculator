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
    }
}
