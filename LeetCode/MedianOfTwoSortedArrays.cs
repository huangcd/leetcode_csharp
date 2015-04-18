using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.MedianOfTwoSortedArrays
{
    public class Solution
    {
        private class IntArray
        {
            private readonly int[] _array;
            private int _toExclusive;
            private int _fromInclusive;

            public IntArray(int[] array, int fromInclusive, int toExclusive)
            {
                _array = array;
                _fromInclusive = fromInclusive;
                _toExclusive = toExclusive;
            }

            public int Length
            {
                get
                {
                    return _toExclusive - _fromInclusive;
                }
            }

            public IntArray TrimLeft(int size)
            {
                _fromInclusive += size;
                return this;
            }

            public IntArray TrimRight(int size)
            {
                _toExclusive -= size;
                return this;
            }

            public int this[int index]
            {
                get
                {
                    return _array[index + _fromInclusive];
                }
            }

            public static implicit operator IntArray(int[] array)
            {
                return new IntArray(array, 0, array.Length);
            }

            public override string ToString()
            {
                var buffer = new StringBuilder();
                for (var i = 0; i < Length; i++)
                {
                    buffer.Append(this[i]).Append(' ');
                }
                return buffer.ToString();
            }
        }

        public double FindMedianSortedArrays(int[] A, int[] B)
        {
            var len = A.Length + B.Length;
            if ((len & 1) == 0)
            {
                return (FindKth(A, B, (len - 1) >> 1) + FindKth(A, B, len >> 1)) / 2;
            }
            return FindKth(A, B, len >> 1);
        }

        private static double FindKth(IntArray a, IntArray b, int k)
        {
            while (true)
            {
                if (a.Length > b.Length)
                {
                    var a1 = a;
                    a = b;
                    b = a1;
                    continue;
                }
                if (a.Length == 0)
                {
                    return b[k];
                }
                if (k == 0)
                {
                    return Math.Min(a[0], b[0]);
                }
                if (k == 1)
                {
                    if (a[0] <= b[0])
                    {
                        a.TrimLeft(1);
                        k = 0;
                        continue;
                    }
                    else
                    {
                        b.TrimLeft(1);
                        k = 0;
                        continue;
                    }
                }

                var mid = k/2;
                var lenA = a.Length;
                if (lenA <= mid)
                {
                    if (a[lenA - 1] < b[mid])
                    {
                        a.TrimLeft(lenA);
                        k = k - lenA;
                    }
                    else
                    {
                        b.TrimLeft(mid);
                        k = k - mid;
                    }
                }
                else
                {
                    if (a[mid] < b[mid])
                    {
                        a.TrimLeft(mid);
                        k = k - mid;
                    }
                    else
                    {
                        b.TrimLeft(mid);
                        k = k - mid;
                    }
                }
            }
        }
    }
}
