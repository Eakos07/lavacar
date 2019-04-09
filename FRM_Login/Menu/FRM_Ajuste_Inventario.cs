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
    public partial class FRM_Ajuste_Inventario : Form
    {
        public FRM_Ajuste_Inventario()
        {
            InitializeComponent();
        }
        #region Variables Globales
        cls_AjustesInventario_DAL AjuDAL = new cls_AjustesInventario_DAL();
        cls_AjustesInventario_BLL Ajuste_BLL = new cls_AjustesInventario_BLL();
        #endregion

        private void CargarAjustesInventario()
        {            
            string sMsjError = string.Empty;
            DataTable DT = new DataTable();
            AjuDAL.cBandera = 'I';

            if (txt_FiltrarDescrip.Text == string.Empty)
            {
                DT = Ajuste_BLL.ListarAjustesInventario(ref sMsjError);
            }
            else
            {
                DT = Ajuste_BLL.FiltrarAjustesInventario(ref sMsjError, txt_FiltrarDescrip.Text.Trim());
            }

            if (sMsjError == string.Empty)
            {
                dgv_Ajuste.DataSource = null;
                dgv_Ajuste.DataSource = DT;
            }
            else
            {
                dgv_Ajuste.DataSource = null;

                MessageBox.Show("Se presento un error a la hora de listar los estados.\n\nDetalle Error : [" + sMsjError + "]",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void Cargar_cmb()
        {
            string sMsjError = string.Empty;

            cls_Articulos_BLL BLLArticulo = new cls_Articulos_BLL();
            DataTable DTA = new DataTable();
            DTA = BLLArticulo.Listar_Articulos(ref sMsjError);
            cmb_Articulo.DataSource = DTA;
            DTA.Rows.Add("0", "Elija Articulo");
            cmb_Articulo.DisplayMember = DTA.Columns[1].ToString();
            cmb_Articulo.ValueMember = DTA.Columns[0].ToString();
            cmb_Articulo.SelectedValue = "0";
        }

        private void FRM_Ajuste_Inventario_Load(object sender, EventArgs e)
        {
            CargarAjustesInventario();
            Cargar_cmb();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (dgv_Ajuste.RowCount == 0)
            {
                MessageBox.Show("No existen datos para modificar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {              
                //AjuDAL.cBandera = 'U';
                AjuDAL.cBandera = 'M';

                txt_IdAjus.Text = dgv_Ajuste.SelectedRows[0].Cells[0].Value.ToString().Trim();
                cmb_Articulo.Text = dgv_Ajuste.SelectedRows[0].Cells[1].Value.ToString().Trim();
                txt_Descrip.Text = dgv_Ajuste.SelectedRows[0].Cells[2].Value.ToString().Trim();
                txt_Fecha.Text = dgv_Ajuste.SelectedRows[0].Cells[3].Value.ToString().Trim();
                txt_Cantidad.Text = dgv_Ajuste.SelectedRows[0].Cells[4].Value.ToString().Trim();
                txt_Monto.Text = dgv_Ajuste.SelectedRows[0].Cells[5].Value.ToString().Trim();

                //AjuDAL.iIdTransaccionAjusteInventario = Convert.ToInt32(dgv_Ajuste.SelectedRows[0].Cells[0].Value.ToString().Trim());
                //AjuDAL.sIdArticulo = dgv_Ajuste.SelectedRows[0].Cells[1].Value.ToString().Trim();
                //AjuDAL.sDescripcion = dgv_Ajuste.SelectedRows[0].Cells[2].Value.ToString().Trim();
                //AjuDAL.dtFecha = Convert.ToDateTime(dgv_Ajuste.SelectedRows[0].Cells[3].Value.ToString().Trim());
                //AjuDAL.iCantidad = Convert.ToInt16(dgv_Ajuste.SelectedRows[0].Cells[4].Value.ToString().Trim());
                //AjuDAL.dMonto = Convert.ToDecimal(dgv_Ajuste.SelectedRows[0].Cells[5].Value.ToString().Trim());

                //txt_IdAjus.Text = AjuDAL.iIdTransaccionAjusteInventario.ToString();
                //txt_Descrip.Text = AjuDAL.sDescripcion;
                //txt_Fecha.Text = AjuDAL.dtFecha.ToString();
                //txt_Cantidad.Text = AjuDAL.iCantidad.ToString();
                //txt_Monto.Text = AjuDAL.dMonto.ToString();

                //string sMsjError = string.Empty;

                //Combobox Articulo
                //cls_Articulos_BLL BLLArticulo = new cls_Articulos_BLL();
                //DataTable DTA = new DataTable();
                //DTA = BLLArticulo.Listar_Articulos(ref sMsjError);
                //cmb_Articulo.DataSource = DTA;
                //cmb_Articulo.DisplayMember = DTA.Columns[1].ToString();
                //cmb_Articulo.ValueMember = DTA.Columns[0].ToString();
                //cmb_Articulo.SelectedValue = AjuDAL.sIdArticulo;


                //txt_FiltrarDescrip.Text = string.Empty;
                //CargarAjustesInventario();
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Refrescar_Click(object sender, EventArgs e)
        {
            CargarAjustesInventario();
            Cargar_cmb();
        }

        private void dgv_Ajuste_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AjuDAL.cBandera = 'M';

            txt_IdAjus.Text = dgv_Ajuste.SelectedRows[0].Cells[0].Value.ToString().Trim();
            cmb_Articulo.Text = dgv_Ajuste.SelectedRows[0].Cells[1].Value.ToString().Trim();
            txt_Descrip.Text = dgv_Ajuste.SelectedRows[0].Cells[2].Value.ToString().Trim();
            txt_Fecha.Text = dgv_Ajuste.SelectedRows[0].Cells[3].Value.ToString().Trim();
            txt_Cantidad.Text = dgv_Ajuste.SelectedRows[0].Cells[4].Value.ToString().Trim();
            txt_Monto.Text = dgv_Ajuste.SelectedRows[0].Cells[5].Value.ToString().Trim();
        }

        private void txt_FiltrarDescrip_TextChanged(object sender, EventArgs e)
        {
            CargarAjustesInventario();
        }
    }
}
