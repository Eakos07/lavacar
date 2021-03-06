﻿using System;
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
using System.Text.RegularExpressions;

namespace FRM_Login.Menu
{
    public partial class FRM_Citas : Form
    {
        public FRM_Citas()
        {
            InitializeComponent();
        }


        #region Variables Globales
        cls_Citas_BLL Obj_Citas_BLL = new cls_Citas_BLL();
        cls_Citas_DAL Obj_Citas_DAL = new cls_Citas_DAL();

        cls_Clientes_BLL Obj_Clientes_BLL = new cls_Clientes_BLL();
        cls_Clientes_DAL Obj_Clientes_DAL = new cls_Clientes_DAL();
        #endregion

        private void FRM_Citas_Load(object sender, EventArgs e)
        {
            CargarDatos_Clientes();
            Cargar_Cmb_Clientes();
            CargarDatos_Citas();
            Cargar_Cmb_Citas();
            
        }

        #region Clientes

        #region Modificar Clientes
        public void Modificar_Clientes()
        {
            if (dgv_Cliente.RowCount == 0)
            {
                MessageBox.Show("No hay datos para modificar");
            }
            else
            {
                Obj_Clientes_DAL.cBandIM = 'M';
                txt_NumPlaca.Enabled = false;
                txt_NumPlaca.Text = dgv_Cliente.SelectedRows[0].Cells[0].Value.ToString().Trim();
                cmbTipoPlacaVehiculo.Text = dgv_Cliente.SelectedRows[0].Cells[1].Value.ToString().Trim();
                cmbTipoVehiculo.Text = dgv_Cliente.SelectedRows[0].Cells[2].Value.ToString().Trim();
                txt_NumVisitas.Text = dgv_Cliente.SelectedRows[0].Cells[3].Value.ToString().Trim();
            }
        }
        #endregion

        public void Cargar_Cmb_Clientes()
        {
            string sMsjError = string.Empty;

            #region Tipo Placa            
            cls_TipoPlaca_BLL Obj_TipoPlaca_BLL = new cls_TipoPlaca_BLL();
            DataTable DT_TipoPlaca = new DataTable();
            DT_TipoPlaca = Obj_TipoPlaca_BLL.Listar_TipoPlaca(ref sMsjError);
            cmbTipoPlacaVehiculo.DataSource = DT_TipoPlaca;
            DT_TipoPlaca.Rows.Add("0", "Elija una opción");
            cmbTipoPlacaVehiculo.DisplayMember = DT_TipoPlaca.Columns[1].ToString();
            cmbTipoPlacaVehiculo.ValueMember = DT_TipoPlaca.Columns[0].ToString();
            cmbTipoPlacaVehiculo.SelectedValue = "0";
            #endregion

            #region Tipo Vehiculo
            cls_TipoVehiculo_BLL Obj_TipoVehiculo_BLL = new cls_TipoVehiculo_BLL();
            DataTable DT_TipoVehiculo = new DataTable();
            DT_TipoVehiculo = Obj_TipoVehiculo_BLL.Listar_TipoVehiculo(ref sMsjError);
            cmbTipoVehiculo.DataSource = DT_TipoVehiculo;
            DT_TipoVehiculo.Rows.Add("0", "Elija una opción");
            cmbTipoVehiculo.DisplayMember = DT_TipoVehiculo.Columns[1].ToString();
            cmbTipoVehiculo.ValueMember = DT_TipoVehiculo.Columns[0].ToString();
            cmbTipoVehiculo.SelectedValue = "0";
            #endregion
        }

