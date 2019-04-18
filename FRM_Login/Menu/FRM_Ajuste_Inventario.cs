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

            txt_IdAjus.Clear();
            txt_Descrip.Clear();
            txt_Fecha.Clear();
            txt_Cantidad.Value = 0;
            txt_Monto.Clear();

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
            DTA.Rows.Add("0", "Elija una opción");
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
                AjuDAL.cBandera = 'M';

                txt_IdAjus.Text = dgv_Ajuste.SelectedRows[0].Cells[0].Value.ToString().Trim();
                cmb_Articulo.Text = dgv_Ajuste.SelectedRows[0].Cells[1].Value.ToString().Trim();
                txt_Descrip.Text = dgv_Ajuste.SelectedRows[0].Cells[2].Value.ToString().Trim();
                txt_Fecha.Text = dgv_Ajuste.SelectedRows[0].Cells[3].Value.ToString().Trim();
                txt_Cantidad.Text = dgv_Ajuste.SelectedRows[0].Cells[4].Value.ToString().Trim();
                txt_Monto.Text = dgv_Ajuste.SelectedRows[0].Cells[5].Value.ToString().Trim();
                
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

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (cmb_Articulo.SelectedValue.ToString() != "0" && !(string.IsNullOrEmpty(txt_Descrip.Text))
                && !(string.IsNullOrEmpty(txt_Fecha.Text)) && !(string.IsNullOrEmpty(txt_Monto.Text))
                && txt_Cantidad.Value != 0)
            {
                AjuDAL.sIdArticulo = cmb_Articulo.SelectedValue.ToString().Trim();
                AjuDAL.sDescripcion = txt_Descrip.Text;
                AjuDAL.dtFecha = Convert.ToDateTime(txt_Fecha.Text);
                AjuDAL.iCantidad = Convert.ToInt16(txt_Cantidad.Value);
                AjuDAL.dMonto = Convert.ToDecimal(txt_Monto.Text);
                string sMsjError = string.Empty;

                if (AjuDAL.cBandera == 'I')
                {
                    Ajuste_BLL.InsertarAjustesInventario(ref sMsjError, ref AjuDAL);
                    if (sMsjError == string.Empty)
                    {
                        MessageBox.Show("Nuevo registro ingresado exitosamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarAjustesInventario();
                        Cargar_cmb();
                    }
                    else
                    {
                        MessageBox.Show("Se genera el siguiente error: " + "[" + sMsjError + "]", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (AjuDAL.cBandera == 'M')
                {
                    AjuDAL.iIdTransaccionAjusteInventario = Convert.ToInt32(txt_IdAjus.Text);
                    Ajuste_BLL.ModificarAjustesInventario(ref sMsjError, ref AjuDAL);
                    if (sMsjError == string.Empty)
                    {
                        MessageBox.Show("Modificación de registro exitoso", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarAjustesInventario();
                        Cargar_cmb();
                    }
                    else
                    {
                        MessageBox.Show("Se genera el siguiente error: " + "[" + sMsjError + "]", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            }
    }
}
