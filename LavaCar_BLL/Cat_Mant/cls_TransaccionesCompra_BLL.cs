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
    }
}
