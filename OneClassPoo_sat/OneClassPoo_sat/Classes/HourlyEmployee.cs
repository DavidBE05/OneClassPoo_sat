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
            return $"{base.ToString()}" +
                $"\n\t Nùmero de horas....{Hours}" +
                $"\n\t Valor de la hora.....{HourValue:C2}" +
                $"\n\t Salario..........{GetValueToPay():C2}\n\t";
        }
    }
}
