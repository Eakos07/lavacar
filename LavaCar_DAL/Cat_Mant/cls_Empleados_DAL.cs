using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaCar_DAL.Cat_Mant
{
    public class cls_Empleados_DAL
    {
        private int  _iTel;
        private string _sIdenti, _sNombre, _sApellidos, _sAddress, _sEmail, _sPuesto, _sIdPoliza, _sIdUser;
        private char _cBandIM, _cIdEstado;
        private byte _bIdEmpleado;

        public byte  bIdEmpleado
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

        public char cIdEstado
        {
            get
            {
                return _cIdEstado;
            }

            set
            {
                _cIdEstado = value;
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

        public string sAddress
        {
            get
            {
                return _sAddress;
            }

            set
            {
                _sAddress = value;
            }
        }

        public string sApellidos
        {
            get
            {
                return _sApellidos;
            }

            set
            {
                _sApellidos = value;
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

        public string sIdenti
        {
            get
            {
                return _sIdenti;
            }

            set
            {
                _sIdenti = value;
            }
        }

        public string sIdPoliza
        {
            get
            {
                return _sIdPoliza;
            }

            set
            {
                _sIdPoliza = value;
            }
        }

        public string sIdUser
        {
            get
            {
                return _sIdUser;
            }

            set
            {
                _sIdUser = value;
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

        public string sPuesto
        {
            get
            {
                return _sPuesto;
            }

            set
            {
                _sPuesto = value;
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
    }
}
