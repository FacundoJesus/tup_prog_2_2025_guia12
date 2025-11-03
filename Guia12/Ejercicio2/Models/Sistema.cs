using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    [Serializable]
    public class Sistema
    {
        private int n;
        public int NroOrden {  get {
                return n++;
            }
        }

        private List<Auto> listaAutos = new List<Auto>();
        private List<Camion> listaCamiones = new List<Camion>();

        public void RecibirCamion(Camion unCamion)
        {
            listaCamiones.Add(unCamion);
            unCamion.NroRegistro = NroOrden;
        }

        public Auto DescargarCamion(int nroOrden)
        {
            Camion camionBuscado = BuscarCamion(nroOrden);

            Auto auto = null;
            if(camionBuscado != null) {
                auto = camionBuscado.RetirarVehiculo();
                listaAutos.Add(auto);
            }
            return auto;
        }

        public int GenerarCamion(DateTime fecha, int capacidad)
        {
            Camion nuevoCamion = new Camion(fecha, capacidad);

            nuevoCamion.NroRegistro = NroOrden;

            return nuevoCamion.NroRegistro;
        }

        public void CargarCamion(int nroOrden,Auto unAuto)
        {
            Camion camionBuscado = BuscarCamion(nroOrden);

            if(camionBuscado != null)
            {
                camionBuscado.CargarVehiculo(unAuto);
                listaAutos.Remove(unAuto);
            }
        }

        private Camion BuscarCamion(int nroRegistro)
        {
            int i = 0;
            int pos = -1;
            
            while(pos ==-1 && i < listaCamiones.Count)
            {
                if (listaCamiones[i].NroRegistro == nroRegistro)
                {
                    pos = i;
                }
                i++;
            }

            Camion camion = null;
            if (pos !=-1)
            {
                camion = listaCamiones[pos];
            }
            return camion;
        }

        public void CerrarCamion(int nro)
        {
            Camion camionBuscado = BuscarCamion(nro);

            if(camionBuscado != null)
            {
                FileStream fs = null;
                StreamWriter sw = null;
                try
                {
                    string path = camionBuscado.ToString() + ".csv";

                    fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                    sw = new StreamWriter(fs);
                    sw.WriteLine("numeroRegistro;modelo");
                    foreach (string linea in camionBuscado.VerCarga())
                    {
                        sw.WriteLine(linea);
                    }
                }catch(Exception ex)
                {
                    throw new Exception("Error al exportar el Camion");
                }
                finally
                {
                    if(sw != null) sw.Close();
                    if (fs != null) fs.Close();
                }

            }
        }

    }
}
