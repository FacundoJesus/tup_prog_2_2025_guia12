using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    [Serializable]
    public class Camion:IComparable
    {
        private DateTime fecha;
        private int cantidad;
        
        public double ValorAsegurado
        {
            get
            {
                double valorAsegurado = 0;
                foreach (Auto auto in transporte)
                {
                    valorAsegurado += auto.Precio;
                }
                return valorAsegurado; 
            }
        }
        public int NroRegistro { get; set; }

        private Stack<Auto> transporte = new Stack<Auto>();

        public Camion() { }
        public Camion(DateTime fecha, int cantidad)
        {
            this.fecha = fecha;
            this.cantidad = cantidad;
        }

        public void CargarVehiculo(Auto unAuto)
        {
            if(transporte.Count < cantidad)
            {
                transporte.Push(unAuto);
            }
        }

        public Auto RetirarVehiculo()
        {
            Auto auto = null;
            if(transporte.Count > 0)
            {
                auto = transporte.Pop();
            }
            return auto;
        }

        public string[] VerCarga()
        {
            string[] carga = new string[transporte.Count];
            int i = 0;
            foreach(Auto auto in transporte)
            {
                carga[i++] = auto.ToString();
            }
            return carga;
        }

        public override string ToString()
        {
            return $"{this.NroRegistro}_{this.fecha:dd-MM-yyyy HH:MM}";
        }

        public int CompareTo(object obj)
        {
            Camion nuevoCamion = obj as Camion;
            if(nuevoCamion != null)
            {
                return this.NroRegistro.CompareTo(nuevoCamion.NroRegistro);
            }
            return -1;
        }

    }
}
