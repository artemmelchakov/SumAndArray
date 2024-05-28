using SumAndArray.Algorithms;
using SumAndArray.Tests.ClassDatas;

namespace SumAndArray.Tests
{
    public class AlgorithmTests
    {
        [Theory]
        [ClassData(typeof(NumberAndArrayTestDataGenerator))]
        public void CheckNumberSumExistenceInEnumerationAlgorithmTest1(uint n, uint[] array, bool expected)
        {
            var result = CheckNumberSumExistenceInEnumeration.Check(array, n);
            Assert.Equal(expected, result);
        }
    }
}