using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LavaCar_DAL.Data_Base;

using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace LavaCar_BLL.Data_Base
{
    public class Cls_DataBase_BLL
    {
        //METODO DE CONECXION A LA BASE DE DATOS SQL SERVER

        public void CrearConx(ref Cls_DataBase_DAL Obj_DB_DAL)
        {
            try
            {
                Obj_DB_DAL.sCxCadena = ConfigurationManager.ConnectionStrings["Windows_AUT"].ConnectionString;
                Obj_DB_DAL.Obj_Connec_DT = new SqlConnection(Obj_DB_DAL.sCxCadena);
                Obj_DB_DAL.sMsjError = string.Empty;
            }
            catch (Exception ex)
            {
                Obj_DB_DAL.sMsjError = ex.Message.ToString();
                Obj_DB_DAL.Obj_Connec_DT = null;
                Obj_DB_DAL.sCxCadena = string.Empty; ;
            }
        }

        //METODO DE CREACION DE PARAMETROS RELACIONANDO
        //LAS VARIABLES DE LA BASE DE DATOS CON LA DE LA PLATAFORMA VISUAL

        public void CrearParametros(ref Cls_DataBase_DAL Obj_DB_DAL)
        {
            try
            {
                Obj_DB_DAL.DT_Parametros = new DataTable("Parametros");
                Obj_DB_DAL.DT_Parametros.Columns.Add("Nombre");
                Obj_DB_DAL.DT_Parametros.Columns.Add("Tipo");
                Obj_DB_DAL.DT_Parametros.Columns.Add("Valor");

                Obj_DB_DAL.sMsjError = string.Empty;
            }
            catch (Exception ex)
            {
                Obj_DB_DAL.sMsjError = ex.Message.ToString();
                Obj_DB_DAL.DT_Parametros = null;
            }
        }
    }
}
