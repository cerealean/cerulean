using System;
using System.Collections.Generic;

namespace Cerulean.Lib.Utilities
{
    static class ListUtility
    {
        private static readonly Random Random = new Random();

        public static void Shuffle<T>(this IList<T> list)
        {
            int listCount = list.Count;
            while (listCount > 1)
            {
                listCount--;
                int randomKey = Random.Next(listCount + 1);
                T value = list[randomKey];
                list[randomKey] = list[listCount];
                list[listCount] = value;
            }
        }
    }
}
