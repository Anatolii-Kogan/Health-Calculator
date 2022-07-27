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
            var tree = new BinaryTreeController(getValues);

            for (int i = 0; i < array.Length; i++)
            {
                tree.Add(array[i], i);
            }

            return tree.GetTreeElements();
        }

        public static int[] GetMaxValuesIndexes(int[] array, int getValues, int offset = 1)
        {
            var tree = new BinaryTreeController(getValues);

            for (int i = 0; i < array.Length; i++)
            {
                tree.Add(array[i], i + offset);
            }

            return tree.GetTreeElementsIndexes();
        }
    }
}
