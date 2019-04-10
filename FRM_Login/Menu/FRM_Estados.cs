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
            
        }

        public void Cargar_Datos()
        {
            txtIdEsta.Enabled = true;
            string sMsjError = string.Empty;
            DataTable dtEstados = new DataTable();
            Obj_DAL.cBandIM = 'I';

            txtIdEsta.Clear();
            txt_Nombre.Clear();

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

            if (!(string.IsNullOrEmpty(txtIdEsta.Text)) && !(string.IsNullOrEmpty(txt_Nombre.Text)))
            {
                Obj_DAL.cIdEstado = Convert.ToChar(txtIdEsta.Text.ToUpper());
                Obj_DAL.sNombre = txt_Nombre.Text;
           
                string sMsjError = string.Empty;

                if(Obj_DAL.cBandIM == 'I')
                {
                    Obj_BLL.Insertar_Estados(ref sMsjError, ref Obj_DAL);

                    if(sMsjError == string.Empty)
                    {
                        MessageBox.Show("Nuevo registro ingresado exitosamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Cargar_Datos();
                    }
                    else
                    {
                        MessageBox.Show("Se genera el siguiente error: " + "[" + sMsjError + "]", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                else if (Obj_DAL.cBandIM == 'M')
                {
                    Obj_BLL.Modificar_Estados(ref sMsjError, ref Obj_DAL);
                    if (sMsjError == string.Empty)
                    {
                        MessageBox.Show("Modificación de registro exitoso", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtIdEsta.Enabled = true;
                        Cargar_Datos();
                    }
                    else
                    {
                        MessageBox.Show("Se genera el siguiente error: " + "[" + sMsjError + "]", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }                
            }
            else
            {
                MessageBox.Show("No se permiten espacios en blanco", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            }
        }

        private void txtIdEsta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras");
            }
        }

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || (e.KeyChar==((char)Keys.Back)))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras");
            }
        }
    }
}
