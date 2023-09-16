using System;
using System.Collections.Generic;
using System.Text;

namespace OneClassPoo_sat.Classes
{
    public class HourlyEmployee : Employee
    {
        public decimal Hours {get; set; }
        public decimal HourValue { get; set; }

        public override decimal GetValueToPay()
        {
            return Hours * HourValue;
        }

        public override string ToString()
        {
            return $"{base.ToString()} \n\t HorasExtras: {GetValueToPay():C2}";
        }
    }
}
