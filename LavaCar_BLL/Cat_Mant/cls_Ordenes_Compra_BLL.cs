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
    public class cls_Ordenes_Compra_BLL
    {
        public DataTable Listar_OrdenesCompra(ref string sMsjError)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();
            Obj_DAL.sTableName = "Ordenes de Compra";
            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Listar_OrdenesCompra"].ToString().Trim();
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

        public DataTable Filtrar_OrdenesCompra(ref string sMsjError, string sFiltro)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();

            Obj_BLL.CrearParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@IdNumOrden", 6, sFiltro);

            Obj_DAL.sTableName = "Ordenes de Compra";
            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Filtrar_OrdenesCompra"].ToString().Trim();
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

        public void Insertar_OrdenesCompra(ref string sMsjError, ref cls_Ordenes_Compra_DAL Obj_OrdenesCompra_DAL)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();

            Obj_BLL.CrearParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@IdProveedor", 8, Obj_OrdenesCompra_DAL.bIdProveedor.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@IdArticulo", 3, Obj_OrdenesCompra_DAL.sIdArticulo.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@Cantidad", 9, Obj_OrdenesCompra_DAL.iCantidad.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@Precio", 4, Obj_OrdenesCompra_DAL.dPrecio.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@IdEstado", 5, Obj_OrdenesCompra_DAL.cIdEstado.ToString().Trim());

            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Insertar_OrdenesCompra"].ToString().Trim();
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

        public void Modificar_OrdenesCompra(ref string sMsjError, ref cls_Ordenes_Compra_DAL Obj_OrdenesCompra_DAL)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();

            Obj_BLL.CrearParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@IdNumOrden", 6, Obj_OrdenesCompra_DAL.iIdNumOrden.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@IdProveedor", 8, Obj_OrdenesCompra_DAL.bIdProveedor.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@IdArticulo", 3, Obj_OrdenesCompra_DAL.sIdArticulo.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@Cantidad", 9, Obj_OrdenesCompra_DAL.iCantidad.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@Precio", 4, Obj_OrdenesCompra_DAL.dPrecio.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@IdEstado", 5, Obj_OrdenesCompra_DAL.cIdEstado.ToString().Trim());
            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Modificar_OrdenesCompra"].ToString().Trim();
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
