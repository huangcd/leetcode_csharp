using System;

namespace LeetCode
{
    public class Interval
    {
        public int start { get; private set; }
        public int end { get; private set; }

        public Interval()
        {
            start = 0; end = 0;
        }

        public Interval(int s, int e)
        {
            start = s; end = e;
        }

        public static implicit operator Interval(int[] val)
        {
            return new Interval(val[0], val[1]);
        }

        public static implicit operator int[](Interval val)
        {
            return new[] { val.start, val.end };
        }

        protected bool Equals(Interval other)
        {
            return start == other.start && end == other.end;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Interval) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (start*397) ^ end;
            }
        }

        public override string ToString()
        {
            return String.Format("[{0}, {1}]", start, end);
        }
    }
}