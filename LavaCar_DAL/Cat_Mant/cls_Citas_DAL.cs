using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaCar_DAL.Cat_Mant
{
    public class cls_Citas_DAL
    {
        private int _iNumCita, _iTel;
        private string _sMsjError, _sNombre, _sNumPlaca, _sEmail, _sHoraCita;
        private char _cCodeServ, _cBandIM;
        private DateTime _dtFechaCita;
        private byte _bIdEstado, _bIdEmpleado;

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

        public byte bIdEstado
        {
            get
            {
                return _bIdEstado;
            }

            set
            {
                _bIdEstado = value;
            }
        }

        public byte bIdEmpleado
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

        
        public char cBandIM
        {
            get
            {
                return _cBandIM;
            }

            set
            {
                _cBandIM = value;
            }
        }

        public string sHoraCita
        {
            get
            {
                return _sHoraCita;
            }

            set
            {
                _sHoraCita = value;
            }
        }
    }
}
