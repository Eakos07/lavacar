﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using LavaCar_DAL.Login;

namespace FRM_Login
{
    public partial class FRM_Nivel_Uno : Form
    {
        cls_Login_DAL obj_Log_DAL = new cls_Login_DAL();
        public FRM_Nivel_Uno(string Usuario)
        {
            InitializeComponent();
            obj_Log_DAL.SUsuario = Usuario;
            lblUsuario.Text = "Bienvenido: " + obj_Log_DAL.SUsuario;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);
        private void AbrirVentana(object VentanaHija)
        {
            if (pnlVentana.Controls.Count > 0)
                pnlVentana.Controls.RemoveAt(0);
            Form vh = VentanaHija as Form;
            vh.TopLevel = false;
            vh.Dock = DockStyle.Fill;
            pnlVentana.Controls.Add(vh);
            pnlVentana.Tag = vh;
            vh.Show();

        }   //Evento para abrir ventana seleccionada

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas salir del sistema?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            AbrirVentana(new Menu.FRM_Citas());
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            AbrirVentana(new Menu.FRM_Marcas());
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCambioContraseña_Click(object sender, EventArgs e)
        {
            AbrirVentana(new Menu.FRM_Cambio_Contraseña(obj_Log_DAL.SUsuario));
        }
    }
}
