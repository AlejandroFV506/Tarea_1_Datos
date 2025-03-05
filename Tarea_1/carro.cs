using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1
{
    internal class carro:Vehiculo
    {
        public override void Avanzar()
        {
            Console.WriteLine("El carro está avanzando");
        }

        public override void Detener()
        {
            Console.WriteLine("El carro se ha detenido");
        }
    }
}
