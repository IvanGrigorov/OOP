using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Rectangle : Shape
    {
        #region Constructor
        public Rectangle (double width, double height)
	    {
            this.Height = height;
            this.Width = width;
	    }

        #endregion

        #region Method
        public override double CalculateSurface()
        {
            return this.Height * this.Width;
        }

        #endregion
    }
}
