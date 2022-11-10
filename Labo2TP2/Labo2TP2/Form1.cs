using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Labo2TP2
{
    public partial class Form1 : Form
    {
        public Form1()
        { InitializeComponent(); }
        Empresa empresa;
        double precioBase = 0;    //DONDE SE USA ESTO? 
        //testeado
        #region Deserialize
        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream fs = null;
            BinaryFormatter bf;
            try
            {
                fs = new FileStream(Application.StartupPath + @"\Save.txt", FileMode.OpenOrCreate, FileAccess.Read);
                if (fs.Length > 0)
                {
                    bf = new BinaryFormatter();
                    empresa = (Empresa)bf.Deserialize(fs);
                }
                else empresa = new Empresa();
            }
            catch (IOException io)
            {
                MessageBox.Show(io.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }
        #endregion

        //testear este (descomentar el performClick())
        #region Serialize
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //guardarProgresoToolStripMenuItem.PerformClick(); //descomentar
        }
        private void guardarProgresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = null;
            BinaryFormatter bf;
            try
            {
                string path = Application.StartupPath + @"\Save.txt";
                if (File.Exists(path))
                    File.Delete(path);
                fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                bf = new BinaryFormatter();
                bf.Serialize(fs, empresa);
            }
            catch (IOException io)
            {
                MessageBox.Show(io.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //fs.Close(); //tira excepcion wtf
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }
        #endregion
        

        //Sin testear
        #region Botones "VER" del menu de arriba
        
        #region VerListaAlojamientos
        private void alojamientosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (empresa.ListaHospedajes.Count > 0)
            {
                foreach (Hospedaje h in empresa.ListaHospedajes)
                {
                    listBox1.Items.Add(h); //trabajamos directo con el obj
                }
            }
        }
        #endregion

        #region VerListaReservas
        private void reservasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (empresa.ListaReservas.Count > 0)
            {
                foreach (Reserva h in empresa.ListaReservas)
                {
                    listBox1.Items.Add(h);
                }
            }
        }
        #endregion

        #region VerListaClientes
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (empresa.ListaClientes.Count > 0)
            {
                foreach (Cliente h in empresa.ListaClientes)
                {
                    listBox1.Items.Add(h);
                }
            }
        }
        #endregion

        #endregion

        //Sin testear
        #region BotonReserva

        private void btnForm1Reservar(object sender, EventArgs e)
        {
            FormReserva formReserva = new FormReserva();

            if (empresa.ListaReservas.Count == 0)
            {
                if (formReserva.ShowDialog() == DialogResult.OK)
                {
                    int nroHab = (Int32)formReserva.numNroHab.Value;
                    int numHuespedes = (Int32)formReserva.numHuespedes.Value;
                    int diasAlq = monthCalendar1.SelectionEnd.Day - monthCalendar1.SelectionStart.Day;

                    empresa.Reservar(empresa.ListaHospedajes[listBox1.SelectedIndex], nroHab, numHuespedes, formReserva.cbCliente.SelectedIndex,
                    monthCalendar1.SelectionStart, diasAlq, monthCalendar1.SelectionStart, monthCalendar1.SelectionEnd);
                }
            }

            else
            {
                foreach (Reserva r in empresa.ListaReservas)
                {
                    //FormReserva formReserva = new FormReserva();

                    if (formReserva.ShowDialog() == DialogResult.OK)
                    {

                        if (DateTime.Compare(r.CheckOut, monthCalendar1.SelectionStart) < 0 || DateTime.Compare(r.CheckIn, monthCalendar1.SelectionEnd) > 0)
                        {
                            int nroHab = (Int32)formReserva.numNroHab.Value;
                            int numHuespedes = (Int32)formReserva.numHuespedes.Value;
                            int diasAlq = monthCalendar1.SelectionEnd.Day - monthCalendar1.SelectionStart.Day;

                            empresa.Reservar(empresa.ListaHospedajes[listBox1.SelectedIndex], nroHab, numHuespedes, formReserva.cbCliente.SelectedIndex,
                            monthCalendar1.SelectionStart, diasAlq, monthCalendar1.SelectionStart, monthCalendar1.SelectionEnd);
                        }

                        #region Errores de reserva

                        // check in < selection start < check out
                        if (DateTime.Compare(r.CheckIn, monthCalendar1.SelectionStart) < 0 && DateTime.Compare(r.CheckOut, monthCalendar1.SelectionStart) > 0)
                        {
                            MessageBox.Show("Error, chocan las fechas,  la reserva nueva empieza antes que la anterior termine.");
                        }

                        // check in < selection end < check out 
                        if (DateTime.Compare(r.CheckIn, monthCalendar1.SelectionEnd) < 0 && DateTime.Compare(r.CheckOut, monthCalendar1.SelectionEnd) > 0)
                        {
                            MessageBox.Show("Error, chocan las fechas , la reserva nueva finaliza antes que la anterior termine.");
                        }

                        // check in < selection start  &&  selection end < check out
                        if (DateTime.Compare(r.CheckIn, monthCalendar1.SelectionStart) < 0 && DateTime.Compare(r.CheckOut, monthCalendar1.SelectionEnd) > 0)
                        {
                            MessageBox.Show("Error, chocan las fechas , la reserva nueva empieza y finaliza durante la reserva anterior.");
                        }

                        //  selection start < check in  &&  check out < selection end 
                        if (DateTime.Compare(r.CheckIn, monthCalendar1.SelectionStart) > 0 && DateTime.Compare(r.CheckOut, monthCalendar1.SelectionEnd) < 0)
                        {
                            MessageBox.Show("Error, chocan las fechas , la reserva vieja empieza y finaliza durante la reserva nueva.");
                        }
                        #endregion
                    }
                }
            
            }
        }
        #endregion

        //Sin testear
        #region Alta De Hospedaje
        private void altaToolStripMenuItem_Click(object sender, EventArgs e) //btn ALOJAMIENTOS - ALTA
        {
            FormCargaPropiedad formCarga = new FormCargaPropiedad();
            if (formCarga.ShowDialog() == DialogResult.OK)
            {
                Hospedaje propiedad = null;

                string dir = formCarga.tbDireccion.Text;
                int nroProp = (int)formCarga.numNroProp.Value;
                //imagen
                if (formCarga.rbHotel.Checked)
                {
                    int estrellas = 0;
                    if (formCarga.rb2estrellas.Checked)
                        estrellas = 2;
                    if (formCarga.rb3estrellas.Checked)
                        estrellas = 3;
                    int[] habitaciones = { (int)formCarga.numSimple.Value,
                                               (int)formCarga.numDobles.Value,
                                               (int)formCarga.numTriples.Value
                        };

                    string nombre = formCarga.tbNombre.Text;

                    propiedad = new Hotel(estrellas, nombre, habitaciones, nroProp, dir, precioBase);
                }

                else if (formCarga.rbCasa.Checked)
                {
                    bool cochera = formCarga.cbCochera.Checked;
                    bool desayuno = formCarga.cbDesayuno.Checked;
                    bool limpieza = formCarga.cbLimpieza.Checked;
                    bool mascota = formCarga.cbMascota.Checked;
                    bool pileta = formCarga.cbPileta.Checked;
                    bool wifi = formCarga.cbWifi.Checked;
                    int camas = (int)formCarga.numCamas.Value;
                    int dias = (int)formCarga.numDias.Value;

                    propiedad = new Casa(dias, camas, cochera, pileta, limpieza, wifi, desayuno, mascota, precioBase, dir, nroProp);
                }

                //aca viene la magia loca de las imagenes, seleccionando mas de una en el mismo fileDialog
                if (MessageBox.Show("Desea agregar fotos?", "Fotos", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    FormImagenes Fimagen = new FormImagenes();
                    Bitmap[] img = null;
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string[] str = openFileDialog1.FileNames;
                        img = new Bitmap[str.Length];
                        for (int i = 0; i < str.Length; i++)
                            img[i] = new Bitmap(str[i]);
                        Fimagen.imageList1.Images.AddRange(img);
                    }
                    propiedad.AgregarImagenes(img);
                    //Fimagen.ShowDialog();
                }
                empresa.AgregarHospedaje(propiedad);
            }
        }
        #endregion

        // Ya quedo no tocar (podria mejorarse y NO crear un nuevo obj)
        #region Modificar Hospedaje
        private void modificarToolStripMenuItem_Click_1(object sender, EventArgs e) 
        {
            try
            {
                FormCargaPropiedad formCarga = new FormCargaPropiedad();
                formCarga.Text = "Modificar Propiedad";
                formCarga.button1.Text = "Modificar";
                if (empresa.ListaHospedajes[listBox1.SelectedIndex] is Casa)
                {
                    Casa c = (Casa)empresa.ListaHospedajes[listBox1.SelectedIndex];
                    formCarga.tbDireccion.Text = c.Direccion;
                    formCarga.numNroProp.Value = c.NroPropiedad;
                    formCarga.cbCochera.Checked = c.Cochera;
                    formCarga.cbDesayuno.Checked = c.Desayuno;
                    formCarga.cbLimpieza.Checked = c.Limpieza;
                    formCarga.cbMascota.Checked = c.Mascotas;
                    formCarga.cbPileta.Checked = c.Pileta;
                    formCarga.cbWifi.Checked = c.Wifi;
                    formCarga.numCamas.Value = c.CantidadCamas;
                    formCarga.numDias.Value = c.DiasMinimos;
                }
                else
                {
                    Hotel h = (Hotel)empresa.ListaHospedajes[listBox1.SelectedIndex];
                    formCarga.tbDireccion.Text = h.Direccion;
                    formCarga.numNroProp.Value = h.NroPropiedad;
                    formCarga.tbNombre.Text = h.Nombre;
                    if (h.Estrellas == 2)
                        formCarga.rb2estrellas.Checked = true;
                    else
                        formCarga.rb3estrellas.Checked = true;

                    formCarga.numSimple.Value = h.cantHabitaciones[0];
                    formCarga.numDobles.Value = h.cantHabitaciones[1];
                    formCarga.numTriples.Value = h.cantHabitaciones[2];
                }
                if (formCarga.ShowDialog() == DialogResult.OK)
                {
                    Hospedaje propiedad = null;

                    string dir = formCarga.tbDireccion.Text;
                    int nroProp = (int)formCarga.numNroProp.Value;
                    //imagen
                    if (formCarga.rbHotel.Checked)
                    {
                        int estrellas = 0;
                        if (formCarga.rb2estrellas.Checked)
                            estrellas = 2;
                        if (formCarga.rb3estrellas.Checked)
                            estrellas = 3;

                        int[] habitaciones = { (int)formCarga.numSimple.Value,
                                               (int)formCarga.numDobles.Value,
                                               (int)formCarga.numTriples.Value
                        };
                        string nombre = formCarga.tbNombre.Text;

                        propiedad = new Hotel(estrellas, nombre, habitaciones, nroProp, dir, precioBase);
                    }

                    else if (formCarga.rbCasa.Checked)
                    {
                        bool cochera = formCarga.cbCochera.Checked;
                        bool desayuno = formCarga.cbDesayuno.Checked;
                        bool limpieza = formCarga.cbLimpieza.Checked;
                        bool mascota = formCarga.cbMascota.Checked;
                        bool pileta = formCarga.cbPileta.Checked;
                        bool wifi = formCarga.cbWifi.Checked;
                        int camas = (int)formCarga.numCamas.Value;
                        int dias = (int)formCarga.numDias.Value;

                        propiedad = new Casa(dias, camas, cochera, pileta, limpieza, wifi, desayuno, mascota, precioBase, dir, nroProp);
                    }
                    empresa.ModificarHospedaje(listBox1.SelectedIndex, propiedad); //index del lView o lBox
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        #endregion

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {


            //if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    //img[0] = new Bitmap(openFileDialog1.FileName);
            //}

            //FormImagenes Fimagen = new FormImagenes();
            ////Fimagen.imageList1.Images.AddRange(img);
            //Fimagen.ShowDialog();
        }

        #region Modificar Cliente
        private void modificarClienteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //buscar cliente segun posicion a traves del listbox
            FormClientes frmClientes = new FormClientes();
            frmClientes.textBox1.Text = empresa.ListaClientes[listBox1.SelectedIndex].Nombre;
            frmClientes.textBox2.Text = empresa.ListaClientes[listBox1.SelectedIndex].Apellido;
            frmClientes.textBox3.Text = empresa.ListaClientes[listBox1.SelectedIndex].Mail;
            frmClientes.textBox4.Text = empresa.ListaClientes[listBox1.SelectedIndex].Celular;
            frmClientes.textBox5.Text = empresa.ListaClientes[listBox1.SelectedIndex].CodigoArea;
            frmClientes.textBox6.Text = empresa.ListaClientes[listBox1.SelectedIndex].Dni;
            if (frmClientes.ShowDialog() == DialogResult.OK)
            {
                Cliente clt = new Cliente(frmClientes.textBox1.Text, frmClientes.textBox2.Text,
                                            frmClientes.textBox3.Text, frmClientes.textBox4.Text,
                                            frmClientes.textBox5.Text, frmClientes.textBox6.Text);
                empresa.ListaClientes[listBox1.SelectedIndex] = clt;
            }
        } 
        #endregion


        //FALTA CODIFICAR
        #region Boton "BUSCAR"

        private void button2_Click(object sender, EventArgs e)
        {

        } 
        #endregion




        private void registrarNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                if (MessageBox.Show("Seguro desea borrar el item seleccionado?", "Borrar", MessageBoxButtons.YesNo)
                    == DialogResult.Yes)
                {
                    empresa.DarDeBaja((Object)listBox1.SelectedItem);
                }
            }
            else MessageBox.Show("Debe seleccionar un item");
            listBox1.Items.Clear();
        }
    }
}
