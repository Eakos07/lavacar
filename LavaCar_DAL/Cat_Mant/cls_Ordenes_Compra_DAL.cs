using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaCar_DAL.Cat_Mant
{
    public class cls_Ordenes_Compra_DAL
    {
        private int _iIdNumOrden;
        private byte _bIdProveedor, _bIdEstado;
        private Int16 _iCantidad;
        private decimal _dPrecio;
        private char _cBandIM;
        private string _sIdArticulo;

        #region Variables Públicas
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

        public decimal dPrecio
        {
            get
            {
                return _dPrecio;
            }

            set
            {
                _dPrecio = value;
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
        #endregion
    }
}
