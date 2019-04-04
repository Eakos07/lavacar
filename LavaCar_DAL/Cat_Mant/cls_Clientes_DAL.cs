using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaCar_DAL.Cat_Mant
{
    public class cls_Clientes_DAL
    {
        private string _sNumPlaca;
        private byte _bIdTipoPlaca, _bIdTipoVehiculo, _bNumVisitas;
        private char _cBandIM;

        #region Variables Públicas
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

        public byte bIdTipoVehiculo
        {
            get
            {
                return _bIdTipoVehiculo;
            }

            set
            {
                _bIdTipoVehiculo = value;
            }
        }

        public byte bNumVisitas
        {
            get
            {
                return _bNumVisitas;
            }

            set
            {
                _bNumVisitas = value;
            }
        }

        public string sNumPlaca
        {
            get
            {
                return _sNumPlaca;
            }

            set
            {
                _sNumPlaca = value;
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
