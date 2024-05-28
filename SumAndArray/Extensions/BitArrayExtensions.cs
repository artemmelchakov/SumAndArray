using System.Collections;

namespace SumAndArray.Extensions
{
    public static class BitArrayExtensions
    {
        /// <summary>
        /// Инкремент массива битов.
        /// </summary>
        /// <param name="bitArray"></param>
        public static void Increment(this BitArray bitArray)
        {
            for (int i = 0; i < bitArray.Count; i++)
            {
                bool previous = bitArray[i];
                bitArray[i] = !previous;
                if (!previous)
                {
                    // Found a clear bit - now that we've set it, we're done
                    return;
                }
            }
        }

        /// <summary>
        /// Проверка на то, что массив битов имеет только один бит со значением true или же ни одного. 
        /// Если переводить такой массив битов в двоичное число, то он будет эквивалентом числу - степени двойки (1, 2, 4, 8, 16 ...) или нулю.
        /// </summary>
        /// <param name="bitArray"></param>
        public static bool HasOnlyOneOrZeroTrueBit(this BitArray bitArray)
        {
            bool hasAtLeastOneTrueBit = false;
            for (int i = 0; i < bitArray.Count; i++)
            {
                if (bitArray[i])
                {
                    if (hasAtLeastOneTrueBit)
                    {
                        return false;
                    }
                    hasAtLeastOneTrueBit = true;
                }
            }
            return true;
        }
    }
}
