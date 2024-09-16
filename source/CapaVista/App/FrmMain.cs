using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            TxtMensaje.Text = String.Format("Hola, {0}!\nTu nivel de usuario es [{1}].", CL_Login.CurrentUser.NombreCompleto, CL_Login.CurrentUser.Nivel);    
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            Program.ShowForm(new FrmListaUsuarios());
            this.Close();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            CL_Login.Logout();
            Program.ShowForm(new FrmLogin());
            this.Close();
        }

        private void BtnJugar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
