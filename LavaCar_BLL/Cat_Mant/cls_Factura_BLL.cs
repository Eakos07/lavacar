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
    public class cls_Factura_BLL
    {
        public DataTable Listar_Factura(ref string sMsjError)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();
            Obj_DAL.sTableName = "Facturas";
            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Listar_Factura"].ToString().Trim();
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

        public DataTable Filtrar_Factura(ref string sMsjError, string sFiltro)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();

            Obj_BLL.CrearParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@NumFactura", 6, sFiltro);

            Obj_DAL.sTableName = "Facturas";
            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Filtrar_Factura"].ToString().Trim();
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
        public void Insertar_Factura(ref string sMsjError, ref cls_Factura_DAL Obj_Factura_DAL)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();

            Obj_BLL.CrearParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@NumFactura", 6, Obj_Factura_DAL.iNumFactura.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@NumPlaca", 3, Obj_Factura_DAL.sNumPlaca.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@CodServicio", 5, Obj_Factura_DAL.cCodServicio.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@IdTipoCambio", 5, Obj_Factura_DAL.cIdTipoCambio.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@CedulaJuridica", 6, Obj_Factura_DAL.iCedulaJuridica.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@MontoNeto", 4, Obj_Factura_DAL.dMontoNeto.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@Descuento", 4, Obj_Factura_DAL.dDescuento.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@MontoTotal", 4, Obj_Factura_DAL.dMontoTotal.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@IdPromocion", 5, Obj_Factura_DAL.cIdPromocion.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@IdTipoFactura", 5, Obj_Factura_DAL.cIdTipoFactura.ToString().Trim());
            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Insertar_Factura"].ToString().Trim();
            Obj_BLL.Execute_NonQuery(ref Obj_DAL);

        }

        public void Modificar_Factura(ref string sMsjError, ref cls_Factura_DAL Obj_Factura_DAL)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();

            Obj_BLL.CrearParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@NumFactura", 6, Obj_Factura_DAL.iNumFactura.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@NumPlaca", 3, Obj_Factura_DAL.sNumPlaca.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@CodServicio", 5, Obj_Factura_DAL.cCodServicio.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@IdTipoCambio", 5, Obj_Factura_DAL.cIdTipoCambio.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@CedulaJuridica", 6, Obj_Factura_DAL.iCedulaJuridica.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@MontoNeto", 4, Obj_Factura_DAL.dMontoNeto.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@Descuento", 4, Obj_Factura_DAL.dDescuento.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@MontoTotal", 4, Obj_Factura_DAL.dMontoTotal.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@IdPromocion", 5, Obj_Factura_DAL.cIdPromocion.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@IdTipoFactura", 5, Obj_Factura_DAL.cIdTipoFactura.ToString().Trim());

            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Modificar_Factura"].ToString().Trim();
            Obj_BLL.Execute_NonQuery(ref Obj_DAL);

        }
    }
}
