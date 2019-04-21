using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Net.Mail;
using LavaCar_DAL.Recuperacion;
using LavaCar_BLL.Recuperacion;


namespace FRM_Login
{
    public partial class FRM_Contraseña : Form
    {
        public FRM_Contraseña()
        {
            InitializeComponent();
        }
        Cls_Recuperacion_BLL obj_Recu_BLL = new Cls_Recuperacion_BLL();
        Cls_Recuperacion_DAL obj_Recu_DAL = new Cls_Recuperacion_DAL();

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            obj_Recu_DAL.SIdentificacion = txtRecuperación.Text;
            obj_Recu_DAL.SEmail = "a";
            obj_Recu_BLL.EnviarCorreo(ref obj_Recu_DAL);
            
            if (obj_Recu_DAL.SEmail.Contains("@")) 
            {
                MessageBox.Show(obj_Recu_DAL.SMsjConfirmacion, "Información Correo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (obj_Recu_DAL.SEmail == "a")
            {
                MessageBox.Show(obj_Recu_DAL.SMsjFallo, "Información Correo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
    }
}
