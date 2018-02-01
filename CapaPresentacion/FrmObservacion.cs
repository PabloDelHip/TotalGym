using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogicaNegocios;

namespace CapaPresentacion
{
    public partial class FrmObservacion : Form
    {
        ClsObservacionesCaja cls_observaciones_caja = new ClsObservacionesCaja();
        ClsGeneral cls_generales = new ClsGeneral();
        public FrmObservacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
           

            if(MessageBox.Show("¿Guardar obervacion y continuar?", "Continuar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ArrayList email = new ArrayList();
                email.Add("pablodelhip@gmail.com");

                foreach (string lista in email)
                {
                    MessageBox.Show(lista);
                }

                //cls_observaciones_caja.m_texto = txtTexto.Text;
                //cls_observaciones_caja.m_idUsuario = Login.idUsuario;
                //string respuesta = cls_observaciones_caja.agregarObservacion();
                //cls_generales.EnviarCorreo(email, txtTexto.Text,"Observaciones","");
                //MessageBox.Show(respuesta);
                //this.Hide();
                //FrmCorteEntrada abrir = new FrmCorteEntrada();
                //abrir.Show();
            }
        }

        private void FrmObservacion_Load(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
