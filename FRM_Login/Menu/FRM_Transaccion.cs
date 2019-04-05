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
    public partial class FRM_Transaccion : Form
    {
        public FRM_Transaccion()
        {
            InitializeComponent();
        }

        cls_TransaccionesCompra_DAL TransC_ObjDAL = new cls_TransaccionesCompra_DAL();
        cls_TransaccionesVenta_DAL TransV_ObjDAL = new cls_TransaccionesVenta_DAL();

        private void CargarTransaccionesCompras()
        {
            cls_TransaccionesCompra_BLL TransC_ObjBLL = new cls_TransaccionesCompra_BLL();
            string sMsjError = string.Empty;
            DataTable DT = new DataTable();
            if (txt_FiltrarArticulos.Text == string.Empty)
            {
                DT = TransC_ObjBLL.ListarTransaccionesCompra(ref sMsjError);
            }
            else
            {
                DT = TransC_ObjBLL.FiltrarTransaccionesCompra(ref sMsjError,txt_FiltrarArticulos.Text.Trim());
            }

            if (sMsjError == string.Empty)
            {
                dgv_Articulos.DataSource = null;
                dgv_Articulos.DataSource = DT;
            }
            else
            {
                dgv_Articulos.DataSource = null;

                MessageBox.Show("Se presento un error a la hora de listar los estados.\n\nDetalle Error : [" + sMsjError + "]",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void CargarTransaccionesVentas()
        {
            cls_TransaccionesVenta_BLL TransV_ObjBLL = new cls_TransaccionesVenta_BLL();
            string sMsjError = string.Empty;
            DataTable DT = new DataTable();
            if (toolStripTextBox1.Text == string.Empty)
            {
                DT = TransV_ObjBLL.ListarTransaccionesVenta(ref sMsjError);
            }
            else
            {
                DT = TransV_ObjBLL.FiltrarTransaccionesVenta(ref sMsjError, txt_FiltrarArticulos.Text.Trim());
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

        private void FRM_Transaccion_Load(object sender, EventArgs e)
        {
            CargarTransaccionesCompras();
            CargarTransaccionesVentas();
        }

        //Modifiicar Transacciones de Compra
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (dgv_Articulos.RowCount == 0)
            {
                MessageBox.Show("No existen datos para modificar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                TransC_ObjDAL = new cls_TransaccionesCompra_DAL();
                TransC_ObjDAL.cBandera = 'U';

                TransC_ObjDAL.iIdTransaccionCompra = Convert.ToInt32(dgv_Articulos.SelectedRows[0].Cells[0].Value.ToString().Trim());
                TransC_ObjDAL.iIdNumOrden = Convert.ToInt32(dgv_Articulos.SelectedRows[0].Cells[1].Value.ToString().Trim());
                TransC_ObjDAL.sIdArticulo = dgv_Articulos.SelectedRows[0].Cells[2].Value.ToString().Trim();
                TransC_ObjDAL.bIdProveedor = Convert.ToByte(dgv_Articulos.SelectedRows[0].Cells[3].Value.ToString().Trim());
                TransC_ObjDAL.sDocumento = dgv_Articulos.SelectedRows[0].Cells[4].Value.ToString().Trim();
                TransC_ObjDAL.dtFecha = Convert.ToDateTime(dgv_Articulos.SelectedRows[0].Cells[5].Value.ToString().Trim());
                TransC_ObjDAL.iCantidad = Convert.ToInt16(dgv_Articulos.SelectedRows[0].Cells[6].Value.ToString().Trim());
                TransC_ObjDAL.dMonto = Convert.ToDecimal(dgv_Articulos.SelectedRows[0].Cells[7].Value.ToString().Trim());

                txt_FiltrarArticulos.Text = string.Empty;
                CargarTransaccionesCompras();
            }
        }
    }
}
