using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
         {
           string [] paises = { "Argentina", "Brasil", "Colombia", "Chile", "Uruguay", "Ecuador", "Japon" , "Peru" };
           
           Console.WriteLine("Ingrese el nombre del pais: ");
           string paisBuscado = Console.ReadLine();
           
           bool encontrado = false;

           foreach (string pais in paises)
           {
                if (pais == paisBuscado)
                 {
                 encontrado = true;
                 break;
                 }
                
            }

            if (encontrado)
            {
                 Console.WriteLine("¡El país ha sido encontrado!");
            }
            else
            {
                Console.WriteLine("El país no ha sido encontrado.");
            }

            
         }
    }
}

/*using System;

class Program
{
    static void Main(string[] args)
    {
        string[] paises = { "Argentina", "Brasil", "Chile", "Colombia", "Ecuador", "México", "Perú", "Uruguay" };

        Console.WriteLine("Ingrese el nombre de un país:");
        string paisBuscado = Console.ReadLine();

        bool encontrado = false;

        foreach (string pais in paises)
        {
            if (pais == paisBuscado)
            {
                encontrado = true;
                break;
            }
        }

        if (encontrado)
        {
            Console.WriteLine("¡El país ha sido encontrado!");
        }
        else
        {
            Console.WriteLine("El país no ha sido encontrado.");
        }
    }
}*/