/*
 * author: Anatolii Kogan
 * e-mail: kogan.1anatoli@gmail.com
 */
using NUnit.Framework;
using Health_Calculator;
using System.Collections.Generic;

namespace HealthCalculatorTester
{
    [TestFixture]
    public class MaxValuesGetterTester
    {
        private int[] _testArray = new int[] { 10, 6, 3, 7, 1, 5, 4, 2 , 8, 9};
        private const int _getValues = 3;

        [Test]
        public void Get_3_MaxValuesFrom_1_to_10()
        {
            var maxValues = MaxValuesGetter.GetMaxValues(_testArray, _getValues);

            List<int> maxValuesList = new List<int>(maxValues);
            Assert.IsTrue(maxValuesList.Contains(8) && maxValuesList.Contains(9) && maxValuesList.Contains(10));
        }
    }
}