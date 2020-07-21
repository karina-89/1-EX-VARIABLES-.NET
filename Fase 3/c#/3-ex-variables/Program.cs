using System;

namespace _3_ex_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano_bisiesto = 1948;
            int ano_nacimiento = 1984;
            int cada_cuanto = 4;
            bool nacimiento_bisiesto = false;
            string nombre = "Karina Rodriguez Ramirez";
            string fecha_nacimiento = "25/05/1984";

            for (int i = ano_bisiesto; i <= ano_nacimiento; i+=cada_cuanto)
            {
                Console.WriteLine("Año bisiesto: " + i);
                if (i == ano_nacimiento)
                    nacimiento_bisiesto = true;
            }
            
            string nacimiento = "";
            if (nacimiento_bisiesto == true)
                nacimiento = "Mi año de nacimiento es bisiesto";
            else
                nacimiento = "Mi año de nacimiento no es bisiesto";

            Console.WriteLine("Mi nombre es " + nombre);
            Console.WriteLine("Nací el " + fecha_nacimiento);
            Console.WriteLine(nacimiento);
        }
    }
}
