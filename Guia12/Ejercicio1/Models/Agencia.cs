using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    [Serializable]
    public class Agencia
    {
        public List<Ticket> ListaAtendidos { get; set; } = new List<Ticket>();

        private Queue<Denuncia> denuncias = new Queue<Denuncia>();
        private Queue<Cliente> nuevosClientes = new Queue<Cliente>();

        private List<Vehiculo> listaVehiculos = new List<Vehiculo>()
        {
            new Vehiculo("LZL594",new Cliente("40158729")),
            new Vehiculo("ABC123",new Cliente("38123596")),
            new Vehiculo("JJJ550",new Cliente("25578951")),
        };

        public void AgregarTicket(Ticket turno)
        {
            if (turno != null) {
                if(turno is Denuncia)
                {
                    denuncias.Enqueue(turno as Denuncia);
                }
                else 
                if(turno is Cliente) 
                {
                    nuevosClientes.Enqueue(turno as Cliente);
                }
            }
        }

        public Ticket AtenderTicket(int tipo)
        {
            Ticket ticket = null;
            if(tipo == 1)
            {
                if(denuncias.Count > 0)
                {
                    ticket = denuncias.Dequeue();
                    
                }
            }
            else
            if(tipo == 2)
            {
                if(nuevosClientes.Count > 0)
                {
                    ticket = nuevosClientes.Dequeue();
                }
            }

            if(ticket != null)
            {
                ListaAtendidos.Add(ticket);
            }
            return ticket;
        }

        public Vehiculo BuscarVehiculo(string nroPatente)
        {
            Vehiculo vehiculo = new Vehiculo(nroPatente, null);

            listaVehiculos.Sort();
            int idx = listaVehiculos.BinarySearch(vehiculo);

            if(idx > -1)
            {
                return listaVehiculos[idx];
            }
            return null;
        }

        public void AgregarVehiculo(string patente, string dni)
        {
            Vehiculo vehiculo = BuscarVehiculo(patente);

            if (vehiculo == null)
            {
                Cliente propietario = new Cliente(dni);
                vehiculo = new Vehiculo(patente, propietario);
                listaVehiculos.Add(vehiculo);
            }
        }
    }
}
