using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaCar_DAL.Cat_Mant
{
    public class cls_FamiliaArticulos_DAL
    {
        private string _sIdFamilia, _sDescripcion;
        private byte _bIdEstado;
        private char _cBandIM;

        #region Variables Publicas
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
