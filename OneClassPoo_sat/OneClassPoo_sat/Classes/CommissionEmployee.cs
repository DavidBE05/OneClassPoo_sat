using System;
using System.Collections.Generic;
using System.Text;

namespace OneClassPoo_sat.Classes
{
    public class CommissionEmployee: Employee
    {
        public decimal CommisionPercentaje { get; set; }
        public int Sales { get;set; }

        public override decimal GetValueToPay()
        {
            return Sales * CommisionPercentaje;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\t Porcentaje de Comisiòn......{CommisionPercentaje:P2}" +
                $"\n\t Ventas...................{Sales:C2}" +
                $"\n\t Salario...............{GetValueToPay():C2} \n\t";
        }
    }
}
