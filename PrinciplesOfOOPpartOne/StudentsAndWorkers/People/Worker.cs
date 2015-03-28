using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    class Worker : Human
    {
        #region Properties
        public int WeekSalary { get; set; }

        public int WorkHoursPerDay { get; set; }

        #endregion

        #region Constructor
        public Worker(string fName, string lName, int weekSalary, int workHoursPerDay)
            : base(fName, lName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }
        #endregion

        #region Method
        public double MoneyPerHour(Worker worker)
        {
            int workHoursPerWeek = worker.WorkHoursPerDay * 5;
            double moneyPerHour = (double)(worker.WeekSalary / workHoursPerWeek);
            return moneyPerHour;
        }
        #endregion
    }
}
