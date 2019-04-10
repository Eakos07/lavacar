using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaCar_DAL.Cat_Mant
{
    public class cls_Horarios_DAL
    {
        private byte _bIdHorario;
        private string _sDescripcion;
        private float _fCantHoras;
        private DateTime _dtmEntrada, _dtmSalida;
        private char _cBandIM, _cIdEstado;

        #region Variables Publicas
        public byte bIdHorario
        {
            get
            {
                return _bIdHorario;
            }

            set
            {
                _bIdHorario = value;
            }
        }

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

        public float fCantHoras
        {
            get
            {
                return _fCantHoras;
            }

            set
            {
                _fCantHoras = value;
            }
        }

        public DateTime dtmEntrada
        {
            get
            {
                return _dtmEntrada;
            }

            set
            {
                _dtmEntrada = value;
            }
        }

        public DateTime dtmSalida
        {
            get
            {
                return _dtmSalida;
            }

            set
            {
                _dtmSalida = value;
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
