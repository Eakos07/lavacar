using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaCar_DAL.Cat_Mant
{
    public class cls_Articulos_DAL
    {
        private string _sIdArticulo, _sNombreArticulo, _sIdFamilia;
        private Int16 _iCantidad, _iInventarioMinimo;
        private char _cIdTipoArticulo;
        private decimal _dPrecioVenta;
        private byte _bIdEstado;

        #region Variables Publicas
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

        public string sNombreArticulo
        {
            get
            {
                return _sNombreArticulo;
            }

            set
            {
                _sNombreArticulo = value;
            }
        }

        public string sIdFamilia
        {
            get
            {
                return _sIdFamilia;
            }

            set
            {
                _sIdFamilia = value;
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

        public short iInventarioMinimo
        {
            get
            {
                return _iInventarioMinimo;
            }

            set
            {
                _iInventarioMinimo = value;
            }
        }

        public char cIdTipoArticulo
        {
            get
            {
                return _cIdTipoArticulo;
            }

            set
            {
                _cIdTipoArticulo = value;
            }
        }

        public decimal dPrecioVenta
        {
            get
            {
                return _dPrecioVenta;
            }

            set
            {
                _dPrecioVenta = value;
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
        #endregion
    }
}
