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
    public partial class FRM_Usuario : Form
    {
        public FRM_Usuario()
        {
            InitializeComponent();
        }

        #region Variables Globales
        cls_Usuarios_BLL Obj_BLL = new cls_Usuarios_BLL();
        cls_Usuarios_DAL Obj_DAL = new cls_Usuarios_DAL();
        #endregion

        private void FRM_Usuario_Load(object sender, EventArgs e)
        {
            Cargar_Datos();
            Cargar_cmb();
        }

        public void Cargar_Datos()
        {

            string sMsjError = string.Empty;
            DataTable dtArticulos = new DataTable();
            Obj_DAL.cBandIM = 'I';

            txt_Usuario.Enabled = true;
            txt_Usuario.Clear();
            txt_Contraseña.Clear();

            if (txt_Filtrar.Text == string.Empty)
            {
                dtArticulos = Obj_BLL.Listar_Usuarios(ref sMsjError);
            }
            else
            {
                dtArticulos = Obj_BLL.Filtrar_Usuarios(ref sMsjError, txt_Filtrar.Text);
            }
            if (sMsjError == string.Empty)
            {
                dgv_Usuario.DataSource = null;
                dgv_Usuario.DataSource = dtArticulos;
            }
        }

        public void Cargar_cmb()
        {
            string sMsjError = string.Empty;

            #region Cargar Estados
            cls_Estados_BLL Obj_Estados_BLL = new cls_Estados_BLL();
            DataTable DT_Estados = new DataTable();
            DT_Estados = Obj_Estados_BLL.Listar_Estados(ref sMsjError);
            cmb_Estado.DataSource = DT_Estados;
            DT_Estados.Rows.Add("0", "Elija una opción");
            cmb_Estado.DisplayMember = DT_Estados.Columns[1].ToString();
            cmb_Estado.ValueMember = DT_Estados.Columns[0].ToString();
            cmb_Estado.SelectedValue = "0";
            #endregion

            #region Empleados           
            cls_Empleados_BLL Obj_Empleados_BLL = new cls_Empleados_BLL();
            DataTable DT_Empleados = new DataTable();
            DT_Empleados = Obj_Empleados_BLL.Listar_Empleados(ref sMsjError);
            cmb_Empleados.DataSource = DT_Empleados;
            DT_Empleados.Rows.Add("0", "", "", "Elija una opción");
            cmb_Empleados.DisplayMember = DT_Empleados.Columns[3].ToString();
            cmb_Empleados.ValueMember = DT_Empleados.Columns[0].ToString();
            cmb_Empleados.SelectedValue = "0";
            #endregion

            #region Cargar Roles
            cls_Roles_BLL Obj_Roles_BLL = new cls_Roles_BLL();
            DataTable DT_Roles = new DataTable();
            DT_Roles = Obj_Roles_BLL.Listar_Roles(ref sMsjError);
            cmb_Rol.DataSource = DT_Roles;
            DT_Roles.Rows.Add("0", "0", "Elija una opción");
            cmb_Rol.DisplayMember = DT_Roles.Columns[2].ToString();
            cmb_Rol.ValueMember = DT_Roles.Columns[0].ToString();
            cmb_Rol.SelectedValue = "0";
            #endregion
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txt_Usuario.Text)) && !(string.IsNullOrEmpty(txt_Contraseña.Text)) && cmb_Estado.SelectedValue.ToString() != "0"
                &&  cmb_Empleados.SelectedValue.ToString() != "0" && cmb_Rol.SelectedValue.ToString() != "0")
            {
                Obj_DAL.sIdUsuario = txt_Usuario.Text;
                Obj_DAL.sContraseña = txt_Contraseña.Text;
                Obj_DAL.bIdRole = Convert.ToByte(cmb_Empleados.SelectedValue);
                Obj_DAL.cIdEstado = Convert.ToChar(cmb_Estado.SelectedValue);
                Obj_DAL.bIdEmpleado = Convert.ToByte(cmb_Empleados.SelectedValue);
                string sMsjError = string.Empty;

                if (Obj_DAL.cBandIM == 'I')
                {
                    Obj_BLL.Insertar_Usuarios(ref sMsjError, ref Obj_DAL);
                    if (sMsjError == string.Empty)
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
                    Obj_BLL.Modificar_Usuarios(ref sMsjError, ref Obj_DAL);
                    if (sMsjError == string.Empty)
                    {
                        MessageBox.Show("Modificación de registro exitoso", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_Usuario.Enabled = true;
                        Cargar_Datos();
                    }
                    else
                    {
                        MessageBox.Show("Se genera el siguiente error: " + "[" + sMsjError + "]", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
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
            Cargar_Datos();
            Cargar_cmb();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (dgv_Usuario.RowCount == 0)
            {
                MessageBox.Show("No hay datos para modificar");
            }
            else
            {
                Obj_DAL.cBandIM = 'M';
                txt_Usuario.Enabled = false;
                txt_Usuario.Text = dgv_Usuario.SelectedRows[0].Cells[0].Value.ToString().Trim();
                txt_Contraseña.Text = dgv_Usuario.SelectedRows[0].Cells[1].Value.ToString().Trim();
                cmb_Empleados.Text = dgv_Usuario.SelectedRows[0].Cells[2].Value.ToString().Trim();
                cmb_Estado.Text = dgv_Usuario.SelectedRows[0].Cells[3].Value.ToString().Trim();
                cmb_Empleados.Text = dgv_Usuario.SelectedRows[0].Cells[4].Value.ToString().Trim();
            }
        }

        private void dgv_Usuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgv_Usuario.RowCount == 0)
            {
                MessageBox.Show("No hay datos para modificar");
            }
            else
            {
                Obj_DAL.cBandIM = 'M';
                txt_Usuario.Enabled = false;
                txt_Usuario.Text = dgv_Usuario.SelectedRows[0].Cells[0].Value.ToString().Trim();
                txt_Contraseña.Text = dgv_Usuario.SelectedRows[0].Cells[1].Value.ToString().Trim();
                cmb_Empleados.Text = dgv_Usuario.SelectedRows[0].Cells[2].Value.ToString().Trim();
                cmb_Estado.Text = dgv_Usuario.SelectedRows[0].Cells[3].Value.ToString().Trim();
                cmb_Empleados.Text = dgv_Usuario.SelectedRows[0].Cells[4].Value.ToString().Trim();
            }
        }

        private void txt_Filtrar_TextChanged(object sender, EventArgs e)
        {
            Cargar_Datos();
        }

        #region Validaciones

        private void txt_Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void cmb_Rol_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cmb_Estado_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
