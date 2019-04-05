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
    public class cls_TransaccionesVenta_BLL
    {
        public DataTable ListarTransaccionesVenta(ref string sMsgError)
        {
            Cls_DataBase_DAL ObjDAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL ObjBLL = new Cls_DataBase_BLL();
            ObjDAL.sTableName = "Transacciones Venta";
            ObjDAL.sSP_Name = ConfigurationManager.AppSettings["Listar_TransaccionesVenta"].ToString().Trim();
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

        public DataTable FiltrarTransaccionesVenta(ref string sMsgError, string sFiltro)
        {
            Cls_DataBase_DAL ObjDAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL ObjBLL = new Cls_DataBase_BLL();

            ObjBLL.CrearParametros(ref ObjDAL);
            ObjDAL.DT_Parametros.Rows.Add("@NumFactura", 6, sFiltro);

            ObjDAL.sTableName = "Transacciones Venta";
            ObjDAL.sSP_Name = ConfigurationManager.AppSettings["Filtrar_TransaccionesVenta"].ToString().Trim();
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

        public void InsertarTransaccionesVenta(ref string sMsgError, ref cls_TransaccionesVenta_DAL ObjDAL_TransV)
        {
            Cls_DataBase_DAL ObjDAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL ObjBLL = new Cls_DataBase_BLL();

            ObjBLL.CrearParametros(ref ObjDAL);

            ObjDAL.DT_Parametros.Rows.Add("@IdArticulo", 3, ObjDAL_TransV.sIdArticulo);
            ObjDAL.DT_Parametros.Rows.Add("@NumFactura", 6, ObjDAL_TransV.iNumFactura);
            ObjDAL.DT_Parametros.Rows.Add("@Fecha", 7, ObjDAL_TransV.dFecha);
            ObjDAL.DT_Parametros.Rows.Add("@Cantidad", 9, ObjDAL_TransV.iCantidad);
            ObjDAL.DT_Parametros.Rows.Add("@Monto", 4, ObjDAL_TransV.dMonto);
            ObjDAL.DT_Parametros.Rows.Add("@IdEstado", 8, ObjDAL_TransV.bIdEstado);

            ObjDAL.sSP_Name = ConfigurationManager.AppSettings["Insertar_TransaccionesVenta"].ToString().Trim();
            ObjBLL.Ejec_Scalar(ref ObjDAL);

            if (ObjDAL.sMsjError == string.Empty)
            {
                sMsgError = string.Empty;
                ObjDAL_TransV.iIdTransaccionVenta= ObjDAL.iValorScalar;
                ObjDAL_TransV.cBandera = 'I';
            }
            else
            {
                sMsgError = ObjDAL.sMsjError;
                ObjDAL_TransV.cBandera = 'U';
                ObjDAL_TransV.iIdTransaccionVenta = -1;
            }

        }

        public void ModificarTransaccionesVenta(ref string sMsgError, ref cls_TransaccionesVenta_DAL ObjDAL_TransV)
        {
            Cls_DataBase_BLL ObjBll = new Cls_DataBase_BLL();
            Cls_DataBase_DAL ObjDAL = new Cls_DataBase_DAL();

            ObjBll.CrearParametros(ref ObjDAL);
            ObjDAL.DT_Parametros.Rows.Add("@IdTransaccionVenta",6,ObjDAL_TransV.iIdTransaccionVenta);
            ObjDAL.DT_Parametros.Rows.Add("@IdArticulo", 3, ObjDAL_TransV.sIdArticulo);
            ObjDAL.DT_Parametros.Rows.Add("@NumFactura", 6, ObjDAL_TransV.iNumFactura);
            ObjDAL.DT_Parametros.Rows.Add("@Fecha", 7, ObjDAL_TransV.dFecha);
            ObjDAL.DT_Parametros.Rows.Add("@Cantidad", 9, ObjDAL_TransV.iCantidad);
            ObjDAL.DT_Parametros.Rows.Add("@Monto", 4, ObjDAL_TransV.dMonto);
            ObjDAL.DT_Parametros.Rows.Add("@IdEstado", 8, ObjDAL_TransV.bIdEstado);

            ObjDAL.sSP_Name = ConfigurationManager.AppSettings["Modificar_TransaccionesVenta"].ToString().Trim();
            ObjBll.Execute_NonQuery(ref ObjDAL);

            if (ObjDAL.sMsjError == string.Empty)
            {
                sMsgError = string.Empty;
            }
            else
            {
                sMsgError = ObjDAL.sMsjError;
            }
        }
    }
}
