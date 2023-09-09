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

            //Instaciar las clases Date.cs
            Date dateObject = new Date(1, 2, 232);
            Console.WriteLine(dateObject.ToString());

        }
    }
}
