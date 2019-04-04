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
    public class cls_TransaccionesCompra_BLL
    {
        public DataTable ListarTransaccionesCompra(ref string sMsgError)
        {
            Cls_DataBase_DAL ObjDAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL ObjBLL = new Cls_DataBase_BLL();
            ObjDAL.sTableName = "Transacciones Compra";
            ObjDAL.sSP_Name = ConfigurationManager.AppSettings["Listar_TransaccionesCompra"].ToString().Trim();
            ObjBLL.Execute_DataAdapter(ref ObjDAL);

            if (ObjDAL.sMsjError == string.Empty)
            {
                sMsgError = string.Empty;
                return ObjDAL.Obj_DSet.Tables[0];
            }
            else
            {
                sMsgError = ObjDAL.sMsjError;
                return null;
            }
        }

        public DataTable FiltrarTransaccionesCompra(ref string sMsgError, string sFiltro)
        {
            Cls_DataBase_DAL ObjDAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL ObjBLL = new Cls_DataBase_BLL();

            ObjBLL.CrearParametros(ref ObjDAL);
            ObjDAL.DT_Parametros.Rows.Add("@Orden", 6, sFiltro);

            ObjDAL.sTableName = "Transacciones Compra";
            ObjDAL.sSP_Name = ConfigurationManager.AppSettings["Filtrar_TransaccionesCompra"].ToString().Trim();
            ObjBLL.Execute_DataAdapter(ref ObjDAL);

            if (ObjDAL.sMsjError == string.Empty)
            {
                sMsgError = string.Empty;
                return ObjDAL.Obj_DSet.Tables[0];
            }
            else
            {
                sMsgError = ObjDAL.sMsjError;
                return null;
            }
        }

        public void InsertarTransaccionesCompra(ref string sMsgError,ref cls_TransaccionesCompra_DAL ObjDAL_TransC)
        {
            Cls_DataBase_DAL ObjDAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL ObjBLL = new Cls_DataBase_BLL();

            ObjBLL.CrearParametros(ref ObjDAL);

            ObjDAL.DT_Parametros.Rows.Add("@IdNumOrden", 6, ObjDAL_TransC.iIdNumOrden);
            ObjDAL.DT_Parametros.Rows.Add("@IdArticulo", 3, ObjDAL_TransC.sIdArticulo.ToString().Trim());
            ObjDAL.DT_Parametros.Rows.Add("@IdProveedor", 8, ObjDAL_TransC.bIdProveedor);
            ObjDAL.DT_Parametros.Rows.Add("@Documento", 3, ObjDAL_TransC.sDocumento.ToString().Trim());
            ObjDAL.DT_Parametros.Rows.Add("@Fecha", 7, ObjDAL_TransC.dtFecha);
            ObjDAL.DT_Parametros.Rows.Add("@Cantidad", 9, ObjDAL_TransC.iCantidad);
            ObjDAL.DT_Parametros.Rows.Add("@Monto", 4, ObjDAL_TransC.dMonto);

            ObjDAL.sSP_Name = ConfigurationManager.AppSettings["Insertar_TransaccionesCompra"].ToString().Trim();
            ObjBLL.Ejec_Scalar(ref ObjDAL);

        }

        public void ModificarTransaccionesCompra(ref string sMsgError,ref cls_TransaccionesCompra_DAL ObjDAL_TransC)
        {
            Cls_DataBase_BLL ObjBll = new Cls_DataBase_BLL();
            Cls_DataBase_DAL ObjDAL = new Cls_DataBase_DAL();

            ObjBll.CrearParametros(ref ObjDAL);
            ObjDAL.DT_Parametros.Rows.Add("@IdTransaccionCompra", 6, ObjDAL_TransC.iIdTransaccionCompra);
            ObjDAL.DT_Parametros.Rows.Add("@IdNumOrden", 6, ObjDAL_TransC.iIdNumOrden);
            ObjDAL.DT_Parametros.Rows.Add("@IdArticulo", 3, ObjDAL_TransC.sIdArticulo.ToString().Trim());
            ObjDAL.DT_Parametros.Rows.Add("@IdProveedor", 8, ObjDAL_TransC.bIdProveedor);
            ObjDAL.DT_Parametros.Rows.Add("@Documento", 3, ObjDAL_TransC.sDocumento.ToString().Trim());
            ObjDAL.DT_Parametros.Rows.Add("@Fecha", 7, ObjDAL_TransC.dtFecha);
            ObjDAL.DT_Parametros.Rows.Add("@Cantidad", 9, ObjDAL_TransC.iCantidad);
            ObjDAL.DT_Parametros.Rows.Add("@Monto", 4, ObjDAL_TransC.dMonto);
        }
    }
}
