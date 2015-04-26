using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape
    {
        #region Fields

        private double width;

        private double height;

        #endregion

        #region Properties

        public double Width
        {
            get { return this.width; }

            set { this.width = value; }
        }

        public double Height
        {
            get { return this.height; }

            set { this.height = value; }
        }

        #endregion

        #region Methods
        public abstract double CalculateSurface();

        #endregion
    }
}
