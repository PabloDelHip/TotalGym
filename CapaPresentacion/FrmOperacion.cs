using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using CapaAccesoDatos;
using CapaLogicaNegocios;
using System.IO;
using System.Threading;
using System.Media;

namespace CapaPresentacion
{
    public partial class FrmOperacion : Form
    {
        ClsGeneral cls_generales = new ClsGeneral();
        ClsSocios cls_socios = new ClsSocios();
        ClsLockers cls_lockers = new ClsLockers();
        ClsMembresias cls_membresias = new ClsMembresias();
        SoundPlayer sonido = new SoundPlayer(); 
        public FrmOperacion()
        {
            InitializeComponent();
        }

        private void FrmOperacion_Load(object sender, EventArgs e)
        {
            BuscarDispositivos();
            llenarComboMembresias();
            cboDispositivos.Visible = false;
            
        }
        private void txtSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void txtSoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        //*******************************  agregamos los controles para la camara

        private bool ExistenDispositivos = false;
    private FilterInfoCollection DispositivosDeVideo;
    private VideoCaptureDevice FuenteDeVideo = null;

    private void btnIniciar_Click(object sender, EventArgs e)
    {
            if (btnIniciar.Text == "Iniciar")
            {
                if (ExistenDispositivos)
                {
                    FuenteDeVideo = new VideoCaptureDevice(DispositivosDeVideo[cboDispositivos.SelectedIndex].MonikerString);
                    FuenteDeVideo.NewFrame += new NewFrameEventHandler(video_NuevoFrame);
                    FuenteDeVideo.Start();
                    btnIniciar.Text = "Tomar";
                    cboDispositivos.Enabled = false;
                    //gbMenu.Text = DispositivosDeVideo[cboDispositivos.SelectedIndex].Name.ToString();
                }
                else
                    MessageBox.Show("Error: No se encuentra dispositivo.");
            }
            else
            {
                if (FuenteDeVideo.IsRunning)
                {
                    TerminarFuenteDeVideo();
                    btnIniciar.Text = "Iniciar";
                    cboDispositivos.Enabled = true;
                }
            }
        }

    public void CargarDispositivos(FilterInfoCollection Dispositivos)
    {
        for (int i = 0; i < Dispositivos.Count; i++)
            cboDispositivos.Items.Add(Dispositivos[i].Name.ToString()); //cboDispositivos es nuestro combobox
        cboDispositivos.Text = cboDispositivos.Items[0].ToString();
    }

    public void BuscarDispositivos()
    {
        DispositivosDeVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        if (DispositivosDeVideo.Count == 0)
            ExistenDispositivos = false;
        else
        {
            ExistenDispositivos = true;
            CargarDispositivos(DispositivosDeVideo);
        }
    }

    public void TerminarFuenteDeVideo()
    {
        if (!(FuenteDeVideo == null))
            if (FuenteDeVideo.IsRunning)
            {
                FuenteDeVideo.SignalToStop();
                FuenteDeVideo = null;
            }
    }

    private void video_NuevoFrame(object sender, NewFrameEventArgs eventArgs)
    {
        Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
        pbFotoUser.Image = Imagen; //pbFotoUser es nuestro pictureBox
    }

    private void btnIniciar_Click_1(object sender, EventArgs e)
    {

    }

    private void cboDispositivos_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void TstCmdAgregarUsr_Click(object sender, EventArgs e)
    {
        
    }

    //FUNCION PARA CONVERTIR LA IMAGEN A BYTES

    public Byte[] Imagen_A_Bytes(String ruta)

    {

        FileStream foto = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.ReadWrite);

        Byte[] arreglo = new Byte[foto.Length];

        BinaryReader reader = new BinaryReader(foto);

        arreglo = reader.ReadBytes(Convert.ToInt32(foto.Length));

        return arreglo;

    }

    //FUNCION PARA CONVERTIR DE BYTES A IMAGEN

    public Image Bytes_A_Imagen(Byte[] ImgBytes)

