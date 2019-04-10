using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LavaCar_DAL.Cat_Mant;
using LavaCar_DAL.Data_Base;
using LavaCar_BLL.Data_Base;
using System.Data;
using System.Configuration;

namespace LavaCar_BLL.Cat_Mant
{
    public class cls_Citas_BLL
    {
        public DataTable Listar_Citas(ref string sMsjError)
        {
            Cls_DataBase_BLL Obj_DB_BLL = new Cls_DataBase_BLL();
            Cls_DataBase_DAL Obj_DB_DAL = new Cls_DataBase_DAL();

            Obj_DB_DAL.sTableName = "Citas";
            Obj_DB_DAL.sSP_Name = ConfigurationManager.AppSettings["Listar_Citas"].ToString();
            Obj_DB_BLL.Execute_DataAdapter(ref Obj_DB_DAL);

            if (Obj_DB_DAL.sMsjError == string.Empty)
            {
                sMsjError = string.Empty;
                return Obj_DB_DAL.Obj_DSet.Tables[0];
            }
            else
            {
                sMsjError = Obj_DB_DAL.sMsjError;
                return null;
            }
        }

        public DataTable Filtrar_Citas(ref string sMsjError, string sFiltro)
        {
            Cls_DataBase_BLL Obj_DB_BLL = new Cls_DataBase_BLL();
            Cls_DataBase_DAL Obj_DB_DAL = new Cls_DataBase_DAL();

            Obj_DB_BLL.CrearParametros(ref Obj_DB_DAL);
            Obj_DB_DAL.DT_Parametros.Rows.Add("@NumeroCita", 6, sFiltro);

            Obj_DB_DAL.sTableName = "Citas";
            Obj_DB_DAL.sSP_Name = ConfigurationManager.AppSettings["Filtrar_Citas"].ToString().Trim();
            Obj_DB_BLL.Execute_DataAdapter(ref Obj_DB_DAL);

            if (Obj_DB_DAL.sMsjError == string.Empty)
            {
                sMsjError = string.Empty;
                return Obj_DB_DAL.Obj_DSet.Tables[0];
            }
            else
            {
                sMsjError = Obj_DB_DAL.sMsjError;
                return null;
            }
        }

        public void Insertar_Citas(ref string sMsjError, ref cls_Citas_DAL Obj_Citas_DAL)
        {
            Cls_DataBase_BLL Obj_DB_BLL = new Cls_DataBase_BLL();
            Cls_DataBase_DAL Obj_DB_DAL = new Cls_DataBase_DAL();
            
            //CREAR PARAMETROS
            Obj_DB_BLL.CrearParametros(ref Obj_DB_DAL);

            Obj_DB_DAL.DT_Parametros.Rows.Add("@Nombre", 3, Obj_Citas_DAL.sNombre.ToString().Trim());
            Obj_DB_DAL.DT_Parametros.Rows.Add("@Telefono", 6, Obj_Citas_DAL.iTel.ToString().Trim());
            Obj_DB_DAL.DT_Parametros.Rows.Add("@NumPlaca", 3, Obj_Citas_DAL.sNumPlaca.ToString().Trim());
            Obj_DB_DAL.DT_Parametros.Rows.Add("@CodServicio", 5, Obj_Citas_DAL.cCodeServ.ToString().Trim());
            Obj_DB_DAL.DT_Parametros.Rows.Add("@Email", 3, Obj_Citas_DAL.sEmail.ToString().Trim());
            Obj_DB_DAL.DT_Parametros.Rows.Add("@FechaCita", 7, Obj_Citas_DAL.dtFechaCita.ToString().Trim());
            Obj_DB_DAL.DT_Parametros.Rows.Add("@HoraCita", 3, Obj_Citas_DAL.sHoraCita.ToString().Trim());
            Obj_DB_DAL.DT_Parametros.Rows.Add("@IdEstado", 8, Obj_Citas_DAL.cIdEstado.ToString().Trim());
            Obj_DB_DAL.DT_Parametros.Rows.Add("@IdEmpleado", 8, Obj_Citas_DAL.bIdEmpleado.ToString().Trim());
            Obj_DB_DAL.sSP_Name = ConfigurationManager.AppSettings["Insertar_Citas"].ToString().Trim();
            Obj_DB_BLL.Ejec_Scalar(ref Obj_DB_DAL);

            if (Obj_DB_DAL.sMsjError == string.Empty)
            {
                sMsjError = string.Empty;
            }
            else
            {
                sMsjError = Obj_DB_DAL.sMsjError;
            }
        }

        public void Modificar_Citas(ref string sMsjError, ref cls_Citas_DAL Obj_Citas_DAL)
        {
            Cls_DataBase_BLL Obj_DB_BLL = new Cls_DataBase_BLL();
            Cls_DataBase_DAL Obj_DB_DAL = new Cls_DataBase_DAL();

            //CREAR PARAMETROS
            Obj_DB_BLL.CrearParametros(ref Obj_DB_DAL);

            Obj_DB_DAL.DT_Parametros.Rows.Add("@Nombre", 3, Obj_Citas_DAL.sNombre.ToString().Trim());
            Obj_DB_DAL.DT_Parametros.Rows.Add("@Telefono", 6, Obj_Citas_DAL.iTel.ToString().Trim());
            Obj_DB_DAL.DT_Parametros.Rows.Add("@NumPlaca", 3, Obj_Citas_DAL.sNumPlaca.ToString().Trim());
            Obj_DB_DAL.DT_Parametros.Rows.Add("@CodServicio", 5, Obj_Citas_DAL.cCodeServ.ToString().Trim());
            Obj_DB_DAL.DT_Parametros.Rows.Add("@Email", 3, Obj_Citas_DAL.sEmail.ToString().Trim());
            Obj_DB_DAL.DT_Parametros.Rows.Add("@FechaCita", 7, Obj_Citas_DAL.dtFechaCita.ToString().Trim());
            Obj_DB_DAL.DT_Parametros.Rows.Add("@HoraCita", 3, Obj_Citas_DAL.sHoraCita.ToString().Trim());
            Obj_DB_DAL.DT_Parametros.Rows.Add("@IdEstado", 8, Obj_Citas_DAL.cIdEstado.ToString().Trim());
            Obj_DB_DAL.DT_Parametros.Rows.Add("@IdEmpleado", 8, Obj_Citas_DAL.bIdEmpleado.ToString().Trim());
            Obj_DB_DAL.sSP_Name = ConfigurationManager.AppSettings["Modificar_Citas"].ToString().Trim();
            Obj_DB_BLL.Execute_NonQuery(ref Obj_DB_DAL);

            if (Obj_DB_DAL.sMsjError == string.Empty)
            {
                sMsjError = string.Empty;
            }
            else
            {
                sMsjError = Obj_DB_DAL.sMsjError;
            }
        }
    }
}
