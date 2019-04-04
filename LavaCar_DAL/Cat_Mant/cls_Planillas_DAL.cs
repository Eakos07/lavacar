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
        private byte _bIdEmpleado, _bIdHorario, _bIdEstado;
        private char _cBandIM;

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