    {

        Bitmap imagen = null;

        Byte[] bytes = (Byte[])(ImgBytes);

        MemoryStream ms = new MemoryStream(bytes);

        imagen = new Bitmap(ms);

        return imagen;

    }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (ChkForm_InsOGuardar())
            {
                ClsSocios Socio = new ClsSocios();
                string mens = "";
                

                // pasamos todos los datos a los parametros de la esctructura para ejecutar el SP AltaSocio
                Socio.m_Nombre = TxtSocio.Text;
                //Socio.m_IdSocio =
                Socio.m_FotoId = "fff";
                Socio.m_Direccion1 = TxtDireccion1.Text;
                Socio.m_Direccion2 = TxtDireccion2.Text;
                Socio.m_Email = TxtEmail.Text;
                Socio.m_Edad = "0";
                Socio.m_Telefono = mktCelular.Text;
                Socio.m_Sexo = RDsexoFem.Checked ? "F" : "M";
                Socio.m_TipoSocio = TxtTipoSocio.Text;

                Socio.m_Fingerprint = "vacio";
                //Socio.m_FechaIngreso = DtpFechaIngreso.Value;
                Socio.m_Vencimiento = DTPFechaVencHasta.Value;
                Socio.m_Observacion = "Observaciones";
                Socio.m_Indicaciones = "Indicaciones";
                Socio.m_User_modif = "Admin";
                Socio.m_FechaNacimiento = Convert.ToDateTime(mktFechaNacimiento.Text);
                // Asignando el valor de la imagen
                // Stream usado como buffer
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                // Se guarda la imagen en el buffer
                pbFotoUser.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                // Se extraen los bytes del buffer para asignarlos como valor para el parámetro.
                //ImgFoto =  ms.GetBuffer();
                //imagen = Convert.ToByte( ms.GetBuffer());
                Socio.m_Foto = ms.GetBuffer();

                //Parametros de salida
                TxtIdSocio.Text = Socio.InsSocio();
                if(!cbbLockers.Text.Equals(""))
                {
                    cargar_locker(Convert.ToInt32(TxtIdSocio.Text));
                }
               // mens = TxtIdSocio.Text;
                MessageBox.Show("Socio agregado de forma correcta");
            }



        }

        private void cargar_locker(int idSocio)
        {
            cls_lockers.m_idLocker = Convert.ToInt32(cbbLockers.SelectedValue.ToString());
            cls_lockers.m_Descripcion = "";
            cls_lockers.m_Sexo = 'M';
            cls_lockers.m_Status = 'S';
            cls_lockers.m_idSocio = idSocio;
            cls_lockers.numeroDias = 0;
            cls_lockers.Tipo = 1;
            cls_lockers.modificar_locker();
        }

        private void TSTxtBuscaSocio_Click(object sender, EventArgs e)
        {

        }

        private void TSTxtBuscaSocio_KeyDown(object sender, KeyEventArgs e)
        {
            ClsSocios Socio = new ClsSocios();
            DataTable dt = new DataTable();

            if ((int)e.KeyCode  == (int)Keys.Enter)
            {

                long NoSocio;
                NoSocio = Int64.Parse ( TSTxtBuscaSocio.Text);
                Socio.m_IdSocio = NoSocio;
                dt = Socio.RegresaSocio();
                if (dt.Rows.Count!=0)
                {

                    foreach (DataRow filas in dt.Rows)
                    {

                        // indice de columnas 
                        //IdSocio 0
                         TxtIdSocio.Text = filas["IdSocio"].ToString();
                        //[FotoId] 1
                        //[Fingerprint] 2
                        //[Nombre] 3
                        TxtSocio.Text= filas["Nombre"].ToString();
                        //[Direccion1] 4
                        TxtDireccion1.Text= filas["Direccion1"].ToString();
                        //[Direccion2] 5
                        TxtDireccion2.Text = filas["Direccion2"].ToString();
                        //[Email] 6
                        TxtEmail.Text= filas["Email"].ToString();
                        //[Edad] 7 
                        //[Telefono] 8 
                        mktCelular.Text= filas["Telefono"].ToString();
                        //,[Sexo] 9
                        string Sexo;
                        Sexo = filas["Sexo"].ToString();
                        if (Sexo == "F")
                        {
                            RDsexoFem.Checked = true;
                            RDmasculino.Checked = false;
                        }
                        else
                        {
                            RDsexoFem.Checked = false;
                            RDmasculino.Checked = true;
                        }

                        //[TipoSocio] 10
                        //[FechaIngreso] 11
                        //DtpFechaIngreso.Text= filas["FechaIngreso"].ToString();
                        //[Indicaciones] 12
                        //[DiasViajero] 13
                        //[Vencimiento_prev] 14
                        //[Vencimiento] 15

                        //[Observacion] 16
                        //[Fecha_modif] 17
                        //[User_modif] 18
                        //[Foto] 19
                        byte[] imageBuffer = (byte[])filas["Foto"];
                        // Se crea un MemoryStream a partir de ese buffer
                        MemoryStream ms = new MemoryStream(imageBuffer);
                        // Se utiliza el MemoryStream para extraer la imagen
                        //PbFotoSocio.Image = Image.FromStream(ms);
                        pbFotoUser.Image = Image.FromStream(ms);

                        //[fechaNacimiento] 20
                        //DTPFechaNac.Text = filas["fechaNacimiento"].ToString();
                        mktFechaNacimiento.Text = filas["fechaNacimiento"].ToString();
                    }
                }
                else MessageBox.Show("  Socio no encontrado ");
            }
        }
            // First method: Convert Image to byte[] array:
            public byte[] imageToByteArray(System.Drawing.Image imageIn)
            {
                MemoryStream ms = new MemoryStream();
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                return ms.ToArray();
            }
            // Second method: Convert byte[] array to Image:
            public Image byteArrayToImage(byte[] byteArrayIn)
            {
                MemoryStream ms = new MemoryStream(byteArrayIn);
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }

        private void TsLimpiaForm_Click(object sender, EventArgs e)
        {
            LimpiaFormulario();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        private void LimpiaFormulario()
        {
            DateTime thisDay = DateTime.Today;
            TxtIdSocio.Text = "";
            TxtSocio.Text = "";
            TxtDireccion1.Text = "";
            TxtDireccion2.Text = "";
            TxtEmail.Text = "";
            mktCelular.Text = "";
            //DtpFechaIngreso.Text = "";
            //DTPFechaNac.Value  = thisDay;
            mktFechaNacimiento.Text = "";
            //DtpFechaIngreso.Value = thisDay;
            //PbFotoSocio.Image = null;
            pbFotoUser.Image = null;
        }

        public bool ChkForm_InsOGuardar()
        {
            Boolean bandera = false;
            // Si el picturebox DEL SOCIO esta vacio,  el chkform marca falso para no continuar
            if (pbFotoUser.Image == null) {
                bandera = false;
                MessageBox.Show("     ¡ NO SE HA ASIGNADO UNA FOTO AL SOCIO ! \n  -POR FAVOR TOME LA FOTO ANTES DE CONTINUAR- ");
            }
            else  bandera = true;  // HA PASADO EL FILTRO DE LA FOTO



            return  bandera;
        }

        private void mktCelular_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void mktCelular_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola");
            mktCelular.Focus();
        }

        private void RDmasculino_CheckedChanged(object sender, EventArgs e)
        {
            //llama al metodo para llevar el combo de los lockers
            seleccionar_locker(1);
        }

        private void RDsexoFem_CheckedChanged(object sender, EventArgs e)
        {
            //llama al metodo para llevar el combo de los lockers
            seleccionar_locker(2);
        }

        private void seleccionar_locker(int tipoBusqueda)
        {
                //se le asigna un valor a la variable tipo que se encarga de
                //seleccionar el tipo de busqueda en el SP
                cls_lockers.Tipo = tipoBusqueda;
                //se llama al metodo  donde esta la accion de SP
                DataTable dt = cls_lockers.verLockers();
                //se llena el datasoucer con lo que regreso el SP
                cbbLockers.DataSource = dt;
                //se coloca el indice o option en web
                cbbLockers.ValueMember = "idLocker";
                //se coloca el valor del combo
                cbbLockers.DisplayMember = "Descripcion";
                cbbLockers.Text = "";
        }

        private void llenarComboMembresias()
        {
            //se llama al metodo  donde esta la accion de SP
            cls_membresias.m_idMembresia = 0;
            cls_membresias.Tipo = 1;
            DataTable dt = cls_membresias.seleccionarMembresias();
            //se llena el datasoucer con lo que regreso el SP
            cbbMembresia.DataSource = dt;
            //se coloca el indice o option en web
            cbbMembresia.ValueMember = "idMembresia";
            //se coloca el valor del combo
            cbbMembresia.DisplayMember = "Descripcion";
            cbbMembresia.Text = "";
        }

        private void cbbLockers_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(!cbbLockers.Text.Equals(""))
            {
                //txtnumDias.Enabled = true;
            }
            else
            {
                //txtnumDias.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void cbbMembresia_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cbbMembresia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (!cbbMembresia.Equals(""))
            {
                MessageBox.Show(cbbMembresia.SelectedValue.ToString());
                cls_membresias.m_idMembresia = Convert.ToInt32(cbbMembresia.SelectedValue.ToString());
                cls_membresias.Tipo = 2;
                DataTable dt = cls_membresias.seleccionarMembresias();
                foreach (DataRow filas in dt.Rows)
                {

                    int rowEscribir = Convert.ToInt32(dataGridView2.Rows.Count) - 1;
                    //se agrega una nueva fila donde van a ir los datos
                    dataGridView2.Rows.Add(1);
                    //se agregan los datos
                    dataGridView2.Rows[rowEscribir].Cells[0].Value = filas["Descripcion"].ToString();
                    dataGridView2.Rows[rowEscribir].Cells[1].Value = filas["Costo"].ToString();


                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sonido.Stream = Properties.Resources._02_01_04;
            sonido.Play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FuenteDeVideo.Stop();
            pbFotoUser.Image = null;
            btnIniciar.Text = "Iniciar";

        }
    }
    }
