using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaCar_DAL.Cat_Mant
{
    public class cls_TipoArticulo_DAL
    {
        private char _cIdTipoArticulo;
        private string _sDescripcion;
        private byte _bIdEstado;

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
