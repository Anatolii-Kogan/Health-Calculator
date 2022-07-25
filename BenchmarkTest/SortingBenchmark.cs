using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Health_Calculator;

namespace BenchmarkTest
{
    [MemoryDiagnoser, RankColumn]
    public class SortingBenchmark
    {
        public const int minValue = 1;
        public const int maxValue = int.MaxValue;
        public const int getValues = 10;

        private readonly int[] _smallTestArray = GetArray(100);
        private readonly int[] _testArray = GetArray(10000);
        private readonly int[] _largeTestArray = GetArray(1000000);
        private readonly int[] _veryLargeTestArray = GetArray(100000000);

        [Benchmark]
        public void GetMaxValuesSmallArrayTest()
        {
            var result = Test.GetMaxValues(_smallTestArray, getValues);
        }

        [Benchmark]
        public void GetMaxValuesTest()
        {
            var result = Test.GetMaxValues(_testArray, getValues);
        }

        [Benchmark]
        public void GetMaxValuesLargeArrayTest()
        {
            var result = Test.GetMaxValues(_largeTestArray, getValues);
        }
        [Benchmark]
        public void GetMaxValuesVeryLargeArrayTest()
        {
            var result = Test.GetMaxValues(_veryLargeTestArray, getValues);
        }

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
