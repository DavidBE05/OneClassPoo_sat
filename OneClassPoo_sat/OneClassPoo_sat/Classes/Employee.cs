using System;
using System.Collections.Generic;
using System.Text;

namespace OneClassPoo_sat.Classes
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Date BirthDate { get; set; }
        public Date HiringDate { get; set; }
        public bool IsActive { get; set; }

        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            return $"INFORMACION DEL EMPLEADO \n\t"+
                $"ID: {Id} \n\t"+
                $"Nombres: {FirstName} \n\t" +
                $"Apellidos: {LastName} \n\t" +
                $"Fecha Cumpleaños: {BirthDate} \n\t" +
                $"Fecha de contratacion: {HiringDate} \n\t" +
                $"¿Empleado activo?: {IsActive}";
        }
    }
}
