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
            
            string sMsjError = string.Empty;
            DataTable dtEstados = new DataTable();

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

            if (!(string.IsNullOrEmpty(txtIdEsta.Text)) || !(string.IsNullOrEmpty(txt_Nombre.Text)) || !(string.IsNullOrEmpty(txtDescEstados.Text)))
            {
                Obj_DAL.bIdEstado = Convert.ToByte(txtIdEsta.Text);
                Obj_DAL.sNombre = txt_Nombre.Text;
                Obj_DAL.sDescripcion = txtDescEstados.Text;
                string sMsjError = string.Empty;

                Obj_BLL.Insertar_Estados(ref sMsjError, ref Obj_DAL);

                MessageBox.Show("Nuevo registro ingresado exitosamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pueden guardar datos vacios", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
                
        }
    }
}
