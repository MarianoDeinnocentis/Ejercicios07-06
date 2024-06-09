using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
          string [] nombreestudiantes = new string[5] {"Mariano", "Carla", "Cande", "Manuel", "Nora"};
          
            foreach (var nombre in nombreestudiantes)
            {
                Console.WriteLine(nombre);
                nombreestudiantes[2]= "Carlos";
            }
               
            {
                nombreestudiantes[4]="Nora";
                Console.WriteLine("nombre del ultimo estudiante: "+nombreestudiantes[4]);
            } 
        

         
          
        }
      
    }
}