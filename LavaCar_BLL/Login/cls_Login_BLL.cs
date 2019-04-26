using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using LavaCar_DAL.Login;

namespace LavaCar_BLL.Login
{
    public class cls_Login_BLL
    {
        public void Ingresar(ref cls_Login_DAL Obj_Login_DAL)
        {
            try
            {
                if (Obj_Login_DAL.SUsuario != "USUARIO" && Obj_Login_DAL.SContrasena != "CONTRASEÑA")
                {
                    Obj_Login_DAL.SCadena = ConfigurationManager.ConnectionStrings[1].ConnectionString;
                    Obj_Login_DAL.Obj_Connec_DB = new SqlConnection(Obj_Login_DAL.SCadena);
                    Obj_Login_DAL.Obj_Connec_DB.Open();

                    Obj_Login_DAL.SQuery = @"Select IdUsuario, Contraseña, IdRole, IdEstado from Sch_Administrativo.T_Usuarios where IdUsuario = '" + Obj_Login_DAL.SUsuario + "' and Contraseña='" + Obj_Login_DAL.SContrasena + "'";
                    SqlCommand cmd = new SqlCommand(Obj_Login_DAL.SQuery, Obj_Login_DAL.Obj_Connec_DB);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read() == true)
                    {
                        Obj_Login_DAL.SUsuario = dr.GetString(0);
                        Obj_Login_DAL.SContrasena = dr.GetString(1);
                        Obj_Login_DAL.BIdRole = dr.GetByte(2);
                        Obj_Login_DAL.SIdEstado = dr.GetString(3);
                    }
                    Obj_Login_DAL.Obj_Connec_DB.Close();
                }
                if (Obj_Login_DAL.SUsuario != "A")
                {
                    Obj_Login_DAL.SMsj = "Usuario Inactivo, por favor contactar al administrador";
                }
                if (Obj_Login_DAL.BIdRole == 0)
                {
                    Obj_Login_DAL.SMsj = "Datos incorrectos, por favor ingrese nuevamente";
                }
                Obj_Login_DAL.Obj_Connec_DB.Dispose();
            }
            catch (Exception ex)
            {

                Obj_Login_DAL.SMsjError = Convert.ToString(ex);
            }
           
            
            
        }
    }
}
