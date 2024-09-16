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
    public partial class FrmRecupero : Form
    {
        public FrmRecupero()
        {
            InitializeComponent();
        }

        private void BtnLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.ShowForm(new FrmLogin(), false);
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                CL_Login.SetNewPassword(TxtUsuario.Text, TxtContrasena.Text, TxtContrasena2.Text); 
                this.Close();
            }
            catch (Exception ex)
            {

                if (MessageBox.Show(ex.Message + "\nIntentar de nuevo?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes) return;
                this.Close();
            }
        }
    }
}
