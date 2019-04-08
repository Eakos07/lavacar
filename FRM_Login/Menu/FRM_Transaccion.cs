﻿using System;
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
            #region Deshabilitar botones
            //Deshabilitar botones ya los insert a dicha tabla son generadas por otro proceso
            txt_IdTranC.Clear();
            txt_FechaC.Clear();
            txt_Doc.Clear();
            txt_CantidadC.Clear();
            txt_MontoC.Clear();
            cmb_ArtC.SelectedValue = null;
            cmb_Orden.SelectedValue = null;
            cmb_Prov.SelectedValue = null;

            txt_IdTranC.Enabled = false;
            txt_FechaC.Enabled = false;
            txt_Doc.Enabled = false;
            txt_CantidadC.Enabled = false;
            txt_MontoC.Enabled = false;
            cmb_ArtC.Enabled = false;
            cmb_Orden.Enabled = false;
            cmb_Prov.Enabled = false;
#endregion
            //Load Pantalla
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
            #region Habilitar Botones
            txt_FechaC.Enabled = true;
            txt_Doc.Enabled = true;
            txt_CantidadC.Enabled = true;
            txt_MontoC.Enabled = true;
            cmb_ArtC.Enabled = true;
            cmb_Orden.Enabled = true;
            cmb_Prov.Enabled = true;
            #endregion

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

                txt_IdTranC.Text = TransC_ObjDAL.iIdTransaccionCompra.ToString();
                txt_Doc.Text = TransC_ObjDAL.sDocumento;
                txt_FechaC.Text = TransC_ObjDAL.dtFecha.ToString();
                txt_CantidadC.Text = TransC_ObjDAL.iCantidad.ToString();
                txt_MontoC.Text = TransC_ObjDAL.dMonto.ToString();

                string sMsjError = string.Empty;
                //Combobox Ordenes de Compra
                cls_Ordenes_Compra_BLL BLLOrden = new cls_Ordenes_Compra_BLL();
                DataTable DTO = new DataTable();
                DTO = BLLOrden.Listar_OrdenesCompra(ref sMsjError);
                //DTO.Rows.Add("0", "Seleccione un Valor");
                cmb_Orden.DataSource = DTO;
                cmb_Orden.DisplayMember = DTO.Columns[0].ToString();
                cmb_Orden.ValueMember = DTO.Columns[0].ToString();
                cmb_Orden.SelectedValue = TransC_ObjDAL.iIdNumOrden.ToString();

                //Combobox Articulo
                cls_Articulos_BLL BLLArticulo = new cls_Articulos_BLL();
                DataTable DTA = new DataTable();
                DTA = BLLArticulo.Listar_Articulos(ref sMsjError);
                cmb_ArtC.DataSource = DTA;
                cmb_ArtC.DisplayMember = DTA.Columns[1].ToString();
                cmb_ArtC.ValueMember = DTA.Columns[0].ToString();
                cmb_ArtC.SelectedValue = TransC_ObjDAL.sIdArticulo;
                //Combobox Proveedores
                cls_Proveedores_BLL BLLProveedores = new cls_Proveedores_BLL();
                DataTable DTP = new DataTable();
                DTP = BLLProveedores.Listar_Proveedores(ref sMsjError);
                cmb_Prov.DataSource = DTP;
                cmb_Prov.DisplayMember = DTP.Columns[1].ToString();
                cmb_Prov.ValueMember = DTP.Columns[0].ToString();
                cmb_Prov.SelectedValue = TransC_ObjDAL.bIdProveedor;



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

                txt_IdTransV.Text = TransV_ObjDAL.iIdTransaccionVenta.ToString();
                txt_FechaV.Text = TransV_ObjDAL.dFecha.ToString();
                txt_CantidadV.Text = TransV_ObjDAL.iCantidad.ToString();
                txt_MontoV.Text = TransV_ObjDAL.dMonto.ToString();

                string sMsjError = string.Empty;

                //Combobox Articulo
                cls_Articulos_BLL BLLArticulo = new cls_Articulos_BLL();
                DataTable DTA = new DataTable();
                DTA = BLLArticulo.Listar_Articulos(ref sMsjError);
                cmb_ArtV.DataSource = DTA;
                cmb_ArtV.DisplayMember = DTA.Columns[1].ToString();
                cmb_ArtV.ValueMember = DTA.Columns[0].ToString();
                cmb_ArtV.SelectedValue = TransV_ObjDAL.sIdArticulo;
                //Combobox Factura
                cls_Factura_BLL BLLFactura = new cls_Factura_BLL();
                DataTable DTP = new DataTable();
                DTP = BLLFactura.Listar_Factura(ref sMsjError);
                cmb_Fact.DataSource = DTP;
                cmb_Fact.DisplayMember = DTP.Columns[0].ToString();
                cmb_Fact.ValueMember = DTP.Columns[0].ToString();
                cmb_Fact.SelectedValue = TransV_ObjDAL.iNumFactura;
                //Combobox Estado
                cls_Estados_BLL BLLEstado = new cls_Estados_BLL();
                DataTable DTE = new DataTable();
                DTE = BLLEstado.Listar_Estados(ref sMsjError);
                cmb_Estado.DataSource = DTE;
                cmb_Estado.DisplayMember = DTE.Columns[1].ToString();
                cmb_Estado.ValueMember = DTE.Columns[0].ToString();
                cmb_Estado.SelectedValue = TransV_ObjDAL.bIdEstado;
                
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
                errorIcono.SetError(txt_IdTranC, "");
            }
            else
            {
                e.Handled = true;
                errorIcono.SetError(txt_IdTranC, "Solo puede digitar numeros ");
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
                errorIcono.SetError(txt_Doc, "");
            }
            else
            {
                e.Handled = true;
                errorIcono.SetError(txt_Doc, "Solo puede digitar letras");
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                errorIcono.SetError(txt_FechaC, "");
            }
            else
            {
                e.Handled = true;
                errorIcono.SetError(txt_FechaC, "Solo puede digitar numeros");
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                errorIcono.SetError(txt_CantidadC, "");
            }
            else
            {
                e.Handled = true;
                errorIcono.SetError(txt_CantidadC, "Solo puede digitar numeros ");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                errorIcono.SetError(txt_MontoC, "");
            }
            else
            {
                e.Handled = true;
                errorIcono.SetError(txt_MontoC, "Solo puede digitar numeros con (.)");
            }

            if (e.KeyChar == '.')
            {
                e.Handled = false;
                errorIcono.SetError(txt_MontoC, "");
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                errorIcono.SetError(txt_FechaV, "");
            }
            else
            {
                e.Handled = true;
                errorIcono.SetError(txt_FechaV, "Solo puede digitar numeros ");
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                errorIcono.SetError(txt_CantidadV, "");
            }
            else
            {
                e.Handled = true;
                errorIcono.SetError(txt_CantidadV, "Solo puede digitar numeros con (.)");
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                errorIcono.SetError(txt_MontoV, "");
            }
            else
            {
                e.Handled = true;
                errorIcono.SetError(txt_MontoV, "Solo puede digitar numeros con (.)");
            }

            if (e.KeyChar == '.')
            {
                e.Handled = false;
                errorIcono.SetError(txt_MontoV, "");
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
