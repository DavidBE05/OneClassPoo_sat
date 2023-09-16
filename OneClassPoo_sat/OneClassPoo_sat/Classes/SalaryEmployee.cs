﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OneClassPoo_sat.Classes
{
    public class SalaryEmployee : Employee
    {
        public decimal Salary { get; set; }

        public override decimal GetValueToPay()
        {
            return Salary;  
        }

        public override string ToString()
        {
            return $"{base.ToString()} \n\t Salario: {GetValueToPay():C2}";
        }
    }
}
