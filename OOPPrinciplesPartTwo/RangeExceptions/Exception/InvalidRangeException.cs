using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeExceptions
{
    public class InvalidRangeException<T> : ApplicationException
        where T : IComparable
    {
        public T Max { get; set; }

        public T Min { get; set; }
        public InvalidRangeException(string msg, T max, T min)
            : base(msg)
        {
            this.Max = max;
            this.Min = min;
            
        }
    }
}
