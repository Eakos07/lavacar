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
    public partial class FRM_Ordenes___de_Compras : Form
    {
        public FRM_Ordenes___de_Compras()
        {
            InitializeComponent();
        }

        #region Variables Globales
        cls_Ordenes_Compra_BLL Obj_OrdenesCompra_BLL = new cls_Ordenes_Compra_BLL();
        cls_Ordenes_Compra_DAL Obj_OrdenesCompra_DAL = new cls_Ordenes_Compra_DAL();

        #endregion
        public void Cargar_Datos()
        {
            txt_NumOrden.Enabled = false;
            string sMsjError = string.Empty;
            DataTable DT_Ordenes = new DataTable();
            Obj_OrdenesCompra_DAL.cBandIM = 'I';

            #region Cargar Estados
            cls_Estados_BLL Obj_Estados_BLL = new cls_Estados_BLL();
            DataTable DT_Estados = new DataTable();
            DT_Estados = Obj_Estados_BLL.Listar_Estados(ref sMsjError);
            cmb_IdEstado.DataSource = DT_Estados;
            DT_Estados.Rows.Add("0", "Elija una opción");
            cmb_IdEstado.DisplayMember = DT_Estados.Columns[1].ToString();
            cmb_IdEstado.ValueMember = DT_Estados.Columns[0].ToString();
            cmb_IdEstado.SelectedValue = "0";
            #endregion
            
            #region Cargar Proveedor
            cls_Proveedores_BLL Obj_Proveedores_BLL = new cls_Proveedores_BLL();
            DataTable DT_Proveedores = new DataTable();
            DT_Proveedores = Obj_Proveedores_BLL.Listar_Proveedores(ref sMsjError);
            cmb_IdProve.DataSource = DT_Proveedores;
            DT_Proveedores.Rows.Add("0", "Elija una opción");
            cmb_IdProve.DisplayMember = DT_Proveedores.Columns[1].ToString();
            cmb_IdProve.ValueMember = DT_Proveedores.Columns[0].ToString();
            cmb_IdProve.SelectedValue = "0";
            #endregion

            #region Cargar Articulo
            cls_Articulos_BLL Obj_Articulo_BLL = new cls_Articulos_BLL();
            DataTable DT_Articulos = new DataTable();
            DT_Articulos = Obj_Articulo_BLL.Listar_Articulos(ref sMsjError);
            cmb_IdArticulo.DataSource = DT_Articulos;
            DT_Articulos.Rows.Add("0", "Elija una opción");
            cmb_IdArticulo.DisplayMember = DT_Articulos.Columns[1].ToString();
            cmb_IdArticulo.ValueMember = DT_Articulos.Columns[0].ToString();
            cmb_IdArticulo.SelectedValue = "0";
            #endregion

            if (txt_Filtrar.Text== string.Empty)
            {
                DT_Ordenes= Obj_OrdenesCompra_BLL.Listar_OrdenesCompra(ref sMsjError);
            }
            else
            {
                DT_Ordenes = Obj_OrdenesCompra_BLL.Filtrar_OrdenesCompra(ref sMsjError, txt_Filtrar.Text);
            }
            if (sMsjError == String.Empty)
            {
                dgv_Ordenes_Compra.DataSource = null;
                dgv_Ordenes_Compra.DataSource = DT_Ordenes;
            }
        }

        private void FRM_Ordenes___de_Compras_Load(object sender, EventArgs e)
        {
            Cargar_Datos();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txt_Cantidad.Text)) &&
                !(string.IsNullOrEmpty(txt_Precio.Text)) && cmb_IdEstado.SelectedValue.ToString() != "0" ||
                cmb_IdProve.SelectedValue.ToString() != "0" && cmb_IdArticulo.SelectedValue.ToString() != "0")
            {
                
                Obj_OrdenesCompra_DAL.iCantidad = Convert.ToInt16(txt_Cantidad.Text);
                Obj_OrdenesCompra_DAL.dPrecio = Convert.ToDecimal(txt_Precio.Text);
                Obj_OrdenesCompra_DAL.bIdEstado = Convert.ToByte(cmb_IdEstado.SelectedValue);
                Obj_OrdenesCompra_DAL.bIdProveedor = Convert.ToByte(cmb_IdProve.SelectedValue);
                Obj_OrdenesCompra_DAL.sIdArticulo = cmb_IdArticulo.SelectedValue.ToString();
                string sMsjError = string.Empty;

                if (Obj_OrdenesCompra_DAL.cBandIM =='I')
                {
                    Obj_OrdenesCompra_BLL.Insertar_OrdenesCompra(ref sMsjError, ref Obj_OrdenesCompra_DAL);
                    MessageBox.Show("Nuevo registro ingresado exitosamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cargar_Datos();
                }
                else if (Obj_OrdenesCompra_DAL.cBandIM == 'M')
                {
                    Obj_OrdenesCompra_BLL.Modificar_OrdenesCompra(ref sMsjError, ref Obj_OrdenesCompra_DAL);
                    MessageBox.Show("Modificación de registro exitosa", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_NumOrden.Enabled = false;
                    Cargar_Datos();
                }
            }
            else
            {
                MessageBox.Show("No se pueden guardar datos vacios", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_Refrescar_Click(object sender, EventArgs e)
        {
            Cargar_Datos();
        }

        private void txt_Filtrar_TextChanged(object sender, EventArgs e)
        {
            Cargar_Datos();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (dgv_Ordenes_Compra.RowCount.Equals(0))
            {
                MessageBox.Show("No hay datos para modificar");
            }
            else
            {
                Obj_OrdenesCompra_DAL.cBandIM = 'M';
                txt_NumOrden.Enabled = false;

                txt_NumOrden.Text = dgv_Ordenes_Compra.SelectedRows[0].Cells[0].Value.ToString().Trim();
                cmb_IdProve.Text = dgv_Ordenes_Compra.SelectedRows[0].Cells[1].Value.ToString().Trim();
                cmb_IdArticulo.Text = dgv_Ordenes_Compra.SelectedRows[0].Cells[2].Value.ToString().Trim();
                txt_Cantidad.Text = dgv_Ordenes_Compra.SelectedRows[0].Cells[3].Value.ToString().Trim();
                txt_Precio.Text = dgv_Ordenes_Compra.SelectedRows[0].Cells[4].Value.ToString().Trim();
                cmb_IdEstado.Text = dgv_Ordenes_Compra.SelectedRows[0].Cells[0].Value.ToString().Trim();
            }
        }

        private void dgv_Ordenes_Compra_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
                Obj_OrdenesCompra_DAL.cBandIM = 'M';
                txt_NumOrden.Enabled = false;

                txt_NumOrden.Text = dgv_Ordenes_Compra.SelectedRows[0].Cells[0].Value.ToString().Trim();
                cmb_IdProve.Text = dgv_Ordenes_Compra.SelectedRows[0].Cells[1].Value.ToString().Trim();
                cmb_IdArticulo.Text = dgv_Ordenes_Compra.SelectedRows[0].Cells[2].Value.ToString().Trim();
                txt_Cantidad.Text = dgv_Ordenes_Compra.SelectedRows[0].Cells[3].Value.ToString().Trim();
                txt_Precio.Text = dgv_Ordenes_Compra.SelectedRows[0].Cells[4].Value.ToString().Trim();
                cmb_IdEstado.Text = dgv_Ordenes_Compra.SelectedRows[0].Cells[0].Value.ToString().Trim();
            
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
