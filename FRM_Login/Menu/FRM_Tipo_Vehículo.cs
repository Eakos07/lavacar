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
    public partial class FRM_Tipo_Vehículo : Form
    {
        public FRM_Tipo_Vehículo()
        {
            InitializeComponent();
        }
        public void Cargar_Datos()
        {
            cls_TipoVehiculo_BLL Obj_BLL = new cls_TipoVehiculo_BLL();
            string sMsjError = string.Empty;
            DataTable dtTipoVehiculo = new DataTable();

            if (toolStripTextBox1.Text == string.Empty)
            {
                dtTipoVehiculo = Obj_BLL.Listar_TipoVehiculo(ref sMsjError);
            }
            else
            {
                dtTipoVehiculo = Obj_BLL.Filtrar_TipoVehiculo(ref sMsjError, toolStripTextBox1.Text);
            }
            if (sMsjError == string.Empty)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dtTipoVehiculo;
            }
        }


        private void FRM_Tipo_Vehículo_Load(object sender, EventArgs e)
        {
            Cargar_Datos();
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            Cargar_Datos();
        }
    }
}
