using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LavaCar_DAL.Cat_Mant;
using LavaCar_DAL.Data_Base;
using LavaCar_BLL.Data_Base;

namespace LavaCar_BLL.Cat_Mant
{
    public class cls_Citas_BLL
    {
        public void Listar_Citas(ref cls_Citas_DAL Obj_Citas_DAL)
        {
            //DETECCION DE ERRORES
            try
            {
                Cls_DataBase_BLL Obj_DB_BLL = new Cls_DataBase_BLL();
                Cls_DataBase_DAL Obj_DB_DAL = new Cls_DataBase_DAL();

                //LLAMADO DEL SP Y LA TABLA
                Obj_DB_DAL.sSP_Name = "SP_LISTAR_CITAS";
                Obj_DB_DAL.sTableName = "Citas";

                //EJECUTAR EL DATAADAPTER PARA DEFINIR VARIABLES Y MOSTRAR TABLA
                Obj_DB_BLL.Execute_DataAdapter(ref Obj_DB_DAL);

                //VERIFICAR ERRORES
                if (Obj_DB_DAL.sMsjError == string.Empty)
                {
                    Obj_Citas_DAL.Obj_DataTable = Obj_DB_DAL.Obj_DSet.Tables[0];
                    Obj_Citas_DAL.sMsjError = string.Empty;
                }
                else
                {
                    Obj_Citas_DAL.sMsjError = Obj_DB_DAL.sMsjError;
                }
            }
            catch (Exception error)
            {
                Obj_Citas_DAL.sMsjError = error.Message.ToString();
            }
        }

        public void Filtrar_Citas (ref cls_Citas_DAL Obj_Citas_DAL, string sFiltro)
        {
            try
            {
                Cls_DataBase_BLL Obj_DB_BLL = new Cls_DataBase_BLL();
                Cls_DataBase_DAL Obj_DB_DAL = new Cls_DataBase_DAL();

                //LLAMADO DEL SP Y LA TABLA
                Obj_DB_DAL.sSP_Name = "SP_LISTAR_CITAS";

                //CREAR PARAMETRO DE FILTRO
                Obj_DB_BLL.CrearParametros(ref Obj_DB_DAL);
                Obj_DB_DAL.DT_Parametros.Rows.Add("@NumeroCita", "6", sFiltro);

                //EJECUTAR LLAMADO DEL FILTRO Y LA TABLA
                Obj_DB_BLL.Execute_DataAdapter(ref Obj_DB_DAL);

                //VERIFICAR MSJ DE ERROR
                if (Obj_DB_DAL.sMsjError == string.Empty)
                {
                    Obj_Citas_DAL.Obj_DataTable = Obj_DB_DAL.Obj_DSet.Tables[0];
                    Obj_Citas_DAL.sMsjError = string.Empty;
                }
                else
                {
                    Obj_Citas_DAL.sMsjError = Obj_DB_DAL.sMsjError;
                }
            }
            catch (Exception error)
            {

                Obj_Citas_DAL.sMsjError = error.Message.ToString();
            }
        }

