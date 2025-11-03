using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    [Serializable]
    public class Vehiculo:IComparable
    {
        private string nroPatente;
        private Cliente dueño;

        public Vehiculo(string patente, Cliente propietario)
        {
            this.nroPatente = patente;
            this.dueño = propietario;
        }

        public Cliente VerDueño() 
        {
            return dueño;
        }

        public string VerPatente()
        {
            return nroPatente;
        }

        public override string ToString()
        {
            return $"{this.nroPatente}";
        }

        public int CompareTo(object obj)
        {
            Vehiculo nuevoVehiculo = obj as Vehiculo;
            if(nuevoVehiculo!=null)
            {
                return this.nroPatente.CompareTo(nuevoVehiculo.nroPatente);
            }
            return -1;
        }
    }
}
