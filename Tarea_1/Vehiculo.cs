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
        private double gasolina;

        public Vehiculo(string marca, double gasolina)
        {
            this.marca = marca;
            this.gasolina = gasolina;
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

        // Método obtener la gasolina
        public double GetGasolina()
        {
            return gasolina;
        }

        // Método para agragar gasolina
        public void SetGasolina(double gasolina)
        {
            if (gasolina >= 0) 
            {
                this.gasolina = gasolina;
            }
            else
            {
                Console.WriteLine("La gasolina no puede ser negativa.");
            }
        }

        //Método que simula que el vehiculo avanza
        public virtual void Avanzar()
        {
            if (gasolina > 0)
            {
                Console.WriteLine("El vehículo está avanzando.");
            }
            else
            {
                Console.WriteLine("No hay suficiente gasolina para arrancar.");
            }
        }
        
        //metodo que simula que el vehiculo se detiene
        public virtual void Detener()
        {
            Console.WriteLine("El vehículo se ha detenido.");
        }
    }
}
