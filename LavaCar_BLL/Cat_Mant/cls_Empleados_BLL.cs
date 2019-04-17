using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using LavaCar_DAL.Cat_Mant;
using LavaCar_BLL.Data_Base;
using LavaCar_DAL.Data_Base;

namespace LavaCar_BLL.Cat_Mant
{
    public class cls_Empleados_BLL
    {
        public DataTable Listar_Empleados(ref string sMsjError)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();

            Obj_DAL.sTableName = "Empleados";
            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Listar_Empleados"].ToString().Trim();
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

        public DataTable Filtrar_Empleados(ref string sMsjError, string sFiltro)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();

            Obj_BLL.CrearParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@Identificacion", 3, sFiltro);

            Obj_DAL.sTableName = "Empleados";
            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Filtrar_Empleados"].ToString().Trim();
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

        public void Insertar_Clientes(ref string sMsjError, ref cls_Empleados_DAL Obj_Empleados_DAL)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();

            Obj_BLL.CrearParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@Identificacion", 3, Obj_Empleados_DAL.sIdenti.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@Nombre", 3, Obj_Empleados_DAL.sNombre.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@Apellidos", 3, Obj_Empleados_DAL.sApellidos.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@Telefono", 6, Obj_Empleados_DAL.iTel.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@Direccion", 3, Obj_Empleados_DAL.sAddress.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@Email", 3, Obj_Empleados_DAL.sEmail.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@Puesto", 3, Obj_Empleados_DAL.sPuesto.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@IdEstado", 5, Obj_Empleados_DAL.cIdEstado.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@IdPoliza", 3, Obj_Empleados_DAL.sIdPoliza.ToString().Trim());

            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Insertar_Empleados"].ToString().Trim();
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

        public void Modificar_Clientes(ref string sMsjError, ref cls_Empleados_DAL Obj_Empleados_DAL)
        {
            Cls_DataBase_DAL Obj_DAL = new Cls_DataBase_DAL();
            Cls_DataBase_BLL Obj_BLL = new Cls_DataBase_BLL();

            Obj_BLL.CrearParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@IdEmpleado", 6, Obj_Empleados_DAL.bIdEmpleado.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@Identificacion", 3, Obj_Empleados_DAL.sIdenti.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@Nombre", 3, Obj_Empleados_DAL.sNombre.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@Apellidos", 3, Obj_Empleados_DAL.sApellidos.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@Telefono", 6, Obj_Empleados_DAL.iTel.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@Direccion", 3, Obj_Empleados_DAL.sAddress.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@Email", 3, Obj_Empleados_DAL.sEmail.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@Puesto", 3, Obj_Empleados_DAL.sPuesto.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@IdEstado", 5, Obj_Empleados_DAL.cIdEstado.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@IdPoliza", 3, Obj_Empleados_DAL.sIdPoliza.ToString().Trim());

            Obj_DAL.sSP_Name = ConfigurationManager.AppSettings["Modificar_Empleados"].ToString().Trim();
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
