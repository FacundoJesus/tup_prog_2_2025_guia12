using Ejercicio2.Models;
using System.Runtime.Serialization.Formatters.Binary;
using System.Transactions;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Sistema sistema = new Sistema();

        private int _nro;

        private void btnCrearCamion_Click(object sender, EventArgs e)
        {
            DateTime fecha = dtpFecha.Value;
            int capacidad = Convert.ToInt32(tbCapacidad.Text);

            _nro = sistema.GenerarCamion(fecha, capacidad);

            MessageBox.Show("Camión Creado!");

            #region Limpio Campos
            tbCapacidad.Clear();
            dtpFecha.Value = DateTime.Now;
            #endregion

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Auto autoSeleccionado = listBox1.SelectedItem as Auto;
            if (autoSeleccionado != null)
            {
                sistema.CargarCamion(_nro, autoSeleccionado);
                listBox1.Items.Remove(autoSeleccionado);
            }
            else
            {
                MessageBox.Show("Debes seleccionar un auto para cargarlo al Camión");
            }
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            Auto auto = sistema.DescargarCamion(_nro);
            listBox1.Items.Add(auto);
        }

        private void btnCerrarCamion_Click(object sender, EventArgs e)
        {
            sistema.CerrarCamion(_nro);
        }

        private void btnRecibirCamion_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "(csv)|*.csv|(txt)|*.txt";
            ofd.Title = "Importación de Vehiculos";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = null;
                StreamReader sr = null;
                string path = ofd.FileName;
                try
                {
                    fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);
                    sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        string linea = sr.ReadLine();
                        string[] splitResult = linea.Split(';');

                        int nroRegistro = Convert.ToInt32(splitResult[0].Trim());
                        string modelo = splitResult[1].Trim();
                        double precio = Convert.ToDouble(splitResult[2].Trim());

                        Auto auto = new Auto(nroRegistro, modelo);
                        auto.Precio = precio;

                        listBox2.Items.Add(auto);
                    }
                    Camion camion = new Camion(DateTime.Now, listBox2.Items.Count);

                    sistema.RecibirCamion(camion);
                    _nro = camion.NroRegistro;
                    foreach (Auto auto in listBox2.Items)
                    {
                        sistema.CargarCamion(camion.NroRegistro, auto);
                    }  
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error en la Importación del Camión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (sr != null) sr.Close();
                    if (fs != null) fs.Close();
                }
            }

        }

        private void btnDescargarCamionRecibido_Click(object sender, EventArgs e)
        {
            if (_nro > 0)
            {
                Auto auto = sistema.DescargarCamion(_nro);
                while (auto != null) {
                    listBox1.Items.Add(auto);
                    listBox2.Items.Remove(auto);

                    auto = sistema.DescargarCamion(_nro);
                }
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            FileStream fs = null;

            try
            {
                fs = new FileStream("datos.bin", FileMode.Open, FileAccess.Read);
#pragma warning disable SYSLIB0011
                BinaryFormatter bf = new BinaryFormatter();
#pragma warning restore SYSLIB0011
                sistema = bf.Deserialize(fs) as Sistema;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en la Deserialización", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (fs != null) fs.Close();
            }

            #region Creo una lista ficticia de Autos - Creo un Camion - Le asigno un número de registro y los Cargo al Camion
            List<Auto> autos = new List<Auto>
            {
                new Auto(100,"Cronos TZ"),
                new Auto(101,"Cronos Full"),
                new Auto(102,"Audi AA"),
                new Auto(103,"Mobi")
            };

            Camion camion = new Camion(DateTime.Now, 6);
            camion.NroRegistro = sistema.NroOrden;
            sistema.RecibirCamion(camion);
            foreach (Auto auto in autos)
            {
                camion.CargarVehiculo(auto);
            }
            #endregion

            #region Los imprimo en el listbox1
            foreach (Auto auto in autos)
            {
                listBox1.Items.Add(auto);
            }
            //o... listBox1.Items.AddRange(autos.ToArray());
            #endregion*/
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*
            FileStream fs = null;
            try
            {
                fs = new FileStream("datos.bin", FileMode.Create, FileAccess.Write);
                #pragma warning disable SYSLIB0011
                BinaryFormatter bf = new BinaryFormatter();
                #pragma warning restore SYSLIB0011
                bf.Serialize(fs, sistema);
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message,"Error en la Serialización",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (fs!=null) fs.Close();
            }*/
        }
        
    }
}
