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
    public partial class FRM_Proveedores : Form
    {
        public FRM_Proveedores()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        
        }

        private void FRM_Proveedores_Load(object sender, EventArgs e)
        {
            Cargar_Datos_Proveedores();
        }
        public void Cargar_Datos_Proveedores()
        {
            cls_Proveedores_BLL Obj_BLL = new cls_Proveedores_BLL();
            string sMsjError = string.Empty;
            DataTable dtProveedores = new DataTable();

            if (txt_FiltrarProveedores.Text == string.Empty)
            {
                dtProveedores = Obj_BLL.Listar_Proveedores(ref sMsjError);
            }
            else
            {
                dtProveedores = Obj_BLL.Filtrar_Proveedores(ref sMsjError, txt_FiltrarProveedores.Text);
            }
            if (sMsjError == string.Empty)
            {
                dgv_Proveedores.DataSource = null;
                dgv_Proveedores.DataSource = dtProveedores;
            }
        }

        private void txt_FiltrarProveedores_TextChanged(object sender, EventArgs e)
        {
            Cargar_Datos_Proveedores();
        }
    }
}
