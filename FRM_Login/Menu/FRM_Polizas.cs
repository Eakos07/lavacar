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
    public partial class FRM_Polizas : Form
    {
        public FRM_Polizas()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Cargar_Datos()
        {
            cls_Polizas_BLL Obj_BLL = new cls_Polizas_BLL();
            string sMsjError = string.Empty;
            DataTable dtPolizas = new DataTable();

            if (toolStripTextBox1.Text == string.Empty)
            {
                dtPolizas = Obj_BLL.Listar_Polizas(ref sMsjError);
            }
            else
            {
                dtPolizas = Obj_BLL.Filtrar_Polizas(ref sMsjError, toolStripTextBox1.Text);
            }
            if (sMsjError == string.Empty)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dtPolizas;
            }
        }

        private void FRM_Polizas_Load(object sender, EventArgs e)
        {
            Cargar_Datos();
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            Cargar_Datos();
        }
    }
}
