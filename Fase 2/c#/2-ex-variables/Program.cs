using System;

namespace _2_ex_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            const int ano_bisiesto = 1948;
            int cada_cuanto = 4;
            int resultado = (1984 - ano_bisiesto) / cada_cuanto;

            Console.WriteLine("Entre el año 1984 y el año " + ano_bisiesto + " hay " + resultado + " años bisiestos.");
        }
    }
}
