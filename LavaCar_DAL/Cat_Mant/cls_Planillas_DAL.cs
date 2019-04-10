using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaCar_DAL.Cat_Mant
{
    public class cls_Planillas_DAL
    {
        private int _iIdPlanilla;
        private byte _bIdEmpleado, _bIdHorario;
        private char _cBandIM , _cIdEstado;

        #region Variables Publicas
        public int iIdPlanilla
        {
            get
            {
                return _iIdPlanilla;
            }

            set
            {
                _iIdPlanilla = value;
            }
        }

        public byte bIdEmpleado
        {
            get
            {
                return _bIdEmpleado;
            }

            set
            {
                _bIdEmpleado = value;
            }
        }

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
