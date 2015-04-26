using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Square : Shape
    {
        #region Constructor
        public Square (double length)
	    {
            this.Height = length;
            this.Width = length;
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
