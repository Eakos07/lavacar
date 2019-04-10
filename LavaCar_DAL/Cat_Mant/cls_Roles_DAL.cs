using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaCar_DAL.Cat_Mant
{
    public class cls_Roles_DAL
    {
        private byte _bIdRole, _bNivel;
        private string _sDescripcion;
        private char _cBandIM, _cIdEstado;

        #region Variables Publicas
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

        public byte bIdRole
        {
            get
            {
                return _bIdRole;
            }

            set
            {
                _bIdRole = value;
            }
        }

        public byte bNivel
        {
            get
            {
                return _bNivel;
            }

            set
            {
                _bNivel = value;
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
