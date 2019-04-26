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
using System.Text.RegularExpressions;

namespace FRM_Login.Menu
{
    public partial class FRM_Empleados : Form
    {
        public FRM_Empleados()
        {
            InitializeComponent();
        }

        #region Variables Globales
        cls_Empleados_BLL EmplC_ObjBLL = new cls_Empleados_BLL();
        cls_Empleados_DAL Obj_DAL = new cls_Empleados_DAL();
        #endregion

        private void FRM_Empleados_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
            Cargar_CMB();
        }

        public void Modificar_Empleados()
        {
            if (dgv_Empleados.RowCount == 0)
            {
                MessageBox.Show("No hay datos para modificar");
            }
            else
            {
                Obj_DAL.cBandIM = 'M';
                txt_IdEmpleado.Text = dgv_Empleados.SelectedRows[0].Cells[0].Value.ToString().Trim();
                txt_Identificacion.Text = dgv_Empleados.SelectedRows[0].Cells[1].Value.ToString().Trim();
                txt_Nombre.Text = dgv_Empleados.SelectedRows[0].Cells[2].Value.ToString().Trim();
                txt_Apellido.Text = dgv_Empleados.SelectedRows[0].Cells[3].Value.ToString().Trim();
                txt_Telefono.Text = dgv_Empleados.SelectedRows[0].Cells[4].Value.ToString().Trim();
                txt_Direccion.Text = dgv_Empleados.SelectedRows[0].Cells[5].Value.ToString().Trim();
                txt_Email.Text = dgv_Empleados.SelectedRows[0].Cells[6].Value.ToString().Trim();
                txt_Puesto.Text = dgv_Empleados.SelectedRows[0].Cells[7].Value.ToString().Trim();
                cmb_IdEstado.Text = dgv_Empleados.SelectedRows[0].Cells[8].Value.ToString().Trim();
                cmb_IdPoliza.Text = dgv_Empleados.SelectedRows[0].Cells[9].Value.ToString().Trim();
            }

        }
        public void CargarEmpleados()
        {

            txt_IdEmpleado.Clear();
            txt_Identificacion.Clear();
            txt_Nombre.Clear();
            txt_Apellido.Clear();
            txt_Telefono.Clear();
            txt_Direccion.Clear();
            txt_Email.Clear();

            txt_Puesto.SelectedItem = "Elija una opción";
            string sMsjError = string.Empty;
            DataTable DT = new DataTable();
            Obj_DAL.cBandIM = 'I';
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
                dgv_Empleados.DataSource = null;
                dgv_Empleados.DataSource = DT;
            }
            else
            {
                dgv_Empleados.DataSource = null;

                MessageBox.Show("Se presento un error a la hora de listar los estados.\n\nDetalle Error : [" + sMsjError + "]",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void Cargar_CMB()
        {
            string sMsjError = string.Empty;
            

            #region Cargar Estados
            cls_Estados_BLL Obj_Estados_BLL = new cls_Estados_BLL();
            DataTable DT_Estados = new DataTable();
            DT_Estados = Obj_Estados_BLL.Listar_Estados(ref sMsjError);
            cmb_IdEstado.DataSource = DT_Estados;
            DT_Estados.Rows.Add("0", "Elija una opción");
            cmb_IdEstado.DisplayMember = DT_Estados.Columns[1].ToString();
            cmb_IdEstado.ValueMember = DT_Estados.Columns[0].ToString();
            cmb_IdEstado.SelectedValue = "0";
            #endregion

            #region Cargar Polizas
            cls_Polizas_BLL Obj_Polizas_BLL = new cls_Polizas_BLL();
            DataTable DT_Polizas = new DataTable();
            DT_Polizas = Obj_Polizas_BLL.Listar_Polizas(ref sMsjError);
            cmb_IdPoliza.DataSource = DT_Polizas;
            DT_Polizas.Rows.Add("Elija una opción", "0");
            cmb_IdPoliza.DisplayMember = DT_Polizas.Columns[0].ToString();
            cmb_IdPoliza.ValueMember = DT_Polizas.Columns[0].ToString();
            cmb_IdPoliza.SelectedValue = "Elija una opción";
            #endregion

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txt_Identificacion.Text)) && !(string.IsNullOrEmpty(txt_Nombre.Text)) && !(string.IsNullOrEmpty(txt_Apellido.Text))
                && !(string.IsNullOrEmpty(txt_Telefono.Text)) && !(string.IsNullOrEmpty(txt_Direccion.Text)) && !(string.IsNullOrEmpty(txt_Email.Text))
                && !(string.IsNullOrEmpty(txt_Puesto.Text)) && cmb_IdEstado.SelectedValue.ToString() != "0" && cmb_IdPoliza.SelectedValue.ToString() != "Elija una opción")
            {
                if (email_bien_escrito(txt_Email.Text) == true)

                {
                    Obj_DAL.sIdenti = txt_Identificacion.Text;
                    Obj_DAL.sNombre = txt_Nombre.Text;
                    Obj_DAL.sApellidos = txt_Apellido.Text;
                    Obj_DAL.iTel = Convert.ToInt32(txt_Telefono.Text);
                    Obj_DAL.sAddress = txt_Direccion.Text;
                    Obj_DAL.sEmail = txt_Email.Text;
                    Obj_DAL.sPuesto = txt_Puesto.Text;
                    Obj_DAL.cIdEstado = Convert.ToChar(cmb_IdEstado.SelectedValue);
                    Obj_DAL.sIdPoliza = cmb_IdPoliza.SelectedValue.ToString().Trim();
                    string sMsjError = string.Empty;

                    if (Obj_DAL.cBandIM == 'I')
                    {
                        EmplC_ObjBLL.Insertar_Clientes(ref sMsjError, ref Obj_DAL);
                        if (sMsjError == string.Empty)
                        {
                            MessageBox.Show("Nuevo registro ingresado exitosamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarEmpleados();
                            Cargar_CMB();
                        }
                        else
                        {
                            MessageBox.Show("Se genera el siguiente error: " + "[" + sMsjError + "]", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else if (Obj_DAL.cBandIM == 'M')
                    {
                        EmplC_ObjBLL.Modificar_Clientes(ref sMsjError, ref Obj_DAL);
                        if (sMsjError == string.Empty)
                        {
                            MessageBox.Show("Modificación de registro exitoso", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarEmpleados();
                            Cargar_CMB();
                        }
                        else
                        {
                            MessageBox.Show("Se genera el siguiente error: " + "[" + sMsjError + "]", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
                else
                {

                    MessageBox.Show("Correo incorrecto, digite una direccion de correo válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show("No se pueden guardar datos vacios", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

           
        }

        private void btn_Refrescar_Click(object sender, EventArgs e)
        {
            CargarEmpleados();
            Cargar_CMB();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            Modificar_Empleados();
        }

        private void dgv_Empleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Modificar_Empleados();
        }

        private void txt_Filtrar_TextChanged(object sender, EventArgs e)
        {
            CargarEmpleados();
        }

        #region Validaciones
        private void cmb_IdEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
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
          
            }
            else
            {
                e.Handled = true;
                 MessageBox.Show("Solo puede digitar letras");
            }
        }

        private void txt_Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) ||
                char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
          
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo puede digitar letras");
            }
        }

        private void txt_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
             
            }
            else
            {
                e.Handled = true;
             
                MessageBox.Show("Solo puede digitar Numeros");
            }

        }

        private void txt_Direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsLetter(e.KeyChar) ||
                char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
              MessageBox.Show("Solo puede digitar letras, numeros y espacios");
            }
        }

        private void txt_Email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Email no puede tener espacios vacios");
            }
        }

        private void txt_Puesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
               
            }
            else
            {
                e.Handled = true;
             MessageBox.Show("Solo puede digitar letras");
            }
        }

        private void cmb_IdEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmb_IdPoliza_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        #endregion

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool email_bien_escrito(string email)
        {
            string expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
