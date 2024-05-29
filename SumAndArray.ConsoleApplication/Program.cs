using SumAndArray.Algorithms;

// Есть массив из n натуральных чисел, n >= 1.
// Написать функцию, которая определяет, можно ли заданное число представить суммой чисел из массива (каждое число можно использовать один раз).
// Пример:
// Массив: { 3, 1, 8, 5, 4 }
// Число 10 - можно представить суммой (1 + 5 + 4)
// Число 2 - нельзя

uint[] array = new uint[] { 3, 1, 8, 5, 4 };
uint n = 10;

ShowEnumerable(array);

Console.WriteLine(CheckNumberSumExistenceInEnumeration.Check(array, n) ? "В перечислении есть сумма." : "В перечислении нет суммы.");

Console.ReadKey(true);

void ShowEnumerable(IEnumerable<uint> enumerable)
{
    foreach (var item in enumerable)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}
