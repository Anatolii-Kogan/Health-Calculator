/*
 * author: Anatolii Kogan
 * e-mail: kogan.1anatoli@gmail.com
 */
using System;
using BenchmarkDotNet.Attributes;
using Health_Calculator;

namespace BenchmarkTest
{
    [MemoryDiagnoser]
    public class SortingBenchmark
    {
        public const int minValue = 1;
        public const int maxValue = int.MaxValue;
        public const int getValues = 10;

        private readonly int[] _smallTestArray = GetArray(100);
        private readonly int[] _testArray = GetArray(10000);
        private readonly int[] _largeTestArray = GetArray(1000000);
        private readonly int[] _veryLargeTestArray = GetArray(100000000);

        #region "Values getting"
        [Benchmark]
        public void GetMaxValuesSmallArrayTest()
        {
            var result = MaxValuesGetter.GetMaxValues(_smallTestArray, getValues);
        }

        [Benchmark]
        public void GetMaxValuesTest()
        {
            var result = MaxValuesGetter.GetMaxValues(_testArray, getValues);
        }

        [Benchmark]
        public void GetMaxValuesLargeArrayTest()
        {
            var result = MaxValuesGetter.GetMaxValues(_largeTestArray, getValues);
        }
        [Benchmark]
        public void GetMaxValuesVeryLargeArrayTest()
        {
            var result = MaxValuesGetter.GetMaxValues(_veryLargeTestArray, getValues);
        }
        #endregion

        #region "Indexes getting"
        [Benchmark]
        public void GetMaxValuesIndexesSmallArrayTest()
        {
            var result = MaxValuesGetter.GetMaxValuesIndexes(_smallTestArray, getValues, offset: 1);
        }

        [Benchmark]
        public void GetMaxValuesIndexesTest()
        {
            var result = MaxValuesGetter.GetMaxValuesIndexes(_testArray, getValues, offset: 1);
        }

        [Benchmark]
        public void GetMaxValuesIndexesLargeArrayTest()
        {
            var result = MaxValuesGetter.GetMaxValuesIndexes(_largeTestArray, getValues, offset: 1);
        }
        [Benchmark]
        public void GetMaxValuesIndexesVeryLargeArrayTest()
        {
            var result = MaxValuesGetter.GetMaxValuesIndexes(_veryLargeTestArray, getValues, offset: 1);
        }
        #endregion

        private static int[] GetArray(int length)
        {
            int[] array = new int[length];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(minValue, maxValue);
            }

            return array;
        }
    }
}
