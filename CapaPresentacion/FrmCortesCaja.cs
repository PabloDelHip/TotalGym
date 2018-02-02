using System;
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
   
    public partial class FrmCortesCaja : Form
    {
        string idUsuario;
        DateTime fecha;
        public int opcion = 0;

        ClsMovCortesCaja cls_MovCortesCaja = new ClsMovCortesCaja();
        FrmReporteMovCaja frmReporteCaja = new FrmReporteMovCaja();
        public FrmCortesCaja()
        {
            InitializeComponent();
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
        private void validarTextBoxID(object sender, EventArgs e)
        {
            if (txtUsuario.Text != null)
            {
                btnBuscarxID.Enabled = true;
                btnBuscarxFecha.Enabled = false;
            }
            else
            {
                MessageBox.Show("No pueden estar los campos vacios para realizar la busqueda");
            }
        }
        private void validarDateTimePickerFecha(object sender, EventArgs e)
        {
            if (dtpFecha.Value != null)
            {
                btnBuscarxFecha.Enabled = true;
                btnBuscarxID.Enabled = false;
            }
            else
            {
                MessageBox.Show("No pueden estar los campos vacios para realizar la busqueda");
            }
        }

        private void btnBuscarxFecha_Click(object sender, EventArgs e)
        {
            try
            {
                cls_MovCortesCaja.m_FechaHora = dtpFecha.Value;
                DataTable dt = cls_MovCortesCaja.buscarCortesCajaXFecha();
                dgvMovimientos.DataSource = dt;
                btnGenerarReporte.Enabled = true;
                opcion = 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnBuscarxID_Click(object sender, EventArgs e)
        {
            try
            {
                cls_MovCortesCaja.m_idUsuario = Convert.ToInt32(txtUsuario.Text);
                DataTable dt = cls_MovCortesCaja.buscarCortesCajaXUsuario();
                dgvMovimientos.DataSource = dt;
                btnGenerarReporte.Enabled = true;
                opcion = 2;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            //reporteEntradas.idSocio = Convert.ToInt32(txtSocio.Text);
            //reporteEntradas.fechaInicioBusqueda = dtpInicioBusqueda.Value;
            //reporteEntradas.fechaFinBusqueda = dtpFinBusqueda.Value;
            frmReporteCaja.ShowDialog();
        }
    }
}
