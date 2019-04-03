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
    public partial class FRM_Clientes : Form
    {
        public FRM_Clientes()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            cls_Clientes_BLL Obj_BLL = new cls_Clientes_BLL();
            string sMsjError = string.Empty;
            DataTable dtClientes= new DataTable();

            if (toolStripTextBox1.Text == string.Empty)
            {
                dtClientes = Obj_BLL.Listar_Clientes(ref sMsjError);
            }
            else
            {
                dtClientes= Obj_BLL.Filtrar_Clientes(ref sMsjError, toolStripTextBox1.Text);
            }
            if (sMsjError == string.Empty)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dtClientes;
            }
        }
        private void FRM_Clientes_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
