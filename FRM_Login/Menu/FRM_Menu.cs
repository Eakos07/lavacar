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

namespace FRM_Login
{
    public partial class FRM_Menu : Form
    {
        public FRM_Menu()
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


        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            AbrirVentana(new Menu.FRM_Citas());
        }

        private void btnPolizas_Click(object sender, EventArgs e)
        {
            AbrirVentana(new Menu.FRM_Polizas());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirVentana(new Menu.FRM_Proveedores());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirVentana(new Menu.FRM_Articulos());
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirVentana(new Menu.FRM_Marcas());
        }
    }
}
