using System;

namespace EllipticCurves
{
    namespace RealField
    {
        public class RealCurve : Curve<double>
        {
            /*
            * Curve equalty in general:
            *  y^2 + a1 xy + a3 y = x^3 + a2 x^2 + a4 x + a5
            */

            public RealCurve(params double[] coefs)
            {
                //maximum coef number = 5
                if (coefs.Length > 5)
                    throw new IndexOutOfRangeException();


                for (int i = 0; i < coefs.Length; i++)
                    this.coefs[i] = coefs[i];
            }

            public override Point<double> SumPoints(Point<double> A, Point<double> B)
            {
                throw new NotImplementedException();
            }
        }
    }
}
