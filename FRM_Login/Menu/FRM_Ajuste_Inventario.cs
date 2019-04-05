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
        cls_AjustesInventario_DAL AjuDAL = new cls_AjustesInventario_DAL();

        private void CargarAjustesInventario()
        {
            cls_AjustesInventario_BLL Ajuste_BLL = new cls_AjustesInventario_BLL();
            string sMsjError = string.Empty;
            DataTable DT = new DataTable();
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
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = DT;
            }
            else
            {
                dataGridView1.DataSource = null;

                MessageBox.Show("Se presento un error a la hora de listar los estados.\n\nDetalle Error : [" + sMsjError + "]",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FRM_Ajuste_Inventario_Load(object sender, EventArgs e)
        {
            CargarAjustesInventario();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("No existen datos para modificar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                AjuDAL = new cls_AjustesInventario_DAL();
                AjuDAL.cBandera = 'U';

                AjuDAL.iIdTransaccionAjusteInventario = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString().Trim());
                AjuDAL.sIdArticulo = dataGridView1.SelectedRows[0].Cells[1].Value.ToString().Trim();
                AjuDAL.sDescripcion = dataGridView1.SelectedRows[0].Cells[2].Value.ToString().Trim();
                AjuDAL.dtFecha = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[3].Value.ToString().Trim());
                AjuDAL.iCantidad = Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[4].Value.ToString().Trim());
                AjuDAL.dMonto = Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells[5].Value.ToString().Trim());

                textBox1.Text = AjuDAL.iIdTransaccionAjusteInventario.ToString();
                txt_Descrip.Text = AjuDAL.sDescripcion;
                txt_Fecha.Text = AjuDAL.dtFecha.ToString();
                txt_Cantidad.Text = AjuDAL.iCantidad.ToString();
                txt_Monto.Text = AjuDAL.dMonto.ToString();

                string sMsjError = string.Empty;

                //Combobox Articulo
                cls_Articulos_BLL BLLArticulo = new cls_Articulos_BLL();
                DataTable DTA = new DataTable();
                DTA = BLLArticulo.Listar_Articulos(ref sMsjError);
                cmb_Articulo.DataSource = DTA;
                cmb_Articulo.DisplayMember = DTA.Columns[1].ToString();
                cmb_Articulo.ValueMember = DTA.Columns[0].ToString();
                cmb_Articulo.SelectedValue = AjuDAL.sIdArticulo;


                txt_FiltrarDescrip.Text = string.Empty;
                CargarAjustesInventario();
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
