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
    public partial class FRM_Citas : Form
    {
        public FRM_Citas()
        {
            InitializeComponent();
        }

        cls_Citas_BLL Obj_Citas_BLL = new cls_Citas_BLL();
        public cls_Citas_DAL Obj_Citas_DAL;

        /*private void CargarDatos()
        {
            if (tsTxtFiltrar.Text == string.Empty)
            {
                Obj_Citas_BLL.Listar_Citas(ref Obj_Citas_DAL);
            }
            else
            {
                Obj_Citas_BLL.Filtrar_Citas(ref Obj_Citas_DAL, tsTxtFiltrar.Text);
            }

            if (Obj_Citas_DAL.sMsjError == string.Empty)
            {
                dgv_Datos.DataSource = null;
                dgv_Datos.DataSource = Obj_Citas_DAL.Obj_DataTable;
            }
            else
            {
                MessageBox.Show("No se ha podido cargar los datos. \n\n Error: [ " + Obj_Citas_DAL.sMsjError + " ]");
            }
        }
        private void FRM_Citas_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }*/
/*
        private void tsBtn_CrearCita_Click(object sender, EventArgs e)
        {
            txt_NumCita.Enabled = true;
            txt_Nombre.Text = string.Empty;
            txt_Tel.Text = string.Empty;
            cb_Placa.SelectedValue = "";
            cb_Servicio.SelectedValue = "";
            txt_Email.Text = string.Empty;
            cb_Fecha.Text = "";
            cb_Hora.SelectedValue = "";
            cb_Estado.SelectedValue = "";
            cb_Empleado.SelectedValue = "";

            Obj_Citas_BLL = new cls_Citas_BLL();

            Obj_Citas_DAL.iNumCita = Convert.ToInt32(txt_NumCita.Text.ToString());
            Obj_Citas_DAL.sNombre = txt_Nombre.Text.ToString();
            Obj_Citas_DAL.iTel = Convert.ToInt32(txt_Tel.Text.ToString());
            Obj_Citas_DAL.sNumPlaca = cb_Placa.SelectedValue.ToString();
            Obj_Citas_DAL.cCodeServ = Convert.ToChar(cb_Servicio.SelectedValue.ToString());
            Obj_Citas_DAL.sEmail = txt_Email.Text.ToString();
            Obj_Citas_DAL.dtHoraCita = Convert.ToInt32(cb_Hora.SelectedValue.ToString());
            Obj_Citas_DAL.iIdEstado = Convert.ToInt32(cb_Estado.SelectedValue.ToString());
            Obj_Citas_DAL.iIdEmpleado = Convert.ToInt32(cb_Empleado.SelectedValue.ToString());

            Obj_Citas_BLL.Insertar_Citas(ref Obj_Citas_DAL);

            if (Obj_Citas_DAL.sMsjError == string.Empty)
            {
                MessageBox.Show("Se modifico exitosamente los Datos Citas", "EXITO",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Se presento un error a la hora de modificar los Datos Cliente. \n \n Error [ " + Obj_Citas_DAL.sMsjError + " ].", "ERROR",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/
    }
}
