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
    public partial class FRM_Planillas : Form
    {
        public FRM_Planillas()
        {
            InitializeComponent();
        }

        #region Variables Globales
        cls_Planillas_BLL Obj_BLL = new cls_Planillas_BLL();
        cls_Planillas_DAL Obj_DAL = new cls_Planillas_DAL();
        #endregion

        private void FRM_Planillas_Load(object sender, EventArgs e)
        {
            Cargar_Datos_Planilla();
            Cargar_cmb();
        }
        public void Cargar_Datos_Planilla()
        {            
            string sMsjError = string.Empty;
            DataTable dtPlanilla = new DataTable();
            Obj_DAL.cBandIM = 'I';            

            txt_IdPlanilla.Clear();

            if (txt_FiltrarPlanillas.Text == string.Empty)
            {
                dtPlanilla = Obj_BLL.Listar_Planilla(ref sMsjError);
            }
            else
            {
                dtPlanilla = Obj_BLL.Filtrar_Planilla(ref sMsjError, txt_FiltrarPlanillas.Text);
            }
            if (sMsjError == string.Empty)
            {
                dgv_Planillas.DataSource = null;
                dgv_Planillas.DataSource = dtPlanilla;
            }
        }

        public void Cargar_cmb()
        {
            string sMsjError = string.Empty;

            #region Cargar Estados
            cls_Estados_BLL Obj_Estados_BLL = new cls_Estados_BLL();
            DataTable DT_Estados = new DataTable();
            DT_Estados = Obj_Estados_BLL.Listar_Estados(ref sMsjError);
            cmb_IdEstado.DataSource = DT_Estados;
            DT_Estados.Rows.Add("0", "Elija Estado");
            cmb_IdEstado.DisplayMember = DT_Estados.Columns[1].ToString();
            cmb_IdEstado.ValueMember = DT_Estados.Columns[0].ToString();
            cmb_IdEstado.SelectedValue = "0";
            #endregion

            #region Horario
            cls_Horarios_BLL Obj_Horarios_BLL = new cls_Horarios_BLL();
            DataTable DT_Horarios = new DataTable();
            DT_Horarios = Obj_Horarios_BLL.Listar_Horarios(ref sMsjError);
            cmb_IdHorario.DataSource = DT_Horarios;
            DT_Horarios.Rows.Add("0", "Elija Estado");
            cmb_IdHorario.DisplayMember = DT_Horarios.Columns[1].ToString();
            cmb_IdHorario.ValueMember = DT_Horarios.Columns[0].ToString();
            cmb_IdHorario.SelectedValue = "0";
            #endregion

            #region Empleados           
            cls_Empleados_BLL Obj_Empleados_BLL = new cls_Empleados_BLL();
            DataTable DT_Empleados = new DataTable();
            DT_Empleados = Obj_Empleados_BLL.Listar_Empleados(ref sMsjError);
            cmb_IdEmpleado.DataSource = DT_Empleados;
            DT_Empleados.Rows.Add("0", "Elija un Empleado");
            cmb_IdEmpleado.DisplayMember = DT_Empleados.Columns[1].ToString();
            cmb_IdEmpleado.ValueMember = DT_Empleados.Columns[0].ToString();
            cmb_IdEmpleado.SelectedValue = "0";
            #endregion
        }

        private void txt_FiltrarPlanillas_TextChanged(object sender, EventArgs e)
        {
            Cargar_Datos_Planilla();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txt_IdPlanilla.Text)) && cmb_IdHorario.SelectedValue.ToString() == "0"
                && cmb_IdEstado.SelectedValue.ToString() == "0" && cmb_IdEmpleado.SelectedValue.ToString() == "0")
            {
                Obj_DAL.iIdPlanilla = Convert.ToInt16(txt_IdPlanilla.Text);
                Obj_DAL.bIdEmpleado = Convert.ToByte(cmb_IdEmpleado.SelectedValue);
                Obj_DAL.bIdHorario = Convert.ToByte(cmb_IdHorario.SelectedValue);
                Obj_DAL.bIdEstado = Convert.ToByte(cmb_IdEstado.SelectedValue);
                string sMsjError = string.Empty;

                if (Obj_DAL.cBandIM == 'I')
                {
                    Obj_BLL.Insertar_Planillas(ref sMsjError, ref Obj_DAL);
                    MessageBox.Show("Nuevo registro ingresado exitosamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cargar_Datos_Planilla();
                }
                else if (Obj_DAL.cBandIM == 'M')
                {
                    Obj_BLL.Modificar_Planillas(ref sMsjError, ref Obj_DAL);
                    MessageBox.Show("Modificación de registro exitoso", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_IdPlanilla.Enabled = true;
                    Cargar_Datos_Planilla();
                }
                Cargar_cmb();
            }
            else
            {
                MessageBox.Show("No se pueden guardar datos vacios", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_Refrescar_Click(object sender, EventArgs e)
        {
            Cargar_Datos_Planilla();
            Cargar_cmb();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {

            if (dgv_Planillas.RowCount == 0)
            {
                MessageBox.Show("No hay datos para modificar");
            }
            else
            {
                Obj_DAL.cBandIM = 'M';
                txt_IdPlanilla.Enabled = false;
                txt_IdPlanilla.Text = dgv_Planillas.SelectedRows[0].Cells[0].Value.ToString().Trim();
                cmb_IdEmpleado.Text = dgv_Planillas.SelectedRows[0].Cells[1].Value.ToString().Trim();
                cmb_IdHorario.Text = dgv_Planillas.SelectedRows[0].Cells[2].Value.ToString().Trim();
                cmb_IdEstado.Text = dgv_Planillas.SelectedRows[0].Cells[3].Value.ToString().Trim();
            }
        }

        private void dgv_Planillas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Planillas.RowCount == 0)
            {
                MessageBox.Show("No hay datos para modificar");
            }
            else
            {
                Obj_DAL.cBandIM = 'M';
                txt_IdPlanilla.Enabled = false;
                txt_IdPlanilla.Text = dgv_Planillas.SelectedRows[0].Cells[0].Value.ToString().Trim();
                cmb_IdEmpleado.Text = dgv_Planillas.SelectedRows[0].Cells[1].Value.ToString().Trim();
                cmb_IdHorario.Text = dgv_Planillas.SelectedRows[0].Cells[2].Value.ToString().Trim();
                cmb_IdEstado.Text = dgv_Planillas.SelectedRows[0].Cells[3].Value.ToString().Trim();
            }
        }

        #region Validaciones
        private void txt_IdPlanilla_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                errorIcono.SetError(txt_IdPlanilla, "");
            }
            else
            {
                e.Handled = true;
                errorIcono.SetError(txt_IdPlanilla, "Solo puede digitar numeros");
            }
        }

        private void cmb_IdEmpleado_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cmb_IdHorario_KeyPress(object sender, KeyPressEventArgs e)
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
        #endregion

        private void btn_Exite_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
