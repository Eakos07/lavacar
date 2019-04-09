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
    public class cls_Planillas_BLL
    {
        public DataTable Listar_Planilla(ref string sMsjError)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();
            Obj_DAL.sTableName = "Planilla";
            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Listar_Planillas"].ToString().Trim();
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

        public DataTable Filtrar_Planilla(ref string sMsjError, string sFiltro)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();

            Obj_BLL.CrearParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@IdPlanilla", 6, sFiltro);

            Obj_DAL.sTableName = "Planilla";
            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Filtrar_Planillas"].ToString().Trim();
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
        public void Insertar_Planillas(ref string sMsjError, ref cls_Planillas_DAL Obj_Planillas_DAL)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();

            Obj_BLL.CrearParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@IdPlanilla", 6, Obj_Planillas_DAL.iIdPlanilla.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@IdEmpleado", 8, Obj_Planillas_DAL.bIdEmpleado.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@IdHorario", 8, Obj_Planillas_DAL.bIdHorario.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@IdEstado", 8, Obj_Planillas_DAL.bIdEstado.ToString().Trim());
          
            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Insertar_Planillas"].ToString().Trim();
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

        public void Modificar_Planillas(ref string sMsjError, ref cls_Planillas_DAL Obj_Planillas_DAL)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();

            Obj_BLL.CrearParametros(ref Obj_DAL);
            Obj_BLL.CrearParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@IdPlanilla", 6, Obj_Planillas_DAL.iIdPlanilla.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@IdEmpleado", 8, Obj_Planillas_DAL.bIdEmpleado.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@IdHorario", 8, Obj_Planillas_DAL.bIdHorario.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@IdEstado", 8, Obj_Planillas_DAL.bIdEstado.ToString().Trim());


            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Modificar_Planillas"].ToString().Trim();
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
