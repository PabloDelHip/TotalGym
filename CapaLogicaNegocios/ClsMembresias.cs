using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using System.Data;

namespace CapaLogicaNegocios
{
   public class ClsMembresias
   {
        public int m_idMembresia { get; set; }
        public int Tipo { get; set; }
        ClsManejador M = new ClsManejador();

        public DataTable seleccionarMembresias()
        {
            List<ClsParametros> lst = new List<ClsParametros>();
            lst.Add(new ClsParametros("@Tipo", Tipo));
            lst.Add(new ClsParametros("@IdMembresia", m_idMembresia));
            return M.Listado("select_membresias", lst);
        }
   }
}
