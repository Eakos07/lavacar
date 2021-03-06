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
    public partial class FRM_Articulos : Form
    {
        public FRM_Articulos()
        {
            InitializeComponent();
        }

     

        #region Variables Globales
        cls_FamiliaArticulos_BLL Obj_BLL_Familia = new cls_FamiliaArticulos_BLL();
        cls_FamiliaArticulos_DAL Obj_DAL_Familia = new cls_FamiliaArticulos_DAL();

        cls_Articulos_BLL Obj_BLL_Articulos = new cls_Articulos_BLL();
        cls_Articulos_DAL Obj_DAL_Articulos = new cls_Articulos_DAL();

        cls_TipoArticulo_BLL Obj_BLL_Tipo = new cls_TipoArticulo_BLL();
        cls_TipoArticulo_DAL Obj_DAL_Tipo = new cls_TipoArticulo_DAL();
        #endregion

        private void FRM_Articulos_Load(object sender, EventArgs e)
        {
            Cargar_Datos_FamiliaArticulos();
            Cargar_cmb_FamiliaArticulos();

            Cargar_Datos_Articulos();
            Cargar_cmb_Articulos();

            Cargar_Datos_TipoArticulo();
            Cargar_cmb_TipoArticulos();
        }

        #region Cargar Familia Articulos
        public void Cargar_Datos_FamiliaArticulos()
        {
            txt_IdFamilia.Enabled = true;
            Obj_DAL_Familia.cBandIM = 'I';
            string sMsjError = string.Empty;
            DataTable dtFamiliaArticulos = new DataTable();            

            txt_IdFamilia.Clear();
            txt_DescripcionFamilia.Clear();
            

            if (txt_FiltrarFamiliaArticulos.Text == string.Empty)
            {
                dtFamiliaArticulos = Obj_BLL_Familia.Listar_FamiliaArticulos(ref sMsjError);
            }
            else
            {
                dtFamiliaArticulos = Obj_BLL_Familia.Filtrar_FamiliaArticulos(ref sMsjError, txt_FiltrarFamiliaArticulos.Text);
            }
            if (sMsjError == string.Empty)
            {
                dgv_FamiliaArticulos.DataSource = null;
                dgv_FamiliaArticulos.DataSource = dtFamiliaArticulos;
            }
        }
        public void Cargar_cmb_FamiliaArticulos()
        {
            string sMsjError = string.Empty;
            cls_Estados_BLL Obj_Estados_BLL = new cls_Estados_BLL();
            DataTable DT_Estados = new DataTable();
            DT_Estados = Obj_Estados_BLL.Listar_Estados(ref sMsjError);
            cmb_IdEstadoFamilia.DataSource = DT_Estados;
            DT_Estados.Rows.Add("0", "Elija una opción");
            cmb_IdEstadoFamilia.DisplayMember = DT_Estados.Columns[1].ToString();
            cmb_IdEstadoFamilia.ValueMember = DT_Estados.Columns[0].ToString();
            cmb_IdEstadoFamilia.SelectedValue = "0";            
        }
        #endregion

        #region CargarArticulos
        public void Cargar_Datos_Articulos()
        {
            txt_Articulo.Enabled = true;
            string sMsjError = string.Empty;
            DataTable dtArticulos = new DataTable();
            Obj_DAL_Articulos.cBandIM = 'I';            

            txt_Articulo.Clear();
            txt_NombreArticulo.Clear();
            txt_Cantidad_Articulo.Value=0;
            txt_InventarioMin_Articulo.Clear();
            txt_PrecioVenta_Articulo.Clear();

            if (txt_FiltrarArticulos.Text == string.Empty)
            {
                dtArticulos = Obj_BLL_Articulos.Listar_Articulos(ref sMsjError);
            }
            else
            {
                dtArticulos = Obj_BLL_Articulos.Filtrar_Articulos(ref sMsjError, txt_FiltrarArticulos.Text);
            }
            if (sMsjError == string.Empty)
            {
                dgv_Articulos.DataSource = null;
                dgv_Articulos.DataSource = dtArticulos;
            }
        }

        public void Cargar_cmb_Articulos()
        {
            string sMsjError = string.Empty;
            #region Cargar Estados
            cls_Estados_BLL Obj_Estados_BLL = new cls_Estados_BLL();
            DataTable DT_Estados = new DataTable();
            DT_Estados = Obj_Estados_BLL.Listar_Estados(ref sMsjError);
            cmb_Estado_Articulos.DataSource = DT_Estados;
            DT_Estados.Rows.Add("0", "Elija una opción");
            cmb_Estado_Articulos.DisplayMember = DT_Estados.Columns[1].ToString();
            cmb_Estado_Articulos.ValueMember = DT_Estados.Columns[0].ToString();
            cmb_Estado_Articulos.SelectedValue = "0";
            #endregion

            #region Cargar IdEstados
            cls_FamiliaArticulos_BLL Obj_FamiliaArticulos_BLL = new cls_FamiliaArticulos_BLL();
            DataTable DT_FamiliaArticulo = new DataTable();
            DT_FamiliaArticulo = Obj_FamiliaArticulos_BLL.Listar_FamiliaArticulos(ref sMsjError);
            cmb_IdFamilia_Articulo.DataSource = DT_FamiliaArticulo;
            DT_FamiliaArticulo.Rows.Add("0", "Elija una opción");
            cmb_IdFamilia_Articulo.DisplayMember = DT_FamiliaArticulo.Columns[1].ToString();
            cmb_IdFamilia_Articulo.ValueMember = DT_FamiliaArticulo.Columns[0].ToString();
            cmb_IdFamilia_Articulo.SelectedValue = "0";
            #endregion

            #region Cargar TipoArticulo
            cls_TipoArticulo_BLL Obj_TipoArticulos_BLL = new cls_TipoArticulo_BLL();
            DataTable DT_TipoArticulo = new DataTable();
            DT_TipoArticulo = Obj_TipoArticulos_BLL.Listar_TipoArticulo(ref sMsjError);
            cmb_Tipo_Articulo.DataSource = DT_TipoArticulo;
            DT_TipoArticulo.Rows.Add("0", "Elija una opción");
            cmb_Tipo_Articulo.DisplayMember = DT_TipoArticulo.Columns[1].ToString();
            cmb_Tipo_Articulo.ValueMember = DT_TipoArticulo.Columns[0].ToString();
            cmb_Tipo_Articulo.SelectedValue = "0";
            #endregion
        }
        #endregion

        #region Cargar Tipo Articulo
        public void Cargar_Datos_TipoArticulo()
        {
            txt_IdTipoArticulo.Enabled = true;
            string sMsjError = string.Empty;
            DataTable dtTipoArticulo = new DataTable();
            Obj_DAL_Tipo.cBandIM = 'I';            

            txt_IdTipoArticulo.Clear();
            txt_DescripcionTipoArticulo.Clear();

            if (txt_FiltrarTipoArticulos.Text == string.Empty)
            {
                dtTipoArticulo = Obj_BLL_Tipo.Listar_TipoArticulo(ref sMsjError);
            }
            else
            {
                dtTipoArticulo = Obj_BLL_Tipo.Filtrar_TipoArticulo(ref sMsjError, txt_FiltrarTipoArticulos.Text);
            }
            if (sMsjError == string.Empty)
            {
                dgv_TipoArticulos.DataSource = null;
                dgv_TipoArticulos.DataSource = dtTipoArticulo;
            }
        }

        public void Cargar_cmb_TipoArticulos()
        {
            string sMsjError = string.Empty;
            cls_Estados_BLL Obj_Estados_BLL = new cls_Estados_BLL();
            DataTable DT_TipoArticulo = new DataTable();
            DT_TipoArticulo = Obj_Estados_BLL.Listar_Estados(ref sMsjError);
            cmb_EstadoTipoArticulo.DataSource = DT_TipoArticulo;
            DT_TipoArticulo.Rows.Add("0", "Elija una opción");
            cmb_EstadoTipoArticulo.DisplayMember = DT_TipoArticulo.Columns[1].ToString();
            cmb_EstadoTipoArticulo.ValueMember = DT_TipoArticulo.Columns[0].ToString();
            cmb_EstadoTipoArticulo.SelectedValue = "0";
            
        }
        #endregion


        #region Familia

        #region Modificar Familia
        public void Modificar_Familia() {

            if (dgv_FamiliaArticulos.RowCount == 0)
            {
                MessageBox.Show("No hay datos para modificar");
            }
            else
            {
                Obj_DAL_Familia.cBandIM = 'M';
                txt_IdFamilia.Enabled = false;
                txt_IdFamilia.Text = dgv_FamiliaArticulos.SelectedRows[0].Cells[0].Value.ToString().Trim();
                txt_DescripcionFamilia.Text = dgv_FamiliaArticulos.SelectedRows[0].Cells[1].Value.ToString().Trim();
                cmb_IdEstadoFamilia.Text = dgv_FamiliaArticulos.SelectedRows[0].Cells[2].Value.ToString().Trim();
            }
        }
        #endregion
        private void btn_RefrescarFamilia_Click(object sender, EventArgs e)
        {
            Cargar_cmb_FamiliaArticulos();
            Cargar_Datos_FamiliaArticulos();
        }

        private void btn_ModificarFamilia_Click(object sender, EventArgs e)
        {
            Modificar_Familia();   
        }

        private void dgv_FamiliaArticulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Modificar_Familia();
        }

        private void btn_GuardarFamilia_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txt_IdFamilia.Text)) && !(string.IsNullOrEmpty(txt_DescripcionFamilia.Text)) && cmb_IdEstadoFamilia.SelectedValue.ToString() != "0")
            {
                Obj_DAL_Familia.sIdFamilia = txt_IdFamilia.Text;
                Obj_DAL_Familia.sDescripcion = txt_DescripcionFamilia.Text;
                Obj_DAL_Familia.cIdEstado = Convert.ToChar(cmb_IdEstadoFamilia.SelectedValue);
                string sMsjError = string.Empty;

                if (Obj_DAL_Familia.cBandIM == 'I')
                {
                    Obj_BLL_Familia.Insertar_FamiliaArticulos(ref sMsjError, ref Obj_DAL_Familia);
                    if (sMsjError == string.Empty)
                    {
                        MessageBox.Show("Nuevo registro ingresado exitosamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Cargar_Datos_FamiliaArticulos();
                        Cargar_cmb_FamiliaArticulos();
                    }
                    else
                    {
                        MessageBox.Show("Se genera el siguiente error: " + "[" + sMsjError + "]", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                else if (Obj_DAL_Familia.cBandIM == 'M')
                {
                    Obj_BLL_Familia.Modificar_FamiliaArticulos(ref sMsjError, ref Obj_DAL_Familia);
                    if (sMsjError == string.Empty)
                    {
                        MessageBox.Show("Modificación de registro exitoso", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_IdFamilia.Enabled = true;
                        Cargar_Datos_FamiliaArticulos();
                        Cargar_cmb_FamiliaArticulos();
                    }
                    else
                    {
                        MessageBox.Show("Se genera el siguiente error: " + "[" + sMsjError + "]", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("No se pueden guardar datos vacios", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_FiltrarFamiliaArticulos_TextChanged(object sender, EventArgs e)
        {
            Cargar_Datos_FamiliaArticulos();
        }

        #region Validaciones
        private void txt_IdFamilia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_DescripcionFamilia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsLetter(e.KeyChar) ||
                char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void cmb_IdEstadoFamilia_KeyPress(object sender, KeyPressEventArgs e)
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

        #region Articulos
        #region Modificar Articulos
        public void Modificar_Articulos()
        {
            if (dgv_Articulos.RowCount == 0)
            {
                MessageBox.Show("No hay datos para modificar");
            }
            else
            {
                Obj_DAL_Articulos.cBandIM = 'M';
                txt_Articulo.Enabled = false;
                txt_Articulo.Text = dgv_Articulos.SelectedRows[0].Cells[0].Value.ToString().Trim();
                txt_NombreArticulo.Text = dgv_Articulos.SelectedRows[0].Cells[1].Value.ToString().Trim();
                txt_Cantidad_Articulo.Text = dgv_Articulos.SelectedRows[0].Cells[2].Value.ToString().Trim();
                cmb_IdFamilia_Articulo.Text = dgv_Articulos.SelectedRows[0].Cells[3].Value.ToString().Trim();
                cmb_Tipo_Articulo.Text = dgv_Articulos.SelectedRows[0].Cells[4].Value.ToString().Trim();
                txt_InventarioMin_Articulo.Text = dgv_Articulos.SelectedRows[0].Cells[5].Value.ToString().Trim();
                txt_PrecioVenta_Articulo.Text = dgv_Articulos.SelectedRows[0].Cells[6].Value.ToString().Trim();
                cmb_Estado_Articulos.Text = dgv_Articulos.SelectedRows[0].Cells[7].Value.ToString().Trim();
            }
        }
        #endregion
        private void dgv_Articulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Modificar_Articulos();
        }              

        private void btn_Modificar_Articulo_Click(object sender, EventArgs e)
        {
            Modificar_Articulos();
        }

        private void btn_GuardarArticulo_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txt_Articulo.Text)) && !(string.IsNullOrEmpty(txt_NombreArticulo.Text)) && !(string.IsNullOrEmpty(txt_Cantidad_Articulo.Text))
                && (cmb_IdFamilia_Articulo.SelectedValue.ToString() != "0") && (cmb_Tipo_Articulo.SelectedValue.ToString() != "0")
                && !(string.IsNullOrEmpty(txt_InventarioMin_Articulo.Text)) && !(string.IsNullOrEmpty(txt_PrecioVenta_Articulo.Text))
                && (cmb_Estado_Articulos.SelectedValue.ToString() != "0"))
            {
                Obj_DAL_Articulos.sIdArticulo = txt_Articulo.Text;
                Obj_DAL_Articulos.sNombreArticulo = txt_NombreArticulo.Text;
                Obj_DAL_Articulos.iCantidad = Convert.ToInt16(txt_Cantidad_Articulo.Text);
                Obj_DAL_Articulos.sIdFamilia = cmb_IdFamilia_Articulo.SelectedValue.ToString();
                Obj_DAL_Articulos.cIdTipoArticulo = Convert.ToChar(cmb_Tipo_Articulo.SelectedValue);
                Obj_DAL_Articulos.iInventarioMinimo = Convert.ToInt16(txt_InventarioMin_Articulo.Text);
                Obj_DAL_Articulos.dPrecioVenta = Convert.ToDecimal(txt_PrecioVenta_Articulo.Text);
                Obj_DAL_Articulos.cIdEstado = Convert.ToChar(cmb_Estado_Articulos.SelectedValue);
                string sMsjError = string.Empty;

                if (Obj_DAL_Articulos.cBandIM == 'I')
                {
                    Obj_BLL_Articulos.Insertar_Articulos(ref sMsjError, ref Obj_DAL_Articulos);
                    if (sMsjError == string.Empty)
                    {
                        MessageBox.Show("Nuevo registro ingresado exitosamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Cargar_Datos_Articulos();
                        Cargar_cmb_Articulos();
                    }
                    else
                    {
                        MessageBox.Show("Se genera el siguiente error: " + "[" + sMsjError + "]", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                else if (Obj_DAL_Articulos.cBandIM == 'M')
                {
                    Obj_BLL_Articulos.Modificar_Articulos(ref sMsjError, ref Obj_DAL_Articulos);
                    if (sMsjError == string.Empty)
                    {
                        MessageBox.Show("Modificación de registro exitoso", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_Articulo.Enabled = true;
                        Cargar_Datos_Articulos();
                        Cargar_cmb_Articulos();
                    }
                    else
                    {
                        MessageBox.Show("Se genera el siguiente error: " + "[" + sMsjError + "]", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("No se pueden guardar datos vacios", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_FiltrarArticulos_TextChanged(object sender, EventArgs e)
        {
            Cargar_Datos_Articulos();
        }

        private void btn_Refrescar_Articulo_Click(object sender, EventArgs e)
        {
            Cargar_Datos_Articulos();
            Cargar_cmb_Articulos();
        }

        #region Validaciones

        private void txt_Articulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (char)(Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Este campo es solo para letras o números");
            }
        }

        private void txt_NombreArticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)(Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Este campo es solo para letras");
            }
        }

        private void txt_Cantidad_Articulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
               e.Handled = false;                
            }
            else
            {
                e.Handled = true;
            }
        }

        private void cmb_IdFamilia_Articulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmb_Estado_Articulos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_InventarioMin_Articulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)(Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Este campo es solo para números");
            }
        }

        private void cmb_Tipo_Articulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_PrecioVenta_Articulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)(Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Este campo es solo para números");
            }
        }
        #endregion

        #endregion

        #region Tipo Articulos
        #region Modificar Tipo Articulos
        public void Modificar_Tipo_Articulos()
        {
            if (dgv_TipoArticulos.RowCount == 0)
            {
                MessageBox.Show("No hay datos para modificar");
            }
            else
            {
                Obj_DAL_Tipo.cBandIM = 'M';
                txt_IdTipoArticulo.Enabled = false;
                txt_IdTipoArticulo.Text = dgv_TipoArticulos.SelectedRows[0].Cells[0].Value.ToString().Trim();
                txt_DescripcionTipoArticulo.Text = dgv_TipoArticulos.SelectedRows[0].Cells[1].Value.ToString().Trim();
                cmb_EstadoTipoArticulo.Text = dgv_TipoArticulos.SelectedRows[0].Cells[2].Value.ToString().Trim();
            }
        }
        #endregion
        private void txt_FiltrarTipoArticulos_TextChanged(object sender, EventArgs e)
        {
            Cargar_Datos_TipoArticulo();
        }

        private void btn_Refrescar_TipoArticulos_Click(object sender, EventArgs e)
        {
            Cargar_Datos_TipoArticulo();
            Cargar_cmb_TipoArticulos();
        }

        private void btn_Modificar_TipoArticulo_Click(object sender, EventArgs e)
        {
            Modificar_Tipo_Articulos();
        }

        private void btn_GuardarTipoArticulo_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txt_IdTipoArticulo.Text)) && !(string.IsNullOrEmpty(txt_DescripcionTipoArticulo.Text))
                && cmb_EstadoTipoArticulo.SelectedValue.ToString() != "0")
            {
                Obj_DAL_Tipo.cIdTipoArticulo = Convert.ToChar(txt_IdTipoArticulo.Text);
                Obj_DAL_Tipo.sDescripcion = txt_DescripcionTipoArticulo.Text;
                Obj_DAL_Tipo.cIdEstado = Convert.ToChar(cmb_EstadoTipoArticulo.SelectedValue);
                string sMsjError = string.Empty;

                if (Obj_DAL_Tipo.cBandIM == 'I')
                {
                    Obj_BLL_Tipo.Insertar_TipoArticulo(ref sMsjError, ref Obj_DAL_Tipo);
                    if (sMsjError == string.Empty)
                    {
                        MessageBox.Show("Nuevo registro ingresado exitosamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Cargar_Datos_TipoArticulo();
                        Cargar_cmb_TipoArticulos();
                    }
                    else
                    {
                        MessageBox.Show("Se genera el siguiente error: " + "[" + sMsjError + "]", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                else if (Obj_DAL_Tipo.cBandIM == 'M')
                {
                    Obj_BLL_Tipo.Modificar_TipoArticulo(ref sMsjError, ref Obj_DAL_Tipo);
                    if (sMsjError == string.Empty)
                    {
                        MessageBox.Show("Modificación de registro exitoso", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_IdTipoArticulo.Enabled = true;
                        Cargar_Datos_TipoArticulo();
                        Cargar_cmb_TipoArticulos();
                    }
                    else
                    {
                        MessageBox.Show("Se genera el siguiente error: " + "[" + sMsjError + "]", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("No se pueden guardar datos vacios", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgv_TipoArticulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Modificar_Tipo_Articulos();
        }

        #region Validaciones
        private void txt_IdTipoArticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_DescripcionTipoArticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsLetter(e.KeyChar) ||
                char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void cmb_EstadoTipoArticulo_KeyPress(object sender, KeyPressEventArgs e)
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


        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
