using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10] {0,1,2,3,4,5,6,7,8,9};
           
            int suma=0;
            foreach (var numero in numeros)
            {
             suma += numero; 
            }
          double promedio = (double) suma/ numeros.Length;
          Console.WriteLine("La suma de los elementos es:" + suma);
          Console.WriteLine("El promedio es: " + promedio); 

            
        
        }
    } 
}
