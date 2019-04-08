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
                dgv_TransCompra.DataSource = null;
                dgv_TransCompra.DataSource = DT;
            }
            else
            {
                dgv_TransCompra.DataSource = null;

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
                dgv_TransVenta.DataSource = null;
                dgv_TransVenta.DataSource = DT;
            }
            else
            {
                dgv_TransVenta.DataSource = null;

                MessageBox.Show("Se presento un error a la hora de listar los estados.\n\nDetalle Error : [" + sMsjError + "]",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FRM_Transaccion_Load(object sender, EventArgs e)
        {
            CargarTransaccionesCompras();
            CargarTransaccionesVentas();
        }

        //Modificar Transacciones de Compra
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (dgv_TransCompra.RowCount == 0)
            {
                MessageBox.Show("No existen datos para modificar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                TransC_ObjDAL = new cls_TransaccionesCompra_DAL();
                TransC_ObjDAL.cBandera = 'U';

                TransC_ObjDAL.iIdTransaccionCompra = Convert.ToInt32(dgv_TransCompra.SelectedRows[0].Cells[0].Value.ToString().Trim());
                TransC_ObjDAL.iIdNumOrden = Convert.ToInt32(dgv_TransCompra.SelectedRows[0].Cells[1].Value.ToString().Trim());
                TransC_ObjDAL.sIdArticulo = dgv_TransCompra.SelectedRows[0].Cells[2].Value.ToString().Trim();
                TransC_ObjDAL.bIdProveedor = Convert.ToByte(dgv_TransCompra.SelectedRows[0].Cells[3].Value.ToString().Trim());
                TransC_ObjDAL.sDocumento = dgv_TransCompra.SelectedRows[0].Cells[4].Value.ToString().Trim();
                TransC_ObjDAL.dtFecha = Convert.ToDateTime(dgv_TransCompra.SelectedRows[0].Cells[5].Value.ToString().Trim());
                TransC_ObjDAL.iCantidad = Convert.ToInt16(dgv_TransCompra.SelectedRows[0].Cells[6].Value.ToString().Trim());
                TransC_ObjDAL.dMonto = Convert.ToDecimal(dgv_TransCompra.SelectedRows[0].Cells[7].Value.ToString().Trim());

                textBox8.Text = TransC_ObjDAL.iIdTransaccionCompra.ToString();
                textBox1.Text = TransC_ObjDAL.sDocumento;
                textBox4.Text = TransC_ObjDAL.dtFecha.ToString();
                textBox3.Text = TransC_ObjDAL.iCantidad.ToString();
                textBox2.Text = TransC_ObjDAL.dMonto.ToString();

                string sMsjError = string.Empty;
                //Combobox Ordenes de Compra
                cls_Ordenes_Compra_BLL BLLOrden = new cls_Ordenes_Compra_BLL();
                DataTable DTO = new DataTable();
                DTO = BLLOrden.Listar_OrdenesCompra(ref sMsjError);
                //DTO.Rows.Add("0", "Seleccione un Valor");
                comboBox7.DataSource = DTO;
                comboBox7.DisplayMember = DTO.Columns[0].ToString();
                comboBox7.ValueMember = DTO.Columns[0].ToString();
                comboBox7.SelectedValue = TransC_ObjDAL.iIdNumOrden.ToString();

                //Combobox Articulo
                cls_Articulos_BLL BLLArticulo = new cls_Articulos_BLL();
                DataTable DTA = new DataTable();
                DTA = BLLArticulo.Listar_Articulos(ref sMsjError);
                comboBox6.DataSource = DTA;
                comboBox6.DisplayMember = DTA.Columns[1].ToString();
                comboBox6.ValueMember = DTA.Columns[0].ToString();
                comboBox6.SelectedValue = TransC_ObjDAL.sIdArticulo;
                //Combobox Proveedores
                cls_Proveedores_BLL BLLProveedores = new cls_Proveedores_BLL();
                DataTable DTP = new DataTable();
                DTP = BLLProveedores.Listar_Proveedores(ref sMsjError);
                comboBox2.DataSource = DTP;
                comboBox2.DisplayMember = DTP.Columns[1].ToString();
                comboBox2.ValueMember = DTP.Columns[0].ToString();
                comboBox2.SelectedValue = TransC_ObjDAL.bIdProveedor;



                txt_FiltrarArticulos.Text = string.Empty;
                CargarTransaccionesCompras();
            }
        }

        //Modificar Transacciones Venta
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (dgv_TransVenta.RowCount == 0)
            {
                MessageBox.Show("No existen datos para modificar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                TransV_ObjDAL = new cls_TransaccionesVenta_DAL();
                TransV_ObjDAL.cBandera = 'U';

                TransV_ObjDAL.iIdTransaccionVenta = Convert.ToInt32(dgv_TransVenta.SelectedRows[0].Cells[0].Value.ToString().Trim());
                TransV_ObjDAL.sIdArticulo = dgv_TransVenta.SelectedRows[0].Cells[1].Value.ToString().Trim();
                TransV_ObjDAL.iNumFactura = Convert.ToInt32(dgv_TransVenta.SelectedRows[0].Cells[2].Value.ToString().Trim());
                TransV_ObjDAL.dFecha = Convert.ToDateTime(dgv_TransVenta.SelectedRows[0].Cells[3].Value.ToString().Trim());
                TransV_ObjDAL.iCantidad = Convert.ToInt16(dgv_TransVenta.SelectedRows[0].Cells[4].Value.ToString().Trim());
                TransV_ObjDAL.dMonto = Convert.ToDecimal(dgv_TransVenta.SelectedRows[0].Cells[5].Value.ToString().Trim());

                textBox9.Text = TransV_ObjDAL.iIdTransaccionVenta.ToString();
                textBox6.Text = TransV_ObjDAL.dFecha.ToString();
                textBox7.Text = TransV_ObjDAL.iCantidad.ToString();
                textBox5.Text = TransV_ObjDAL.dMonto.ToString();

                string sMsjError = string.Empty;

                //Combobox Articulo
                cls_Articulos_BLL BLLArticulo = new cls_Articulos_BLL();
                DataTable DTA = new DataTable();
                DTA = BLLArticulo.Listar_Articulos(ref sMsjError);
                comboBox3.DataSource = DTA;
                comboBox3.DisplayMember = DTA.Columns[1].ToString();
                comboBox3.ValueMember = DTA.Columns[0].ToString();
                comboBox3.SelectedValue = TransV_ObjDAL.sIdArticulo;
                //Combobox Factura
                cls_Factura_BLL BLLFactura = new cls_Factura_BLL();
                DataTable DTP = new DataTable();
                DTP = BLLFactura.Listar_Factura(ref sMsjError);
                comboBox4.DataSource = DTP;
                comboBox4.DisplayMember = DTP.Columns[0].ToString();
                comboBox4.ValueMember = DTP.Columns[0].ToString();
                comboBox4.SelectedValue = TransV_ObjDAL.iNumFactura;
                //Combobox Estado
                cls_Estados_BLL BLLEstado = new cls_Estados_BLL();
                DataTable DTE = new DataTable();
                DTE = BLLEstado.Listar_Estados(ref sMsjError);
                comboBox5.DataSource = DTE;
                comboBox5.DisplayMember = DTE.Columns[1].ToString();
                comboBox5.ValueMember = DTE.Columns[0].ToString();
                comboBox5.SelectedValue = TransV_ObjDAL.bIdEstado;
                
                toolStrip1.Text = string.Empty;
                CargarTransaccionesVentas();
            }
        }

        #region Validaciones
        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                errorIcono.SetError(textBox8, "");
            }
            else
            {
                e.Handled = true;
                errorIcono.SetError(textBox8, "Solo puede digitar numeros ");
            }
        }

        private void comboBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) ||
                char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
                errorIcono.SetError(textBox1, "");
            }
            else
            {
                e.Handled = true;
                errorIcono.SetError(textBox1, "Solo puede digitar letras");
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                errorIcono.SetError(textBox4, "");
            }
            else
            {
                e.Handled = true;
                errorIcono.SetError(textBox4, "Solo puede digitar numeros");
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                errorIcono.SetError(textBox3, "");
            }
            else
            {
                e.Handled = true;
                errorIcono.SetError(textBox3, "Solo puede digitar numeros ");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                errorIcono.SetError(textBox2, "");
            }
            else
            {
                e.Handled = true;
                errorIcono.SetError(textBox2, "Solo puede digitar numeros con (.)");
            }

            if (e.KeyChar == '.')
            {
                e.Handled = false;
                errorIcono.SetError(textBox2, "");
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                errorIcono.SetError(textBox6, "");
            }
            else
            {
                e.Handled = true;
                errorIcono.SetError(textBox6, "Solo puede digitar numeros ");
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                errorIcono.SetError(textBox7, "");
            }
            else
            {
                e.Handled = true;
                errorIcono.SetError(textBox7, "Solo puede digitar numeros con (.)");
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                errorIcono.SetError(textBox5, "");
            }
            else
            {
                e.Handled = true;
                errorIcono.SetError(textBox5, "Solo puede digitar numeros con (.)");
            }

            if (e.KeyChar == '.')
            {
                e.Handled = false;
                errorIcono.SetError(textBox5, "");
            }
        }



        #endregion

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
