using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1
{
    internal class Vehiculo
    {
        public string Marca;

        public virtual void Avanzar()
        {
            Console.WriteLine("El vehículo está avanzando.");
        }

        public virtual void Detener()
        {
            Console.WriteLine("El vehículo se ha detenido.");
        }
    }
}
