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
        public void Cargar_Polizas()
        {
            cls_Polizas_BLL Obj_Polizas_BLL = new cls_Polizas_BLL();
            cls_TipoPolizas_BLL Obj_TipoPolizas_BLL = new cls_TipoPolizas_BLL();
            string sMsjError = string.Empty;
            DataTable dtPolizas = new DataTable();

            if (txt_FiltrarTipoPoliza.Text == string.Empty)
            {
                dtPolizas = Obj_Polizas_BLL.Listar_Polizas(ref sMsjError);
            }
            else
            {
                dtPolizas = Obj_Polizas_BLL.Filtrar_Polizas(ref sMsjError, txt_FiltrarTipoPoliza.Text);
            }

            if (sMsjError == string.Empty)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dtPolizas;
            }
        }
        public void Cargar_TipoPolizas()
        {
            cls_TipoPolizas_BLL Obj_TipoPolizas_BLL = new cls_TipoPolizas_BLL();
            string sMsjError = string.Empty;
            DataTable dtTipoPolizas = new DataTable();

            if (toolStripTextBox2.Text == string.Empty)
            {
                dtTipoPolizas = Obj_TipoPolizas_BLL.Listar_TipoPolizas(ref sMsjError);
            }
            else
            {
                dtTipoPolizas = Obj_TipoPolizas_BLL.Filtrar_TipoPolizas(ref sMsjError, toolStripTextBox2.Text);
            }
            if (sMsjError == string.Empty)
            {
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = dtTipoPolizas;
             }

        }

        private void FRM_Polizas_Load(object sender, EventArgs e)
        {
            Cargar_Polizas();
            Cargar_TipoPolizas();
        }

        private void toolStripTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            Cargar_Polizas();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripTextBox2_TextChanged(object sender, EventArgs e)
        {
            Cargar_TipoPolizas();
        }

        private void btnSalir_TipoPolizas_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
