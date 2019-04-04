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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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
            Cargar_Datos_Articulos();
            Cargar_Datos_TipoArticulo();
        }
        #region Familia Articulos
        public void Cargar_Datos_FamiliaArticulos()
        {
            
            string sMsjError = string.Empty;
            DataTable dtFamiliaArticulos = new DataTable();

            #region Cargar Estados
            cls_Estados_BLL Obj_Estados_BLL = new cls_Estados_BLL();
            DataTable DT_Estados = new DataTable();
            DT_Estados = Obj_Estados_BLL.Listar_Estados(ref sMsjError);
            cmb_IdEstadoFamilia.DataSource = DT_Estados;
            DT_Estados.Rows.Add("0", "Elija Estado");
            cmb_IdEstadoFamilia.DisplayMember = DT_Estados.Columns[1].ToString();
            cmb_IdEstadoFamilia.ValueMember = DT_Estados.Columns[0].ToString();
            cmb_IdEstadoFamilia.SelectedValue = "0";
            #endregion

            txt_IdFamilia.Clear();
            txt_DescripcionFamilia.Clear();
            cmb_IdEstadoFamilia.Text = " ";

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
        #endregion

        #region Articulos
        public void Cargar_Datos_Articulos()
        {
            
            string sMsjError = string.Empty;
            DataTable dtArticulos = new DataTable();

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
        #endregion

        #region Tipo Articulo
        public void Cargar_Datos_TipoArticulo()
        {
            
            string sMsjError = string.Empty;
            DataTable dtTipoArticulo = new DataTable();

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
        #endregion

        private void txt_FiltrarFamiliaArticulos_TextChanged(object sender, EventArgs e)
        {
            Cargar_Datos_FamiliaArticulos();
        }

        private void txt_FiltrarArticulos_TextChanged(object sender, EventArgs e)
        {
            Cargar_Datos_Articulos();
        }

        private void txt_FiltrarTipoArticulos_TextChanged(object sender, EventArgs e)
        {
            Cargar_Datos_TipoArticulo();
        }

        private void btn_RefrescarFamilia_Click(object sender, EventArgs e)
        {
            Cargar_Datos_TipoArticulo();
        }

        private void btn_ModificarFamilia_Click(object sender, EventArgs e)
        {
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
                cmb_IdEstadoFamilia.SelectedValue = dgv_FamiliaArticulos.SelectedRows[0].Cells[2].Value.ToString().Trim();
            }
        }

        private void btn_GuardarFamilia_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txt_IdFamilia.Text)) || !(string.IsNullOrEmpty(txt_DescripcionFamilia.Text)) || !(string.IsNullOrEmpty(cmb_IdEstadoFamilia.Text)))
            {
                Obj_DAL_Familia.sIdFamilia = txt_IdFamilia.Text;
                Obj_DAL_Familia.sDescripcion = txt_DescripcionFamilia.Text;
                Obj_DAL_Familia.bIdEstado = Convert.ToByte(cmb_IdEstadoFamilia.SelectedValue);
                string sMsjError = string.Empty;

                if (Obj_DAL_Familia.cBandIM == 'I')
                {
                    Obj_BLL_Familia.Insertar_FamiliaArticulos(ref sMsjError, ref Obj_DAL_Familia);
                    MessageBox.Show("Nuevo registro ingresado exitosamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cargar_Datos_FamiliaArticulos();
                }
                else if (Obj_DAL_Familia.cBandIM == 'M')
                {
                    Obj_BLL_Familia.Modificar_FamiliaArticulos(ref sMsjError, ref Obj_DAL_Familia);
                    MessageBox.Show("Modificación de registro exitoso", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_IdFamilia.Enabled = true;
                    Cargar_Datos_FamiliaArticulos();
                }
            }
            else
            {
                MessageBox.Show("No se pueden guardar datos vacios", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgv_Articulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_FamiliaArticulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Obj_DAL_Familia.cBandIM = 'M';
            txt_IdFamilia.Enabled = false;
            txt_IdFamilia.Text = dgv_FamiliaArticulos.SelectedRows[0].Cells[0].Value.ToString().Trim();
            txt_DescripcionFamilia.Text = dgv_FamiliaArticulos.SelectedRows[0].Cells[1].Value.ToString().Trim();
            cmb_IdEstadoFamilia.SelectedValue = dgv_FamiliaArticulos.SelectedRows[0].Cells[2].Value.ToString().Trim();
        }
    }
}
