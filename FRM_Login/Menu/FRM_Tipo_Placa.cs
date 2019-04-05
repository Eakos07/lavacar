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
namespace FRM_Login.Menu
{ 
    public partial class FRM_Tipo_Placa : Form
    {
        public FRM_Tipo_Placa()
        {
            InitializeComponent();
        }

        public void Cargar_Datos()
        {
            cls_TipoPlaca_BLL Obj_BLL = new cls_TipoPlaca_BLL();
            string sMsjError = string.Empty;
            DataTable dtTipoPlaca = new DataTable();

            if (toolStripTextBox1.Text == string.Empty)
            {
                dtTipoPlaca = Obj_BLL.Listar_TipoPlaca(ref sMsjError);
            }
            else
            {
                dtTipoPlaca = Obj_BLL.Filtrar_TipoPlaca(ref sMsjError, toolStripTextBox1.Text);
            }
            if (sMsjError == string.Empty)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dtTipoPlaca;
            }

        }

        private void FRM_Tipo_Placa_Load(object sender, EventArgs e)
        {
            Cargar_Datos();
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            Cargar_Datos();
        }
    }
}
