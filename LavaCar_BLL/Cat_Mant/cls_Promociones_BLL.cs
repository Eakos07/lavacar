﻿using System;
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
    public class cls_Promociones_BLL
    {
        public DataTable Listar_Promociones(ref string sMsjError)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();
            Obj_DAL.sTableName = "Promociones";
            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Listar_Promociones"].ToString().Trim();
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

        public DataTable Filtrar_Promociones(ref string sMsjError, string sFiltro)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();

            Obj_BLL.CrearParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@TipoPromocion", 3, sFiltro);

            Obj_DAL.sTableName = "Promociones";
            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Filtrar_Promociones"].ToString().Trim();
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
        public void Insertar_Promociones(ref string sMsjError, ref cls_Promociones_DAL Obj_Promociones_DAL)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();

            Obj_BLL.CrearParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@IdPromocion", 5, Obj_Promociones_DAL.cIdPromocion.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@TipoPromocion", 3, Obj_Promociones_DAL.sTipoPromocion.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@Descripcion", 3, Obj_Promociones_DAL.sDescripcion.ToString().Trim());
            
            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Insertar_Promociones"].ToString().Trim();
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

        public void Modificar_Promociones(ref string sMsjError, ref cls_Promociones_DAL Obj_Promociones_DAL)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();

            Obj_BLL.CrearParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@IdPromocion", 5, Obj_Promociones_DAL.cIdPromocion.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@TipoPromocion", 3, Obj_Promociones_DAL.sTipoPromocion.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@Descripcion", 3, Obj_Promociones_DAL.sDescripcion.ToString().Trim());

            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Modificar_Promociones"].ToString().Trim();
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

