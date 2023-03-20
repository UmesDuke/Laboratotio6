using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratotio6
{
    public partial class Form1 : Form
    {
        private Maestro maestro = new Maestro();

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vehiculo v = new Vehiculo();
            v.NoPlaca = textBox4.Text;
            v.Marca = textBox5.Text;            
            v.Color = textBox7.Text;

            v.Modelo = Convert.ToInt32(textBox6.Text);
            v.Precio = Convert.ToDouble(textBox8.Text);
            
            if ( maestro.RegistrarVehiculo(v) )
            {
                maestro.Guardar();
            } else
            {
                MessageBox.Show(this, "¡Vehículo existente!");
            }
        }

        private void MostrarReporte()
        {
            List<Reporter> reportes = new List<Reporter>();
            int mayorKm = 0;
            int id = 0;
            foreach (Alquiler a in maestro.Alquilers)
            {
                Cliente c = null;
                Vehiculo v = null;

                foreach (Cliente c1 in maestro.Clientes)
                {
                    if (a.Nit == c1.Nit)
                    {
                        c = c1;
                        break;
                    }
                } 

                foreach(Vehiculo v1 in maestro.Vehiculos)
                {
                    if (a.NoPlaca == v1.NoPlaca)
                    {
                        v = v1;
                        break;
                    }
                }

                if (c != null && v != null)
                {
                    reportes.Add(new Reporter(c, v, a));
                    if (mayorKm <= a.Kilometros)
                    {
                        mayorKm = a.Kilometros;
                        id = c.Nit;
                    }
                }
            }

            dataGridViewAlquileres.DataSource = reportes;
            labelKm.Text = "[ NIT: " + id + " , Km: " + mayorKm + " ]";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            maestro.Cargar();

            dataGridViewClientes.DataSource = maestro.Clientes;
            dataGridViewVehiculos.DataSource = maestro.Vehiculos;
            MostrarReporte();
        }
    }
}
