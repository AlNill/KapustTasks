using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    public class CountingSort
    {
        /// <summary>
        /// Returned sorted list. Memory - O(1), time - O(n).
        /// </summary>
        /// <param name="inputStream">Stream from 0 to maxValue. Size < 1000000000.</param>
        /// <param name="sortFactor">Flow factor. >= 0. If the number x is encountered in the stream, then it will no longer meet numbers less than (x - sortFactor).</param>
        /// <param name="maxValue">Maximum value in stream. 0 <= value <= 2000.</param>
        /// <returns>Sorted list</returns>
        public IEnumerable<int> Sort(IEnumerable<int> inputStream, int sortFactor, int maxValue)
        {
            int[] supportArr = new int[maxValue + 1];
            var enumerator = inputStream.GetEnumerator();
            while (enumerator.MoveNext())
            {
                ++supportArr[enumerator.Current];
            };

            for (int i = 0; i < supportArr.Length; ++i)
            {
                for (int j = 0; j < supportArr[i]; ++j)
                    yield return i;
            }
        }
    }
}
