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
    public partial class FRM_Roles : Form
    {
        public FRM_Roles()
        {
            InitializeComponent();
        }

        private void FRM_Roles_Load(object sender, EventArgs e)
        {
            Cargar_Datos_Roles();
        }
        public void Cargar_Datos_Roles()
        {
            cls_Roles_BLL Obj_BLL = new cls_Roles_BLL();
            string sMsjError = string.Empty;
            DataTable dtRoles = new DataTable();

            if (txt_FiltrarRoles.Text == string.Empty)
            {
                dtRoles = Obj_BLL.Listar_Roles(ref sMsjError);
            }
            else
            {
                dtRoles = Obj_BLL.Filtrar_Roles(ref sMsjError, txt_FiltrarRoles.Text);
            }
            if (sMsjError == string.Empty)
            {
                dgv_Roles.DataSource = null;
                dgv_Roles.DataSource = dtRoles;
            }
        }

        private void txt_FiltrarRoles_TextChanged(object sender, EventArgs e)
        {
            Cargar_Datos_Roles();
        }
    }
}
