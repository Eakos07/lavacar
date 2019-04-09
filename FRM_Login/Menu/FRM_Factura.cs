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
    public partial class FRM_Factura : Form
    {
        public FRM_Factura()
        {
            InitializeComponent();
        }

        #region Variables Globales
        cls_Factura_BLL Obj_BLL = new cls_Factura_BLL();
        cls_Factura_DAL Obj_DAL = new cls_Factura_DAL();
        #endregion

        private void FRM_Factura_Load(object sender, EventArgs e)
        {
            Cargar_Datos_Factura();
            Cargar_cmb();
        }
        public void Cargar_Datos_Factura()
        {
            
            string sMsjError = string.Empty;
            DataTable dtFactura = new DataTable();
            Obj_DAL.cBandIM = 'I';

            if (txt_FiltrarFacturas.Text == string.Empty)
            {
                dtFactura = Obj_BLL.Listar_Factura(ref sMsjError);
            }
            else
            {
                dtFactura = Obj_BLL.Filtrar_Factura(ref sMsjError, txt_FiltrarFacturas.Text);
            }
            if (sMsjError == string.Empty)
            {
                dgv_Facturas.DataSource = null;
                dgv_Facturas.DataSource = dtFactura;
            }
        }

        public void Cargar_cmb()
        {
            string sMsjError = string.Empty;

            #region Cliente
            cls_Clientes_BLL Obj_Clientes_BLL = new cls_Clientes_BLL();
            DataTable DT_Clientes = new DataTable();
            DT_Clientes = Obj_Clientes_BLL.Listar_Clientes(ref sMsjError);
            cmb_NumPlaca.DataSource = DT_Clientes;
            DT_Clientes.Rows.Add("Elija Estado", "0");
            cmb_NumPlaca.DisplayMember = DT_Clientes.Columns[0].ToString();
            cmb_NumPlaca.ValueMember = DT_Clientes.Columns[0].ToString();
            cmb_NumPlaca.SelectedValue = "Elija Estado";
            #endregion

            #region Tipo Servicio
            cls_TipoServicio_BLL Obj_TipoServicio_BLL = new cls_TipoServicio_BLL();
            DataTable DT_TipoServicio = new DataTable();
            DT_TipoServicio = Obj_TipoServicio_BLL.Listar_TipoServicio(ref sMsjError);
            cmb_CodServ.DataSource = DT_TipoServicio;
            DT_TipoServicio.Rows.Add("0", "Elija Estado");
            cmb_CodServ.DisplayMember = DT_TipoServicio.Columns[1].ToString();
            cmb_CodServ.ValueMember = DT_TipoServicio.Columns[0].ToString();
            cmb_CodServ.SelectedValue = "0";
            #endregion

            #region Tipo Cambio
            cls_TipoCambio_BLL Obj_TipoCambio_BLL = new cls_TipoCambio_BLL();
            DataTable DT_TipoCambio = new DataTable();
            DT_TipoCambio = Obj_TipoCambio_BLL.Listar_TipoCambio(ref sMsjError);
            cmb_IdTipCamb.DataSource = DT_TipoCambio;
            DT_TipoCambio.Rows.Add("Elija Estado", "0");
            cmb_IdTipCamb.DisplayMember = DT_TipoCambio.Columns[1].ToString();
            cmb_IdTipCamb.ValueMember = DT_TipoCambio.Columns[0].ToString();
            cmb_IdTipCamb.SelectedValue = "Elija Estado";
            #endregion

            #region Promociones
            cls_Promociones_BLL Obj_Promociones_BLL = new cls_Promociones_BLL();
            DataTable DT_Promociones = new DataTable();
            DT_Promociones = Obj_Promociones_BLL.Listar_Promociones(ref sMsjError);
            cmb_IdTipCamb.DataSource = DT_Promociones;
            DT_Promociones.Rows.Add("0", "Elija Estado");
            cmb_IdTipCamb.DisplayMember = DT_Promociones.Columns[1].ToString();
            cmb_IdTipCamb.ValueMember = DT_Promociones.Columns[0].ToString();
            cmb_IdTipCamb.SelectedValue = "0";
            #endregion

            #region Tipo Factura
            cls_TipoFactura_BLL Obj_TipoFactura_BLL = new cls_TipoFactura_BLL();
            DataTable DT_TipoFactura = new DataTable();
            DT_TipoFactura = Obj_TipoFactura_BLL.Listar_TipoFactura(ref sMsjError);
            cmb_IdTipFactu.DataSource = DT_Promociones;
            DT_TipoFactura.Rows.Add("0", "Elija Estado");
            cmb_IdTipFactu.DisplayMember = DT_Promociones.Columns[1].ToString();
            cmb_IdTipFactu.ValueMember = DT_Promociones.Columns[0].ToString();
            cmb_IdTipFactu.SelectedValue = "0";
            #endregion
        }

        private void txt_FiltrarFacturas_TextChanged(object sender, EventArgs e)
        {
            Cargar_Datos_Factura();
        }

        #region Validaciones
        private void txt_NumFact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                errorIcono.SetError(txt_NumFact, "");
            }
            else
            {
                e.Handled = true;
                errorIcono.SetError(txt_NumFact, "Solo puede digitar numeros");
            }
        }

        private void cmb_NumPlaca_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cmb_CodServ_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cmb_IdTipCamb_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cmb_CedJuri_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cmb_IdPromo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cmb_IdTipFactu_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_MontoNeto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                errorIcono.SetError(txt_NumFact, "");
            }
            else
            {
                e.Handled = true;
                errorIcono.SetError(txt_NumFact, "Solo puede digitar numeros");
            }

            if (e.KeyChar == ',')
            {
                e.Handled = false;
                errorIcono.SetError(txt_MontoNeto, "");
            }
        }

        private void txt_Descuent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                errorIcono.SetError(txt_NumFact, "");
            }
            else
            {
                e.Handled = true;
                errorIcono.SetError(txt_NumFact, "Solo puede digitar numeros");
            }

            if (e.KeyChar == ',')
            {
                e.Handled = false;
                errorIcono.SetError(txt_MontoNeto, "");
            }
        }

        private void txt_MontoTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                errorIcono.SetError(txt_NumFact, "");
            }
            else
            {
                e.Handled = true;
                errorIcono.SetError(txt_NumFact, "Solo puede digitar numeros");
            }

            if (e.KeyChar == ',')
            {
                e.Handled = false;
                errorIcono.SetError(txt_MontoNeto, "");
            }
        }
        #endregion

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txt_MontoNeto.Text)) && !(string.IsNullOrEmpty(txt_Descuent.Text)) && !(string.IsNullOrEmpty(txt_MontoTotal.Text))
                && cmb_NumPlaca.SelectedValue.ToString() != "0" && cmb_CodServ.ToString() != "0" && cmb_IdTipCamb.SelectedValue.ToString() != "0" 
                && cmb_IdPromo.SelectedValue.ToString() != "0"
                && cmb_IdTipFactu.Text != "Elija Estado")
            {
                Obj_DAL.sNumPlaca = cmb_NumPlaca.SelectedText.ToString().Trim();

                string sMsjError = string.Empty;

                if (Obj_DAL.cBandIM == 'I')
                {
                    Obj_BLL.Insertar_Factura(ref sMsjError, ref Obj_DAL);
                    MessageBox.Show("Nuevo registro ingresado exitosamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cargar_Datos_Factura();
                }
                else if (Obj_DAL.cBandIM == 'M')
                {
                    Obj_BLL.Modificar_Factura(ref sMsjError, ref Obj_DAL);
                    MessageBox.Show("Modificación de registro exitoso", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cargar_Datos_Factura();
                }
                Cargar_cmb();
            }
            else
            {
                MessageBox.Show("No se pueden guardar datos vacios", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
