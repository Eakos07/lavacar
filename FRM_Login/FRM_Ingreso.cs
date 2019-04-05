using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Configuration;

using System.Data.SqlClient;

namespace FRM_Login
{
    public partial class FRM_Ingreso : Form
    {
        public FRM_Ingreso()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_Ingreso_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtUsuarioLogin_Enter(object sender, EventArgs e)
        {
            if (txtUsuarioLogin.Text == "USUARIO")
            {
                txtUsuarioLogin.Text = "";
                txtUsuarioLogin.ForeColor = Color.Black;
            }
        }

        private void txtUsuarioLogin_Leave(object sender, EventArgs e)
        {
            if (txtUsuarioLogin.Text == "")
            {
                txtUsuarioLogin.Text = "USUARIO";
                txtUsuarioLogin.ForeColor = Color.Black;
            }
        }

        private void txtContrase_Enter(object sender, EventArgs e)
        {
            if (txtContrase.Text == "CONTRASEÑA")
            {
                txtContrase.Text = "";
                txtContrase.ForeColor = Color.Black;
                txtContrase.UseSystemPasswordChar = true;
            }
        }

        private void txtContrase_Leave(object sender, EventArgs e)
        {
            if (txtContrase.Text == "")
            {
                txtContrase.Text = "CONTRASEÑA";
                txtContrase.ForeColor = Color.Black;
                txtContrase.UseSystemPasswordChar = false;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuarioLogin.Text != "USUARIO" && txtContrase.Text != "CONTRASEÑA")
            {
                if (txtUsuarioLogin.Text == "Admin")
                {
                    MessageBox.Show("Validación Exitosa");
                    Menu.FRM_Administrador pantalla = new Menu.FRM_Administrador();
                    pantalla.ShowDialog();
                    
                }
                
            }
            else
            {
                MessageBox.Show("Datos incorrectos", "Warining", MessageBoxButtons.OK);
            }
          

        }
        private void cerrarSesion(object sender, FormClosedEventArgs e)
        {
            txtContrase.Text = "CONTRASEÑA";
            txtUsuarioLogin.Text = "USUARIO";
            this.Show();
            txtUsuarioLogin.Focus();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FRM_Contraseña PantallaContra = new FRM_Contraseña();
            PantallaContra.ShowDialog();
            PantallaContra.Dispose();
        }
    }
}
