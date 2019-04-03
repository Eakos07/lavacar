using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LavaCar_DAL.Cat_Mant;
using LavaCar_BLL.Cat_Mant;

namespace FRM_Login.Menu
{
    public partial class FRM_Planillas : Form
    {
        public FRM_Planillas()
        {
            InitializeComponent();
        }

        private void FRM_Planillas_Load(object sender, EventArgs e)
        {
            Cargar_Datos_Planilla();
        }
        public void Cargar_Datos_Planilla()
        {
            cls_Planillas_BLL Obj_BLL = new cls_Planillas_BLL();
            string sMsjError = string.Empty;
            DataTable dtPlanilla = new DataTable();

            if (txt_FiltrarPlanillas.Text == string.Empty)
            {
                dtPlanilla = Obj_BLL.Listar_Planilla(ref sMsjError);
            }
            else
            {
                dtPlanilla = Obj_BLL.Filtrar_Planilla(ref sMsjError, txt_FiltrarPlanillas.Text);
            }
            if (sMsjError == string.Empty)
            {
                dgv_Planillas.DataSource = null;
                dgv_Planillas.DataSource = dtPlanilla;
            }
        }

        private void txt_FiltrarPlanillas_TextChanged(object sender, EventArgs e)
        {
            Cargar_Datos_Planilla();
        }
    }
}
