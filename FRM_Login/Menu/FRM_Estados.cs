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
    public partial class FRM_Estados : Form
    {
        public FRM_Estados()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Variables Globales
        cls_Estados_DAL Obj_DAL = new cls_Estados_DAL();
        cls_Estados_BLL Obj_BLL = new cls_Estados_BLL();
        #endregion

        private void FRM_Estados_Load(object sender, EventArgs e)
        {
            Cargar_Datos();
            Obj_DAL.cBandIM = 'I';
        }
        public void Cargar_Datos()
        {
            
            string sMsjError = string.Empty;
            DataTable dtEstados = new DataTable();

            txtIdEsta.Enabled = false;
            txtIdEsta.Clear();
            txt_Nombre.Clear();
            txtDescEstados.Clear();

            if(toolStripTextBox1.Text == string.Empty)
            {
                dtEstados = Obj_BLL.Listar_Estados(ref sMsjError);
            }
            else
            {
                dtEstados = Obj_BLL.Filtrar_Estados(ref sMsjError, toolStripTextBox1.Text);
            }
            if (sMsjError == string.Empty)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dtEstados;
            }
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            Cargar_Datos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (!(string.IsNullOrEmpty(txtIdEsta.Text)) && !(string.IsNullOrEmpty(txt_Nombre.Text)) && !(string.IsNullOrEmpty(txtDescEstados.Text)))
            {
                Obj_DAL.bIdEstado = Convert.ToByte(txtIdEsta.Text);
                Obj_DAL.sNombre = txt_Nombre.Text;
                Obj_DAL.sDescripcion = txtDescEstados.Text;
                string sMsjError = string.Empty;

                if(Obj_DAL.cBandIM == 'I')
                {
                    Obj_BLL.Insertar_Estados(ref sMsjError, ref Obj_DAL);
                    MessageBox.Show("Nuevo registro ingresado exitosamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cargar_Datos();
                }
                else if (Obj_DAL.cBandIM == 'M')
                {
                    Obj_BLL.Modificar_Estados(ref sMsjError, ref Obj_DAL);
                    MessageBox.Show("Modificación de registro exitoso", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdEsta.Enabled = true;
                    Cargar_Datos();
                }                
            }
            else
            {
                MessageBox.Show("No se pueden guardar datos vacios", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
                
        }

        private void btn_Refrescar_Click(object sender, EventArgs e)
        {
            Cargar_Datos();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if(dataGridView1.RowCount == 0)
            {
                MessageBox.Show("No hay datos para modificar");
            }
            else
            {
                Obj_DAL.cBandIM = 'M';
                txtIdEsta.Enabled = false;
                txtIdEsta.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString().Trim();
                txt_Nombre.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString().Trim();
                txtDescEstados.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString().Trim();
            }

            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("No hay datos para modificar");
            }
            else
            {
                Obj_DAL.cBandIM = 'M';
                txtIdEsta.Enabled = false;
                txtIdEsta.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString().Trim();
                txt_Nombre.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString().Trim();
                txtDescEstados.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString().Trim();
            }
        }

        private void txtIdEsta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                errorIcono.SetError(txtIdEsta, "");
            }
            else
            {
                e.Handled = true;
                errorIcono.SetError(txtIdEsta, "Solo puede digitar numeros");
            }
        }

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) ||
                char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
                errorIcono.SetError(txt_Nombre, "");
            }
            else
            {
                e.Handled = true;
                errorIcono.SetError(txt_Nombre, "Solo puede digitar letras");
            }
        }

        private void txtDescEstados_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) ||
                char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
                errorIcono.SetError(txtDescEstados, "");
            }
            else
            {
                e.Handled = true;
                errorIcono.SetError(txtDescEstados, "Solo puede digitar letras");
            }
        }
    }
}
