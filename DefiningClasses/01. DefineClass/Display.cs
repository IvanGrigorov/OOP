using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DefineClass
{
    class Display
    {
        #region Fields

        private int size;
        private int? colorNumber;

        #endregion

        #region Properties

        public int Size
        {
            get { return this.size; }
            set { this.size = value; }
        }
        public int? ColorNumber
        {
            get { return this.colorNumber; }
            set { this.colorNumber = value; }
        }

        #endregion

        #region Constructors 
        public Display(int size, int colorNumber)
        {
            this.size = size;
            this.colorNumber = colorNumber;
        }
        public Display(int size)
        {
            this.size = size;
            this.colorNumber = null;
        }

        #endregion
    }
}
