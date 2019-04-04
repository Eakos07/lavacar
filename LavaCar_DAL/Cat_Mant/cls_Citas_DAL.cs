using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LavaCar_DAL.Cat_Mant
{
    public class cls_Citas_DAL
    {
        public DataTable Obj_DataTable = new DataTable();

        private int _iNumCita, _iTel, _iIdEstado, _iIdEmpleado;
        private string _sMsjError, _sNombre, _sNumPlaca, _sEmail;
        private char _cCodeServ;
        private DateTime _dtFechaCita;
        private int _dtHoraCita;

        public int iNumCita
        {
            get
            {
                return _iNumCita;
            }

            set
            {
                _iNumCita = value;
            }
        }

        public int iTel
        {
            get
            {
                return _iTel;
            }

            set
            {
                _iTel = value;
            }
        }

        public string sNombre
        {
            get
            {
                return _sNombre;
            }

            set
            {
                _sNombre = value;
            }
        }

        public string sNumPlaca
        {
            get
            {
                return _sNumPlaca;
            }

            set
            {
                _sNumPlaca = value;
            }
        }

        public string sEmail
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

        public char cCodeServ
        {
            get
            {
                return _cCodeServ;
            }

            set
            {
                _cCodeServ = value;
            }
        }

        public DateTime dtFechaCita
        {
            get
            {
                return _dtFechaCita;
            }

            set
            {
                _dtFechaCita = value;
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

        public int iIdEstado
        {
            get
            {
                return _iIdEstado;
            }

            set
            {
                _iIdEstado = value;
            }
        }

        public int iIdEmpleado
        {
            get
            {
                return _iIdEmpleado;
            }

            set
            {
                _iIdEmpleado = value;
            }
        }

        public int dtHoraCita
        {
            get
            {
                return _dtHoraCita;
            }

            set
            {
                _dtHoraCita = value;
            }
        }
    }
}
