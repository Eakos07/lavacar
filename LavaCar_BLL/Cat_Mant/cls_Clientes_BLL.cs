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
    public class cls_Clientes_BLL
    {
        public DataTable Listar_Clientes(ref string sMsjError)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();
            Obj_DAL.sTableName = "Clientes";
            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Listar_Clientes"].ToString().Trim();
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

        public DataTable Filtrar_Clientes(ref string sMsjError, string sFiltro)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();

            Obj_BLL.CrearParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@NumPlaca", 3, sFiltro);

            Obj_DAL.sTableName = "Clientes";
            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Filtrar_Clientes"].ToString().Trim();
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

        public void Insertar_Clientes(ref string sMsjError, ref cls_Clientes_DAL Obj_Clientes_DAL)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();

            Obj_BLL.CrearParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@NumPlaca", 3, Obj_Clientes_DAL.sNumPlaca.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@IdTipoPlaca", 8, Obj_Clientes_DAL.bIdTipoPlaca.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@IdTipoVehiculo", 8, Obj_Clientes_DAL.bIdTipoVehiculo.ToString().Trim());
            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Insertar_Clientes"].ToString().Trim();
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

        public void Modificar_Clientes(ref string sMsjError, ref cls_Clientes_DAL Obj_Clientes_DAL)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();

            Obj_BLL.CrearParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@NumPlaca", 3, Obj_Clientes_DAL.sNumPlaca.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@IdTipoPlaca", 8, Obj_Clientes_DAL.bIdTipoPlaca.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@IdTipoVehiculo", 8, Obj_Clientes_DAL.bIdTipoVehiculo.ToString().Trim());
            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Modificar_Clientes"].ToString().Trim();
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
