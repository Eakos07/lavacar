using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaCar_DAL.Cat_Mant
{
    public class cls_Polizas_DAL
    {
        private string _sIdPoliza;
        private char _cIdTipoPoliza;
        private DateTime _dFechaVencimiento;
        private byte _bIdEstado;
        private int _iCedulaJuridica;

        #region Variables públicas
        public string sIdPoliza
        {
            get
            {
                return _sIdPoliza;
            }

            set
            {
                _sIdPoliza = value;
            }
        }

        public char cIdTipoPoliza
        {
            get
            {
                return _cIdTipoPoliza;
            }

            set
            {
                _cIdTipoPoliza = value;
            }
        }

        public DateTime dFechaVencimiento
        {
            get
            {
                return _dFechaVencimiento;
            }

            set
            {
                _dFechaVencimiento = value;
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
        #endregion
    }
}
