using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaCar_DAL.Cat_Mant
{
    public class cls_TipoServicio_DAL
    {
        private char _cCodServicio, _cBandIM;
        private string _sNombreServicio;
        private decimal _dPrecio;
        private DateTime _dtmDuracion;
        private byte _bIdTipoVehiculo;

        #region Variables Públicas
        public char cCodServicio
        {
            get
            {
                return _cCodServicio;
            }

            set
            {
                _cCodServicio = value;
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

        public string sNombreServicio
        {
            get
            {
                return _sNombreServicio;
            }

            set
            {
                _sNombreServicio = value;
            }
        }

        public decimal dPrecio
        {
            get
            {
                return _dPrecio;
            }

            set
            {
                _dPrecio = value;
            }
        }

        public DateTime dtmDuracion
        {
            get
            {
                return _dtmDuracion;
            }

            set
            {
                _dtmDuracion = value;
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
#endregion
    }
}
