
namespace CapaVista
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnUsuarios = new System.Windows.Forms.Button();
            this.TxtMensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnLogout
            // 
            this.BtnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogout.Location = new System.Drawing.Point(40, 364);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(174, 35);
            this.BtnLogout.TabIndex = 6;
            this.BtnLogout.Text = "< Cerrar sesión";
            this.BtnLogout.UseVisualStyleBackColor = true;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // BtnUsuarios
            // 
            this.BtnUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BtnUsuarios.FlatAppearance.BorderSize = 0;
            this.BtnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsuarios.ForeColor = System.Drawing.Color.White;
            this.BtnUsuarios.Location = new System.Drawing.Point(231, 364);
            this.BtnUsuarios.Name = "BtnUsuarios";
            this.BtnUsuarios.Size = new System.Drawing.Size(174, 35);
            this.BtnUsuarios.TabIndex = 8;
            this.BtnUsuarios.Text = "Ver usuarios >";
            this.BtnUsuarios.UseVisualStyleBackColor = false;
            this.BtnUsuarios.Click += new System.EventHandler(this.BtnUsuarios_Click);
            // 
            // TxtMensaje
            // 
            this.TxtMensaje.AutoSize = true;
            this.TxtMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMensaje.Location = new System.Drawing.Point(36, 36);
            this.TxtMensaje.Name = "TxtMensaje";
            this.TxtMensaje.Size = new System.Drawing.Size(255, 48);
            this.TxtMensaje.TabIndex = 9;
            this.TxtMensaje.Text = "Hola, NOMBRE!\r\nTu nivel de usuario es NIVEL";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 431);
            this.Controls.Add(this.TxtMensaje);
            this.Controls.Add(this.BtnUsuarios);
            this.Controls.Add(this.BtnLogout);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(470, 470);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello World";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Button BtnUsuarios;
        private System.Windows.Forms.Label TxtMensaje;
    }
}