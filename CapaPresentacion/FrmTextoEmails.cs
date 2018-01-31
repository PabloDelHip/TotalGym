using CapaLogicaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmTextoEmails : Form
    {
        public FrmTextoEmails()
        {
            InitializeComponent();
        }
        ClsTextoEmail cls_textoEmail = new ClsTextoEmail();
        private void FrmTextoEmails_Load(object sender, EventArgs e)
        {
            DataTable dt = cls_textoEmail.TextosEmails();
            foreach (DataRow filas in dt.Rows)
            {
                txtAsuntoAdeudos.Text = filas["AsuntoDeudas"].ToString();
                txtCuerpoAdeudos.Text = filas["TextoCorreo"].ToString();
                txtAsuntoCumpleañeros.Text = filas["AsuntoCumpleanos"].ToString();
                txtCuerpoCumpleañeros.Text = filas["TextoCumpleAnos"].ToString();
            }
        }

        private void btnModificarAdeudos_Click(object sender, EventArgs e)
        {
            txtAsuntoAdeudos.Enabled = true;
            txtCuerpoAdeudos.Enabled = true;
            btnGuardarAdeudos.Enabled = true;
        }

        private void btnModificarCumpleañeros_Click(object sender, EventArgs e)
        {
            txtAsuntoCumpleañeros.Enabled = true;
            txtCuerpoCumpleañeros.Enabled = true;
            btnGuardarCumpleañeos.Enabled = true;
        }

        private void btnGuardarAdeudos_Click(object sender, EventArgs e)
        {
            cls_textoEmail.m_AsuntoDeudas = txtAsuntoAdeudos.Text;
            cls_textoEmail.m_AsuntoCumpleanos = txtAsuntoCumpleañeros.Text;
            cls_textoEmail.m_TextoCorreo = txtCuerpoAdeudos.Text;
            cls_textoEmail.m_TextoCumpleAnos = txtCuerpoCumpleañeros.Text;
            string respuesta = cls_textoEmail.modificarTextosEmails();
            MessageBox.Show(respuesta);
            // codigo para probar la creacion del ticket solamente
            ClsCrearTicket t = new ClsCrearTicket();

            //apertura de caja
            //t.abreCajon();

            //datos de la cabecera
            t.textoCentrado("Gimnasio");
            t.textoIzquierda("EXPEDIDO EN: Cancun, Q Roo");
            t.textoIzquierda("DIRECION: Av Kabah");
            t.textoIzquierda("TELEFONO: 12345679");
            t.textoIzquierda("R.F.C: #########");
            t.textoIzquierda("E-MAIL: micorreo@midireccion.com");
            t.textoIzquierda(" ");
            t.textoExtremos("Caja # 1","Ticket # ");

            //sub cabecera
            t.textoIzquierda("");
            t.textoIzquierda("LE ATENDIO: Vendedor");
            t.textoIzquierda("CLIENTE: Publico en gral");
            t.textoIzquierda("");
            t.textoExtremos("FECHA: " + DateTime.Now.ToShortDateString(), "HORA: " + DateTime.Now.ToShortTimeString());
            t.lineasAsterisco();

            //cuerpo ...

            //texto final del ticket
            t.textoIzquierda("");
            t.textoCentrado("¡GRACIAS POR SU COMPRA!");
            t.textoIzquierda("");
            //t.cortarTicket();
            t.imprimirTicket("Microsoft XPS Document Writer");
        }

        private void btnGuardarCumpleañeos_Click(object sender, EventArgs e)
        {
            cls_textoEmail.m_AsuntoDeudas = txtAsuntoAdeudos.Text;
            cls_textoEmail.m_AsuntoCumpleanos = txtAsuntoCumpleañeros.Text;
            cls_textoEmail.m_TextoCorreo = txtCuerpoAdeudos.Text;
            cls_textoEmail.m_TextoCumpleAnos = txtCuerpoCumpleañeros.Text;
            string respuesta = cls_textoEmail.modificarTextosEmails();
            MessageBox.Show(respuesta);
        }
    }
}
