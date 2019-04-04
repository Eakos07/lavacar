using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LavaCar_DAL.Cat_Mant;
using LavaCar_BLL.Cat_Mant;

namespace FRM_Login.Menu
{
    public partial class FRM_Tipo_Factura : Form
    {
        public FRM_Tipo_Factura()
        {
            InitializeComponent();
        }

        private void FRM_Tipo_Factura_Load(object sender, EventArgs e)
        {
            Cargar_Datos_TipoFactura();
        }
        public void Cargar_Datos_TipoFactura()
        {
            cls_TipoFactura_BLL Obj_BLL = new cls_TipoFactura_BLL();
            string sMsjError = string.Empty;
            DataTable dtTipoFactura = new DataTable();

            if (txt_FiltrarTipoFactura.Text == string.Empty)
            {
                dtTipoFactura = Obj_BLL.Listar_TipoFactura(ref sMsjError);
            }
            else
            {
                dtTipoFactura = Obj_BLL.Filtrar_TipoFactura(ref sMsjError, txt_FiltrarTipoFactura.Text);
            }
            if (sMsjError == string.Empty)
            {
                dgv_TipoFactura.DataSource = null;
                dgv_TipoFactura.DataSource = dtTipoFactura;
            }
        }

        private void txt_FiltrarTipoFactura_TextChanged(object sender, EventArgs e)
        {
            Cargar_Datos_TipoFactura();
        }
    }
}
