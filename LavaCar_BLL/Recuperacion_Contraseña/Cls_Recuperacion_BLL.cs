using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LavaCar_DAL.Recuperacion;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Net.Mail;

namespace LavaCar_BLL.Recuperacion
{
    public class Cls_Recuperacion_BLL
    {
        public void EnviarCorreo(ref Cls_Recuperacion_DAL Obj_RECU_DAL)
        {
            
            Obj_RECU_DAL.SCadena = ConfigurationManager.ConnectionStrings[1].ConnectionString;
            Obj_RECU_DAL.Obj_Connec_DB = new SqlConnection(Obj_RECU_DAL.SCadena);
            Obj_RECU_DAL.Obj_Connec_DB.Open();

            Obj_RECU_DAL.SQuery = @"Select IdEmpleado, Email from Sch_Administrativo.T_Empleados where Identificacion = '" + Obj_RECU_DAL.SIdentificacion + "'";
            SqlCommand cmd = new SqlCommand(Obj_RECU_DAL.SQuery, Obj_RECU_DAL.Obj_Connec_DB);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                Obj_RECU_DAL.BIdEmpleado = dr.GetByte(0);
                Obj_RECU_DAL.SEmail = dr.GetString(1);
                dr.Close();
            }

            Obj_RECU_DAL.SQuery1 = @"Select Contraseña from Sch_Administrativo.T_Usuarios where IdEmpleado ='" + Obj_RECU_DAL.BIdEmpleado + "'";
            SqlCommand cmd1 = new SqlCommand(Obj_RECU_DAL.SQuery1, Obj_RECU_DAL.Obj_Connec_DB);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read() == true)
            {
                Obj_RECU_DAL.SContraseña = dr1.GetString(0);
            }

            
                Obj_RECU_DAL.Obj_Connec_DB.Dispose();

                MailMessage msg = new MailMessage();
                msg.To.Add(Obj_RECU_DAL.SEmail);
                msg.Subject = "Recuperación de Contraseña";
                msg.Body = "Su contraseña es: " + Obj_RECU_DAL.SContraseña;
                msg.From = new MailAddress("lavacar.octupus@gmail.com");
                SmtpClient clienteSmtp = new SmtpClient();

                clienteSmtp.Credentials = new System.Net.NetworkCredential("lavacar.octupus@gmail.com", "analisisnicolas");
                clienteSmtp.Port = 587;
                clienteSmtp.EnableSsl = true;

                clienteSmtp.Host = "smtp.gmail.com";

                try

                {

                    clienteSmtp.Send(msg);
                    Obj_RECU_DAL.SMsjConfirmacion = "El correo fue enviado exitosamente";
                    Obj_RECU_DAL.Obj_Connec_DB.Dispose();

                }

                catch (Exception ex)

                {

                    Console.Write(ex.Message);

                    Obj_RECU_DAL.Obj_Connec_DB.Dispose();


                }
            
            if (Obj_RECU_DAL.SEmail == "a")     
            {
                Obj_RECU_DAL.SMsjFallo = "Error al enviar el correo, por favor intente de nuevo";
                Obj_RECU_DAL.Obj_Connec_DB.Dispose();
            }
    }
}
}
