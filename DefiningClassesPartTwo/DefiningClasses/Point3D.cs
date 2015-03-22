/* Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
   Implement the ToString() to enable printing a 3D point.
   Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}.
   Add a static property to return the point O.*/


using System;


namespace DefiningClasses
{
    public struct Point3D
    {
        #region Properties

        public decimal X { get; set; }
        public decimal Y { get; set; }
        public decimal Z { get; set; }
        public Point3D Start
        {
            get { return Point3D.O; }
        }

        #endregion

        #region Constructor

        public Point3D(decimal x, decimal y, decimal z) : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        #endregion

        #region Fields 

        private static readonly Point3D O = new Point3D(0, 0, 0);

        #endregion

        #region Methods

        public override string ToString()
        {
            return string.Format("({0},{2},{3})", this.X, this.Y, this.Z);
        }

        #endregion
    }
}
