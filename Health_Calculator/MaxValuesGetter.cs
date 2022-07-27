/*
 * author: Anatolii Kogan
 * e-mail: kogan.1anatoli@gmail.com
 */
using System.Collections.Generic;

namespace Health_Calculator
{
    public class MaxValuesGetter
    {
        public static int[] GetMaxValues(int[] array, int getValues)
        {
            int[] maxValues = new int[getValues];

            int n = array.Length;
            // Построение кучи (перегруппируем массив)
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(array, n, i);
            }

            getValues--;
            for (int i = n - 1; i >= 0; i--)
            {
                // Перемещаем текущий корень в конец
                int maxValue = array[0];
                array[0] = array[i];
                array[i] = maxValue;

                maxValues[getValues] = maxValue;
                if (getValues == 0)
                {
                    break;
                }
                getValues--;

                // вызываем процедуру heapify на уменьшенной куче
                Heapify(array, i, 0);
            }

            return maxValues;

            void Heapify(int[] arr, int n, int index)
            {
                int largestIndex = index;
                // Инициализируем наибольший элемент как корень
                int leftIndex = 2 * index + 1; // left = 2*i + 1
                int rightIndex = 2 * index + 2; // right = 2*i + 2

                // Если левый дочерний элемент больше корня
                if (leftIndex < n && arr[leftIndex] > arr[largestIndex])
                    largestIndex = leftIndex;

                // Если правый дочерний элемент больше, чем самый большой элемент на данный момент
                if (rightIndex < n && arr[rightIndex] > arr[largestIndex])
                    largestIndex = rightIndex;

                // Если самый большой элемент не корень
                if (largestIndex != index)
                {
                    int temp = arr[index];
                    arr[index] = arr[largestIndex];
                    arr[largestIndex] = temp;

                    // Рекурсивно преобразуем в двоичную кучу затронутое поддерево
                    Heapify(arr, n, largestIndex);
                }
            }
        }

        public static int[] GetMaxValueUseBinaryTree(int[] array, int getValues)
        {
            var tree = new BinaryTreeController(getValues);

            for (int i = 0; i < array.Length; i++)
            {
                tree.Add(array[i], i);
            }

            return tree.GetTreeElements();
        }
    }
}
