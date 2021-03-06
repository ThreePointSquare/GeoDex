﻿using System;

namespace Geodex.Volumes
{
    public class TorusEllipse : Field
    {

        #region members

        public double A = 2.0;
        public double B = 0.5;
        public double C = 1.0;

        #endregion

        #region constructors


        public TorusEllipse() : base()
        {

        }

        public TorusEllipse(UV uv) : base()
        {
            this.U = uv.U;
            this.V = uv.V;
        }

        public TorusEllipse(UV uv, double a, double b, double c) : base()
        {
            this.A = a;
            this.B = b;
            this.C = c;

            this.U = uv.U;
            this.V = uv.V;
        }

        #endregion

        #region methods


        protected override void Evaluate()
        {

            double i = U * Math.PI;
            double j = V * Math.PI;

            p.X = (A + B * Math.Cos(i)) * Math.Cos(j);
            p.Y = (A + B * Math.Cos(i)) * Math.Sin(j);
            p.Z = C * Math.Sin(i);

        }

        #endregion

    }
}