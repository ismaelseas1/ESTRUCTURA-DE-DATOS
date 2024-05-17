using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tareaColas2
{
    public class Nodo
    {
        public Cliente Cliente { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(Cliente cliente)
        {
            Cliente = cliente;
            Siguiente = null;
        }
    }
}
