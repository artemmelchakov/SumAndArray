using System.Collections;

namespace SumAndArray.Tests.ClassDatas
{
    /// <summary>
    /// Генератор входных данных для тестов <see cref="AlgorithmTests"/>.
    /// </summary>
    internal class NumberAndArrayTestDataGenerator : IEnumerable<object[]>
    {
        /// <summary>
        /// Входные данные для тестов.
        /// Первый элемент кортежа - число n.
        /// Второй элемент кортежа - массив, в котором ищут сумму, равную числу n.
        /// Третий элемент кортежа - ожидаемый правильный ответ алгоритма.
        /// </summary>
        private static readonly IEnumerable<(uint, uint[], bool)> _numberAndArrayAndExpected = new[]
        {
            (10u, new uint[] { 3, 1, 8, 5, 4 }, true),
            (10u, new uint[] { 4, 3, 2, 1 }, true),
            (11u, new uint[] { 4, 3, 2, 1 }, false),
            (5u, new uint[] { 9, 3, 8, 1 }, false),
            (4u, new uint[] { 9, 3, 8, 1 }, true),
            (10u, new uint[] { 9, 3, 8, 1 }, true),
            (9u, new uint[] { 9, 3, 8, 1 }, true),
            (17u, new uint[] { 9, 3, 8, 1 }, true),
            (11u, new uint[] { 4 }, false),
            (11u, new uint[] { 12, 14 }, false),
            (11u, new uint[] { 12, 14, 11 }, false),
            (11u, new uint[] { 4, 3, 2, 1, 1 }, true)
        };

        private readonly IEnumerable<object[]> _numberAndArrayAndExpected_Obj =  
            _numberAndArrayAndExpected.Select(t => new object[] { t.Item1, t.Item2, t.Item3 });
        public IEnumerator<object[]> GetEnumerator() => _numberAndArrayAndExpected_Obj.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
