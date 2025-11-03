using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    [Serializable]
    public abstract class Ticket
    {
        protected int nroOrden;
        private DateTime fechaHora;

        public Ticket()
        {
            fechaHora = DateTime.Now;
        }

        public int VerNro()
        {
            return nroOrden;
        }

        public DateTime VerFechaHora() 
        { 
            return fechaHora;
        }

        public override string ToString()
        {
            return $"{this.nroOrden};{this.fechaHora:dd-MM-yyyy HH:MM}";
        }
    }
}
