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
        ClsLogin ini = new ClsLogin();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void CmdLogin_Click(object sender, EventArgs e)
        {
            //string usu="";
            //string pass="";
            string res="";

            ini.M_Login = TxtUsuario.Text;
            ini.M_Pass = TxtPassword.Text;
            //  res = ini.ExisteUsr();
            res = ini.ExisteUsr();

            if (res=="1")
                {
                //MessageBox.Show(" Usuario encontrado");
                this.Hide();
                FrmMain frm = new FrmMain();
                frm.Show();
                }
            else
                MessageBox.Show(" Usuario no encontrado");

            // FrmPrincipal FormInicial = new FrmPrincipal();
            // FormInicial.Show();
            // this.Hide();

        }
        


    }
}
