using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaCar_DAL.Cat_Mant
{
    public class cls_TipoArticulo_DAL
    {
        private char _cIdTipoArticulo, _cBandIM, _cIdEstado;
        private string _sDescripcion;

        #region Variables Publicas
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
