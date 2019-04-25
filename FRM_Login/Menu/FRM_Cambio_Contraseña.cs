using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LavaCar_DAL.Login;
using LavaCar_BLL.Cat_Mant;
using System.Configuration;
using System.Data.SqlClient;


namespace FRM_Login.Menu
{
    public partial class FRM_Cambio_Contraseña : Form
    {

        cls_Login_DAL Obj_Login_DAL = new cls_Login_DAL();
        cls_Cambio_Contraseña Obj_Cambio_BLL = new cls_Cambio_Contraseña();

        public FRM_Cambio_Contraseña(string usuario)
        {
            InitializeComponent();
            
            Obj_Login_DAL.SUsuario = usuario;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            if (txtContraNueva.Text == txtRepetirContra.Text)
            {

                Obj_Login_DAL.SContraseñaNueva = txtContraNueva.Text;
                Obj_Login_DAL.SContraseñaActual = txtContraActual.Text;
                Obj_Cambio_BLL.CambiarContraseña(ref Obj_Login_DAL);
                MessageBox.Show(Obj_Login_DAL.SMsj, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
             
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden, por favor ingrese nuevamente los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContraNueva.Text = "";
                txtRepetirContra.Text = "";
            }
                      
             
            
        }
    }
}
