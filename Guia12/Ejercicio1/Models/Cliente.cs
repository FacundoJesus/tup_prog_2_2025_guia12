using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    [Serializable]
    public class Cliente:Ticket
    {
        private long dni;
        private static int numero;

        public int TipoVehiculo { get; set; }

        public Cliente(string dni)
        {

            foreach (char c in dni)
            {
                if (!char.IsDigit(c))
                    throw new DniNoValidoException("Hay caracteres no numéricos");
            }

            long dniLong = Convert.ToInt64(dni);
            if(dniLong<5000000)
            {
                throw new DniNoValidoException("El DNI debe ser mayor a 5.000.000");
            }

            this.dni = dniLong;
            base.nroOrden = numero++;
        }

        public override string ToString() {
            return $"CLIENTE;{base.ToString()};{this.dni};{this.TipoVehiculo}";
        }
    }
}
