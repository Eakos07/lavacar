using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LavaCar_DAL.Data_Base;
using LavaCar_BLL.Data_Base;
using System.Configuration;
using LavaCar_DAL.Cat_Mant;

namespace LavaCar_BLL.Cat_Mant
{
    public class cls_TipoPlaca_BLL
    {
        public DataTable Listar_TipoPlaca(ref string sMsjError)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();
            Obj_DAL.sTableName = "Tipo Placa";
            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Listar_TipoPlaca"].ToString().Trim();
            Obj_BLL.Execute_DataAdapter(ref Obj_DAL);

            if (Obj_DAL.sMsjError == string.Empty)
            {
                sMsjError = string.Empty;
                return Obj_DAL.Obj_DSet.Tables[0];
            }
            else
            {
                sMsjError = Obj_DAL.sMsjError;
                return null;
            }

        }

        public DataTable Filtrar_TipoPlaca(ref string sMsjError, string sFiltro)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();

            Obj_BLL.CrearParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@IdTipoPlaca", 8, sFiltro);

            Obj_DAL.sTableName = "Tipo Placa";
            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Filtrar_TipoPlaca"].ToString().Trim();
            Obj_BLL.Execute_DataAdapter(ref Obj_DAL);


            if (Obj_DAL.sMsjError == string.Empty)
            {
                sMsjError = string.Empty;
                return Obj_DAL.Obj_DSet.Tables[0];
            }
            else
            {
                sMsjError = Obj_DAL.sMsjError;
                return null;
            }
        }
        public void Insertar_TipoPlaca(ref string sMsjError, ref cls_TipoPlaca_DAL Obj_TipoPlaca_DAL)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();

            Obj_BLL.CrearParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@IdTipoPlaca", 8, Obj_TipoPlaca_DAL.bIdTipoPlaca.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@Descripcion", 3, Obj_TipoPlaca_DAL.sDescripcion.ToString().Trim());
            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Insertar_TipoPlaca"].ToString().Trim();
            Obj_BLL.Execute_NonQuery(ref Obj_DAL);
        }

        public void Modificar_TipoPlaca(ref string sMsjError, ref cls_TipoPlaca_DAL Obj_TipoPlaca_DAL)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();

            Obj_BLL.CrearParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@IdTipoPlaca", 8, Obj_TipoPlaca_DAL.bIdTipoPlaca.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@Descripcion", 3, Obj_TipoPlaca_DAL.sDescripcion.ToString().Trim());
            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Modificar_TipoPlaca"].ToString().Trim();
            Obj_BLL.Execute_NonQuery(ref Obj_DAL);
        }
    }
}
