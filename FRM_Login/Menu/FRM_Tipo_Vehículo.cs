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
    public partial class FRM_Tipo_Vehículo : Form
    {
        public FRM_Tipo_Vehículo()
        {
            InitializeComponent();
        }
        #region Variables Globales
        cls_TipoVehiculo_BLL Obj_TipoVehiculo_BLL = new cls_TipoVehiculo_BLL();
        cls_TipoVehiculo_DAL Obj_TipoVehiculo_DAL = new cls_TipoVehiculo_DAL();
        #endregion

        public void Cargar_Datos()
        {
            
            string sMsjError = string.Empty;
            DataTable dtTipoVehiculo = new DataTable();
            Obj_TipoVehiculo_DAL.cBandIM = 'I';

            if (txt_FiltTipVehicul.Text == string.Empty)
            {
                dtTipoVehiculo = Obj_TipoVehiculo_BLL.Listar_TipoVehiculo(ref sMsjError);
            }
            else
            {
                dtTipoVehiculo = Obj_TipoVehiculo_BLL.Filtrar_TipoVehiculo(ref sMsjError, txt_FiltTipVehicul.Text);
            }
            if (sMsjError == string.Empty)
            {
                dgv_TipoVehiculo.DataSource = null;
                dgv_TipoVehiculo.DataSource = dtTipoVehiculo;
            }
        }


        private void FRM_Tipo_Vehículo_Load(object sender, EventArgs e)
        {
            Cargar_Datos();
        }

        private void txt_FiltTipVehicul_TextChanged(object sender, EventArgs e)
        {
            Cargar_Datos();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_TipoVehiculo.Text) || !string.IsNullOrEmpty(txt_Descrip.Text))
            {
                Obj_TipoVehiculo_DAL.bIdTipoVehiculo = Convert.ToByte(txt_TipoVehiculo.Text);
                Obj_TipoVehiculo_DAL.sDescripcion = txt_Descrip.Text;
                string sMsjError = string.Empty;

                if (Obj_TipoVehiculo_DAL.cBandIM=='I')
                {
                    Obj_TipoVehiculo_BLL.Insertar_TipoVehiculo(ref sMsjError, ref Obj_TipoVehiculo_DAL);
                    MessageBox.Show("Nuevo registro ingresado exitosamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cargar_Datos();
                }
                else if (Obj_TipoVehiculo_DAL.cBandIM == 'M')
                {
                    Obj_TipoVehiculo_BLL.Modificar_TipoVehiculo(ref sMsjError, ref Obj_TipoVehiculo_DAL);
                    MessageBox.Show("Modificación de registro exitoso", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_TipoVehiculo.Enabled = true;
                    Cargar_Datos();
                }
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (dgv_TipoVehiculo.RowCount == 0)
            {
                MessageBox.Show("No hay datos para modificar");
            }
            else
            {
                Obj_TipoVehiculo_DAL.cBandIM = 'M';
                txt_TipoVehiculo.Enabled = false;
                txt_TipoVehiculo.Text = dgv_TipoVehiculo.SelectedRows[0].Cells[0].Value.ToString().Trim();
                txt_Descrip.Text = dgv_TipoVehiculo.SelectedRows[0].Cells[1].Value.ToString().Trim();
            }
        }

        private void dgv_TipoVehiculo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Obj_TipoVehiculo_DAL.cBandIM = 'M';
            txt_TipoVehiculo.Enabled = false;
            txt_TipoVehiculo.Text = dgv_TipoVehiculo.SelectedRows[0].Cells[0].Value.ToString().Trim();
            txt_Descrip.Text = dgv_TipoVehiculo.SelectedRows[0].Cells[1].Value.ToString().Trim();
        }

        private void btn_Refrescar_Click(object sender, EventArgs e)
        {
            Cargar_Datos();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_TipoVehiculo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                errorIcono.SetError(txt_TipoVehiculo, "");
            }
            else
            {
                e.Handled = true;
                errorIcono.SetError(txt_TipoVehiculo, "Solo puede digitar numeros");
            }
        }

        private void txt_Descrip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) ||
                char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
                errorIcono.SetError(txt_NumCita, "");
            }
            else
            {
                e.Handled = true;
                errorIcono.SetError(txt_NumCita, "Solo puede digitar letras");
            }
        }
    }
}
