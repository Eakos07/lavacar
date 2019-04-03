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
using LavaCar_DAL.Cat_Mant;

namespace FRM_Login.Menu
{
    public partial class FRM_Articulos : Form
    {
        public FRM_Articulos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_Articulos_Load(object sender, EventArgs e)
        {
            Cargar_Datos_FamiliaArticulos();
        }
        public void Cargar_Datos_FamiliaArticulos()
        {
            cls_FamiliaArticulos_BLL Obj_BLL = new cls_FamiliaArticulos_BLL();
            string sMsjError = string.Empty;
            DataTable dtFamiliaArticulos = new DataTable();

            if (txt_FiltrarFamiliaArticulos.Text == string.Empty)
            {
                dtFamiliaArticulos = Obj_BLL.Listar_FamiliaArticulos(ref sMsjError);
            }
            else
            {
                dtFamiliaArticulos = Obj_BLL.Filtrar_FamiliaArticulos(ref sMsjError, txt_FiltrarFamiliaArticulos.Text);
            }
            if (sMsjError == string.Empty)
            {
                dgv_FamiliaArticulos.DataSource = null;
                dgv_FamiliaArticulos.DataSource = dtFamiliaArticulos;
            }
        }

        private void txt_FiltrarFamiliaArticulos_TextChanged(object sender, EventArgs e)
        {
            Cargar_Datos_FamiliaArticulos();
        }
    }
}
