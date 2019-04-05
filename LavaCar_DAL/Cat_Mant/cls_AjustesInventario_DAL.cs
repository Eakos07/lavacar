using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaCar_DAL.Cat_Mant
{
    public class cls_AjustesInventario_DAL
    {
        private int _iIdTransaccionAjusteInventario;
        private string _sIdArticulo, _sDescripcion;
        private DateTime _dtFecha;
        private short _iCantidad;
        private decimal _dMonto;
        private char _cBandera;

        public int iIdTransaccionAjusteInventario
        {
            get
            {
                return _iIdTransaccionAjusteInventario;
            }

            set
            {
                _iIdTransaccionAjusteInventario = value;
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

        public string sDescripcion
        {
            get
            {
                return _sDescripcion;
            }

            set
            {
                _sDescripcion = value;
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
