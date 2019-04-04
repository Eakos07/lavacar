using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LavaCar_BLL.Cat_Mant;
using LavaCar_DAL.Cat_Mant;

namespace FRM_Login.Menu
{
    public partial class FRM_Tipo_Cambio : Form
    {
        public FRM_Tipo_Cambio()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FRM_Tipo_Cambio_Load(object sender, EventArgs e)
        {
            Cargar_Datos_TipoCambio();
        }
        public void Cargar_Datos_TipoCambio()
        {
            cls_TipoCambio_BLL Obj_BLL = new cls_TipoCambio_BLL();
            string sMsjError = string.Empty;
            DataTable dtTipoCambio = new DataTable();

            if (txt_FiltrarTipoCambio.Text == string.Empty)
            {
                dtTipoCambio = Obj_BLL.Listar_TipoCambio(ref sMsjError);
            }
            else
            {
                dtTipoCambio = Obj_BLL.Filtrar_TipoCambio(ref sMsjError, txt_FiltrarTipoCambio.Text);
            }
            if (sMsjError == string.Empty)
            {
                dgv_TipoCambio.DataSource = null;
                dgv_TipoCambio.DataSource = dtTipoCambio;
            }
        }

        private void txt_FiltrarTipoCambio_TextChanged(object sender, EventArgs e)
        {
            Cargar_Datos_TipoCambio();
        }
    }
}
