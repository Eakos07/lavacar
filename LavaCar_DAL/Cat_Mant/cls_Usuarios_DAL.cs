using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaCar_DAL.Cat_Mant
{
    public class cls_Usuarios_DAL
    {
        private string _sIdUsuario, _sContraseña;
        private byte _bIdRole, _bIdEstado;
        private char _cBandIM;

        #region Variables Publicas
        public string sIdUsuario
        {
            get
            {
                return _sIdUsuario;
            }

            set
            {
                _sIdUsuario = value;
            }
        }

        public string sContraseña
        {
            get
            {
                return _sContraseña;
            }

            set
            {
                _sContraseña = value;
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
