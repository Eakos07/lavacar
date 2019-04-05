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
    public partial class FRM_Empleados : Form
    {
        public FRM_Empleados()
        {
            InitializeComponent();
        }

        private void CargarEmpleados()
        {
            cls_Empleados_BLL EmplC_ObjBLL = new cls_Empleados_BLL();
            string sMsjError = string.Empty;
            DataTable DT = new DataTable();
            if (txt_Filtrar.Text == string.Empty)
            {
                DT = EmplC_ObjBLL.Listar_Empleados(ref sMsjError);
            }
            else
            {
                DT = EmplC_ObjBLL.Filtrar_Empleados(ref sMsjError, txt_Filtrar.Text.Trim());
            }

            if (sMsjError == string.Empty)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = DT;
            }
            else
            {
                dataGridView1.DataSource = null;

                MessageBox.Show("Se presento un error a la hora de listar los estados.\n\nDetalle Error : [" + sMsjError + "]",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #region Validaciones
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

        private void txt_Identificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                errorIcono.SetError(txt_Identificacion, "");
            }
            else
            {
                e.Handled = true;
                errorIcono.SetError(txt_Identificacion, "Solo puede digitar numeros");
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

        private void txt_Apellido_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                errorIcono.SetError(txt_Telefono, "");
            }
            else
            {
                e.Handled = true;
                errorIcono.SetError(txt_Telefono, "Solo puede digitar numeros");
            }

            if (e.KeyChar == '-')
            {
                e.Handled = false;
                errorIcono.SetError(txt_Telefono, "");
            }
        }

        private void txt_Direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsLetter(e.KeyChar) ||
                char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
                errorIcono.SetError(txt_Direccion, "");
            }
            else
            {
                e.Handled = true;
                errorIcono.SetError(txt_Direccion, "Solo puede digitar letras, numeros y espacios");
            }
        }

        private void txt_Email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                errorIcono.SetError(txt_Email, "Email no puede tener espacios vacios");
            }
            else
            {
                e.Handled = false;
                errorIcono.SetError(txt_Email, "");
            }
        }

        private void txt_Puesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                errorIcono.SetError(txt_Puesto, "");
            }
            else
            {
                e.Handled = true;
                errorIcono.SetError(txt_Puesto, "Solo puede digitar letras");
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

        private void cmb_IdPoliza_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cmb_IdUsuario_KeyPress(object sender, KeyPressEventArgs e)
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

        private void FRM_Empleados_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
        }
    }
}
