using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace tareaColas2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema de Atención de Cajeros Automáticos");

            Console.Write("Ingrese la cantidad de clientes a atender: ");
            int cantidadClientes = int.Parse(Console.ReadLine());

            List<Cliente> clientes = new List<Cliente>();

            for (int i = 1; i <= cantidadClientes; i++)
            {
                Console.Write("Ingrese el nombre del cliente {0}: ", i);
                string nombreCliente = Console.ReadLine();

                Console.Write("Ingrese el tiempo de atención del cliente {0} (en minutos): ", i);
                int tiempoAtencion = int.Parse(Console.ReadLine());

                Cliente cliente = new Cliente(nombreCliente, tiempoAtencion);
                clientes.Add(cliente);
            }

            Cola colaClientes = new Cola();

            foreach (Cliente cliente in clientes)
            {
                colaClientes.Encolar(cliente);
            }

            Console.WriteLine("\nLista inicial de espera:");
            colaClientes.MostrarCola();

            Console.WriteLine("\nSimulando atención de clientes...");

            int tiempoTotal = 0;
            while (!colaClientes.Vacia)
            {
                Cliente clienteAtendido = colaClientes.Desencolar();
                Console.WriteLine("\nAtendiendo a {0} ({1} minutos)", clienteAtendido.Nombre, clienteAtendido.TiempoAtencion);

                tiempoTotal += clienteAtendido.TiempoAtencion;
                Thread.Sleep(clienteAtendido.TiempoAtencion * 1000); // Simula el tiempo de atención
            }

            Console.WriteLine("\nLista de clientes atendidos:");
            foreach (Cliente cliente in clientes)
            {
                Console.WriteLine("- {0} ({1} minutos)", cliente.Nombre, cliente.TiempoAtencion);
            }

            Console.WriteLine("\nTiempo total de atención: {0} minutos", tiempoTotal);
            Console.ReadKey();
        }
    

}
}
