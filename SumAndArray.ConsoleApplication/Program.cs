using SumAndArray.Algorithms;

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
