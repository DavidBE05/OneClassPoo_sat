using OneClassPoo_sat.Classes;
using System;

namespace OneClassPoo_sat
{
    public class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("OOP APLICATTION");
                Console.WriteLine("-------------");

                //Declarar algunas varibales
                int day, month, year;
                string firstName, lastName;
                decimal salary;

                Console.WriteLine("Ingrese el dia");
                day = Convert.ToInt32(Console.ReadLine()); //ToInt32, ToDecimal, ToDouble, ToFloat, ToBoolel, para cambiar el console Read Line

                Console.WriteLine("Ingrese el mes");
                month = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el año");
                year = Convert.ToInt32(Console.ReadLine());

                //Instaciar las clases Date.cs
                Date dateObject = new Date(year, month, day);
                Console.WriteLine("\n");
                Console.WriteLine(dateObject.ToString());

                Console.WriteLine("Ingrese el nombre completo");
                firstName = Console.ReadLine();

                Console.WriteLine("Ingrese apellidos");
                lastName = Console.ReadLine();

                Console.WriteLine("Ingrese salario");
                salary = Convert.ToDecimal(Console.ReadLine());

                SalaryEmployee salaryEmployee = new SalaryEmployee() 
                {  
                    Id= 123,
                    FirstName=firstName,
                    LastName=lastName,
                    BirthDate=dateObject,
                    HiringDate=dateObject,  
                    IsActive=true,
                    Salary=salary,
                };

                Console.Clear();
                Console.WriteLine(salaryEmployee);

            }
            catch (Exception ex)
            {
                Console.WriteLine("\n");
                Console.WriteLine(ex.Message);  
            }
           

        }
        
    }
}
