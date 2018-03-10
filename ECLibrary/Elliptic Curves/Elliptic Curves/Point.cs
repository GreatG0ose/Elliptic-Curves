using System;

namespace EllipticCurves
{
    public abstract class Point<T> where T : struct
    {
        public abstract T X { get; set; }
        public abstract T Y { get; set; }

        public Point(T x, T y) {}

        /// <summary>
        /// Check points coordinates equalty
        /// </summary>
        /// <param name="point">variable point must be Point type</param>
        /// <returns></returns>
        public override bool Equals(object point)
        {
            Point<T> a = (Point<T>)point;

            return this.X.Equals(a.X) && this.Y.Equals(a.Y);
        }

        public override int GetHashCode()
        {
            int hashcode = X.GetHashCode();
            hashcode = 31 * hashcode + Y.GetHashCode();

            return hashcode;
        }
    }
}