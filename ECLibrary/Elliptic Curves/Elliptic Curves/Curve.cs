using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EllipticCurves
{
    /*
     * Curve equalty in general:
     *  y^2 + a1 xy + a3 y = x^3 + a2 x^2 + a4 x + a5
     */
    public abstract class Curve<T> where T : struct
    {
        protected T[] coefs;

        public abstract Point<T> O { get; }
        //protected Point<T>[] array;
        

        public abstract bool IsSingular { get; }

        protected T this[int i]
        {
            get { return this.coefs[i - 1]; } //a0 = 1// does not exists
        }


        public Point<T> SumPoints(Point<T> A, Point<T> B)
        {
            throw new NotImplementedException();

            if(A.Equals(O))
                return B;
            if (B.Equals(O))
                return A;

            T f;                //lambda
            if (!A.Equals(B))
                f = ((dynamic)B.Y - A.Y) / ((dynamic)B.X - A.X);
            else
                f = (3 * (dynamic)A.X * A.X + coefs[0]) / (2 * (dynamic)A.Y);

            

        }

    }
}
