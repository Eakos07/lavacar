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
    public partial class FRM_Factura : Form
    {
        public FRM_Factura()
        {
            InitializeComponent();
        }

        private void FRM_Factura_Load(object sender, EventArgs e)
        {
            Cargar_Datos_Factura();
        }
        public void Cargar_Datos_Factura()
        {
            cls_Factura_BLL Obj_BLL = new cls_Factura_BLL();
            string sMsjError = string.Empty;
            DataTable dtFactura = new DataTable();

            if (txt_FiltrarFacturas.Text == string.Empty)
            {
                dtFactura = Obj_BLL.Listar_Factura(ref sMsjError);
            }
            else
            {
                dtFactura = Obj_BLL.Filtrar_Factura(ref sMsjError, txt_FiltrarFacturas.Text);
            }
            if (sMsjError == string.Empty)
            {
                dgv_Facturas.DataSource = null;
                dgv_Facturas.DataSource = dtFactura;
            }
        }

        private void txt_FiltrarFacturas_TextChanged(object sender, EventArgs e)
        {
            Cargar_Datos_Factura();
        }
    }
}
