// If you want to run the GSMTest comment this and uncomment GSMTest because there can't be two Main methods running 
// in the same solution.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DefineClass
{
    class GSMCallHistoryTest
    {
        static void Main()
        {
            DateTime date1 = new DateTime(1994, 12, 25, 18, 36, 45);
            DateTime date2 = new DateTime(2005, 11, 12, 21, 30, 40);
            DateTime date3 = new DateTime(2012, 10, 9, 20, 30, 38);
            DateTime date4 = new DateTime(2015, 1, 9, 21, 38, 31);

            GSM newGSM = new GSM("Galaxy Dous", "Samsung", "Ivan", 450, 5, 16000, BatteryTypes.LiIon, 2000, 150);
            newGSM.AddCall(GSM.callHistory, new Calls(date1, "0888999987", 123));
            newGSM.AddCall(GSM.callHistory, new Calls(date2, "0888999988", 143));
            newGSM.AddCall(GSM.callHistory, new Calls(date1, "0888988987", 153));
            newGSM.AddCall(GSM.callHistory, new Calls(date1, "0888987988", 163));
            for (int i = 0; i < newGSM.CallHistory.Count; i++)
            {
                Console.WriteLine(newGSM.CallHistory[i].ToString());
            }
            Console.WriteLine();
            Console.WriteLine("The price is {0:F2} leva. ", newGSM.CallPrice(newGSM.CallHistory, 0.37));
            int tmpSeconds = int.MinValue;
            Calls tmpCall = new Calls();
            foreach (Calls Call in newGSM.CallHistory)
            {
                if (Call.Duration > tmpSeconds)
                {
                    tmpCall = Call;
                }
            }
            newGSM.DeleteCall(GSM.callHistory, tmpCall);
            Console.WriteLine();
            Console.WriteLine("The new price is {0:F2} leva. ", newGSM.CallPrice(newGSM.CallHistory, 0.37));
            newGSM.ClearHistory(GSM.callHistory);
            Console.WriteLine();
            for (int i = 0; i < newGSM.CallHistory.Count; i++)
            {
                Console.WriteLine(newGSM.CallHistory[i].ToString());
            }
            Console.WriteLine("The list is empty so nothing is going to show. ");
        }
    }
}
