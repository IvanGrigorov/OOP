using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DefineClass
{
    public enum BatteryTypes
    {
        LiIon,
        NiMH,
        NiCd
    };
    class Battery
    {
        #region Fields

        private BatteryTypes model;
        private int? hourIdle, hoursTalk;

        #endregion

        #region Properties

        public int? HourIdle
        {
            get { return this.hourIdle; }
            set { this.hourIdle = value; }
        }
        public int? HoursTalk
        {
            get { return this.hoursTalk; }
            set { this.hoursTalk = value; }
        }

        #endregion

        #region Constructors
        public Battery(BatteryTypes model ,int hourIdle, int hoursTalk)
        {
            this.model = model;
            this.hourIdle = hourIdle;
            this.hoursTalk = hoursTalk;
        }
        public Battery(BatteryTypes model)
        {
            this.model = model;
            this.hourIdle = null;
            this.hoursTalk = null;
        }

        #endregion
    }

}
