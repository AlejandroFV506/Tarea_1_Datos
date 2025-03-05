using System;
using Tarea_1;


namespace Tarea_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Vehiculo carro = new Carro("Toyota", 10.5);
            Vehiculo camion = new Camion("Volvo", 0); 
            Vehiculo bicicleta = new Bicicleta("Trek", 0); 

            carro.Avanzar();
            carro.Detener();  

            camion.Avanzar(); 
            camion.Detener(); 

            bicicleta.Avanzar();
            bicicleta.Detener();  

            carro.GetMarca();
            Console.WriteLine("La Marca del carro es " + carro.GetMarca());
            
            carro.GetCombustible();
            Console.WriteLine("El combustible del carro es " + carro.GetCombustible());
            carro.SetMarca("Hyundai"); 
            carro.SetCombustible(1000);

            camion.GetMarca();
            camion.SetMarca("Mercedes Benz"); 

            Console.WriteLine("La Marca del carro es " + carro.GetMarca());
            Console.WriteLine("La Marca del camion es " + camion.GetMarca());
            Console.WriteLine("El combustible del carro es " + carro.GetCombustible());
        }
    }
}