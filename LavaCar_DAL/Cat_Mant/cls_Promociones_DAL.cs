using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaCar_DAL.Cat_Mant
{
    public class cls_Promociones_DAL
    {
        private char _cIdPromocion;
        private string _sTipoPromocion, _sDescripcion;

        #region Variables publicas
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

        public string sTipoPromocion
        {
            get
            {
                return _sTipoPromocion;
            }

            set
            {
                _sTipoPromocion = value;
            }
        }
        #endregion
    }
}
