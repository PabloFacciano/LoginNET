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
    public partial class FrmListaUsuarios : Form
    {
        public FrmListaUsuarios()
        {
            InitializeComponent();
            DGVUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //Selecciona toda la fila al hacer click en cualquier celda
            DGVUsuarios.MultiSelect = false; //desactiva la seleccion multiple
            DGVUsuarios.AllowUserToAddRows = false; //desactiva  la ultima fila para evitar que el usuario agregue datos a la grilla manualmente
            DGVUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;    // Ajuste automatico para todas las columnas visibles
            DGVUsuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;    // Ajuste automatico para todas las filas visibles
            DGVUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;    // Estilo de los bordes de las celdas
            DGVUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None; // Estilo de las columnas del encabezado
            DGVUsuarios.ColumnHeadersHeight = 30;  // Alto del encabezado
            DGVUsuarios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;    // Estilo de la fila de encabezado
            DGVUsuarios.RowHeadersVisible = false; //Elimino las cabeceras de las filas
            CargarUsuarios();
            BtnNuevo.Focus();
        }

        CD_Usuario[] FullData = null;

        private void CargarUsuarios()
        {
            DGVUsuarios.ClearSelection();

            DGVUsuarios.DataSource = null;
            DGVUsuarios.Columns.Clear();

            TxtBuscar.Text.Trim();
            if (TxtBuscar.Text.Length > 0)
            {
                FullData = CD_Usuario.SelectBy("%" + TxtBuscar.Text + "%");
            } else
            {
                FullData = CD_Usuario.Select();
            }
            DGVUsuarios.DataSource = FullData;

            foreach (DataGridViewColumn column in DGVUsuarios.Columns)
            {
                if (column.HeaderText == "Contrasena")
                {
                    column.Visible = false; // Ocultar contraseñas
                }
            }

            DataGridViewButtonColumn BtnEdit = new DataGridViewButtonColumn();
            BtnEdit.Text = "Editar";
            BtnEdit.UseColumnTextForButtonValue = true;
            DGVUsuarios.Columns.Add(BtnEdit);

            DataGridViewButtonColumn BtnDelete = new DataGridViewButtonColumn();
            BtnDelete.Text = "Eliminar";
            BtnDelete.UseColumnTextForButtonValue = true;
            DGVUsuarios.Columns.Add(BtnDelete);
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            if (!CL_Login.CurrentuserCanEditOtherUsers())
            {
                MessageBox.Show("No tienes permiso para crear usuarios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FrmUsuario frm = new FrmUsuario();
            frm.Usuario = new CD_Usuario();
            Program.ShowForm(frm, true);
            CargarUsuarios();
        }

        private void BtnEditar_Click()
        {
            if (DGVUsuarios.SelectedRows.Count == 0) return;
            if (!CL_Login.CurrentuserCanEditOtherUsers())
            {
                MessageBox.Show("No tienes permiso para editar usuarios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FrmUsuario frm = new FrmUsuario();
            frm.Usuario = (CD_Usuario)DGVUsuarios.SelectedRows[0].DataBoundItem;
            Program.ShowForm(frm, true);
            CargarUsuarios();
        }

        private void BtnEliminar_Click()
        {
            if (DGVUsuarios.SelectedRows.Count == 0) return;
            if (!CL_Login.CurrentuserCanEditOtherUsers())
            {
                MessageBox.Show("No tienes permiso para eliminar usuarios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Eliminar registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;

            CD_Usuario.Delete((CD_Usuario)DGVUsuarios.SelectedRows[0].DataBoundItem);
            CargarUsuarios();
        }

        private void DGVUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (DGVUsuarios.SelectedRows.Count < 1) return;

            if (DGVUsuarios.SelectedCells[e.ColumnIndex].Value.ToString() == "Editar") BtnEditar_Click();
            if (DGVUsuarios.SelectedCells[e.ColumnIndex].Value.ToString() == "Eliminar") BtnEliminar_Click();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Program.ShowForm(new FrmMain());
            this.Close();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void FrmListaUsuarios_Load(object sender, EventArgs e)
        {

                    }
    }
}
