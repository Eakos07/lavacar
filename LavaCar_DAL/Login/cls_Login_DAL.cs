using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LavaCar_DAL.Login
{
    public class cls_Login_DAL
    {
        private SqlConnection _Obj_Connec_DB;
        private string _SUsuario, _SContrasena, _SCadena, _SMsj, _SQuery;
        private byte _BIdRole;

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

        public string SCadena
        {
            get
            {
                return _SCadena;
            }

            set
            {
                _SCadena = value;
            }
        }

        public string SContrasena
        {
            get
            {
                return _SContrasena;
            }

            set
            {
                _SContrasena = value;
            }
        }

        public string SMsj
        {
            get
            {
                return _SMsj;
            }

            set
            {
                _SMsj = value;
            }
        }

        public string SUsuario
        {
            get
            {
                return _SUsuario;
            }

            set
            {
                _SUsuario = value;
            }
        }

        public byte BIdRole
        {
            get
            {
                return _BIdRole;
            }

            set
            {
                _BIdRole = value;
            }
        }

        public string SQuery
        {
            get
            {
                return _SQuery;
            }

            set
            {
                _SQuery = value;
            }
        }
    }
}
