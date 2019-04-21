using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LavaCar_DAL.Recuperacion
{
    public class Cls_Recuperacion_DAL
    {
        private SqlConnection _Obj_Connec_DB;
        private string _sEmail, _sContraseña, _sCadena, _sQuery, _sQuery1, _sIdentificacion, _sMsjConfirmacion, _sMsjFallo;
        private byte _bIdEmpleado;


        #region Get And Set
        public SqlConnection Obj_Connec_DB
        {
            get
            {
                return _Obj_Connec_DB;
            }

            set
            {
                _Obj_Connec_DB = value;
            }
        }
   

        public string SEmail
        {
            get
            {
                return _sEmail;
            }

            set
            {
                _sEmail = value;
            }
        }

        public string SContraseña
        {
            get
            {
                return _sContraseña;
            }

            set
            {
                _sContraseña = value;
            }
        }

        public string SQuery
        {
            get
            {
                return _sQuery;
            }

            set
            {
                _sQuery = value;
            }
        }

        public string SQuery1
        {
            get
            {
                return _sQuery1;
            }

            set
            {
                _sQuery1 = value;
            }
        }

        public string SCadena
        {
            get
            {
                return _sCadena;
            }

            set
            {
                _sCadena = value;
            }
        }

        public string SIdentificacion
        {
            get
            {
                return _sIdentificacion;
            }

            set
            {
                _sIdentificacion = value;
            }
        }

        public byte BIdEmpleado
        {
            get
            {
                return _bIdEmpleado;
            }

            set
            {
                _bIdEmpleado = value;
            }
        }

        public string SMsjConfirmacion
        {
            get
            {
                return _sMsjConfirmacion;
            }

            set
            {
                _sMsjConfirmacion = value;
            }
        }

        public string SMsjFallo
        {
            get
            {
                return _sMsjFallo;
            }

            set
            {
                _sMsjFallo = value;
            }
        }
    }
}
#endregion