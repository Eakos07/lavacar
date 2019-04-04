using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using LavaCar_DAL.Data_Base;
using LavaCar_DAL.Cat_Mant;
using LavaCar_BLL.Data_Base;

namespace LavaCar_BLL.Cat_Mant
{
    public class cls_Polizas_BLL
    {
        public DataTable Listar_Polizas(ref string sMsjError)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();
            Obj_DAL.sTableName = "Polizas";
            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Listar_Polizas"].ToString().Trim();
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
        public DataTable Filtrar_Polizas(ref string sMsjError, string sFiltro)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();

            Obj_BLL.CrearParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@IdPoliza", 3, sFiltro);

            Obj_DAL.sTableName = "Polizas";
            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Filtrar_Polizas"].ToString().Trim();
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
        public void Insertar_Polizas(ref string sMsjError, ref cls_Polizas_DAL Obj_Polizas_DAL)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();

            Obj_BLL.CrearParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@IdPoliza", 3, Obj_Polizas_DAL.sIdPoliza.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@IdTipoPoliza", 5, Obj_Polizas_DAL.cIdTipoPoliza.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@FechaVencimiento", 11, Obj_Polizas_DAL.dFechaVencimiento.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@IdEstado", 8, Obj_Polizas_DAL.bIdEstado.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@CedulaJuridica", 6, Obj_Polizas_DAL.iCedulaJuridica.ToString().Trim());

            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Insertar_Polizas"].ToString().Trim();
            Obj_BLL.Execute_NonQuery(ref Obj_DAL);

        }

        public void Modificar_Polizas(ref string sMsjError, ref cls_Polizas_DAL Obj_Polizas_DAL)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();

            Obj_BLL.CrearParametros(ref Obj_DAL);
            Obj_BLL.CrearParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@IdPoliza", 3, Obj_Polizas_DAL.sIdPoliza.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@IdTipoPoliza", 5, Obj_Polizas_DAL.cIdTipoPoliza.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@FechaVencimiento", 11, Obj_Polizas_DAL.dFechaVencimiento.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@IdEstado", 8, Obj_Polizas_DAL.bIdEstado.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@CedulaJuridica", 6, Obj_Polizas_DAL.iCedulaJuridica.ToString().Trim());

            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Modificar_Polizas"].ToString().Trim();
            Obj_BLL.Execute_NonQuery(ref Obj_DAL);

        }
    }
}
