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
    public partial class FRM_Marcas : Form
    {
        public FRM_Marcas()
        {
            InitializeComponent();
            timer1.Enabled = true;
            btn_salida.Enabled = false;
        }

        

        private void FRM_Marcas_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
           
        }

   

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
        }

        private void btn_entrada_Click(object sender, EventArgs e)
        {
            label7.Text = label1.Text;
            btn_salida.Enabled = true;
        }

        private void btn_salida_Click(object sender, EventArgs e)
        {
            label8.Text = label2.Text;
            btn_entrada.Enabled = false;
            btn_salida.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
