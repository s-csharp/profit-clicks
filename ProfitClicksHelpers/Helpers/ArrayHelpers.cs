using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProfitClicksHelpers.Helpers
{
    /// <summary>
    /// Хелпер для работы с массивами
    /// </summary>
    public static class ArrayHelper
    {
        /// <summary>
        /// Проверка существования двух чисел как сумма другого 
        /// </summary>
        /// <param name="source">Последовательность чисел</param>
        /// <param name="number">Число, как сумма двух из последовательности</param>
        /// <exception cref="ArgumentNullException">Последовательность не определена или пуста</exception>
        /// <returns>Да / Нет</returns>
        public static bool ExistNumbersAsSum(int[] source, int number)
        {
            if (source == null ||
                source.Length == 0)
                throw new ArgumentNullException(nameof(source), "Sequence is null or empty");

            var result = false;
            var table = new HashSet<int>(source.Length);

            foreach (var item in source)
            {
                var value = number - item;

                if (!table.Contains(value))
                    table.Add(item);
                else
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        /// <summary>
        /// Поиск максимального префикса среди последовательности строк
        /// </summary>
        /// <param name="source">Последовательность строк</param>
        /// <exception cref="ArgumentNullException">Последовательность не определена или пуста</exception>
        /// <returns>Максимальный префикс</returns>
        public static string MaxPrefix(string[] source)
        {
            if (source == null ||
                source.Length == 0)
                throw new ArgumentNullException(nameof(source), "Sequence is null or empty");

            var result = new StringBuilder();

            var maxPrefix = source[0]?.Length ?? 0;

            foreach (var item in source)
            {
                if (item == null ||
                    item.Length == 0)
                {
                    maxPrefix = 0;
                    break;
                }
                else if (item.Length < maxPrefix)
                    maxPrefix = item.Length;
            }

            if (maxPrefix > 0)
            {
                for (var i = 0; i < maxPrefix; i++)
                {
                    var symbol = source[0][i];

                    if (source.All(x => x[i] == symbol))
                        result.Append(symbol);
                    else
                        break;
                }
            }

            return result.ToString();
        }
    }
}