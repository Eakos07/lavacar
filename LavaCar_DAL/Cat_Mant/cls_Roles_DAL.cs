using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaCar_DAL.Cat_Mant
{
    public class cls_Roles_DAL
    {
        private byte _bIdRole, _bNivel, _bIdEstado;
        private string _sDescripcion;

        #region Variables Publicas
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
        #endregion
    }
}
