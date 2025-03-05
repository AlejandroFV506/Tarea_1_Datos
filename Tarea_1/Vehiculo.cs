using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1
{
    internal class Vehiculo
    {
        private string marca;
        private double combustible;

        public Vehiculo(string marca, double combustible)
        {
            this.marca = marca;
            this.combustible = combustible;
        }

        // Método para obtener la marca
        public string GetMarca()
        {
            return marca;
        }

        // Método para agregar la marca
        public void SetMarca(string marca)
        {
            if (!string.IsNullOrEmpty(marca)) // Validación simple
            {
                this.marca = marca;
            }
            else
            {
                Console.WriteLine("La marca no puede estar vacía.");
            }
        }

        // Método obtener el combustible
        public double GetCombustible()
        {
            return combustible;
        }

        // Método para agregar combustible
        public void SetCombustible(double combustible)
        {
            if (combustible >= 0) 
            {
                this.combustible = combustible;
            }
            else
            {
                Console.WriteLine("El combustible no puede ser negativo.");
            }
        }

        //Método que simula que el vehiculo avanza
        public virtual void Avanzar()
        {
            if (combustible > 0)
            {
                Console.WriteLine("El vehículo está avanzando.");
            }
            else
            {
                Console.WriteLine("No hay suficiente combustible para arrancar.");
            }
        }
        
        //metodo que simula que el vehiculo se detiene
        public virtual void Detener()
        {
            Console.WriteLine("El vehículo se ha detenido.");
        }
    }
}
