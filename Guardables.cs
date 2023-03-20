using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratotio6
{
    interface Guardables
    {
        void Guardar(StreamWriter writer);
        void Cargar(StreamReader reader);
    }
}
