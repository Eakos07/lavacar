using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaCar_DAL.Cat_Mant
{
    public class cls_Factura_DAL
    {
        private int _iNumFactura, _iCedulaJuridica;
        private string _sNumPlaca;
        private char _cCodServicio, _cIdTipoCambio, _cIdPromocion, _cIdTipoFactura, _cBandIM;
        private decimal _dMontoNeto, _dDescuento, _dMontoTotal;

        #region Variables Publicas
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

        public int iCedulaJuridica
        {
            get
            {
                return _iCedulaJuridica;
            }

            set
            {
                _iCedulaJuridica = value;
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

        public char cCodServicio
        {
            get
            {
                return _cCodServicio;
            }

            set
            {
                _cCodServicio = value;
            }
        }

        public char cIdTipoCambio
        {
            get
            {
                return _cIdTipoCambio;
            }

            set
            {
                _cIdTipoCambio = value;
            }
        }

        public char cIdPromocion
        {
            get
            {
                return _cIdPromocion;
            }

            set
            {
                _cIdPromocion = value;
            }
        }

        public char cIdTipoFactura
        {
            get
            {
                return _cIdTipoFactura;
            }

            set
            {
                _cIdTipoFactura = value;
            }
        }

        public decimal dMontoNeto
        {
            get
            {
                return _dMontoNeto;
            }

            set
            {
                _dMontoNeto = value;
            }
        }

        public decimal dDescuento
        {
            get
            {
                return _dDescuento;
            }

            set
            {
                _dDescuento = value;
            }
        }

        public decimal dMontoTotal
        {
            get
            {
                return _dMontoTotal;
            }

            set
            {
                _dMontoTotal = value;
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
