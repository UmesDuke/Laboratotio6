using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratotio6
{
    class Reporter
    {
        // Nombre del cliente, los datos del automóvil,  la fecha de devolución, y el total a pagar
        private Cliente cliente;
        private Vehiculo Vehiculo;
        private Alquiler Alquiler;
        private double totalApagar;

        public Reporter(Cliente cliente, Vehiculo vehiculo, Alquiler alquiler)
        {
            this.cliente = cliente;
            this.Vehiculo = vehiculo;
            this.Alquiler = alquiler;
            this.totalApagar = alquiler.Kilometros * vehiculo.Precio;
        }

       
        public string Nombre { get => cliente.Nombre; }
        public string NoPlaca { get => Vehiculo.NoPlaca; }
        public string Marca { get => Vehiculo.Marca; }
        public string Color { get => Vehiculo.Color; }
        public int Modelo { get => Vehiculo.Modelo; }
        public DateTime FechaAlquiler { get => Alquiler.FechaAlquiler; }
        public DateTime FechaDevolucion { get => Alquiler.FechaDevolucion; }
        public double TotalApagar { get => totalApagar; }
    }
}
