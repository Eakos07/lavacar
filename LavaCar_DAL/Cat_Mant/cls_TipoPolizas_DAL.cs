using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaCar_DAL.Cat_Mant
{
    public class cls_TipoPolizas_DAL
    {
        private char _cIdTipoPoliza;
        private string _sNombrePoliza, _sCompañia;
        private byte _bIdProveedor;

        #region Variables Públicas
        public char cIdTipoPoliza
        {
            get
            {
                return _cIdTipoPoliza;
            }

            set
            {
                _cIdTipoPoliza = value;
            }
        }

        public string sNombrePoliza
        {
            get
            {
                return _sNombrePoliza;
            }

            set
            {
                _sNombrePoliza = value;
            }
        }

        public string sCompañia
        {
            get
            {
                return _sCompañia;
            }

            set
            {
                _sCompañia = value;
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
#endregion

    }
}
