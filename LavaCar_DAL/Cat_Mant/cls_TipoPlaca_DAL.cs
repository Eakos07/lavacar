using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaCar_DAL.Cat_Mant
{
    public class cls_TipoPlaca_DAL
    {
        private byte _bIdTipoPlaca;
        private string _sDescripcion;

        #region Variables Publicas
        public byte bIdTipoPlaca
        {
            get
            {
                return _bIdTipoPlaca;
            }

            set
            {
                _bIdTipoPlaca = value;
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
        #endregion
    }
}
