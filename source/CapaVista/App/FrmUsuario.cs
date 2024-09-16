using CapaDatos;
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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        public CD_Usuario Usuario { get; set; }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                CL_Login.UpsertUser(Usuario.Id, TxtNombre.Text, TxtUsuario.Text, (string)CmbNivel.SelectedItem, TxtContrasena.Text, TxtContrasena2.Text);
                this.Close();
            }
            catch (Exception ex)
            {

                if (MessageBox.Show(ex.Message + "\nIntentar de nuevo?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes) return;
                this.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            TxtNombre.Text = Usuario.NombreCompleto;
            TxtUsuario.Text = Usuario.Usuario;
            TxtNombre.Focus();
            CmbNivel.SelectedText = Usuario.Nivel;
        }
    }
}
