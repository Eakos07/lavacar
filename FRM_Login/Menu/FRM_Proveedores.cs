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
    public partial class FRM_Proveedores : Form
    {
        public FRM_Proveedores()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        
        }

        #region Variables Globales
        cls_Proveedores_BLL Obj_BLL = new cls_Proveedores_BLL();
        cls_Proveedores_DAL Obj_DAL = new cls_Proveedores_DAL();
        #endregion

        private void FRM_Proveedores_Load(object sender, EventArgs e)
        {
            Cargar_Datos_Proveedores();
            Cargar_cmb();
        }
        public void Cargar_Datos_Proveedores()
        {
            
            string sMsjError = string.Empty;
            DataTable dtProveedores = new DataTable();
            Obj_DAL.cBandIM = 'I';            

            txt_IdProveedor.Enabled = false;
            txt_IdProveedor.Clear();
            txtNomProveedor.Clear();
            txtEmailProveedor.Clear();
            txtTelefoProveedor.Clear();
            txtPlazoPago.Value=1;

            if (txt_FiltrarProveedores.Text == string.Empty)
            {
                dtProveedores = Obj_BLL.Listar_Proveedores(ref sMsjError);
            }
            else
            {
                dtProveedores = Obj_BLL.Filtrar_Proveedores(ref sMsjError, txt_FiltrarProveedores.Text);
            }
            if (sMsjError == string.Empty)
            {
                dgv_Proveedores.DataSource = null;
                dgv_Proveedores.DataSource = dtProveedores;
            }
        }

        public void Cargar_cmb()
        {
            string sMsjError = string.Empty;

            #region Cargar Estado
            cls_Estados_BLL Obj_Estados_BLL = new cls_Estados_BLL();
            DataTable DT_Estados = new DataTable();
            DT_Estados = Obj_Estados_BLL.Listar_Estados(ref sMsjError);
            cmb_IdEstadoProveedor.DataSource = DT_Estados;
            DT_Estados.Rows.Add("0", "Elija una opción");
            cmb_IdEstadoProveedor.DisplayMember = DT_Estados.Columns[1].ToString();
            cmb_IdEstadoProveedor.ValueMember = DT_Estados.Columns[0].ToString();
            cmb_IdEstadoProveedor.SelectedValue = "0";
            #endregion
        }

        private void txt_FiltrarProveedores_TextChanged(object sender, EventArgs e)
        {
            Cargar_Datos_Proveedores();
        }

        private void btn_Refrescar_Click(object sender, EventArgs e)
        {
            Cargar_Datos_Proveedores();
            Cargar_cmb();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (dgv_Proveedores.RowCount == 0)
            {
                MessageBox.Show("No hay datos para modificar");
            }
            else
            {
                Obj_DAL.cBandIM = 'M';
                txt_IdProveedor.Enabled = false;
                txt_IdProveedor.Text = dgv_Proveedores.SelectedRows[0].Cells[0].Value.ToString().Trim();
                txtNomProveedor.Text = dgv_Proveedores.SelectedRows[0].Cells[1].Value.ToString().Trim();
                txtEmailProveedor.Text = dgv_Proveedores.SelectedRows[0].Cells[2].Value.ToString().Trim();
                txtTelefoProveedor.Text = dgv_Proveedores.SelectedRows[0].Cells[3].Value.ToString().Trim();
                txtPlazoPago.Text = dgv_Proveedores.SelectedRows[0].Cells[4].Value.ToString().Trim();
                cmb_IdEstadoProveedor.Text = dgv_Proveedores.SelectedRows[0].Cells[5].Value.ToString().Trim();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtNomProveedor.Text)) && !(string.IsNullOrEmpty(txtTelefoProveedor.Text))
                && !(string.IsNullOrEmpty(txtEmailProveedor.Text)) && !(string.IsNullOrEmpty(txtPlazoPago.Text)) && cmb_IdEstadoProveedor.SelectedValue.ToString() != "0")
            {
               
                Obj_DAL.sNombreProveedor = txtNomProveedor.Text;
                Obj_DAL.sEmail = txtEmailProveedor.Text;
                Obj_DAL.iTelefono = Convert.ToInt32(txtTelefoProveedor.Text);
                Obj_DAL.bPlazoPago = Convert.ToByte(txtPlazoPago.Text);
                Obj_DAL.cIdEstado = Convert.ToChar(cmb_IdEstadoProveedor.SelectedValue);
                string sMsjError = string.Empty;

                if (Obj_DAL.cBandIM == 'I')
                {
                    Obj_BLL.Insertar_Proveedores(ref sMsjError, ref Obj_DAL);
                    if (sMsjError == string.Empty)
                    {
                        MessageBox.Show("Nuevo registro ingresado exitosamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Cargar_Datos_Proveedores();
                    }
                    else
                    {
                        MessageBox.Show("Se genera el siguiente error: " + "[" + sMsjError + "]", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                else if (Obj_DAL.cBandIM == 'M')
                {
                    Obj_DAL.bIdProveedor = Convert.ToByte(txt_IdProveedor.Text);
                    Obj_BLL.Modificar_Proveedores(ref sMsjError, ref Obj_DAL);
                    if (sMsjError == string.Empty)
                    {
                        MessageBox.Show("Modificación de registro exitoso", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_IdProveedor.Enabled = true;
                        Cargar_Datos_Proveedores();
                    }
                    else
                    {
                        MessageBox.Show("Se genera el siguiente error: " + "[" + sMsjError + "]", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                Cargar_cmb();
            }
        }

        private void dgv_Proveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Proveedores.RowCount == 0)
            {
                MessageBox.Show("No hay datos para modificar");
            }
            else
            {
                Obj_DAL.cBandIM = 'M';
                txt_IdProveedor.Enabled = false;
                txt_IdProveedor.Text = dgv_Proveedores.SelectedRows[0].Cells[0].Value.ToString().Trim();
                txtNomProveedor.Text = dgv_Proveedores.SelectedRows[0].Cells[1].Value.ToString().Trim();
                txtEmailProveedor.Text = dgv_Proveedores.SelectedRows[0].Cells[2].Value.ToString().Trim();
                txtTelefoProveedor.Text = dgv_Proveedores.SelectedRows[0].Cells[3].Value.ToString().Trim();
                txtPlazoPago.Text = dgv_Proveedores.SelectedRows[0].Cells[4].Value.ToString().Trim();
                cmb_IdEstadoProveedor.Text = dgv_Proveedores.SelectedRows[0].Cells[5].Value.ToString().Trim();
            }
        }

        #region Validaciones
        private void txt_IdProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                errorIcono.SetError(txt_IdProveedor, "");
            }
            else
            {
                e.Handled = true;
                errorIcono.SetError(txt_IdProveedor, "Solo puede digitar numeros");
            }
        }

        private void txtNomProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) ||
                char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
                errorIcono.SetError(txtNomProveedor, "");
            }
            else
            {
                e.Handled = true;
                errorIcono.SetError(txtNomProveedor, "Solo puede digitar letras");
            }
        }

        private void txtEmailProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                errorIcono.SetError(txtEmailProveedor, "No pueden haber espacions vacios en el correo");
            }
        }

        private void txtTelefoProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                errorIcono.SetError(txtTelefoProveedor, "");
            }
            else
            {
                e.Handled = true;
                errorIcono.SetError(txtTelefoProveedor, "Solo puede digitar numeros");
            }

            if (e.KeyChar == '-')
            {
                e.Handled = false;
                errorIcono.SetError(txtTelefoProveedor, "");
            }
        }

        private void cmb_IdEstadoProveedor_KeyPress(object sender, KeyPressEventArgs e)
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
        #endregion

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
