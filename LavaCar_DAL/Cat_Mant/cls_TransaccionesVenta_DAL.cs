using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaCar_DAL.Cat_Mant
{
    public class cls_TransaccionesVenta_DAL
    {
        private int _iIdTransaccionVenta, _iNumFactura;
        private string _sIdArticulo;
        private DateTime _dFecha;
        private short _iCantidad;
        private decimal _dMonto;
        private byte _bIdEstado;
        private char _cBandera;

        public int iIdTransaccionVenta
        {
            get
            {
                return _iIdTransaccionVenta;
            }

            set
            {
                _iIdTransaccionVenta = value;
            }
        }

        public int iNumFactura
        {
            get
            {
                return _iNumFactura;
            }

            set
            {
                _iNumFactura = value;
            }
        }

        public string sIdArticulo
        {
            get
            {
                return _sIdArticulo;
            }

            set
            {
                _sIdArticulo = value;
            }
        }

        public DateTime dFecha
        {
            get
            {
                return _dFecha;
            }

            set
            {
                _dFecha = value;
            }
        }

        public short iCantidad
        {
            get
            {
                return _iCantidad;
            }

            set
            {
                _iCantidad = value;
            }
        }

        public decimal dMonto
        {
            get
            {
                return _dMonto;
            }

            set
            {
                _dMonto = value;
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

        public char cBandera
        {
            get
            {
                return _cBandera;
            }

            set
            {
                _cBandera = value;
            }
        }
    }
}
