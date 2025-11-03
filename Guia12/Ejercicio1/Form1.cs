using Ejercicio1.Models;
using System.Runtime.Serialization.Formatters.Binary;
using System.Transactions;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Agencia agencia = new Agencia();

        private void btnTicket_Click(object sender, EventArgs e)
        {
            try
            {
                Ticket ticket = null;
                if (rbDenuncia.Checked)
                {
                    string patente = tbPatente.Text;
                    
                    Vehiculo vehiculo = agencia.BuscarVehiculo(patente);

                    if (vehiculo != null)
                    {
                        ticket = new Denuncia(vehiculo);
                        tbPatente.Clear();
                    }
                    else
                    {
                        MessageBox.Show("El vehiculo con esa Patente no existe en el Sistema. Debe registrarse como Nuevo Cliente.");
                    }
                }
                else
                if (rbNuevoCliente.Checked)
                {
                    string dni = tbDNI.Text;
                    ticket = new Cliente(dni);
                    ((Cliente)ticket).TipoVehiculo = cmbTipoVehiculo.SelectedIndex+1;

                    tbDNI.Clear();

                }
                else
                {
                    MessageBox.Show("Debes seleccionar una opción");
                }

                if (ticket != null)
                {
                    agencia.AgregarTicket(ticket);
                    lsbTurnos.Items.Add(ticket);

                    rbDenuncia.Checked = false;
                    rbNuevoCliente.Checked = false;
                }
            }
            catch (DniNoValidoException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAtenderDenuncias_Click(object sender, EventArgs e)
        {
            Ticket ticket = agencia.AtenderTicket(1);
            if (ticket != null)
            {
                lsbTurnos.Items.Remove(ticket);
            }
            else
            {
                MessageBox.Show("No hay Tickets del tipo 'Denuncia' para Atender");
            }
        }

        private void btnAtenderNuevoCliente_Click(object sender, EventArgs e)
        {
            Ticket ticket = agencia.AtenderTicket(2);
            if (ticket != null)
            {
                lsbTurnos.Items.Remove(ticket);
            }
            else
            {
                MessageBox.Show("No hay Tickets del tipo 'Nuevo Cliente' para Atender");
            }
        }

        private void btnImportarVehiculos_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "IMPORTACIÓN DE VEHÍCULOS";
            openFileDialog1.Filter = "(csv)|*.csv";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = null;
                StreamReader sr = null;
                string path = openFileDialog1.FileName;
                try
                {
                    fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);
                    sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        string linea = sr.ReadLine();
                        string[] splitResult = linea.Split(';');

                        string patente = splitResult[0].Trim();
                        string dni = splitResult[1].Trim();

                        //Agrego método para agregarlo a la lista de vehiculos de la agencia.
                        agencia.AgregarVehiculo(patente, dni);

                        MessageBox.Show("Vehiculos Importados de manera satisfactoria");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error en la importación de vehiculos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (sr != null) sr.Close();
                    if (fs != null) fs.Close();
                }
            }
        }

        private void btnExportarTickets_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "EXPORTACIÓN DE TICKETS";
            saveFileDialog1.Filter = "(csv)|*.csv";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = null;
                StreamWriter sw = null;
                string path = saveFileDialog1.FileName;
                try
                {
                    fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                    sw = new StreamWriter(fs);
                    sw.WriteLine("DENUNCIA;nroOrden;FechaHora;nroPatente");
                    sw.WriteLine("CLIENTE;nroOrden;FechaHora;dni;TipoVehiculo");

                    foreach (Ticket ticket in agencia.ListaAtendidos)
                    {
                        sw.WriteLine(ticket.ToString());
                    }

                    MessageBox.Show("Tickets exportados de manera Satisfactoria.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error en la Exportación de Tickets", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (sw != null) sw.Close();
                    if (fs != null) fs.Close();
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream("datos.bin", FileMode.Open, FileAccess.Read);
                #pragma warning disable SYSLIB0011
                BinaryFormatter bf = new BinaryFormatter();
                #pragma warning restore SYSLIB0011
                agencia = bf.Deserialize(fs) as Agencia;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error al Deserializar el Archivo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                if (fs != null) fs.Close(); 
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream("datos.bin", FileMode.Create, FileAccess.Write);
                #pragma warning disable SYSLIB0011
                BinaryFormatter bf = new BinaryFormatter();
                #pragma warning restore SYSLIB0011
                bf.Serialize(fs, agencia);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al Serializar el Archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (fs != null) fs.Close();
            }

        }
    }
}
