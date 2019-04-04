using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using LavaCar_DAL.Data_Base;
using LavaCar_BLL.Data_Base;
using LavaCar_DAL.Cat_Mant;

namespace LavaCar_BLL.Cat_Mant
{
    public class cls_TipoPolizas_BLL
    {
        public DataTable Listar_TipoPolizas(ref string sMsjError)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();
            Obj_DAL.sTableName = "Tipo Poliza";
            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Listar_TipoPolizas"].ToString().Trim();
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

        public DataTable Filtrar_TipoPolizas(ref string sMsjError, string sFiltro)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();

            Obj_BLL.CrearParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@NombrePoliza", 3, sFiltro);

            Obj_DAL.sTableName = "Tipo Polizas";
            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Filtrar_TipoPolizas"].ToString().Trim();
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
        public void Insertar_TipoPolizas(ref string sMsjError, ref cls_TipoPolizas_DAL Obj_TipoPolizas_DAL)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();

            Obj_BLL.CrearParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@IdTipoPoliza", 5, Obj_TipoPolizas_DAL.cIdTipoPoliza.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@NombrePoliza", 3, Obj_TipoPolizas_DAL.sNombrePoliza.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@Compañia", 3, Obj_TipoPolizas_DAL.sCompañia.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@IdProveedor", 8, Obj_TipoPolizas_DAL.bIdProveedor.ToString().Trim());
            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Insertar_TipoPolizas"].ToString().Trim();
            Obj_BLL.Execute_NonQuery(ref Obj_DAL);
        }

        public void Modificar_TipoPolizas(ref string sMsjError, ref cls_TipoPolizas_DAL Obj_TipoPolizas_DAL)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();

            Obj_BLL.CrearParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@IdTipoPoliza", 5, Obj_TipoPolizas_DAL.cIdTipoPoliza.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@NombrePoliza", 3, Obj_TipoPolizas_DAL.sNombrePoliza.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@Compañia", 3, Obj_TipoPolizas_DAL.sCompañia.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@IdProveedor", 8, Obj_TipoPolizas_DAL.bIdProveedor.ToString().Trim());
            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Modificar_TipoPolizas"].ToString().Trim();
            Obj_BLL.Execute_NonQuery(ref Obj_DAL);
        }
    }
}
