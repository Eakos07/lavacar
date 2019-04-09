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
    public partial class FRM_Tipo_Cambio : Form
    {
        public FRM_Tipo_Cambio()
        {
            InitializeComponent();
        }

        #region Variables Globales
        cls_TipoCambio_BLL Obj_BLL = new cls_TipoCambio_BLL();
        cls_TipoCambio_DAL Obj_DAL = new cls_TipoCambio_DAL();
        #endregion

        private void FRM_Tipo_Cambio_Load(object sender, EventArgs e)
        {
            Cargar_Datos_TipoCambio();
        }
        public void Cargar_Datos_TipoCambio()
        {
            
            string sMsjError = string.Empty;
            DataTable dtTipoCambio = new DataTable();
            Obj_DAL.cBandIM = 'I';

            if (txt_FiltrarTipoCambio.Text == string.Empty)
            {
                dtTipoCambio = Obj_BLL.Listar_TipoCambio(ref sMsjError);
            }
            else
            {
                dtTipoCambio = Obj_BLL.Filtrar_TipoCambio(ref sMsjError, txt_FiltrarTipoCambio.Text);
            }
            if (sMsjError == string.Empty)
            {
                dgv_TipoCambio.DataSource = null;
                dgv_TipoCambio.DataSource = dtTipoCambio;
            }
        }

        private void txt_FiltrarTipoCambio_TextChanged(object sender, EventArgs e)
        {
            Cargar_Datos_TipoCambio();
        }

        #region Validaciones
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

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                errorIcono.SetError(txt_Valor, "");
            }
            else
            {
                e.Handled = true;
                errorIcono.SetError(txt_Valor, "Solo puede digitar numeros con (-)");
            }

            if (e.KeyChar == '-')
            {
                e.Handled = false;
                errorIcono.SetError(txt_Valor, "");
            }
        }
        #endregion

        //private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
        //    {
        //        e.Handled = false;
        //        errorIcono.SetError(txt_Fecha, "");
        //    }
        //    else
        //    {
        //        e.Handled = true;
        //        errorIcono.SetError(txt_Fecha, "Solo puede digitar numeros");
        //    }
        //}

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {

            if (!(string.IsNullOrEmpty(txt_IdTipoCambio.Text)) && !(string.IsNullOrEmpty(txt_Valor.Text)) && !(string.IsNullOrEmpty(txt_Fecha.Text)))
            {
                Obj_DAL.cTipoCambio = Convert.ToChar(txt_IdTipoCambio.Text);
                Obj_DAL.dValor = Convert.ToDecimal(txt_Valor.Text);
                Obj_DAL.dtmFecha = Convert.ToDateTime(txt_Fecha.Text);
                string sMsjError = string.Empty;

                if (Obj_DAL.cBandIM == 'I')
                {
                    Obj_BLL.Insertar_TipoCambio(ref sMsjError, ref Obj_DAL);
                    if (sMsjError == string.Empty)
                    {
                        MessageBox.Show("Nuevo registro ingresado exitosamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Cargar_Datos_TipoCambio();
                    }
                    else
                    {
                        MessageBox.Show("Se genera el siguiente error: " + "[" + sMsjError + "]", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                else if (Obj_DAL.cBandIM == 'M')
                {
                    Obj_BLL.Modificar_TipoCambio(ref sMsjError, ref Obj_DAL);
                    if (sMsjError == string.Empty)
                    {
                        MessageBox.Show("Modificación de registro exitoso", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_IdTipoCambio.Enabled = true;
                        Cargar_Datos_TipoCambio();
                    }
                    else
                    {
                        MessageBox.Show("Se genera el siguiente error: " + "[" + sMsjError + "]", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("No se pueden guardar datos vacios", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if(dgv_TipoCambio.RowCount == 0)
            {
                MessageBox.Show("No hay datos para modificar");
            }
            else
            {
                Obj_DAL.cBandIM = 'M';
                txt_IdTipoCambio.Enabled = false;
                txt_IdTipoCambio.Text = dgv_TipoCambio.SelectedRows[0].Cells[0].Value.ToString().Trim();
                txt_Valor.Text = dgv_TipoCambio.SelectedRows[0].Cells[1].Value.ToString().Trim();
                txt_Fecha.Text = dgv_TipoCambio.SelectedRows[0].Cells[2].Value.ToString().Trim();
            }
        }

        private void dgv_TipoCambio_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Obj_DAL.cBandIM = 'M';
            txt_IdTipoCambio.Enabled = false;
            txt_IdTipoCambio.Text = dgv_TipoCambio.SelectedRows[0].Cells[0].Value.ToString().Trim();
            txt_Valor.Text = dgv_TipoCambio.SelectedRows[0].Cells[1].Value.ToString().Trim();
            txt_Fecha.Text = dgv_TipoCambio.SelectedRows[0].Cells[2].Value.ToString().Trim();
        }

        private void btn_Refrescar_Click(object sender, EventArgs e)
        {
            Cargar_Datos_TipoCambio();
        }
    }
}
