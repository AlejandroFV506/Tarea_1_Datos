using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1
{
    internal class bicicleta:Vehiculo
    {
        public bicicleta(string marca, double combustible) : base(marca, combustible) { }

        //Simula que la bicicleta avanza
        public override void Avanzar()
        {
            Console.WriteLine($"La bicicleta {GetMarca()} esta avanzando");
        }

        //Simula que la bicicleta se detiene
        public override void Detener()
        {
            Console.WriteLine($"La bicicleta {GetMarca()} se ha detenido.");
        }

        //Simula que la bicicleta hace trucos
        public void Moverse(string direccion)
        {
            Console.WriteLine($"La bicicleta {GetMarca()} se está moviendo hacia {direccion}");
        }  

        public void Moverse(string direccion, int vueltas)
        {
            Console.WriteLine($"La bicicleta {GetMarca()} se está dando {vueltas} hacia {direccion}");
        }  
        
    }
}
