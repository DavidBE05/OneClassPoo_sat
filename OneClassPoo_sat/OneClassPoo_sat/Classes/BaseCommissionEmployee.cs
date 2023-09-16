using System;
using System.Collections.Generic;
using System.Text;

namespace OneClassPoo_sat.Classes
{
    public class BaseCommissionEmployee : Employee
    {
        public decimal Base { get; set; }

        public override decimal GetValueToPay()
        {
            return Base;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\t Base................{Base:C2}" +
                $"\n\t Salario Total...............{GetValueToPay():C2}\n\t";
        }
    }
}
