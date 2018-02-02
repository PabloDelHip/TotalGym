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
using CapaPresentacion;



namespace CapaPresentacion
{
    public partial class FrmLogin : Form
    {
        Login ini = new Login();


        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void CmdLogin_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.ingresar_login;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.ingresar_login_1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ini.M_Login = TxtUsuario.Text;
            ini.M_Pass = TxtPassword.Text;
            DataTable dt = ini.buscarUsuario();

            int numeroFilas = dt.Rows.Count;

            if (numeroFilas == 1)
            {
                foreach (DataRow filas in dt.Rows)
                {
                    Login.idUsuario = Convert.ToInt32(filas["idUsuario"]);
                    Login.nombre = Convert.ToString(filas["Nombre"]);
                }

                this.Hide();
                //FrmObservacion abrir = new FrmObservacion();
                //abrir.Show();

                FrmCorteEntrada abrir = new FrmCorteEntrada();
                abrir.Show();
            }

            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Usuario no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtPassword.Text = "";
                TxtUsuario.Text = "";
                TxtUsuario.Focus();
            }
        }
    }
}
