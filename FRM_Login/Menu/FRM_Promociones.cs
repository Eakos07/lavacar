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
    public partial class FRM_Promociones : Form
    {
        public FRM_Promociones()
        {
            InitializeComponent();
        }

        private void FRM_Promociones_Load(object sender, EventArgs e)
        {
            Cargar_Datos_Promociones();

        }
        #region Variables Globales
        cls_Promociones_BLL Obj_BLL = new cls_Promociones_BLL();
        cls_Promociones_DAL Obj_DAL = new cls_Promociones_DAL();
        #endregion
        public void Cargar_Datos_Promociones()
        {
            
            string sMsjError = string.Empty;
            DataTable dtPromociones = new DataTable();
            Obj_DAL.cBandIM = 'I';

            txt_IdPromociones.Clear();
            txt_TipoPromo.Clear();
            txt_descrip.Clear();

            if (txt_FiltrarPromociones.Text == string.Empty)
            {
                dtPromociones = Obj_BLL.Listar_Promociones(ref sMsjError);
            }
            else
            {
                dtPromociones = Obj_BLL.Filtrar_Promociones(ref sMsjError, txt_FiltrarPromociones.Text);
            }
            if (sMsjError == string.Empty)
            {
                dgv_Promociones.DataSource = null;
                dgv_Promociones.DataSource = dtPromociones;
            }
        }

        private void txt_FiltrarPromociones_TextChanged(object sender, EventArgs e)
        {
            Cargar_Datos_Promociones();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_IdPromociones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras");
            }
        }

        private void dgv_Promociones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Promociones.RowCount == 0)
            {
                MessageBox.Show("No hay datos para modificar");
            }
            else
            {
                Obj_DAL.cBandIM = 'M';
                txt_IdPromociones.Enabled = false;
                txt_IdPromociones.Text = dgv_Promociones.SelectedRows[0].Cells[0].Value.ToString().Trim();
                txt_TipoPromo.Text = dgv_Promociones.SelectedRows[0].Cells[1].Value.ToString().Trim();
                txt_descrip.Text = dgv_Promociones.SelectedRows[0].Cells[2].Value.ToString().Trim();
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (dgv_Promociones.RowCount == 0)
            {
                MessageBox.Show("No hay datos para modificar");
            }
            else
            {
                Obj_DAL.cBandIM = 'M';
                txt_IdPromociones.Enabled = false;
                txt_IdPromociones.Text = dgv_Promociones.SelectedRows[0].Cells[0].Value.ToString().Trim();
                txt_TipoPromo.Text = dgv_Promociones.SelectedRows[0].Cells[1].Value.ToString().Trim();
                txt_descrip.Text = dgv_Promociones.SelectedRows[0].Cells[2].Value.ToString().Trim();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txt_IdPromociones.Text)) && !(string.IsNullOrEmpty(txt_TipoPromo.Text)) && !(string.IsNullOrEmpty(txt_descrip.Text)))
            {
                Obj_DAL.cIdPromocion = Convert.ToChar(txt_IdPromociones.Text);
                Obj_DAL.sTipoPromocion = txt_TipoPromo.Text;
                Obj_DAL.sDescripcion = txt_descrip.Text;

                string sMsjError = string.Empty;

                if (Obj_DAL.cBandIM == 'I')
                {
                    Obj_BLL.Insertar_Promociones(ref sMsjError, ref Obj_DAL);
                    if (sMsjError == string.Empty)
                    {
                        MessageBox.Show("Nuevo registro ingresado exitosamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Cargar_Datos_Promociones();
                    }
                    else
                    {
                        MessageBox.Show("Se genera el siguiente error: " + "[" + sMsjError + "]", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else if (Obj_DAL.cBandIM == 'M')
                {
                    Obj_BLL.Modificar_Promociones(ref sMsjError, ref Obj_DAL);
                    if (sMsjError == string.Empty)
                    {
                        MessageBox.Show("Modificación de registro exitoso", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Cargar_Datos_Promociones();
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
    }
}
