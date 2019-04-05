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
   

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnPolizas_Click(object sender, EventArgs e)
        {
            AbrirVentana(new FRM_Polizas());
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            AbrirVentana(new FRM_Marcas());
        }

        private void btnSupervisor_Click(object sender, EventArgs e)
        {
            //AbrirVentana(new FRM_Supervisor());
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            AbrirVentana(new FRM_Articulos());
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            AbrirVentana(new FRM_Proveedores());
        }

        private void btnEstados_Click(object sender, EventArgs e)
        {
            AbrirVentana(new FRM_Estados());
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            AbrirVentana(new FRM_Citas());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirVentana(new FRM_Articulos());
        }

        private void btnProveedores_Click_1(object sender, EventArgs e)
        {
            AbrirVentana(new FRM_Proveedores());
        }

        private void btnMarcas_Click_1(object sender, EventArgs e)
        {
            AbrirVentana(new FRM_Marcas());
        }

        private void btnPlanillas_Click(object sender, EventArgs e)
        {
            AbrirVentana(new FRM_Planillas());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirVentana(new FRM_Clientes());
        }

        private void btnTipoPlaca_Click(object sender, EventArgs e)
        {
            AbrirVentana(new FRM_Tipo_Placa());
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirVentana(new FRM_Empleados());
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            AbrirVentana(new FRM_Factura());
        }

        private void btnTipoCambio_Click(object sender, EventArgs e)
        {
            AbrirVentana(new FRM_Tipo_Cambio());
        }

        private void btnTipoFactura_Click(object sender, EventArgs e)
        {
            AbrirVentana(new FRM_Tipo_Factura());
        }

        private void btnTipoServicio_Click(object sender, EventArgs e)
        {
            AbrirVentana(new FRM_Tipo_Servicio());
        }

        private void btnTipoVehiculo_Click(object sender, EventArgs e)
        {
            AbrirVentana(new FRM_Tipo_Vehículo());
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            AbrirVentana(new FRM_Roles());
        }

        private void button19_Click(object sender, EventArgs e)
        {
            AbrirVentana(new FRM_Transaccion());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirVentana(new FRM_Usuario());
        }
    }
}
