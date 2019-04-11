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
    public partial class FRM_Horarios : Form
    {
        public FRM_Horarios()
        {
            InitializeComponent();
        }

        #region Variables Globales
        cls_Horarios_BLL Obj_BLL = new cls_Horarios_BLL();
        cls_Horarios_DAL Obj_DAL = new cls_Horarios_DAL();
        #endregion

        private void FRM_Horarios_Load(object sender, EventArgs e)
        {
            Cargar_Datos_Horarios();
            Cargar_cmb();
        }

        public void Cargar_Datos_Horarios()
        {

            string sMsjError = string.Empty;
            DataTable dtHorarios = new DataTable();
            Obj_DAL.cBandIM = 'I';

            txt_IdHorario.Enabled = false;
            txt_IdHorario.Clear();
            txt_Descrip.Clear();
            txt_Entrada.Clear();
            txt_Salida.Clear();

            if (txt_FiltrarHorarios.Text == string.Empty)
            {
                dtHorarios = Obj_BLL.Listar_Horarios(ref sMsjError);
            }
            else
            {
                dtHorarios = Obj_BLL.Filtrar_Horarios(ref sMsjError, txt_FiltrarHorarios.Text);
            }
            if (sMsjError == string.Empty)
            {
                dgv_Horarios.DataSource = null;
                dgv_Horarios.DataSource = dtHorarios;
            }
        }

        public void Cargar_cmb()
        {
            string sMsjError = string.Empty;
            cls_Estados_BLL Obj_Estados_BLL = new cls_Estados_BLL();
            DataTable DT_Estados = new DataTable();
            DT_Estados = Obj_Estados_BLL.Listar_Estados(ref sMsjError);
            cmb_IdEstado.DataSource = DT_Estados;
            DT_Estados.Rows.Add("0", "Elija Estado");
            cmb_IdEstado.DisplayMember = DT_Estados.Columns[1].ToString();
            cmb_IdEstado.ValueMember = DT_Estados.Columns[0].ToString();
            cmb_IdEstado.SelectedValue = "0";

        }

        private void txt_FiltrarHorarios_TextChanged(object sender, EventArgs e)
        {
            Cargar_Datos_Horarios();
        }

        private void btn_Refrescar_Click(object sender, EventArgs e)
        {
            Cargar_Datos_Horarios();
            Cargar_cmb();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (dgv_Horarios.RowCount == 0)
            {
                MessageBox.Show("No hay datos para modificar");
            }
            else
            {
                Obj_DAL.cBandIM = 'M';
                txt_IdHorario.Enabled = false;
                txt_IdHorario.Text = dgv_Horarios.SelectedRows[0].Cells[0].Value.ToString().Trim();
                txt_Descrip.Text = dgv_Horarios.SelectedRows[0].Cells[1].Value.ToString().Trim();
                txt_CantiHoras.Text = dgv_Horarios.SelectedRows[0].Cells[2].Value.ToString().Trim();
                txt_Entrada.Text = dgv_Horarios.SelectedRows[0].Cells[3].Value.ToString().Trim();
                txt_Salida.Text = dgv_Horarios.SelectedRows[0].Cells[4].Value.ToString().Trim();
                cmb_IdEstado.Text = dgv_Horarios.SelectedRows[0].Cells[5].Value.ToString().Trim();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txt_Descrip.Text)) && !(string.IsNullOrEmpty(txt_CantiHoras.Text))
                && !(string.IsNullOrEmpty(txt_Entrada.Text)) && !(string.IsNullOrEmpty(txt_Salida.Text)) && cmb_IdEstado.SelectedValue.ToString() != "0")
            {
                Obj_DAL.sDescripcion = txt_Descrip.Text;
                Obj_DAL.fCantHoras = Convert.ToSingle(txt_CantiHoras.Text);
                Obj_DAL.dtmEntrada = Convert.ToDateTime(txt_Entrada.Text);
                Obj_DAL.dtmSalida = Convert.ToDateTime(txt_Salida.Text);
                Obj_DAL.cIdEstado = Convert.ToChar(cmb_IdEstado.SelectedValue);
                string sMsjError = string.Empty;

                if (Obj_DAL.cBandIM == 'I')
                {
                    Obj_BLL.Insertar_Horarios(ref sMsjError, ref Obj_DAL);
                    if (sMsjError == string.Empty)
                    {
                        MessageBox.Show("Nuevo registro ingresado exitosamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Cargar_Datos_Horarios();
                    }
                    else
                    {
                        MessageBox.Show("Se genera el siguiente error: " + "[" + sMsjError + "]", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else if (Obj_DAL.cBandIM == 'M')
                {
                    Obj_DAL.bIdHorario = Convert.ToByte(txt_IdHorario.Text);
                    Obj_BLL.Modificar_Horarios(ref sMsjError, ref Obj_DAL);
                    if (sMsjError == string.Empty)
                    {
                        MessageBox.Show("Modificación de registro exitoso", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //txt_IdHorario.Enabled = true;
                        Cargar_Datos_Horarios();
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

        private void dgv_Horarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Horarios.RowCount == 0)
            {
                MessageBox.Show("No hay datos para modificar");
            }
            else
            {
                Obj_DAL.cBandIM = 'M';
                txt_IdHorario.Enabled = false;
                txt_IdHorario.Text = dgv_Horarios.SelectedRows[0].Cells[0].Value.ToString().Trim();
                txt_Descrip.Text = dgv_Horarios.SelectedRows[0].Cells[1].Value.ToString().Trim();
                txt_CantiHoras.Text = dgv_Horarios.SelectedRows[0].Cells[2].Value.ToString().Trim();
                txt_Entrada.Text = dgv_Horarios.SelectedRows[0].Cells[3].Value.ToString().Trim();
                txt_Salida.Text = dgv_Horarios.SelectedRows[0].Cells[4].Value.ToString().Trim();
                cmb_IdEstado.Text = dgv_Horarios.SelectedRows[0].Cells[5].Value.ToString().Trim();
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Validaciones
        private void txt_IdHorario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se Permiten Numeros");

            }
            else
            {
                e.Handled = false;

            }

        }




        #endregion

        private void txt_CantiHoras_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }


    }
}
