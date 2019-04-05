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
    public partial class FRM_Roles : Form
    {
        public FRM_Roles()
        {
            InitializeComponent();
        }

        #region 
        cls_Roles_BLL Obj_BLL = new cls_Roles_BLL();
        cls_Roles_DAL Obj_DAL = new cls_Roles_DAL();
        #endregion

        private void FRM_Roles_Load(object sender, EventArgs e)
        {
            Cargar_Datos_Roles();
        }
        public void Cargar_Datos_Roles()
        {
            
            string sMsjError = string.Empty;
            DataTable dtRoles = new DataTable();
            Obj_DAL.cBandIM = 'I';

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

            txt_IdRol.Clear();
            txt_Nivel.Clear();
            txt_Descrip.Clear();

            if (txt_FiltrarRoles.Text == string.Empty)
            {
                dtRoles = Obj_BLL.Listar_Roles(ref sMsjError);
            }
            else
            {
                dtRoles = Obj_BLL.Filtrar_Roles(ref sMsjError, txt_FiltrarRoles.Text);
            }
            if (sMsjError == string.Empty)
            {
                dgv_Roles.DataSource = null;
                dgv_Roles.DataSource = dtRoles;
            }
        }

        private void txt_FiltrarRoles_TextChanged(object sender, EventArgs e)
        {
            Cargar_Datos_Roles();
        }

        private void btn_Refrescar_Click(object sender, EventArgs e)
        {
            Cargar_Datos_Roles();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (dgv_Roles.RowCount == 0)
            {
                MessageBox.Show("No hay datos para modificar");
            }
            else
            {
                Obj_DAL.cBandIM = 'M';
                txt_IdRol.Enabled = false;
                txt_IdRol.Text = dgv_Roles.SelectedRows[0].Cells[0].Value.ToString().Trim();
                txt_Nivel.Text = dgv_Roles.SelectedRows[0].Cells[1].Value.ToString().Trim();
                txt_Descrip.Text = dgv_Roles.SelectedRows[0].Cells[2].Value.ToString().Trim();
                cmb_IdEstado.SelectedValue = dgv_Roles.SelectedRows[0].Cells[3].Value.ToString().Trim();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txt_IdRol.Text)) && !(string.IsNullOrEmpty(txt_Nivel.Text)) && !(string.IsNullOrEmpty(txt_Descrip.Text)) 
                && cmb_IdEstado.SelectedValue.ToString() != "0")
            {
                Obj_DAL.bIdRole = Convert.ToByte(txt_IdRol.Text);
                Obj_DAL.bNivel = Convert.ToByte(txt_Nivel.Text);
                Obj_DAL.sDescripcion = txt_Descrip.Text;
                Obj_DAL.bIdEstado = Convert.ToByte(cmb_IdEstado.SelectedValue);
                string sMsjError = string.Empty;

                if (Obj_DAL.cBandIM == 'I')
                {
                    Obj_BLL.Insertar_Roles(ref sMsjError, ref Obj_DAL);
                    MessageBox.Show("Nuevo registro ingresado exitosamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cargar_Datos_Roles();
                }
                else if (Obj_DAL.cBandIM == 'M')
                {
                    Obj_BLL.Modificar_Roles(ref sMsjError, ref Obj_DAL);
                    MessageBox.Show("Modificación de registro exitoso", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_IdRol.Enabled = true;
                    Cargar_Datos_Roles();
                }
            }
            else
            {
                MessageBox.Show("No se pueden guardar datos vacios", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgv_Roles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Roles.RowCount == 0)
            {
                MessageBox.Show("No hay datos para modificar");
            }
            else
            {
                Obj_DAL.cBandIM = 'M';
                txt_IdRol.Enabled = false;
                txt_IdRol.Text = dgv_Roles.SelectedRows[0].Cells[0].Value.ToString().Trim();
                txt_Nivel.Text = dgv_Roles.SelectedRows[0].Cells[1].Value.ToString().Trim();
                txt_Descrip.Text = dgv_Roles.SelectedRows[0].Cells[2].Value.ToString().Trim();
                cmb_IdEstado.SelectedValue = dgv_Roles.SelectedRows[0].Cells[3].Value.ToString().Trim();
            }
        }

        #region Validaciones
        private void txt_IdRol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                errorIcono.SetError(txt_IdRol, "");
            }
            else
            {
                e.Handled = true;
                errorIcono.SetError(txt_IdRol, "Solo puede digitar numeros");
            }
        }

        private void txt_Descrip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsLetter(e.KeyChar) ||
                char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
                errorIcono.SetError(txt_Descrip, "");
            }
            else
            {
                e.Handled = true;
                errorIcono.SetError(txt_Descrip, "Solo puede digitar letras o numeros ");
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
    }
}
