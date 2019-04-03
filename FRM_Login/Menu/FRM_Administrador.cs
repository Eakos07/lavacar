using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRM_Login.Menu
{
    public partial class FRM_Administrador : Form
    {
        public FRM_Administrador()
        {
            InitializeComponent();
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
        private void btnCitas_Click(object sender, EventArgs e)
        {
            AbrirVentana(new Menu.FRM_Citas());
        }
    }
}
