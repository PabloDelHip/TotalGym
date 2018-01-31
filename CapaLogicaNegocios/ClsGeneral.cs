using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocios
{
    public class ClsGeneral
    {
        public string Servidor()
        {
            string idSocio="";
                Socket miPrimerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                // paso 2 - creamos el socket

                IPEndPoint miDireccion = new IPEndPoint(IPAddress.Any, 1234);
                byte[] ByRec;
            //paso 3 -IPAddress.Any significa que va a escuchar al cliente en toda la red

            try

            {



                // paso 4

                miPrimerSocket.Bind(miDireccion); // Asociamos el socket a miDireccion

                miPrimerSocket.Listen(1); // Lo ponemos a escucha

                Socket Escuchar = miPrimerSocket.Accept();

                //creamos el nuevo socket, para comenzar a trabajar con él

                //La aplicación queda en reposo hasta que el socket se conecte a el cliente

                //Una vez conectado, la aplicación sigue su camino 

                Console.WriteLine("Conectado con exito");
                

                ByRec = new byte[255];
                int a = Escuchar.Receive(ByRec, 0, ByRec.Length, 0);
                Array.Resize(ref ByRec, a);
                //MessageBox.Show(Encoding.Default.GetString(ByRec));
                idSocio = Convert.ToString(Encoding.Default.GetString(ByRec));
                miPrimerSocket.Close(); //Luego lo cerramos



            }

            catch (Exception error)

            {
                throw error;
                    //Console.WriteLine("Error: {0}", error.ToString());

                }
            return idSocio;

        }

        public string EnviarCorreo(ArrayList correos, string textoCorreo,string asunto,string respuestaEmail)
        {
            string respuesta = "";

            try
            {
                System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();

                //Direccion de correo electronico a la que queremos enviar el mensaje
                foreach (string lista in correos)
                {
                    mmsg.To.Add(lista);
                }

                //Nota: La propiedad To es una colección que permite enviar el mensaje a más de un destinatario

                //Asunto
                mmsg.Subject = asunto;
                mmsg.SubjectEncoding = System.Text.Encoding.UTF8;

                //Direccion de correo electronico que queremos que reciba una copia del mensaje
                // mmsg.Bcc.Add("destinatariocopia@servidordominio.com"); //Opcional

                //Cuerpo del Mensaje
                mmsg.Body = textoCorreo;
                mmsg.BodyEncoding = System.Text.Encoding.UTF8;
                mmsg.IsBodyHtml = false; //Si no queremos que se envíe como HTML

                //Correo electronico desde la que enviamos el mensaje
                mmsg.From = new System.Net.Mail.MailAddress("cotizador@trueatwork.com");


                /*-------------------------CLIENTE DE CORREO----------------------*/

                //Creamos un objeto de cliente de correo
                System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();

                //Hay que crear las credenciales del correo emisor
                cliente.Credentials =
                    new System.Net.NetworkCredential("cotizador@trueatwork.com", "Cancun17");

                //Lo siguiente es obligatorio si enviamos el mensaje desde Gmail

                cliente.Port = 587;
                cliente.EnableSsl = true;


                cliente.Host = "smtp.1and1.com"; //Para Gmail "smtp.gmail.com";
                //Enviamos el mensaje      
                cliente.Send(mmsg);
                respuesta = respuestaEmail;
            }
            catch (System.Net.Mail.SmtpException ex)
            {
                //Aquí gestionamos los errores al intentar enviar el correo
                respuesta = ex.ToString();
            }

            return respuesta;
        }
    }
}
