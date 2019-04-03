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
    public partial class FRM_Promociones : Form
    {
        public FRM_Promociones()
        {
            InitializeComponent();
        }

        private void FRM_Promociones_Load(object sender, EventArgs e)
        {
            Cargar_Datos_Promociones();

        }
        public void Cargar_Datos_Promociones()
        {
            cls_Promociones_BLL Obj_BLL = new cls_Promociones_BLL();
            string sMsjError = string.Empty;
            DataTable dtPromociones = new DataTable();

            if (txt_FiltrarPromociones.Text == string.Empty)
            {
                dtPromociones = Obj_BLL.Listar_Promociones(ref sMsjError);
            }
            else
            {
                dtPromociones = Obj_BLL.Filtrar_Promociones(ref sMsjError, txt_FiltrarPromociones.Text);
            }
            if (sMsjError == string.Empty)
            {
                dgv_Promociones.DataSource = null;
                dgv_Promociones.DataSource = dtPromociones;
            }
        }

        private void txt_FiltrarPromociones_TextChanged(object sender, EventArgs e)
        {
            Cargar_Datos_Promociones();
        }
    }
}
