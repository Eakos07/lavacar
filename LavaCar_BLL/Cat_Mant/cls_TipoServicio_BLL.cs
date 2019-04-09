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
    public class cls_TipoServicio_BLL
    {
        public DataTable Listar_TipoServicio(ref string sMsjError)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();
            Obj_DAL.sTableName = "Tipo Servicio";
            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Listar_TipoServicio"].ToString().Trim();
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

        public DataTable Filtrar_TipoServicio(ref string sMsjError, string sFiltro)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();

            Obj_BLL.CrearParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@CodServicio", 5, sFiltro);

            Obj_DAL.sTableName = "Tipo Servicio";
            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Filtrar_TipoServicio"].ToString().Trim();
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
        public void Insertar_TipoServicio(ref string sMsjError, ref cls_TipoServicio_DAL Obj_TipoServicio_DAL)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();

            Obj_BLL.CrearParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@CodServicio", 5, Obj_TipoServicio_DAL.cCodServicio.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@NombreServicio", 3, Obj_TipoServicio_DAL.sNombreServicio.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@Precio", 4, Obj_TipoServicio_DAL.dPrecio.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@Duracion", 3, Obj_TipoServicio_DAL.sDuracion.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@IdTipoVehiculo", 8, Obj_TipoServicio_DAL.bIdTipoVehiculo.ToString().Trim());
            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Insertar_TipoServicio"].ToString().Trim();
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

        public void Modificar_TipoServicio(ref string sMsjError, ref cls_TipoServicio_DAL Obj_TipoServicio_DAL)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();

            Obj_BLL.CrearParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@CodServicio", 5, Obj_TipoServicio_DAL.cCodServicio.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@NombreServicio", 3, Obj_TipoServicio_DAL.sNombreServicio.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@Precio", 4, Obj_TipoServicio_DAL.dPrecio.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@Duracion", 3, Obj_TipoServicio_DAL.sDuracion.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@IdTipoVehiculo", 8, Obj_TipoServicio_DAL.bIdTipoVehiculo.ToString().Trim());
            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Modificar_TipoServicio"].ToString().Trim();
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

