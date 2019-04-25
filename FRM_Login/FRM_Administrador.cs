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
using LavaCar_DAL.Login;

namespace FRM_Login.Menu
{
    public partial class FRM_Administrador : Form
    {

        cls_Login_DAL obj_Log_DAL = new cls_Login_DAL();
        public FRM_Administrador(string Usuario)
        {
            InitializeComponent();
            obj_Log_DAL.SUsuario = Usuario;
            lblUsuario.Text = "Bienvenido: " +obj_Log_DAL.SUsuario;
            
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
            AbrirVentana(new FRM_Horarios());
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

        private void btnInventario_Click(object sender, EventArgs e)
        {
            AbrirVentana(new FRM_Ajuste_Inventario());
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas salir del sistema?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                Application.Exit();
            
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            AbrirVentana(new FRM_Ordenes___de_Compras());
        }

        private void btnPromociones_Click(object sender, EventArgs e)
        {
            AbrirVentana(new FRM_Promociones());
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirVentana(new FRM_Cambio_Contraseña(obj_Log_DAL.SUsuario));
        }
    }
}
