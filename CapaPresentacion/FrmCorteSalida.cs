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
    public partial class FrmCorteSalida : Form
    {
        ClsCorteCaja cls_corte_caja = new ClsCorteCaja();
        public FrmCorteSalida()
        {
            InitializeComponent();
        }

        private void FrmCorteSalida_Load(object sender, EventArgs e)
        {

            txtDineroEntrada.Text = Login.dineroEntrada.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double dineroCaja = Convert.ToDouble(txtDineroEntrada.Text);
            double dineroSalida = Convert.ToDouble(txtDineroSalida.Text);
            cls_corte_caja.m_Supervisor = "supervisor";
            cls_corte_caja.m_cantidadCorte = dineroSalida;

            if (dineroCaja > dineroSalida)
            {
                MessageBox.Show("el dinero es menor");
            }

            else if(dineroCaja<=dineroSalida)
            {
                MessageBox.Show("dinero correcto");
                cls_corte_caja.cerrarCaja();
                MessageBox.Show("bien");
            }
        }
    }
}
