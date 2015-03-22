using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DefineClass
{
    class Calls
    {
        #region Fields 

        private string date;
        private string time;
        private string phoneNumber;
        private int callDuration;

        #endregion

        #region Properties

       

        public string Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public string Time
        {
            get { return this.time; }
            set { this.time = value; }
        }

        public string PhoneNumbers
        {
            get { return this.phoneNumber; }
            set { this.phoneNumber = value; }
        }

        public int Duration
        {
            get { return this.callDuration; }
            set { this.callDuration = value; }
        }

        #endregion
        #region Constructor

        public Calls()
        {

        }
        public Calls(DateTime date, string phoneNumber, int duration)
        {
            Date = date.Date.ToString();
            Time = date.TimeOfDay.ToString();
            PhoneNumbers = phoneNumber;
            Duration = duration;
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return string.Format("The call was on {0}, in {1}, from number {2} for {3} seconds. ", this.Date, this.Time, this.PhoneNumbers.ToString(), this.Duration.ToString());
        }

        #endregion
    }
    
}
