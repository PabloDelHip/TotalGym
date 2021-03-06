﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogicaNegocios;
using System.IO;
using System.Threading;
using System.Collections;
using System.Media;

namespace CapaPresentacion
{
    public partial class FrmMain : Form
    {
        ClsGeneral cls_generales = new ClsGeneral();
        ClsSocios cls_socios = new ClsSocios();
        ClsLockers cls_lockers = new ClsLockers();
        SoundPlayer sonido = new SoundPlayer();
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmOperacion form3 = new FrmOperacion();

            form3.MdiParent = this.MdiParent;

            form3.Show();
        }

        private void FrmSocios_Load(object sender, EventArgs e)
        {
            //Creamos el delegado 
            ThreadStart delegado = new ThreadStart(llamarServidor);
            //Creamos la instancia del hilo 
            Thread hilo = new Thread(delegado);
            //Iniciamos el hilo 
            hilo.Start();
            FrmOperacion abrir = new FrmOperacion();
            AbrirVentanas(abrir);

            /*******Enviar correo cumpleañeros********/
            DataTable dt = cls_socios.EnviarEmailCumpleañeros();

            if (dt.Rows.Count > 0)
            {
                ArrayList Correos = new ArrayList();
                string textoCorreo = "";
                string asunto = "";
                string respuestaM = "Correos a cumpleañeros enviado de forma correcta";
                string respuesta = "";

                foreach (DataRow filas in dt.Rows)
                {
                    Correos.Add(filas["Email"].ToString());
                    textoCorreo = filas["TextoCumpleAnos"].ToString();
                    asunto = filas["AsuntoCumpleanos"].ToString();
                }


                respuesta = cls_generales.EnviarCorreo(Correos, textoCorreo, asunto, respuestaM);
                MessageBox.Show(respuesta.ToString());
            }


        }

        private void nueviToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmOperacion abrir = new FrmOperacion();
            AbrirVentanas(abrir);
        }

        /***************************************/

        public void llamarServidor()
        {
            while (true)
            {
                int idSocio = Convert.ToInt32(cls_generales.Servidor());
                cls_lockers.m_idSocio = idSocio;
                string respuesta = cls_lockers.buscar_lockers_ocupados();
                if(respuesta.Equals("1"))
                {
                    sonido.Stream = Properties.Resources._02_01_04;
                    sonido.Play();
                }


                cls_socios.m_IdSocio = idSocio ;
                DataTable dt = cls_socios.DatosSocio();
                foreach (DataRow filas in dt.Rows)
                {
                   // MessageBox.Show(filas["Nombre"].ToString());

                    //txtNombre.Text = "hola";
                    //txtFechaVencimiento.Text = filas["Vencimiento"].ToString().Substring(0, 10);
                    byte[] imageBuffer = (byte[])filas["Foto"];
                    // Se crea un MemoryStream a partir de ese buffer
                    MemoryStream ms = new MemoryStream(imageBuffer);
                    // Se utiliza el MemoryStream para extraer la imagen
                    ptbImagenSocio.Image = Image.FromStream(ms);
                    
                }


            }
        }


        public void AbrirVentanas(Form abrir)
        {
           // int x = (pPrincipal.Width - abrir.Width) / 2, y = (pPrincipal.Height - abrir.Height) / 2;
            foreach (Control c in pPrincipal.Controls)
            {
                
                if (c.Name == abrir.Name)
                {
                   // c.Location = new Point(x, y);
                    c.BringToFront();
                    c.Show();
                    return;
                }
                
            }
            //abrir.Location = new Point(x, y);
            abrir.TopLevel = false;
            pPrincipal.Controls.Add(abrir);
            abrir.BringToFront();
            abrir.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void deudasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmOperacion abrir = new FrmOperacion();
            AbrirVentanas(abrir);
        }

        private void sociosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deudasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmDeudasSocios abrir = new FrmDeudasSocios();
            AbrirVentanas(abrir);
        }

        private void instructoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInstructores abrir = new FrmInstructores();
            AbrirVentanas(abrir);
        }

        private void entradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBusquedaEntradas abrir = new FrmBusquedaEntradas();
            AbrirVentanas(abrir);
        }

        private void textoDeEmailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTextoEmails abrir = new FrmTextoEmails();
            AbrirVentanas(abrir);
        }

<<<<<<< HEAD
        private void cortesDeCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCortesCaja abrir = new FrmCortesCaja();
            AbrirVentanas(abrir);
=======
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void corteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCorteSalida abrir = new FrmCorteSalida();
            abrir.ShowDialog();
>>>>>>> 5dbc4da04bb1d73c5fbba2efb04819f505d8e0b0
        }
    }
}
