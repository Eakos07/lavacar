using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LavaCar_BLL.Cat_Mant;
using LavaCar_DAL.Cat_Mant;

namespace FRM_Login.Menu
{
    public partial class FRM_Horarios : Form
    {
        public FRM_Horarios()
        {
            InitializeComponent();
        }
        private void FRM_Horarios_Load(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public void Cargar_Datos_Horarios()
        {
            cls_Horarios_BLL Obj_BLL = new cls_Horarios_BLL();
            string sMsjError = string.Empty;
            DataTable dtHorarios = new DataTable();

            if (txt_FiltrarHorarios.Text == string.Empty)
            {
                dtHorarios = Obj_BLL.Listar_Horarios(ref sMsjError);
            }
            else
            {
                dtHorarios = Obj_BLL.Filtrar_Horarios(ref sMsjError, txt_FiltrarHorarios.Text);
            }
            if (sMsjError == string.Empty)
            {
                dgv_Horarios.DataSource = null;
                dgv_Horarios.DataSource = dtHorarios;
            }
        }

        private void txt_FiltrarHorarios_TextChanged(object sender, EventArgs e)
        {
            Cargar_Datos_Horarios();
        }
    }
}
