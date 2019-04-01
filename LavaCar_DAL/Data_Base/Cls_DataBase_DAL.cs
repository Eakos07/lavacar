using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LavaCar_DAL.Data_Base
{
    public class Cls_DataBase_DAL
    {
        public DataTable DT_Parametros = new DataTable("Parametros");
        public SqlConnection Obj_Connec_DT = new SqlConnection();
        public SqlDataAdapter Obj_DAdapter = new SqlDataAdapter();
        public DataSet Obj_DSet = new DataSet();
        public SqlCommand Obj_Command;

        private string _sCxCadena, _sTableName, _sSP_Name, _sScalarV, _sMsjError;

        public string sCxCadena
        {
            get
            {
                return _sCxCadena;
            }

            set
            {
                _sCxCadena = value;
            }
        }

        public string sTableName
        {
            get
            {
                return _sTableName;
            }

            set
            {
                _sTableName = value;
            }
        }

        public string sScalarV
        {
            get
            {
                return _sScalarV;
            }

            set
            {
                _sScalarV = value;
            }
        }

        public string sSP_Name
        {
            get
            {
                return _sSP_Name;
            }

            set
            {
                _sSP_Name = value;
            }
        }

        public string sMsjError
        {
            get
            {
                return _sMsjError;
            }

            set
            {
                _sMsjError = value;
            }
        }
    }
}
