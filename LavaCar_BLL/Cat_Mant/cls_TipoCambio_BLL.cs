using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using LavaCar_DAL.Data_Base;
using LavaCar_BLL.Data_Base;
using LavaCar_DAL.Cat_Mant;

namespace LavaCar_BLL.Cat_Mant
{
    public class cls_TipoCambio_BLL
    {
        public DataTable Listar_TipoCambio(ref string sMsjError)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();
            Obj_DAL.sTableName = "Tipo Cambio";
            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Listar_TipoCambio"].ToString().Trim();
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

        public DataTable Filtrar_TipoCambio(ref string sMsjError, string sFiltro)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();

            Obj_BLL.CrearParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@IdTipoCambio", 5, sFiltro);

            Obj_DAL.sTableName = "Tipo Cambio";
            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Filtrar_TipoCambio"].ToString().Trim();
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
        public void Insertar_TipoCambio(ref string sMsjError, ref cls_TipoCambio_DAL Obj_TipoCambio_DAL)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();

            Obj_BLL.CrearParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@IdTipoCambio",5, Obj_TipoCambio_DAL.cTipoCambio.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@Valor", 4, Obj_TipoCambio_DAL.dValor.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@Fecha", 11, Obj_TipoCambio_DAL.dtmFecha.ToString().Trim());
            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Insertar_TipoCambio"].ToString().Trim();
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

        public void Modificar_TipoCambio(ref string sMsjError, ref cls_TipoCambio_DAL Obj_TipoCambio_DAL)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();

            Obj_BLL.CrearParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@IdTipoCambio", 5, Obj_TipoCambio_DAL.cTipoCambio.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@Valor", 4, Obj_TipoCambio_DAL.dValor.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@Fecha", 11, Obj_TipoCambio_DAL.dtmFecha.ToString().Trim());
            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Modificar_TipoCambio"].ToString().Trim();
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
