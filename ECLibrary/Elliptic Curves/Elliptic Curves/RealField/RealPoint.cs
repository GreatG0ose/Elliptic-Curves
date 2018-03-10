using System;

namespace EllipticCurves
{
    namespace RealField {
        public class RealPoint : Point<double>
        {
            double x, y;

            public RealPoint(double x, double y)
            {
                this.X = x;
                this.Y = y;
            }

            public override double X
            {
                get
                {
                    return x;
                }

                set
                {
                    this.x = value;
                }
            }

            public override double Y
            {

                get
                {
                    return y;
                }

                set
                {
                    this.y = value;
                }
            }
        }
    }
}