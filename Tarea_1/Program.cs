using Tarea_1;


namespace Tarea_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Vehiculo carro = new carro("Toyota", 10.5);
            Vehiculo camion = new camión("Volvo", 0); 
            Vehiculo bicicleta = new bicicleta("Trek", 0); 

            carro.Avanzar();
            carro.Detener();  

            camion.Avanzar(); 
            camion.Detener(); 

            bicicleta.Avanzar();
            bicicleta.Detener();  

            carro.SetMarca(""); 
            carro.SetGasolina(-5); 
        }
    }
}