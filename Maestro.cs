using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratotio6
{
    class Maestro
    {
        private List<Vehiculo> vehiculos = new List<Vehiculo>();
        private List<Alquiler> alquilers = new List<Alquiler>();
        private List<Cliente> clientes = new List<Cliente>();

        internal List<Vehiculo> Vehiculos { get => vehiculos; set => vehiculos = value; }
        internal List<Alquiler> Alquilers { get => alquilers; set => alquilers = value; }
        internal List<Cliente> Clientes { get => clientes; set => clientes = value; }

        public bool RegistrarVehiculo(Vehiculo vehiculo)
        {
            foreach (Vehiculo v in this.vehiculos)
            {
                if (v.NoPlaca == vehiculo.NoPlaca)
                {
                    return false;
                }
            }

            this.vehiculos.Add(vehiculo);
            return true;
        }

        public void Cargar()
        {
            StreamReader reader = OpenReader("clientes.txt");
            while (reader.Peek() > -1)
            {
                Cliente c = new Cliente();
                c.Cargar(reader);
                clientes.Add(c);
            }
            reader.Close();

            reader = OpenReader("vehiculos.txt");
            while (reader.Peek() > -1)
            {
                Vehiculo v = new Vehiculo();
                v.Cargar(reader);
                vehiculos.Add(v);
            }
            reader.Close();

            reader = OpenReader("Alquieler.txt");
            while (reader.Peek() > -1)
            {
                Alquiler a = new Alquiler();
                a.Cargar(reader);
                alquilers.Add(a);
            }
            reader.Close();
        }

        public void Guardar()
        {
            StreamWriter writer = OpenWriter("clientes.txt");
            foreach (Guardables g in clientes)
            {
                g.Guardar(writer);
            }
            writer.Close();

            writer = OpenWriter("vehiculos.txt");
            foreach (Guardables g in vehiculos)
            {
                g.Guardar(writer);
            }
            writer.Close();

            writer = OpenWriter("Alquieler.txt");
            foreach (Guardables g in alquilers)
            {
                g.Guardar(writer);
            }
            writer.Close();
        }

        private StreamReader OpenReader(string fileName)
        {
            FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read);
            return new StreamReader(stream);
        }

        private StreamWriter OpenWriter(string fileName)
        {
            FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            return new StreamWriter(stream);
        }
    }
}
