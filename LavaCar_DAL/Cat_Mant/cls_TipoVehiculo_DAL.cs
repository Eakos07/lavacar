﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaCar_DAL.Cat_Mant
{
    public class cls_TipoVehiculo_DAL
    {
        private byte _bIdTipoVehiculo;
        private string _sDescripcion;
        private char _cBandIM;

        #region Variables publicas 

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
