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
    public partial class FRM_Tipo_Placa : Form
    {
        public FRM_Tipo_Placa()
        {
            InitializeComponent();
        }
        #region Variables Globales
        cls_TipoPlaca_DAL Obj_TipoPlaca_DAL = new cls_TipoPlaca_DAL();
        cls_TipoPlaca_BLL Obj_TipoPlaca_BLL = new cls_TipoPlaca_BLL();
        #endregion

        public void Cargar_Datos()
        {
            cls_TipoPlaca_BLL Obj_BLL = new cls_TipoPlaca_BLL();
            string sMsjError = string.Empty;
            DataTable dtTipoPlaca = new DataTable();
            Obj_TipoPlaca_DAL.cBandIM = 'I';

            if (txt_Filtrar.Text == string.Empty)
            {
                dtTipoPlaca = Obj_BLL.Listar_TipoPlaca(ref sMsjError);
            }
            else
            {
                dtTipoPlaca = Obj_BLL.Filtrar_TipoPlaca(ref sMsjError, txt_Filtrar.Text);
            }
            if (sMsjError == string.Empty)
            {
                dgv_TipoPlaca.DataSource = null;
                dgv_TipoPlaca.DataSource = dtTipoPlaca;
            }

        }

        private void FRM_Tipo_Placa_Load(object sender, EventArgs e)
        {
            Cargar_Datos();
        }

       
        private void dgv_TipoPlaca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Obj_TipoPlaca_DAL.cBandIM = 'M';
            txt_IdTipoPlaca.Enabled = false;
            txt_IdTipoPlaca.Text = dgv_TipoPlaca.SelectedRows[0].Cells[0].Value.ToString().Trim();
            txt_Descripcion.Text = dgv_TipoPlaca.SelectedRows[0].Cells[1].Value.ToString().Trim();
        }

        private void txt_Filtrar_TextChanged(object sender, EventArgs e)
        {
            Cargar_Datos();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txt_IdTipoPlaca.Text)) && !(string.IsNullOrEmpty(txt_Descripcion.Text)))
            {
                Obj_TipoPlaca_DAL.bIdTipoPlaca = Convert.ToByte(txt_IdTipoPlaca.Text);
                Obj_TipoPlaca_DAL.sDescripcion = txt_Descripcion.Text;
                string sMsjError = string.Empty;

                if (Obj_TipoPlaca_DAL.cBandIM == 'I')
                {
                    Obj_TipoPlaca_BLL.Insertar_TipoPlaca(ref sMsjError, ref Obj_TipoPlaca_DAL);
                    MessageBox.Show("Nuevo registro ingresado exitosamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cargar_Datos();
                }
                else if (Obj_TipoPlaca_DAL.cBandIM == 'M')
                {
                    Obj_TipoPlaca_BLL.Modificar_TipoPlaca(ref sMsjError, ref Obj_TipoPlaca_DAL);
                    MessageBox.Show("Modificación de registro exitoso", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_IdTipoPlaca.Enabled = true;
                    Cargar_Datos();
                }
            }
            else
            {
                MessageBox.Show("No se pueden guardar datos vacios", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (dgv_TipoPlaca.RowCount==0)
            {
                MessageBox.Show("No hay datos para modificar");
            }
            else
            {
                Obj_TipoPlaca_DAL.cBandIM = 'M';
                txt_IdTipoPlaca.Enabled = false;
                txt_IdTipoPlaca.Text = dgv_TipoPlaca.SelectedRows[0].Cells[0].Value.ToString().Trim();
                txt_Descripcion.Text = dgv_TipoPlaca.SelectedRows[0].Cells[1].Value.ToString().Trim();
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Refrescar_Click(object sender, EventArgs e)
        {
            Cargar_Datos();
        }
    }
}
