using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LavaCar_DAL.Login;
using System.Configuration;
using System.Data.SqlClient;

namespace LavaCar_BLL.Cat_Mant
{
    public class cls_Cambio_Contraseña
    {
        public void CambiarContraseña(ref cls_Login_DAL obj_Login_DAL)
        {
            obj_Login_DAL.SCadena = ConfigurationManager.ConnectionStrings[1].ConnectionString;
            obj_Login_DAL.Obj_Connec_DB = new SqlConnection(obj_Login_DAL.SCadena);
            obj_Login_DAL.Obj_Connec_DB.Open();

            obj_Login_DAL.SQuery = @"Select Contraseña from Sch_Administrativo.T_Usuarios where IdUsuario = '" + obj_Login_DAL.SUsuario + "'";
            SqlCommand cmd1 = new SqlCommand(obj_Login_DAL.SQuery, obj_Login_DAL.Obj_Connec_DB);
            SqlDataReader dr = cmd1.ExecuteReader();


            if (dr.Read() == true)
            {
                obj_Login_DAL.SContrasena = dr.GetString(0);

            }
            if (obj_Login_DAL.SContrasena == obj_Login_DAL.SContraseñaActual)
            {
                dr.Close();
                SqlCommand cmd = new SqlCommand("update Sch_Administrativo.T_Usuarios set Contraseña=@contraseña where IdUsuario=@IdUsuario", obj_Login_DAL.Obj_Connec_DB);
                cmd.Parameters.AddWithValue("@contraseña", obj_Login_DAL.SContraseñaNueva);
                cmd.Parameters.AddWithValue("@IdUsuario", obj_Login_DAL.SUsuario);
                cmd.ExecuteNonQuery();
                obj_Login_DAL.SMsj = "Cambio de contraseña realizado";  //MessageBox.Show("Cambio de contraseña realizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                obj_Login_DAL.Obj_Connec_DB.Close();

            }
            else
            {
                obj_Login_DAL.SMsj = "Contraseña Actual Incorrecta, por favor ingrese su contraseña";
            }
            
        }
    }
}
