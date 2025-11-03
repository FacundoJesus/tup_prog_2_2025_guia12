using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    [Serializable]
    public class Denuncia:Ticket
    {
        private Vehiculo dominio;
        private static int numero;

        public Denuncia(Vehiculo asegurado)
        {
            this.dominio = dominio;
            
            base.nroOrden = numero++;
        }

        public override string ToString()
        {
            return $"DENUNCIA;{base.ToString()};{this.dominio.ToString()}";
        }
    }
}
