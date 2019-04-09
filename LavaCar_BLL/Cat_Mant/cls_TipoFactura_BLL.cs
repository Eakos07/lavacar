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
    public class cls_TipoFactura_BLL
    {
        public DataTable Listar_TipoFactura(ref string sMsjError)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();
            Obj_DAL.sTableName = "Tipo Factura";
            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Listar_TipoFactura"].ToString().Trim();
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

        public DataTable Filtrar_TipoFactura(ref string sMsjError, string sFiltro)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();

            Obj_BLL.CrearParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@TipoFactura", 3, sFiltro);

            Obj_DAL.sTableName = "Tipo Factura";
            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Filtrar_TipoFactura"].ToString().Trim();
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
        public void Insertar_TipoFactura(ref string sMsjError, ref cls_TipoFactura_DAL Obj_TipoFactura_DAL)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();

            Obj_BLL.CrearParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@IdTipoFactura", 5, Obj_TipoFactura_DAL.cIdTipoFactura.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@TipoFactura", 3, Obj_TipoFactura_DAL.sTipoFactura.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@Descripcion", 3, Obj_TipoFactura_DAL.sDescripcion.ToString().Trim());

            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Insertar_TipoFactura"].ToString().Trim();
            Obj_BLL.Execute_NonQuery(ref Obj_DAL);

            if (Obj_DAL.sMsjError == string.Empty)
            {
                sMsjError = string.Empty;
            }
            else
            {
                sMsjError = Obj_DAL.sMsjError;
            }

        }

        public void Modificar_TipoFactura(ref string sMsjError, ref cls_TipoFactura_DAL Obj_TipoFactura_DAL)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();

            Obj_BLL.CrearParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@IdTipoFactura", 5, Obj_TipoFactura_DAL.cIdTipoFactura.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@TipoFactura", 3, Obj_TipoFactura_DAL.sTipoFactura.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@Descripcion", 3, Obj_TipoFactura_DAL.sDescripcion.ToString().Trim());

            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Modificar_TipoFactura"].ToString().Trim();
            Obj_BLL.Execute_NonQuery(ref Obj_DAL);

            if (Obj_DAL.sMsjError == string.Empty)
            {
                sMsjError = string.Empty;
            }
            else
            {
                sMsjError = Obj_DAL.sMsjError;
            }

        }
    }
}