        public void CargarDatos_Clientes()
        {

            txt_NumPlaca.Enabled = true;
            string sMsjError = string.Empty;
            DataTable dtClientes = new DataTable();
            Obj_Clientes_DAL.cBandIM = 'I';                       

            if (txt_FiltrarClientes.Text == string.Empty)
            {              

                txt_NumPlaca.Clear();
                txt_NumVisitas.Clear();
                dtClientes = Obj_Clientes_BLL.Listar_Clientes(ref sMsjError);
            }
            else
            {
                dtClientes = Obj_Clientes_BLL.Filtrar_Clientes(ref sMsjError, txt_FiltrarClientes.Text);
            }
            if (sMsjError == string.Empty)
            {
                dgv_Cliente.DataSource = null;
                dgv_Cliente.DataSource = dtClientes;
            }
        }

        private void btn_RC_Save_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txt_NumPlaca.Text)) && cmbTipoPlacaVehiculo.SelectedValue.ToString() != "0"
                && cmbTipoVehiculo.SelectedValue.ToString() != "0")
            {
                if (cmbTipoPlacaVehiculo.SelectedValue.ToString() == "1")
                {
                    if(cmbTipoVehiculo.SelectedValue.ToString() == "4")
                    {
                        GuardarDatosClientes();
                    }
                    else
                    {
                        MessageBox.Show("El tipo de placa no coincide con el tipo de vehiculo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else if(cmbTipoPlacaVehiculo.SelectedValue.ToString() != "1")
                {
                    if (cmbTipoVehiculo.SelectedValue.ToString() == "4")
                    {
                        MessageBox.Show("El tipo de placa no coincide con el tipo de vehiculo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);                        
                    }
                    else
                    {
                        GuardarDatosClientes();
                    }
                }
                
            }
            else
            {
                MessageBox.Show("No se pueden guardar datos vacios", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void GuardarDatosClientes()
        {
            #region Guardar Datos
            Obj_Clientes_DAL.sNumPlaca = txt_NumPlaca.Text;
            Obj_Clientes_DAL.bIdTipoPlaca = Convert.ToByte(cmbTipoPlacaVehiculo.SelectedValue.ToString().Trim());
            Obj_Clientes_DAL.bIdTipoVehiculo = Convert.ToByte(cmbTipoVehiculo.SelectedValue.ToString().Trim());

            string sMsjError = string.Empty;

            if (Obj_Clientes_DAL.cBandIM == 'I')
            {
                Obj_Clientes_BLL.Insertar_Clientes(ref sMsjError, ref Obj_Clientes_DAL);
                if (sMsjError == string.Empty)
                {
                    MessageBox.Show("Nuevo registro ingresado exitosamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cargar_Cmb_Clientes();
                    CargarDatos_Clientes();
                }
                else
                {
                    MessageBox.Show("Se genera el siguiente error: " + "[" + sMsjError + "]", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (Obj_Clientes_DAL.cBandIM == 'M')
            {
                Obj_Clientes_BLL.Modificar_Clientes(ref sMsjError, ref Obj_Clientes_DAL);
                if (sMsjError == string.Empty)
                {
                    MessageBox.Show("Modificación de registro exitoso", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_NumPlaca.Enabled = true;
                    Cargar_Cmb_Clientes();
                    CargarDatos_Clientes();
                }
                else
                {
                    MessageBox.Show("Se genera el siguiente error: " + "[" + sMsjError + "]", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            #endregion
        }

        private void btn_RC_Modificar_Click(object sender, EventArgs e)
        {
            Modificar_Clientes();
        }

        private void btn_RC_Refrescar_Click(object sender, EventArgs e)
        {
            CargarDatos_Clientes();
            Cargar_Cmb_Clientes();
        }

        private void dgv_Cliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Modificar_Clientes();
        }

        private void txt_FiltrarClientes_TextChanged(object sender, EventArgs e)
        {
            CargarDatos_Clientes();
        }

        #region Validaciones

        private void txt_NumPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            string expresion;
            
            if (char.IsLetter(e.KeyChar))
            {
                if (e.KeyChar == 'A' || e.KeyChar == 'E' || e.KeyChar == 'I' || e.KeyChar == 'O' || e.KeyChar == 'U'
                 || e.KeyChar == 'a' || e.KeyChar == 'e' || e.KeyChar == 'i' || e.KeyChar == 'o' || e.KeyChar == 'u'
                    )
                    {
                     e.Handled = true;
                }
                                
                else if  (txt_NumPlaca.SelectionStart.ToString() == "0")
                {
                    txt_NumPlaca.MaxLength = 7;
                }
                else if (txt_NumPlaca.SelectionStart.ToString().Trim() == "0"
                    || txt_NumPlaca.SelectionStart.ToString().Trim() == "1"
                    || txt_NumPlaca.SelectionStart.ToString().Trim() == "2")
                {
                    e.Handled = false;
                }                    
                else
                {
                    e.Handled = true;
                }

            }
            else if (char.IsDigit(e.KeyChar))
            {                
                expresion = "^[A-Z]*$";

                if(txt_NumPlaca.SelectionStart.ToString() == "0")
                {
                    txt_NumPlaca.MaxLength = 6;
                }

                else if ((Regex.IsMatch(txt_NumPlaca.Text, expresion)) && (txt_NumPlaca.SelectionStart.ToString().Trim() == "3"))
                {
                    e.Handled = true;
                }
                else if (Regex.IsMatch(txt_NumPlaca.Text , expresion) && (txt_NumPlaca.SelectionStart.ToString().Trim() == "1" || txt_NumPlaca.SelectionStart.ToString().Trim() == "2"))
                {
                    e.Handled = true;

                }
                else
                {
                    e.Handled = false;
                }
                
            }
            else if (e.KeyChar == '-')
            {
                expresion = "^[0-9]*$";

                if(Regex.IsMatch(txt_NumPlaca.Text, expresion))
                {
                    e.Handled = true;
                }
                else if (txt_NumPlaca.SelectionStart.ToString().Trim() == "3")
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else if (e.KeyChar == (char)(Keys.Space))
            {
                e.Handled = true;
            }


        }


        private void cmbTipoVehiculo_KeyPress(object sender, KeyPressEventArgs e)
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



        private void cmbTipoPlacaVehiculo_KeyPress(object sender, KeyPressEventArgs e)
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

        #endregion

        #region Citas
        #region Modificar Citas
        public void Modificar_Citas()
        {
            if (dgv_Citas.RowCount == 0)
            {
                MessageBox.Show("No hay datos para modificar");
            }
            else
            {
                dtp_Fecha.MinDate = Convert.ToDateTime("01/01/2019");
                Obj_Citas_DAL.cBandIM = 'M';
                txt_NumCita.Enabled = false;
                txt_NumCita.Text = dgv_Citas.SelectedRows[0].Cells[0].Value.ToString().Trim();
                txt_NomCliente.Text = dgv_Citas.SelectedRows[0].Cells[1].Value.ToString().Trim();
                txt_Telefono.Text = dgv_Citas.SelectedRows[0].Cells[2].Value.ToString().Trim();
                cmb_RegistroPlaca.SelectedValue = dgv_Citas.SelectedRows[0].Cells[3].Value.ToString().Trim();
                cmb_TipoServicio.Text = dgv_Citas.SelectedRows[0].Cells[4].Value.ToString().Trim();
                txt_Email.Text = dgv_Citas.SelectedRows[0].Cells[5].Value.ToString().Trim();
                dtp_Fecha.Value = Convert.ToDateTime(dgv_Citas.SelectedRows[0].Cells[6].Value);
                cmb_HoraCita.SelectedText = dgv_Citas.SelectedRows[0].Cells[7].Value.ToString().Trim();
                cmb_EstadoCita.Text = dgv_Citas.SelectedRows[0].Cells[8].Value.ToString().Trim();
                cmb_EmpleadoCitas.Text = dgv_Citas.SelectedRows[0].Cells[9].Value.ToString().Trim();
            }
        }
        #endregion
        public void CargarDatos_Citas()
        {
            cmb_HoraCita.SelectedItem = "Elija una opción";
            dtp_Fecha.MinDate = DateTime.Now;
            string sMsjError = string.Empty;
            DataTable dtCitas = new DataTable();
            Obj_Citas_DAL.cBandIM = 'I';

            txt_NumCita.Enabled = false;
            txt_NumCita.Clear();
            txt_NomCliente.Clear();
            txt_Telefono.Clear();
            txt_Email.Clear();


            if (txt_FiltrarCitas.Text == string.Empty)
            {
                dtCitas = Obj_Citas_BLL.Listar_Citas(ref sMsjError);
            }
            else
            {
                dtCitas = Obj_Citas_BLL.Filtrar_Citas(ref sMsjError, txt_FiltrarClientes.Text);
            }
            if (sMsjError == string.Empty)
            {
                dgv_Citas.DataSource = null;
                dgv_Citas.DataSource = dtCitas;
            }
        }

        public void Cargar_Cmb_Citas()
        {
            string sMsjError = string.Empty;

            #region Empleados           
            cls_Empleados_BLL Obj_Empleados_BLL = new cls_Empleados_BLL();
            DataTable DT_Empleados = new DataTable();
            DT_Empleados = Obj_Empleados_BLL.Listar_Empleados(ref sMsjError);
            cmb_EmpleadoCitas.DataSource = DT_Empleados;
            DT_Empleados.Rows.Add("0", "", "", "Elija una opción");
            cmb_EmpleadoCitas.DisplayMember = DT_Empleados.Columns[3].ToString();
            cmb_EmpleadoCitas.ValueMember = DT_Empleados.Columns[0].ToString();
            cmb_EmpleadoCitas.SelectedValue = "0";
            #endregion

            #region Cargar Estados
            cls_Estados_BLL Obj_Estados_BLL = new cls_Estados_BLL();
            DataTable DT_Estados = new DataTable();
            DT_Estados = Obj_Estados_BLL.Listar_Estados(ref sMsjError);
            cmb_EstadoCita.DataSource = DT_Estados;
            DT_Estados.Rows.Add("0", "Elija una opción");
            cmb_EstadoCita.DisplayMember = DT_Estados.Columns[1].ToString();
            cmb_EstadoCita.ValueMember = DT_Estados.Columns[0].ToString();
            cmb_EstadoCita.SelectedValue = "0";
            #endregion

            #region Cliente
            cls_Clientes_BLL Obj_Clientes_BLL = new cls_Clientes_BLL();
            DataTable DT_Clientes = new DataTable();
            DT_Clientes = Obj_Clientes_BLL.Listar_Clientes(ref sMsjError);
            cmb_RegistroPlaca.DataSource = DT_Clientes;
            DT_Clientes.Rows.Add("Elija una opción", "0");
            cmb_RegistroPlaca.DisplayMember = DT_Clientes.Columns[0].ToString();
            cmb_RegistroPlaca.ValueMember = DT_Clientes.Columns[0].ToString();
            cmb_RegistroPlaca.SelectedValue = "Elija una opción";
            #endregion

            #region Tipo Servicio
            cls_TipoServicio_BLL Obj_TipoServicio_BLL = new cls_TipoServicio_BLL();
            DataTable DT_TipoServicio = new DataTable();
            DT_TipoServicio = Obj_TipoServicio_BLL.Listar_TipoServicio(ref sMsjError);
            cmb_TipoServicio.DataSource = DT_TipoServicio;
            DT_TipoServicio.Rows.Add("0", "Elija una opción");
            cmb_TipoServicio.DisplayMember = DT_TipoServicio.Columns[1].ToString();
            cmb_TipoServicio.ValueMember = DT_TipoServicio.Columns[0].ToString();
            cmb_TipoServicio.SelectedValue = "0";
            #endregion
        }

        private void btn_GuardarCitas_Click(object sender, EventArgs e)
        {


            if ((txt_NomCliente.Text.Trim() != string.Empty)
                 && (txt_Email.Text.Trim() != string.Empty)
                 && (cmb_HoraCita.Text != "Elija una opción")
                 && (cmb_EstadoCita.SelectedValue.ToString() != "0")
                 && (cmb_RegistroPlaca.SelectedValue.ToString() != "0")
                 && (cmb_TipoServicio.SelectedValue.ToString() != "0")
                 && (cmb_EmpleadoCitas.SelectedValue.ToString() != "0"))
            {
                if (email_bien_escrito(txt_Email.Text) == true)
                {
                    Obj_Citas_DAL.sNombre = txt_NomCliente.Text.ToString();
                    if(txt_Telefono.Text.Trim() == string.Empty)
                    {
                        Obj_Citas_DAL.iTel = Convert.ToInt32(null);
                    }
                    else
                    {
                        Obj_Citas_DAL.iTel = Convert.ToInt32(txt_Telefono.Text.ToString());
                    }
                    
                    Obj_Citas_DAL.sNumPlaca = cmb_RegistroPlaca.SelectedValue.ToString();
                    Obj_Citas_DAL.cCodeServ = Convert.ToChar(cmb_TipoServicio.SelectedValue.ToString());
                    Obj_Citas_DAL.sEmail = txt_Email.Text.ToString();
                    Obj_Citas_DAL.dtFechaCita = Convert.ToDateTime(dtp_Fecha.Value.Date.ToString());

                    Obj_Citas_DAL.cIdEstado = Convert.ToChar(cmb_EstadoCita.SelectedValue.ToString());
                    Obj_Citas_DAL.bIdEmpleado = Convert.ToByte(cmb_EmpleadoCitas.SelectedValue.ToString());

                    string sMsjError = string.Empty;

                    if (Obj_Citas_DAL.cBandIM == 'I')
                    {
                        Obj_Citas_DAL.sHoraCita = cmb_HoraCita.SelectedItem.ToString();
                        Obj_Citas_BLL.Insertar_Citas(ref sMsjError, ref Obj_Citas_DAL);
                        if (sMsjError == string.Empty)
                        {
                            MessageBox.Show("Nuevo registro ingresado exitosamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Cargar_Cmb_Citas();
                            CargarDatos_Citas();
                        }
                        else
                        {
                            MessageBox.Show("Se genera el siguiente error: " + "[" + sMsjError + "]", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else if (Obj_Citas_DAL.cBandIM == 'M')
                    {
                        Obj_Citas_DAL.sHoraCita = cmb_HoraCita.Text.ToString();
                        Obj_Citas_BLL.Modificar_Citas(ref sMsjError, ref Obj_Citas_DAL);
                        if (sMsjError == string.Empty)
                        {
                            MessageBox.Show("Modificación de registro exitoso", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Cargar_Cmb_Citas();
                            CargarDatos_Citas();
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

        private void txt_FiltrarCitas_TextChanged(object sender, EventArgs e)
        {
            CargarDatos_Citas();
        }

        private void btn_RefrescarCitas_Click(object sender, EventArgs e)
        {
            CargarDatos_Citas();
            Cargar_Cmb_Citas();
            cmb_HoraCita.Text = "Elija una opción";
        }

        private void dgv_Citas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Modificar_Citas();

        }

        private void btn_ModificarCitas_Click(object sender, EventArgs e)
        {
            Modificar_Citas();
        }

        #region Validaciones

        private void txt_NomCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == (char)(Keys.Space))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo puede digitar letras");
            }
        }

        private void cmb_HoraCita_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }       

        private void cmb_RegistroPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmb_TipoServicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmb_EstadoCita_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmb_EmpleadoCitas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        
        private void dtp_Fecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txt_Email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Email no puede tener espacios vacios");
            }
           
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

        #endregion

        #endregion

        private void btn_RC_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Citas_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
