using Tarea_1;


namespace Tarea_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Vehiculo carro = new carro("Toyota", 10.5);
            Camion camion = new Camion("Volvo", 0); 
            bicicleta bicicleta = new bicicleta("Trek", 0); 

            carro.Avanzar();
            carro.Detener();  

            camion.Avanzar(); 
            camion.Detener();
            camion.Cargar(); 

            bicicleta.Avanzar();
            bicicleta.Detener();
            bicicleta.Moverse("atrás");
            bicicleta.Moverse("derecha", 3);  

            carro.SetMarca(""); 
            carro.SetCombustible(-5);
        }
    }
}