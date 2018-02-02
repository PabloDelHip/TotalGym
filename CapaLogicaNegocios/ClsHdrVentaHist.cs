using CapaAccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocios
{

    public class ClsHdrVentaHist
    {

        public int m_IdSocio { get; set; }
        public double m_Subtotal { get; set; }
        public double m_IVA { get; set; }
        public double m_Total{ get; set; }
        public string m_User_modif { get; set; }

        /**************Estructura*************/

        ClsManejador M = new ClsManejador();  // Referenciamos la clase para poder armar la estructura del SP
                                              // Checamos que exista el usuario

        public string guardarVenta()
        {
            string mensaje = "";
            List<ClsParametros> lst = new List<ClsParametros>();

            try
            {
                // armamos la clase para el cuerpo del procedimiento
                // Parametros de entrada
                lst.Add(new ClsParametros("@idSocio", m_IdSocio));
                lst.Add(new ClsParametros("@Subtotal", m_Subtotal));
                lst.Add(new ClsParametros("@IVA", m_IVA));
                lst.Add(new ClsParametros("@Total", m_Total));
                lst.Add(new ClsParametros("@User_modif", m_User_modif));

                /*Mensaje de salida*/
                lst.Add(new ClsParametros("@FolioVenta", SqlDbType.VarChar, 40));
                M.Ejecutar_sp("guardarVenta", lst);
                //Retornamos el mensaje  de salida del SP
                mensaje = lst[5].Valor.ToString();/////.valor 

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return mensaje;
        }
    }
}
