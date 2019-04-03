using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaCar_DAL.Cat_Mant
{
    public class cls_TipoCambio_DAL
    {
        private char _cTipoCambio;
        private decimal _dValor;
        private DateTime _dtmFecha;

        #region Variables Publicas
        public char cTipoCambio
        {
            get
            {
                return _cTipoCambio;
            }

            set
            {
                _cTipoCambio = value;
            }
        }

        public decimal dValor
        {
            get
            {
                return _dValor;
            }

            set
            {
                _dValor = value;
            }
        }

        public DateTime dtmFecha
        {
            get
            {
                return _dtmFecha;
            }

            set
            {
                _dtmFecha = value;
            }
        }
        #endregion
    }
}
