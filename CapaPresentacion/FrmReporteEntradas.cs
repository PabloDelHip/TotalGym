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
    public partial class FrmReporteEntradas : Form
    {
        public int idSocio;
        public DateTime fechaInicioBusqueda;
        public DateTime fechaFinBusqueda;
        public FrmReporteEntradas()
        {
            InitializeComponent();
        }

        private void FrmReporteEntradas_Load(object sender, EventArgs e)
        {
     
        }

        private void FrmReporteEntradas_Load_1(object sender, EventArgs e)
        {
            CREntradas reporteEntradas = new CREntradas();
            reporteEntradas.SetParameterValue("@idSocio", idSocio);
            reporteEntradas.SetParameterValue("@FechaInicioBusqueda", fechaInicioBusqueda);
            reporteEntradas.SetParameterValue("@FechaFinBusqueda", fechaFinBusqueda);
            CRVreporteEntradas.ReportSource = reporteEntradas;
        }

        private void CRVreporteEntradas_Load(object sender, EventArgs e)
        {

        }
    }
}
