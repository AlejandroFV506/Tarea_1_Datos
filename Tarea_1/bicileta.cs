using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1
{
    internal class bicileta:Vehiculo
    {
        public override void Avanzar()
        {
            Console.WriteLine("La bicicleta se esta moviendo");
        }

        public override void Detener()
        {
            Console.WriteLine("La bicicleta se ha detenido.");
        }
    }
}
