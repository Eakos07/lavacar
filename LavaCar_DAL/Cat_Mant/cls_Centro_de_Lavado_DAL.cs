using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaCar_DAL.Cat_Mant
{
    public class cls_Centro_de_Lavado_DAL
    {
        private int _iCedulaJuridica, _iTelefono;
        private string _sNombreComercial, _sDireccion, _sEmail;

        #region Variables Públicas
        public int iCedulaJuridica
        {
            get
            {
                return _iCedulaJuridica;
            }

            set
            {
                _iCedulaJuridica = value;
            }
        }

        public int iTelefono
        {
            get
            {
                return _iTelefono;
            }

            set
            {
                _iTelefono = value;
            }
        }

        public string sDireccion
        {
            get
            {
                return _sDireccion;
            }

            set
            {
                _sDireccion = value;
            }
        }

        public string sEmail
        {
            get
            {
                return _sEmail;
            }

            set
            {
                _sEmail = value;
            }
        }

        public string sNombreComercial
        {
            get
            {
                return _sNombreComercial;
            }

            set
            {
                _sNombreComercial = value;
            }
        }
        #endregion

    }
}
