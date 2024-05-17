using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tareaColas2
{
   public class Cliente
    {
        public string Nombre { get; set; }
        public int TiempoAtencion { get; set; }

        public Cliente(string nombre, int tiempoAtencion)
        {
            Nombre = nombre;
            TiempoAtencion = tiempoAtencion;
        }
    }
}
