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
            Cargar_Datos_Articulos();
            Cargar_Datos_TipoArticulo();
        }
        #region Familia Articulos
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
        #endregion

        #region Articulos
        public void Cargar_Datos_Articulos()
        {
            cls_Articulos_BLL Obj_BLL = new cls_Articulos_BLL();
            string sMsjError = string.Empty;
            DataTable dtArticulos = new DataTable();

            if (txt_FiltrarArticulos.Text == string.Empty)
            {
                dtArticulos = Obj_BLL.Listar_Articulos(ref sMsjError);
            }
            else
            {
                dtArticulos = Obj_BLL.Filtrar_Articulos(ref sMsjError, txt_FiltrarArticulos.Text);
            }
            if (sMsjError == string.Empty)
            {
                dgv_Articulos.DataSource = null;
                dgv_Articulos.DataSource = dtArticulos;
            }
        }
        #endregion

        #region Tipo Articulo
        public void Cargar_Datos_TipoArticulo()
        {
            cls_TipoArticulo_BLL Obj_BLL = new cls_TipoArticulo_BLL();
            string sMsjError = string.Empty;
            DataTable dtTipoArticulo = new DataTable();

            if (txt_FiltrarTipoArticulos.Text == string.Empty)
            {
                dtTipoArticulo = Obj_BLL.Listar_TipoArticulo(ref sMsjError);
            }
            else
            {
                dtTipoArticulo = Obj_BLL.Filtrar_TipoArticulo(ref sMsjError, txt_FiltrarTipoArticulos.Text);
            }
            if (sMsjError == string.Empty)
            {
                dgv_TipoArticulos.DataSource = null;
                dgv_TipoArticulos.DataSource = dtTipoArticulo;
            }
        }
        #endregion

        private void txt_FiltrarFamiliaArticulos_TextChanged(object sender, EventArgs e)
        {
            Cargar_Datos_FamiliaArticulos();
        }

        private void txt_FiltrarArticulos_TextChanged(object sender, EventArgs e)
        {
            Cargar_Datos_Articulos();
        }

        private void txt_FiltrarTipoArticulos_TextChanged(object sender, EventArgs e)
        {
            Cargar_Datos_TipoArticulo();
        }
    }
}