        public void Insertar_Citas(ref cls_Citas_DAL Obj_Citas_DAL)
        {
            try
            {
                Cls_DataBase_BLL Obj_DB_BLL = new Cls_DataBase_BLL();
                Cls_DataBase_DAL Obj_DB_DAL = new Cls_DataBase_DAL();

                //LLAMAR SP
                Obj_DB_DAL.sSP_Name = "SP_INSERTAR_CITAS";

                //CREAR PARAMETROS
                Obj_DB_BLL.CrearParametros(ref Obj_DB_DAL);

                Obj_DB_DAL.DT_Parametros.Rows.Add("@Nombre", "3", Obj_Citas_DAL.sNombre);
                Obj_DB_DAL.DT_Parametros.Rows.Add("@Telefono", "6", Obj_Citas_DAL.iTel);
                Obj_DB_DAL.DT_Parametros.Rows.Add("@NumPlaca", "3", Obj_Citas_DAL.sNumPlaca);
                Obj_DB_DAL.DT_Parametros.Rows.Add("@CodServicio", "5", Obj_Citas_DAL.cCodeServ);
                Obj_DB_DAL.DT_Parametros.Rows.Add("@Email", "3", Obj_Citas_DAL.sEmail);
                Obj_DB_DAL.DT_Parametros.Rows.Add("@FechaCita", "7", Obj_Citas_DAL.dtFechaCita);
                Obj_DB_DAL.DT_Parametros.Rows.Add("@HoraCita", "8", Obj_Citas_DAL.dtHoraCita);
                Obj_DB_DAL.DT_Parametros.Rows.Add("@IdEstado", "6", Obj_Citas_DAL.iIdEstado);
                Obj_DB_DAL.DT_Parametros.Rows.Add("@IdEmpleado", "6", Obj_Citas_DAL.iIdEmpleado);

                //EJECUTAR COMADO PARA INSERTAR A LA BD
                Obj_DB_BLL.Execute_NonQuery(ref Obj_DB_DAL);

                //VEREFICACION DE MSJ DE ERROR
                if (Obj_DB_DAL.sMsjError == string.Empty)
                {
                    Obj_Citas_DAL.sMsjError = string.Empty;
                    Obj_Citas_DAL.iNumCita = Convert.ToInt32(Obj_DB_DAL.sScalarV);
                }
                else
                {
                    Obj_Citas_DAL.sMsjError = Obj_DB_DAL.sMsjError;
                }
            }
            catch (Exception error)
            {

                Obj_Citas_DAL.sMsjError = error.Message.ToString();
            }
        }

        public void Modificar_Citas(ref cls_Citas_DAL Obj_Citas_DAL)
        {
            try
            {
                Cls_DataBase_BLL Obj_DB_BLL = new Cls_DataBase_BLL();
                Cls_DataBase_DAL Obj_DB_DAL = new Cls_DataBase_DAL();

                //LLAMAR SP
                Obj_DB_DAL.sSP_Name = "SP_MODIFICAR_CITAS";

                //CREAR PARAMETROS
                Obj_DB_BLL.CrearParametros(ref Obj_DB_DAL);

                Obj_DB_DAL.DT_Parametros.Rows.Add("@NumeroCita", "6", Obj_Citas_DAL.iNumCita);
                Obj_DB_DAL.DT_Parametros.Rows.Add("@Nombre", "3", Obj_Citas_DAL.sNombre);
                Obj_DB_DAL.DT_Parametros.Rows.Add("@Telefono", "6", Obj_Citas_DAL.iTel);
                Obj_DB_DAL.DT_Parametros.Rows.Add("@NumPlaca", "3", Obj_Citas_DAL.sNumPlaca);
                Obj_DB_DAL.DT_Parametros.Rows.Add("@CodServicio", "5", Obj_Citas_DAL.cCodeServ);
                Obj_DB_DAL.DT_Parametros.Rows.Add("@Email", "3", Obj_Citas_DAL.sEmail);
                Obj_DB_DAL.DT_Parametros.Rows.Add("@FechaCita", "7", Obj_Citas_DAL.dtFechaCita);
                Obj_DB_DAL.DT_Parametros.Rows.Add("@HoraCita", "8", Obj_Citas_DAL.dtHoraCita);
                Obj_DB_DAL.DT_Parametros.Rows.Add("@IdEstado", "6", Obj_Citas_DAL.iIdEstado);
                Obj_DB_DAL.DT_Parametros.Rows.Add("@IdEmpleado", "6", Obj_Citas_DAL.iIdEmpleado);

                //EJECUTAR COMADO PARA MODIFICAR A LA BD
                Obj_DB_BLL.Execute_NonQuery(ref Obj_DB_DAL);

                //VEREFICACION DE MSJ DE ERROR
                if (Obj_DB_DAL.sMsjError == string.Empty)
                {
                    Obj_Citas_DAL.sMsjError = string.Empty;
                }
                else
                {
                    Obj_Citas_DAL.sMsjError = Obj_DB_DAL.sMsjError;
                }
            }
            catch (Exception error)
            {

                Obj_Citas_DAL.sMsjError = error.Message.ToString();
            }
        }
    }
}
