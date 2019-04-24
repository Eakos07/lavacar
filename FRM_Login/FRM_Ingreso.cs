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
using LavaCar_BLL.Login;
using LavaCar_DAL.Login;

namespace FRM_Login
{
    public partial class FRM_Ingreso : Form
    {
        public FRM_Ingreso()
        {
            InitializeComponent();
            
        }

        cls_Login_BLL obj_Login_BLL = new cls_Login_BLL();
        cls_Login_DAL obj_Login_DAL = new cls_Login_DAL();

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

            obj_Login_DAL.SMsjError = string.Empty;
            obj_Login_DAL.SUsuario = txtUsuarioLogin.Text;
            obj_Login_DAL.SContrasena = txtContrase.Text;

            

            if (txtContrase.Text != "CONTRASEÑA" && txtUsuarioLogin.Text != "USUARIO")
            {
                obj_Login_BLL.Ingresar(ref obj_Login_DAL);

                if (obj_Login_DAL.BIdRole == 3)
                {
                    this.Hide();
                    MessageBox.Show("Bienvenido: " + obj_Login_DAL.SUsuario, "Octupus", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Menu.FRM_Administrador PantallaMenu = new Menu.FRM_Administrador(obj_Login_DAL.SUsuario);

                    PantallaMenu.ShowDialog();

                }

                if (obj_Login_DAL.BIdRole == 2)
                {
                    MessageBox.Show("No sea necio aún no estan las demás pantallas", "PELIGRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (obj_Login_DAL.BIdRole == 1)
                {
                    this.Hide();
                    MessageBox.Show("Bienvenido: " + obj_Login_DAL.SUsuario);
                    FRM_Nivel_Uno PantallaMenu1 = new FRM_Nivel_Uno();
                    PantallaMenu1.ShowDialog();
                }
                if (obj_Login_DAL.BIdRole == 0)
                {
                    MessageBox.Show("Por favor, ingrese un Usuario o Contraseña válidas", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un Usuario o Contraseña válidas", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            if (obj_Login_DAL.SMsjError.Contains("a"))
            {
                MessageBox.Show(obj_Login_DAL.SMsjError);
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
