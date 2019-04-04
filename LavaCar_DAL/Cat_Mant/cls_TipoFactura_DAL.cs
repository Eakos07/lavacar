using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaCar_DAL.Cat_Mant
{
    public class cls_TipoFactura_DAL
    {
        private char _cIdTipoFactura, _cBandIM;
        private string _sTipoFactura, _sDescripcion;

        #region Variables Publicas
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

        public string sTipoFactura
        {
            get
            {
                return _sTipoFactura;
            }

            set
            {
                _sTipoFactura = value;
            }
        }
        #endregion
    }
}
