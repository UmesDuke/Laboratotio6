using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratotio6
{
    class Vehiculo : Guardables
    {
        private string noPlaca;
        private string marca;
        private string color;
        private int modelo;
        private double precio;

        public string NoPlaca { get => noPlaca; set => noPlaca = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Color { get => color; set => color = value; }
        public int Modelo { get => modelo; set => modelo = value; }
        public double Precio { get => precio; set => precio = value; }

        public void Cargar(StreamReader reader)
        {
            noPlaca = reader.ReadLine();
            marca = reader.ReadLine();
            color = reader.ReadLine();
            modelo = Convert.ToInt32(reader.ReadLine());
            precio = Convert.ToDouble(reader.ReadLine());
        }

        public void Guardar(StreamWriter writer)
        {
            writer.WriteLine(noPlaca);
            writer.WriteLine(marca);
            writer.WriteLine(color);
            writer.WriteLine(modelo);
            writer.WriteLine(precio);
        }
    }
}
