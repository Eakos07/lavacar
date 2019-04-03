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

        private void btnCitas_Click(object sender, EventArgs e)
        {
            FRM_Citas PantallaCitas = new FRM_Citas();
            PantallaCitas.ShowDialog();
        }
    }
}
