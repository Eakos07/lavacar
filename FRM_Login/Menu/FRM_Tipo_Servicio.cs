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
            string sMsjError = string.Empty;
            DataTable DT_TipoServicio = new DataTable();
            Obj_TipoServicio_DAL.cBandIM = 'I';            

            txt_Duracion.Clear();
            txt_CodigoServicio.Clear();
            txt_CodigoServicio.Enabled = true;
            txt_NombreServicio.Clear();
            txt_Precio.Clear();

            if (txt_Filtrar.Text == string.Empty)
            {
                DT_TipoServicio = Obj_TipoServicio_BLL.Listar_TipoServicio(ref sMsjError);
            }
            else
            {
                DT_TipoServicio = Obj_TipoServicio_BLL.Filtrar_TipoServicio(ref sMsjError, txt_Filtrar.Text);
            }
            if (sMsjError == string.Empty)
            {
                dgv_TipoServicio.DataSource = null;
                dgv_TipoServicio.DataSource = DT_TipoServicio;
            }
        }

        public void Modificar_Tipo_Servicio()
        {
            if (dgv_TipoServicio.RowCount == 0)
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
                cmb_IdTipoVehiculo.Text = dgv_TipoServicio.SelectedRows[0].Cells[4].Value.ToString().Trim();
            }
        }

        public void Cargar_cmb()
        {
            string sMsjError = string.Empty;

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
        }

        private void FRM_Tipo_Servicio_Load(object sender, EventArgs e)
        {
            Cargar_Datos();
            Cargar_cmb();
        }

        private void txt_Filtrar_TextChanged(object sender, EventArgs e)
        {
            Cargar_Datos();
        }

        private void btn_Refrescar_Click(object sender, EventArgs e)
        {
            Cargar_Datos(); //
            Cargar_cmb();
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
                else if (Obj_TipoServicio_DAL.cBandIM == 'M')
                {
                    Obj_TipoServicio_BLL.Modificar_TipoServicio(ref sMsjError, ref Obj_TipoServicio_DAL);
                    if (sMsjError == string.Empty)
                    {
                        MessageBox.Show("Modificación de registro exitosa", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_CodigoServicio.Enabled = false;
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


        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            Modificar_Tipo_Servicio();
        }

        private void txt_CodigoServicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                errorIcono.SetError(txt_CodigoServicio, "");
            }
            else
            {
                e.Handled = true;
                errorIcono.SetError(txt_CodigoServicio, "Solo puede digitar numeros con (-)");
            }
        }

        private void txt_NombreServicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) ||
                char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
                errorIcono.SetError(txt_NombreServicio, "");
            }
            else
            {
                e.Handled = true;
                errorIcono.SetError(txt_NombreServicio, "Solo puede digitar letras");
            }
        }

        private void txt_Precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                errorIcono.SetError(txt_Precio, "");
            }
            else
            {
                e.Handled = true;
                errorIcono.SetError(txt_Precio, "Solo puede digitar numeros con (.)");
            }

            if (e.KeyChar == '.')
            {
                e.Handled = false;
                errorIcono.SetError(txt_Precio, "");
            }
        }

        private void cmb_IdTipoVehiculo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dgv_TipoServicio_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Modificar_Tipo_Servicio();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
