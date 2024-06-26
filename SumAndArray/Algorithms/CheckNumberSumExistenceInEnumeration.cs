﻿using SumAndArray.Extensions;
using System.Collections;

namespace SumAndArray.Algorithms
{
    public static class CheckNumberSumExistenceInEnumeration
    {
        /// <summary>
        /// Проверить наличие суммы чисел в массиве.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="number"></param>
        /// <returns> true - сумма есть в массиве, false - нет. </returns>
        public static bool Check(uint[] array, uint number)
        {
            // Исключаем из массива все числа, которые больше числа number, так как из них точно сумма не получится.
            array = array.Where(item => item <= number).ToArray();
            // Если после исключения таких чисел массив стал пустым, то суммы в таком массиве точно быть не могло,
            // ведь все числа в массиве больше числа number.
            // А если количество элементов меньше двух, то сумма не получится, ведь для суммы нужно, как минимум, два числа.
            if (array.Length < 2)
            {
                return false;
            }

            // Массив-маска для удобного нахождения суммы. Сразу же зададим маске значение ..00011.
            // Данная маска в цикле будет увеличиваться как число в двоичной системе счисления.
            // Таким образом, можно будет перебрать все комбинации чисел для того, чтобы их просуммировать.
            var bitArray = new BitArray(array.Length, false);
            bitArray.Set(0, true);
            bitArray.Set(1, true);

            // Основной цикл нахождения суммы, который идёт до тех пор, пока массив-маска целиком не будет заполнена единицами.
            while(true)
            {
                // Если битовая маска будет иметь только один или ноль значений true, то суммы не получится,
                // ведь для суммы нужно, как минимум, два числа. Пропустим шаг с этой битовой маской.
                if (bitArray.HasOnlyOneOrZeroTrueBit())
                {
                    bitArray.Increment();
                    continue;
                }
                // Нахождение суммы по битовой маске.
                // Пример: 
                //      массив        {1, 4, 2, 5}
                //      битовая маска {1, 0, 1, 1}
                //      результат     1 + 2 + 5 = 8
                uint sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (bitArray[i])
                    {
                        sum += array[i];
                    }
                }
                // Если полученная сумма равна числу number, то можно утверждать, что в массиве есть такие числа, которые 
                // в сумме дают число number. Возвращаем положительный результат.
                if (sum == number)
                {
                    return true;
                }

                // Если маска подошла к последнему значению, то есть  полностью заполнена единицами, то необходимо прервать цикл.
                if (bitArray.HasAllSet())
                {
                    break;
                }
                // Если же нет - делаем инкремент.
                else
                {
                    bitArray.Increment();
                }
            }
            // Если после прохождения цикла не нашлось ни одной суммы - возвращаем отрицательный результат.
            return false;
        }
    }
}
