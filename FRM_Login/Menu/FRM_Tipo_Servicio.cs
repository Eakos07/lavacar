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
    public partial class FRM_Tipo_Servicio : Form
    {
        public FRM_Tipo_Servicio()
        {
            InitializeComponent();
        }

        #region Variables Globales
        cls_TipoServicio_BLL Obj_TipoServicio_BLL = new cls_TipoServicio_BLL();
        cls_TipoServicio_DAL Obj_TipoServicio_DAL = new cls_TipoServicio_DAL();   
        #endregion

        public void Cargar_Datos()
        {
            string sMsjError = String.Empty;
            DataTable DT_TipoServicio = new DataTable();
            
            
            #region Cargar TipoVehiculo
            cls_TipoVehiculo_BLL Obj_TipoVehiculo_BLL = new cls_TipoVehiculo_BLL();
            DataTable DT_TipoVehiculo = new DataTable();
            DT_TipoVehiculo = Obj_TipoVehiculo_BLL.Listar_TipoVehiculo(ref sMsjError);
            cmb_IdTipoVehiculo.DataSource = DT_TipoVehiculo;
            DT_TipoVehiculo.Rows.Add("0", "Elija una opción");
            cmb_IdTipoVehiculo.DisplayMember = DT_TipoVehiculo.Columns[1].ToString();
            cmb_IdTipoVehiculo.ValueMember = DT_TipoVehiculo.Columns[0].ToString();
            cmb_IdTipoVehiculo.SelectedValue = "0";
            #endregion

            txt_Duracion.Clear();
            txt_CodigoServicio.Clear();
            txt_NombreServicio.Clear();
            txt_Precio.Clear();

            if (txt_Filtrar.Text == String.Empty)
            {
              DT_TipoServicio = Obj_TipoServicio_BLL.Listar_TipoServicio(ref sMsjError);
            }
            else
            {
                DT_TipoServicio = Obj_TipoServicio_BLL.Filtrar_TipoServicio(ref sMsjError, txt_Filtrar.Text);
            }
            if (sMsjError == String.Empty)
            {
                dgv_TipoServicio.DataSource = null;
                dgv_TipoServicio.DataSource = DT_TipoServicio;
            }
        }

        private void FRM_Tipo_Servicio_Load(object sender, EventArgs e)
        {
            Cargar_Datos();
            Obj_TipoServicio_DAL.cBandIM = 'I';
        }

        private void txt_Filtrar_TextChanged(object sender, EventArgs e)
        {
            Cargar_Datos();
        }

        private void btn_Refrescar_Click(object sender, EventArgs e)
        {
            Cargar_Datos(); //
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txt_CodigoServicio.Text)) && !(string.IsNullOrEmpty(txt_NombreServicio.Text))&&
                !(string.IsNullOrEmpty(txt_Precio.Text)) && !(string.IsNullOrEmpty(txt_Duracion.Text))
                && (cmb_IdTipoVehiculo.SelectedValue.ToString() != "0"))
            {
                Obj_TipoServicio_DAL.cCodServicio = Convert.ToChar(txt_CodigoServicio.Text);
                Obj_TipoServicio_DAL.sNombreServicio = txt_NombreServicio.Text;
                Obj_TipoServicio_DAL.dPrecio = Convert.ToDecimal(txt_Precio.Text);
                Obj_TipoServicio_DAL.sDuracion = txt_Duracion.Text;
                Obj_TipoServicio_DAL.bIdTipoVehiculo = Convert.ToByte(cmb_IdTipoVehiculo.SelectedValue);
                string sMsjError = string.Empty;

                if (Obj_TipoServicio_DAL.cBandIM=='I')
                {
                    Obj_TipoServicio_BLL.Insertar_TipoServicio(ref sMsjError, ref Obj_TipoServicio_DAL);
                    MessageBox.Show("Nuevo registro ingresado exitosamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cargar_Datos();
                }
                else if (Obj_TipoServicio_DAL.cBandIM == 'M')
                {
                    Obj_TipoServicio_BLL.Modificar_TipoServicio(ref sMsjError, ref Obj_TipoServicio_DAL);
                    MessageBox.Show("Modificación de registro exitosa", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_CodigoServicio.Enabled = false;
                    Cargar_Datos();
                }
            }
            else
            {
                MessageBox.Show("No se pueden guardar datos vacios", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgv_TipoServicio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Obj_TipoServicio_DAL.cBandIM = 'M';
            txt_CodigoServicio.Enabled = false;

            txt_CodigoServicio.Text = dgv_TipoServicio.SelectedRows[0].Cells[0].Value.ToString().Trim();
            txt_NombreServicio.Text = dgv_TipoServicio.SelectedRows[0].Cells[1].Value.ToString().Trim();
            txt_Precio.Text = dgv_TipoServicio.SelectedRows[0].Cells[2].Value.ToString().Trim();
            txt_Duracion.Text = dgv_TipoServicio.SelectedRows[0].Cells[3].Value.ToString().Trim();
            cmb_IdTipoVehiculo.SelectedValue = dgv_TipoServicio.SelectedRows[0].Cells[4].Value.ToString().Trim();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (dgv_TipoServicio.RowCount==0)
            {
                MessageBox.Show("No hay datos para modificar");
            }
            else
            {
                Obj_TipoServicio_DAL.cBandIM = 'M';
                txt_CodigoServicio.Enabled = false;
                
                txt_CodigoServicio.Text = dgv_TipoServicio.SelectedRows[0].Cells[0].Value.ToString().Trim();
                txt_NombreServicio.Text = dgv_TipoServicio.SelectedRows[0].Cells[1].Value.ToString().Trim();
                txt_Precio.Text = dgv_TipoServicio.SelectedRows[0].Cells[2].Value.ToString().Trim();
                txt_Duracion.Text = dgv_TipoServicio.SelectedRows[0].Cells[3].Value.ToString().Trim();
                cmb_IdTipoVehiculo.SelectedValue = dgv_TipoServicio.SelectedRows[0].Cells[4].Value.ToString().Trim();
            }

        }
    }
}
