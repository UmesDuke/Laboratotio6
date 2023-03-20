using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratotio6
{
    class Alquiler : Guardables
    {
        //Nit, placa, fecha alquiler, fecha devolución, kilómetros recorridos. 

        private int nit;
        private string noPlaca;
        private DateTime fechaAlquiler;
        private DateTime fechaDevolucion;
        private int kilometros;

        public int Nit { get => nit; set => nit = value; }
        public string NoPlaca { get => noPlaca; set => noPlaca = value; }
        public DateTime FechaAlquiler { get => fechaAlquiler; set => fechaAlquiler = value; }
        public DateTime FechaDevolucion { get => fechaDevolucion; set => fechaDevolucion = value; }
        public int Kilometros { get => kilometros; set => kilometros = value; }

        public void Cargar(StreamReader reader)
        {
            nit = Convert.ToInt32(reader.ReadLine());
            noPlaca = reader.ReadLine();
            fechaAlquiler = DateTime.Parse(reader.ReadLine());
            fechaDevolucion = DateTime.Parse(reader.ReadLine());
            kilometros = Convert.ToInt32(reader.ReadLine());
        }

        public void Guardar(StreamWriter writer)
        {
            writer.WriteLine(nit);
            writer.WriteLine(noPlaca);
            writer.WriteLine(fechaAlquiler);
            writer.WriteLine(fechaDevolucion);
            writer.WriteLine(kilometros);
        }
    }
}
