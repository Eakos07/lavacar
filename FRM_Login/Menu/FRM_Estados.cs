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
    public partial class FRM_Estados : Form
    {
        public FRM_Estados()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_Estados_Load(object sender, EventArgs e)
        {
            Cargar_Datos();
        }
        public void Cargar_Datos()
        {
            cls_Estados_BLL Obj_BLL = new cls_Estados_BLL();
            string sMsjError = string.Empty;
            DataTable dtEstados = new DataTable();

            if(toolStripTextBox1.Text == string.Empty)
            {
                dtEstados = Obj_BLL.Listar_Estados(ref sMsjError);
            }
            else
            {
                dtEstados = Obj_BLL.Filtrar_Estados(ref sMsjError, toolStripTextBox1.Text);
            }
            if (sMsjError == string.Empty)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dtEstados;
            }
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            Cargar_Datos();
        }
    }
}
