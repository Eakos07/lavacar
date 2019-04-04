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
    public partial class FRM_Clientes : Form
    {
        public FRM_Clientes()
        {
            InitializeComponent();
        }

        #region Variables Globales
        cls_Clientes_BLL ObjBLL = new cls_Clientes_BLL();
        cls_Clientes_DAL ObjDAL = new cls_Clientes_DAL();
        #endregion

        public void CargarDatos()
        {
            cls_Clientes_BLL Obj_BLL = new cls_Clientes_BLL();
            string sMsjError = string.Empty;
            DataTable dtClientes = new DataTable();
            ObjDAL.cBandIM = 'I';
            #region Combo Tipo Placa
            cls_TipoPlaca_BLL Obj_TipoPlaca_BLL = new cls_TipoPlaca_BLL();
            DataTable DT_TipoPlaca = new DataTable();
            DT_TipoPlaca = Obj_TipoPlaca_BLL.Listar_TipoPlaca(ref sMsjError);
            cmbTipoPlacaVehiculo.DataSource = DT_TipoPlaca;
            DT_TipoPlaca.Rows.Add("0", "Elija una opción");
            cmbTipoPlacaVehiculo.DisplayMember = DT_TipoPlaca.Columns[1].ToString();
            cmbTipoPlacaVehiculo.ValueMember = DT_TipoPlaca.Columns[0].ToString();
            cmbTipoPlacaVehiculo.SelectedValue = "0";
            #endregion

            #region Combo Tipo Vehiculo
            cls_TipoVehiculo_BLL Obj_TipoVehiculo_BLL = new cls_TipoVehiculo_BLL();
            DataTable DT_TipoVehiculo = new DataTable();
            DT_TipoVehiculo = Obj_TipoVehiculo_BLL.Listar_TipoVehiculo (ref sMsjError);
            cmbTipoVehiculo.DataSource = DT_TipoVehiculo;
            DT_TipoVehiculo.Rows.Add("0", "Elija una opción");
            cmbTipoVehiculo.DisplayMember = DT_TipoVehiculo.Columns[1].ToString();
            cmbTipoVehiculo.ValueMember = DT_TipoVehiculo.Columns[0].ToString();
            cmbTipoVehiculo.SelectedValue = "0";
            #endregion

            if (toolStripTextBox1.Text == string.Empty)
            {
                dtClientes = Obj_BLL.Listar_Clientes(ref sMsjError);
            }
            else
            {
                dtClientes = Obj_BLL.Filtrar_Clientes(ref sMsjError, toolStripTextBox1.Text);
            }
            if (sMsjError == string.Empty)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dtClientes;
            }
        }
        private void FRM_Clientes_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPlacaVehiculo.Text) && cmbTipoPlacaVehiculo.SelectedValue.ToString() != "Elija una opción"
                && cmbTipoVehiculo.SelectedValue.ToString() != "Elija una opción")
            {
                ObjDAL.sNumPlaca = txtPlacaVehiculo.Text;
                ObjDAL.bIdTipoPlaca = Convert.ToByte(cmbTipoPlacaVehiculo.SelectedValue);
                ObjDAL.bIdTipoVehiculo = Convert.ToByte(cmbTipoVehiculo.SelectedValue);
                string sMsjError = string.Empty;

                if (ObjDAL.cBandIM == 'I')
                {
                    ObjBLL.Insertar_Clientes(ref sMsjError, ref ObjDAL);
                    MessageBox.Show("Nuevo registro ingresado exitosamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos();
                }
                else if (ObjDAL.cBandIM == 'M')
                {
                    ObjBLL.Modificar_Clientes(ref sMsjError, ref ObjDAL);
                    MessageBox.Show("Modificación de registro exitoso", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos();
                }
            }
            else
            {
                MessageBox.Show("No se pueden guardar datos vacios", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
