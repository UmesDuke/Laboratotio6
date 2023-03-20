using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratotio6
{
    class Cliente : Guardables
    {
        private int NIT;
        private string nombre;
        private string direcion;

        public int Nit { get => NIT; set => NIT = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direcion { get => direcion; set => direcion = value; }

        public void Cargar(StreamReader reader)
        {
            NIT = Convert.ToInt32(reader.ReadLine());
            nombre = reader.ReadLine();
            direcion = reader.ReadLine();
        }

        public void Guardar(StreamWriter writer)
        {
            writer.WriteLine(NIT);
            writer.WriteLine(nombre);
            writer.WriteLine(direcion);
        }
    }
}
