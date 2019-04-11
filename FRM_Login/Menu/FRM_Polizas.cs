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
    public partial class FRM_Polizas : Form
    {
        public FRM_Polizas()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Variables Globales
        cls_Polizas_BLL Obj_Polizas_BLL = new cls_Polizas_BLL();
        cls_Polizas_DAL Obj_Polizas_DAL = new cls_Polizas_DAL();
        cls_TipoPolizas_BLL Obj_TipoPolizas_BLL = new cls_TipoPolizas_BLL();
        cls_TipoPolizas_DAL Obj_TipoPolizas_DAL = new cls_TipoPolizas_DAL();

        #endregion

        public void Cargar_Polizas()
        {
           
            string sMsjError = string.Empty;
            DataTable dtPolizas = new DataTable();
            Obj_Polizas_DAL.cBandIM = 'I';

            #region Cargar Centro Lavado
            cls_Centro_de_Lavado_BLL Obj_Octopus_BLL = new cls_Centro_de_Lavado_BLL();
            DataTable dt_Octopus = new DataTable();
            dt_Octopus = Obj_Octopus_BLL.Listar_LavadoOctopus(ref sMsjError);
            txt_CeduJurid.Text = dt_Octopus.Columns[0].ToString();

            #endregion

            txt_IdPoliza.Clear();
            txt_FechaVenci.Clear();
            txt_CeduJurid.Text = "2000000020";

            if (txt_FiltrarTipoPoliza.Text == string.Empty)
            {
                dtPolizas = Obj_Polizas_BLL.Listar_Polizas(ref sMsjError);
            }
            else
            {
                dtPolizas = Obj_Polizas_BLL.Filtrar_Polizas(ref sMsjError, txt_FiltrarTipoPoliza.Text);
            }

            if (sMsjError == string.Empty)
            {
                dgv_Polizas.DataSource = null;
                dgv_Polizas.DataSource = dtPolizas;
            }
        }

        public void Cargar_cmb_Polizas()
        {
            string sMsjError = string.Empty;

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

            #region Cargar TipoPolizas
            cls_TipoPolizas_BLL Obj_TipoPolizas_BLL = new cls_TipoPolizas_BLL();
            DataTable DT_TipoPolizas = new DataTable();
            DT_TipoPolizas = Obj_TipoPolizas_BLL.Listar_TipoPolizas(ref sMsjError);
            cmb_IdTipoPoliza.DataSource = DT_TipoPolizas;
            DT_TipoPolizas.Rows.Add("0", "Elija una opción");
            cmb_IdTipoPoliza.DisplayMember = DT_TipoPolizas.Columns[1].ToString();
            cmb_IdTipoPoliza.ValueMember = DT_TipoPolizas.Columns[0].ToString();
            cmb_IdTipoPoliza.SelectedValue = "0";
            #endregion
        }
        public void Cargar_TipoPolizas()
        {
            cls_TipoPolizas_BLL Obj_TipoPolizas_BLL = new cls_TipoPolizas_BLL();
            string sMsjError = string.Empty;
            DataTable dtTipoPolizas = new DataTable();
            Obj_TipoPolizas_DAL.cBandIM = 'I';            

            txt_IdTipoPoliza.Clear();
            txt_NombrePoliza.Clear();
            txt_Compañia.Clear();
            

            if (toolStripTextBox2.Text == string.Empty)
            {
                dtTipoPolizas = Obj_TipoPolizas_BLL.Listar_TipoPolizas(ref sMsjError);
            }
            else
            {
                dtTipoPolizas = Obj_TipoPolizas_BLL.Filtrar_TipoPolizas(ref sMsjError, toolStripTextBox2.Text);
            }
            if (sMsjError == string.Empty)
            {
                dgv_TipoPoliza.DataSource = null;
                dgv_TipoPoliza.DataSource = dtTipoPolizas;
             }

        }

        public void Cargar_cmb_TipoPolizas()
        {
            string sMsjError = string.Empty;

            #region Cargar Proveedores

            cls_Proveedores_BLL Obj_Proveedor_BLL = new cls_Proveedores_BLL();
            DataTable DT_Proveedor = new DataTable();
            DT_Proveedor = Obj_Proveedor_BLL.Listar_Proveedores(ref sMsjError);
            cmb_IdProveedor.DataSource = DT_Proveedor;
            DT_Proveedor.Rows.Add("0", "Elija una opción");
            cmb_IdProveedor.DisplayMember = DT_Proveedor.Columns[1].ToString();
            cmb_IdProveedor.ValueMember = DT_Proveedor.Columns[0].ToString();
            cmb_IdProveedor.SelectedValue = "0";
            #endregion
        }

        private void FRM_Polizas_Load(object sender, EventArgs e)
        {
            Cargar_Polizas();
            Cargar_cmb_Polizas();
            Cargar_TipoPolizas();
            Cargar_cmb_TipoPolizas();
        }

        private void toolStripTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            Cargar_Polizas();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripTextBox2_TextChanged(object sender, EventArgs e)
        {
            Cargar_TipoPolizas();
        }

        private void btnSalir_TipoPolizas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Polizas
        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (dgv_Polizas.RowCount == 0)
            {
                MessageBox.Show("No hay datos para modificar");
            }
            else
            {
                Obj_Polizas_DAL.cBandIM = 'M';
                txt_IdPoliza.Enabled = false;

                txt_IdPoliza.Text = dgv_Polizas.SelectedRows[0].Cells[0].Value.ToString().Trim();
                cmb_IdTipoPoliza.Text = dgv_Polizas.SelectedRows[0].Cells[1].Value.ToString().Trim();
                txt_FechaVenci.Text = dgv_Polizas.SelectedRows[0].Cells[2].Value.ToString().Trim();
                cmb_IdEstado.Text= dgv_Polizas.SelectedRows[0].Cells[3].Value.ToString().Trim();
                txt_CeduJurid.Text = dgv_Polizas.SelectedRows[0].Cells[4].Value.ToString().Trim();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txt_IdPoliza.Text)) && cmb_IdTipoPoliza.SelectedValue.ToString() !="0" && 
                !(string.IsNullOrEmpty(txt_FechaVenci.Text))&& cmb_IdEstado.SelectedValue.ToString() !="0" &&
                !(string.IsNullOrEmpty(txt_CeduJurid.Text)))
            {
                Obj_Polizas_DAL.sIdPoliza = txt_IdPoliza.Text;
                Obj_Polizas_DAL.cIdTipoPoliza = Convert.ToChar(cmb_IdTipoPoliza.SelectedValue);
                Obj_Polizas_DAL.dFechaVencimiento = Convert.ToDateTime(txt_FechaVenci.Text);
                Obj_Polizas_DAL.cIdEstado = Convert.ToChar(cmb_IdEstado.SelectedValue);
                Obj_Polizas_DAL.iCedulaJuridica = Convert.ToInt32(txt_CeduJurid.Text);

                if ((Convert.ToDateTime(txt_FechaVenci.Text.Trim())) < DateTime.Now )
                {
                    MessageBox.Show("La fecha de vencimiento no puede ser menor a la fecha actual", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                string sMsjError = string.Empty;

                if (Obj_Polizas_DAL.cBandIM =='I')
                {
                    Obj_Polizas_BLL.Insertar_Polizas(ref sMsjError, ref Obj_Polizas_DAL);
                    if (sMsjError == string.Empty)
                    {
                        MessageBox.Show("Nuevo registro ingresado exitosamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Cargar_Polizas();
                    }
                    else
                    {
                        MessageBox.Show("Se genera el siguiente error: " + "[" + sMsjError + "]", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                else if (Obj_Polizas_DAL.cBandIM == 'M')
                {
                    Obj_Polizas_BLL.Modificar_Polizas(ref sMsjError, ref Obj_Polizas_DAL);
                    if (sMsjError == string.Empty)
                    {
                        MessageBox.Show("Modificación de registro exitosa", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_IdPoliza.Enabled = false;
                        Cargar_Polizas();
                    }
                    else
                    {
                        MessageBox.Show("Se genera el siguiente error: " + "[" + sMsjError + "]", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                }
                Cargar_cmb_Polizas();
            }
            else
            {
                MessageBox.Show("No se pueden guardar datos vacios", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_Refrescar_Click(object sender, EventArgs e)
        {
            Cargar_Polizas();
            Cargar_cmb_Polizas();
        }
        #endregion

        #region Tipo Polizas
        private void btn_Refrescar_TipoPolizas_Click(object sender, EventArgs e)
        {
            Cargar_TipoPolizas();
            Cargar_cmb_TipoPolizas();
        }

        private void dgv_TipoPoliza_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgv_TipoPoliza.RowCount == 0)
            {
                MessageBox.Show("No hay datos para modificar");
            }
            else
            {
                Obj_TipoPolizas_DAL.cBandIM = 'M';
                txt_IdTipoPoliza.Enabled = false;

                txt_IdTipoPoliza.Text = dgv_TipoPoliza.SelectedRows[0].Cells[0].Value.ToString().Trim();
                txt_NombrePoliza.Text = dgv_TipoPoliza.SelectedRows[0].Cells[1].Value.ToString().Trim();
                txt_Compañia.Text = dgv_TipoPoliza.SelectedRows[0].Cells[2].Value.ToString().Trim();
                cmb_IdProveedor.Text = dgv_TipoPoliza.SelectedRows[0].Cells[3].Value.ToString().Trim();
            }
        }

        private void btn_Guardar_TipoPolizas_Click(object sender, EventArgs e)
        {
            if ((txt_IdTipoPoliza.Text.Trim() == string.Empty) || (txt_NombrePoliza.Text.Trim() == string.Empty) ||
               (txt_Compañia.Text.Trim() == string.Empty) || (cmb_IdProveedor.SelectedValue.ToString()=="0") )

            {

                MessageBox.Show("No pueden haber campos en blanco", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                else
	        {        
                string sMsjError = string.Empty;
                Obj_TipoPolizas_DAL.cIdTipoPoliza = Convert.ToChar(txt_IdTipoPoliza.Text);
                Obj_TipoPolizas_DAL.sNombrePoliza = txt_NombrePoliza.Text;
                Obj_TipoPolizas_DAL.sCompañia = txt_Compañia.Text;
                Obj_TipoPolizas_DAL.bIdProveedor = Convert.ToByte(cmb_IdProveedor.SelectedValue);

                if (Obj_TipoPolizas_DAL.cBandIM =='I')
                {
                    Obj_TipoPolizas_BLL.Insertar_TipoPolizas(ref sMsjError, ref Obj_TipoPolizas_DAL);
                    if (sMsjError == string.Empty)
                    {
                        MessageBox.Show("Nuevo registro ingresado exitosamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Cargar_TipoPolizas();
                    }
                    else
                    {
                        MessageBox.Show("Se genera el siguiente error: " + "[" + sMsjError + "]", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                else if (Obj_TipoPolizas_DAL.cBandIM == 'M')
                {
                    Obj_TipoPolizas_BLL.Insertar_TipoPolizas(ref sMsjError, ref Obj_TipoPolizas_DAL);
                    if (sMsjError == string.Empty)
                    {
                        MessageBox.Show("Modificación de registro exitosa", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_IdTipoPoliza.Enabled = false;
                        Cargar_TipoPolizas();
                    }
                    else
                    {
                        MessageBox.Show("Se genera el siguiente error: " + "[" + sMsjError + "]", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                Cargar_cmb_TipoPolizas();
            }
        }

        private void btn_Modificar_TipoPolizas_Click(object sender, EventArgs e)
        {
            if (dgv_TipoPoliza.RowCount == 0)
            {
                MessageBox.Show("No hay datos para modificar");
            }
            else
            {
                Obj_TipoPolizas_DAL.cBandIM = 'M';
                txt_IdTipoPoliza.Enabled = false;

                txt_IdTipoPoliza.Text = dgv_TipoPoliza.SelectedRows[0].Cells[0].Value.ToString().Trim();
                txt_NombrePoliza.Text = dgv_TipoPoliza.SelectedRows[0].Cells[1].Value.ToString().Trim();
                txt_Compañia.Text = dgv_TipoPoliza.SelectedRows[0].Cells[2].Value.ToString().Trim();
                cmb_IdProveedor.Text = dgv_TipoPoliza.SelectedRows[0].Cells[3].Value.ToString().Trim();
            }
        }
        #endregion

        #region Validaciones
        private void txt_IdPoliza_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                errorIcono.SetError(txt_IdPoliza, "");
            }
            else
            {
                e.Handled = true;
                errorIcono.SetError(txt_IdPoliza, "Solo puede digitar numeros");
            }
        }

        private void cmb_IdTipoPoliza_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_FechaVenci_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                errorIcono.SetError(txt_FechaVenci, "");
            }
            else
            {
                e.Handled = true;
                errorIcono.SetError(txt_FechaVenci, "Solo puede digitar numeros");
            }
        }

        private void cmb_IdEstado_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_CeduJurid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsLetter(e.KeyChar) ||
                char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
                errorIcono.SetError(txt_CeduJurid, "");
            }
            else
            {
                e.Handled = true;
                errorIcono.SetError(txt_CeduJurid, "Solo puede digitar cedulas o pasaporte alfanumericas y espacios");
            }
        }

        private void txt_IdTipoPoliza_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                errorIcono.SetError(txt_IdPoliza, "");
            }
            else
            {
                e.Handled = true;
                errorIcono.SetError(txt_IdPoliza, "Solo puede digitar numeros");
            }
        }

        private void txt_NombrePoliza_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                errorIcono.SetError(txt_IdPoliza, "");
            }
            else
            {
                e.Handled = true;
                errorIcono.SetError(txt_IdPoliza, "Solo puede digitar letras");
            }
        }

        private void txt_Compañia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsLetter(e.KeyChar) ||
                char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
                errorIcono.SetError(txt_CeduJurid, "");
            }
            else
            {
                e.Handled = true;
                errorIcono.SetError(txt_CeduJurid, "Solo puede digitar nuero o letras");
            }
        }

        private void cmb_IdProveedor_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dgv_Polizas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Polizas.RowCount == 0)
            {
                MessageBox.Show("No hay datos para modificar");
            }
            else
            {
                Obj_Polizas_DAL.cBandIM = 'M';
                txt_IdPoliza.Enabled = false;

                txt_IdPoliza.Text = dgv_Polizas.SelectedRows[0].Cells[0].Value.ToString().Trim();
                cmb_IdTipoPoliza.Text = dgv_Polizas.SelectedRows[0].Cells[1].Value.ToString().Trim();
                txt_FechaVenci.Text = dgv_Polizas.SelectedRows[0].Cells[2].Value.ToString().Trim();
                cmb_IdEstado.Text = dgv_Polizas.SelectedRows[0].Cells[3].Value.ToString().Trim();
                txt_CeduJurid.Text = dgv_Polizas.SelectedRows[0].Cells[4].Value.ToString().Trim();
            }
        }
    }
}
