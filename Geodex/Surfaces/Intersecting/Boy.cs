﻿using System;

namespace Geodex.Surfaces.Intersecting
{
    public class Boy : Field
    {

        #region members

        #endregion

        #region constructors

        public Boy() : base()
        {

        }

        public Boy(UV uv) : base()
        {
            this.U = uv.U;
            this.V = uv.V;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double i = U * Math.PI;
            double j = V * Math.PI;

            double k = 2 - Math.Sqrt(2) * Math.Sin(3 * i) * Math.Sin(2 * j);

            p.X = (Math.Sqrt(2) * Math.Pow(Math.Cos(j), 2) * Math.Cos(2 * i) + Math.Cos(i) * Math.Sin(2 * j)) / k;
            p.Y = (Math.Sqrt(2) * Math.Pow(Math.Cos(j), 2) * Math.Sin(2 * i) - Math.Sin(i) * Math.Sin(2 * j)) / k;
            p.Z = (3 * Math.Pow(Math.Cos(j), 2)) / k;

        }

        #endregion

    }
}