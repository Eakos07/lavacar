using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaCar_DAL.Cat_Mant
{
    public class cls_TransaccionesCompra_DAL
    {
        private string _sIdArticulo, _sDocumento;
        private int _iIdTransaccionCompra, _iIdNumOrden;
        private DateTime _dtFecha;
        private short _iCantidad;
        private byte _bIdProveedor;
        private decimal _dMonto;
        private char _cBandera;

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

        public string sDocumento
        {
            get
            {
                return _sDocumento;
            }

            set
            {
                _sDocumento = value;
            }
        }

        public int iIdTransaccionCompra
        {
            get
            {
                return _iIdTransaccionCompra;
            }

            set
            {
                _iIdTransaccionCompra = value;
            }
        }

        public int iIdNumOrden
        {
            get
            {
                return _iIdNumOrden;
            }

            set
            {
                _iIdNumOrden = value;
            }
        }

        public DateTime dtFecha
        {
            get
            {
                return _dtFecha;
            }

            set
            {
                _dtFecha = value;
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
