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
    public partial class FrmCorteEntrada : Form
    {
        ClsCorteCaja cls_corte_caja = new ClsCorteCaja();
        public FrmCorteEntrada()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Dinero en caja entrada: "+txtDineroCaja.Text+"\n¿Continuar?", "Continuar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                double dineroEntrada = Convert.ToDouble(txtDineroCaja.Text); 
                cls_corte_caja.m_idUsuario = Login.idUsuario;
                cls_corte_caja.m_cantidad = dineroEntrada;
                string respuesta = cls_corte_caja.movimientoCorteCajaEntrada();
                MessageBox.Show(respuesta);
                Login.dineroEntrada = dineroEntrada;
                this.Hide();
                FrmMain abrir = new FrmMain();
                abrir.Show();
                
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtDineroCaja_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
