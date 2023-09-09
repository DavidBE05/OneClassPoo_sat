using OneClassPoo_sat.Classes;
using System;

namespace OneClassPoo_sat
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OOP APLICATTION");
            Console.WriteLine("-------------");

            //Declarar algunas varibales
            int day, month, year;
            Console.WriteLine("Ingrese el dia");
            day = Convert.ToInt32(Console.ReadLine()); //ToInt32, ToDecimal, ToDouble, ToFloat, ToBoolel, para cambiar el console Read Line

            Console.WriteLine("Ingrese el mes");
            month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el año");
            year = Convert.ToInt32(Console.ReadLine());

            //Instaciar las clases Date.cs
            Date dateObject = new Date(year, month, day);
            Console.WriteLine(dateObject.ToString());

        }
    }
}
