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

namespace FRM_Login.Menu
{
    public partial class FRM_Administrador : Form
    {
        public FRM_Administrador()
        {
            InitializeComponent();
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
        private void btnCitas_Click(object sender, EventArgs e)
        {
            AbrirVentana(new Menu.FRM_Citas());
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_Marca_Click(object sender, EventArgs e)
        {
            AbrirVentana(new Menu.FRM_Estados());
        }

        private void btn_Estados_Click(object sender, EventArgs e)
        {
            AbrirVentana(new Menu.FRM_Estados());
        }

        private void btn_Marca_Click_1(object sender, EventArgs e)
        {
            AbrirVentana(new Menu.FRM_Marcas());
        }

        private void btn_Superv_Click(object sender, EventArgs e)
        {
            AbrirVentana(new Menu.FRM_Supervisor());
        }

        private void btn_Artic_Click(object sender, EventArgs e)
        {
            AbrirVentana(new Menu.FRM_Articulos());
        }

        private void btn_Prove_Click(object sender, EventArgs e)
        {
            AbrirVentana(new Menu.FRM_Proveedores());
        }

        private void btnPolizas_Click(object sender, EventArgs e)
        {
            AbrirVentana(new Menu.FRM_Polizas());
        }
    }
}
