using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tareaColas2
{
    public class Cola
    {
        private Nodo primero;
        private Nodo ultimo;

        public bool Vacia { get { return primero == null; } }

        public void Encolar(Cliente cliente)
        {
            Nodo nuevoNodo = new Nodo(cliente);

            if (Vacia)
            {
                primero = nuevoNodo;
                ultimo = nuevoNodo;
            }
            else
            {
                ultimo.Siguiente = nuevoNodo;
                ultimo = nuevoNodo;
            }
        }

        public Cliente Desencolar()
        {
            if (Vacia)
            {
                throw new Exception("La cola está vacía");
            }

            Cliente clienteAtendido = primero.Cliente;
            primero = primero.Siguiente;

            if (primero == null)
            {
                ultimo = null;
            }

            return clienteAtendido;
        }

        public void MostrarCola()
        {
            if (Vacia)
            {
                Console.WriteLine("La cola está vacía");
                return;
            }

            Nodo actual = primero;

            Console.WriteLine("Lista de espera:");
            while (actual != null)
            {
                Console.WriteLine("- {0} ({1} minutos)", actual.Cliente.Nombre, actual.Cliente.TiempoAtencion);
                actual = actual.Siguiente;
            }
        }
    }
}
