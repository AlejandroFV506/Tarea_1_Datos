using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1
{
    internal class camión:Vehiculo
    {
        public override void Avanzar()
        {
            Console.WriteLine("El camión está avanzando");
        }

        public override void Detener()
        {
            Console.WriteLine("El camión se ha detenido");
        }
    }
}
