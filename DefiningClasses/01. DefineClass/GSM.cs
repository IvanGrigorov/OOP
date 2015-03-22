using System;
using System.Collections.Generic;


namespace _01.DefineClass
{
    class GSM
    {
        #region Fields

        private string model, manifacturer, owner; 
        private int price;
        public static string iPhoneS4 = "Info about IPhone S4";
        private Battery battery;
        private Display display;
        public static List<Calls> callHistory = new List<Calls>();

        #endregion

        #region Properties

        public List<Calls> CallHistory
        {
            get { return callHistory; }            
        }
        public String Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public String Manifacturer
        {
            get { return this.manifacturer; }
            set { this.manifacturer = value; }
        }
        public String Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }
        public int Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        #endregion

        #region Constructors

        public GSM(string model, string manifacturer, string owner, int price, int size, int colorNumber, BatteryTypes batteryModel, int hoursIdle, int hoursTalk)
        {
            this.Model = model;
            this.Manifacturer = manifacturer;
            this.Owner = owner;
            this.Price = price;
            display = new Display(size, colorNumber);
            battery = new Battery(batteryModel, hoursIdle, hoursTalk);
            
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            
            return string.Format("This GSM model ({0}) is designed by {1} and costs {2}. It's owner is {3}", this.model, this.manifacturer, this.price, this.owner);
        }

        public void AddCall(List<Calls> callHistory, Calls call)
        {
            callHistory.Add(call);
        }

        public void DeleteCall(List<Calls> callHistory, Calls call)
        {
            foreach (Calls tmpCall in callHistory)
            {
                if (tmpCall == call)
                {
                    callHistory.Remove(tmpCall);
                    break;
                }
            }
        }

        public void ClearHistory(List<Calls> callHistory)
        {
            callHistory.Clear();
        }

        public double CallPrice(List<Calls> callHistory, double pricePerMinute)
        {
            double pricePerSecond = (double)(pricePerMinute / 60);
            long totalSeconds = 0;
            foreach (Calls tmpCall in callHistory)
            {
                totalSeconds += tmpCall.Duration;
            }
            return pricePerSecond * totalSeconds;
        }

        #endregion

    }
}
