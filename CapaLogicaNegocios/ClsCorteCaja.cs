﻿using CapaAccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocios
{
    public class ClsCorteCaja
    {
        public string m_Supervisor { get; set; }
        public DateTime m_FechaHora { get; set; }
        public int m_idMovimiento { get; set; }
        public int m_entrada { get; set; }
        public int m_salida { get; set; }
        public int m_idUsuario { get; set; }
        public double m_cantidad { get; set; }
        public double m_cantidadCorte { get; set; }
        public int m_cajaCerrada { get; set; }

        ClsManejador M = new ClsManejador();

        public string movimientoCorteCajaEntrada()
        {
            string respuesta= "";
            List<ClsParametros> lst = new List<ClsParametros>();

            try
            {
                // armamos la clase para el cuerpo del procedimiento
                // Parametros de entrada
                lst.Add(new ClsParametros("@idUsuario", m_idUsuario));
                lst.Add(new ClsParametros("@cantidad", m_cantidad));

                /*Mensaje de salida*/
                lst.Add(new ClsParametros("@respuesta", SqlDbType.VarChar, 40));
                M.Ejecutar_sp("movimiento_corte_caja_entrada", lst);
                //Retornamos el mensaje  de salida del SP
                respuesta = lst[2].Valor.ToString();/////.valor 

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return respuesta;
        }

        public string cerrarCaja()
        {
            
            List<ClsParametros> lst = new List<ClsParametros>();

            try
            {
                // armamos la clase para el cuerpo del procedimiento
                // Parametros de entrada
                lst.Add(new ClsParametros("@Supervisor", m_Supervisor));
                lst.Add(new ClsParametros("@cantidadCorte", m_cantidadCorte));
                M.Ejecutar_sp("cerrar_caja", lst);

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return "";
        }
    }
}
