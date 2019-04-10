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
    public class cls_Horarios_BLL
    {
        public DataTable Listar_Horarios(ref string sMsjError)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();
            Obj_DAL.sTableName = "Horarios";
            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Listar_Horarios"].ToString().Trim();
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

        public DataTable Filtrar_Horarios(ref string sMsjError, string sFiltro)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();

            Obj_BLL.CrearParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@Descripcion", 3, sFiltro);

            Obj_DAL.sTableName = "Horarios";
            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Filtrar_Horarios"].ToString().Trim();
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
        public void Insertar_Horarios(ref string sMsjError, ref cls_Horarios_DAL Obj_Horarios_DAL)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();

            Obj_BLL.CrearParametros(ref Obj_DAL);
            //Obj_DAL.DT_Parametros.Rows.Add("@IdHorario",8, Obj_Horarios_DAL.bIdHorario.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@Descripcion", 3, Obj_Horarios_DAL.sDescripcion.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@CantHoras", 10, Obj_Horarios_DAL.fCantHoras.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@Entrada", 7, Obj_Horarios_DAL.dtmEntrada.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@Salida", 7, Obj_Horarios_DAL.dtmSalida.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@IdEstado", 8, Obj_Horarios_DAL.cIdEstado.ToString().Trim());
            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Insertar_Horarios"].ToString().Trim();
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

        public void Modificar_Horarios(ref string sMsjError, ref cls_Horarios_DAL Obj_Horarios_DAL)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();

            Obj_BLL.CrearParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@IdHorario", 8, Obj_Horarios_DAL.bIdHorario.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@Descripcion", 3, Obj_Horarios_DAL.sDescripcion.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@CantHoras", 10, Obj_Horarios_DAL.fCantHoras.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@Entrada", 7, Obj_Horarios_DAL.dtmEntrada.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@Salida", 7, Obj_Horarios_DAL.dtmSalida.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@IdEstado", 8, Obj_Horarios_DAL.cIdEstado.ToString().Trim());
           
            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Modificar_Horarios"].ToString().Trim();
            Obj_BLL.Ejec_Scalar(ref Obj_DAL);

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
