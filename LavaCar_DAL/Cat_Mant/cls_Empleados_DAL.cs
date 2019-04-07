using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaCar_DAL.Cat_Mant
{
    public class cls_Empleados_DAL
    {
        private int _iIdEmpleado, _iTel, _iIdEstado;
        private string _sIdenti, _sNombre, _sApellidos, _sAddress, _sEmail, _sPuesto, _sIdPoliza, _sIdUser;
        private char _cBandIM;

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
