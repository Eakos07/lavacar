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
    public class cls_Articulos_BLL
    {
        public DataTable Listar_Articulos(ref string sMsjError)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();
            Obj_DAL.sTableName = "Articulos";
            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Listar_Articulos"].ToString().Trim();
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

        public DataTable Filtrar_Articulos(ref string sMsjError, string sFiltro)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();

            Obj_BLL.CrearParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@NombreArticulo", 3, sFiltro);

            Obj_DAL.sTableName = "Articulos";
            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Filtrar_Articulos"].ToString().Trim();
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

        public void Insertar_Articulos(ref string sMsjError, ref cls_Articulos_DAL Obj_Articulos_DAL)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();

            Obj_BLL.CrearParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@IdArticulo", 3, Obj_Articulos_DAL.sIdArticulo.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@NombreArticulo", 3, Obj_Articulos_DAL.sNombreArticulo.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@Cantidad", 9, Obj_Articulos_DAL.iCantidad.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@IdFamilia", 3, Obj_Articulos_DAL.sIdFamilia.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@IdTipoArticulo", 5, Obj_Articulos_DAL.cIdTipoArticulo.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@InventarioMinimo", 9, Obj_Articulos_DAL.iInventarioMinimo.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@PrecioVenta", 4, Obj_Articulos_DAL.dPrecioVenta.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@IdEstado", 5, Obj_Articulos_DAL.cIdEstado.ToString().Trim());
            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Insertar_Articulos"].ToString().Trim();
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

        public void Modificar_Articulos(ref string sMsjError, ref cls_Articulos_DAL Obj_Articulos_DAL)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();

            Obj_BLL.CrearParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@IdArticulo", 3, Obj_Articulos_DAL.sIdArticulo.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@NombreArticulo", 3, Obj_Articulos_DAL.sNombreArticulo.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@Cantidad", 9, Obj_Articulos_DAL.iCantidad.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@IdFamilia", 3, Obj_Articulos_DAL.sIdFamilia.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@IdTipoArticulo", 5, Obj_Articulos_DAL.cIdTipoArticulo.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@InventarioMinimo", 9, Obj_Articulos_DAL.iInventarioMinimo.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@PrecioVenta", 4, Obj_Articulos_DAL.dPrecioVenta.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@IdEstado", 5, Obj_Articulos_DAL.cIdEstado.ToString().Trim());
            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Modificar_Articulos"].ToString().Trim();
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
