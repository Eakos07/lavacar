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
    public partial class FRM_Ajuste_Inventario : Form
    {
        public FRM_Ajuste_Inventario()
        {
            InitializeComponent();
        }

        private void CargarAjustesInventario()
        {
            cls_AjustesInventario_BLL Ajuste_BLL = new cls_AjustesInventario_BLL();
            string sMsjError = string.Empty;
            DataTable DT = new DataTable();
            if (txt_FiltrarDescrip.Text == string.Empty)
            {
                DT = Ajuste_BLL.ListarAjustesInventario(ref sMsjError);
            }
            else
            {
                DT = Ajuste_BLL.FiltrarAjustesInventario(ref sMsjError, txt_FiltrarDescrip.Text.Trim());
            }

            if (sMsjError == string.Empty)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = DT;
            }
            else
            {
                dataGridView1.DataSource = null;

                MessageBox.Show("Se presento un error a la hora de listar los estados.\n\nDetalle Error : [" + sMsjError + "]",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FRM_Ajuste_Inventario_Load(object sender, EventArgs e)
        {
            CargarAjustesInventario();
        }
    }
}
