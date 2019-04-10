using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaCar_DAL.Cat_Mant
{
    public class cls_Proveedores_DAL
    {
        private byte _bIdProveedor, _bPlazoPago;
        private string _sNombreProveedor, _sEmail;
        private int _iTelefono;
        private char _cBandIM, _cIdEstado;

        #region Variables Publicas
        public byte bIdProveedor
        {
            get
            {
                return _bIdProveedor;
            }

            set
            {
                _bIdProveedor = value;
            }
        }

        public byte bPlazoPago
        {
            get
            {
                return _bPlazoPago;
            }

            set
            {
                _bPlazoPago = value;
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

        public string sNombreProveedor
        {
            get
            {
                return _sNombreProveedor;
            }

            set
            {
                _sNombreProveedor = value;
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

        public int iTelefono
        {
            get
            {
                return _iTelefono;
            }

            set
            {
                _iTelefono = value;
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
        #endregion
    }
}
