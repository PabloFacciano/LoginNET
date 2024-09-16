namespace CapaVista
{
    partial class FrmRecupero
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
            this.TxtContrasena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtContrasena2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.LinkLabel();
            this.BtnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtContrasena
            // 
            this.TxtContrasena.Location = new System.Drawing.Point(107, 247);
            this.TxtContrasena.MaxLength = 100;
            this.TxtContrasena.Name = "TxtContrasena";
            this.TxtContrasena.Size = new System.Drawing.Size(174, 20);
            this.TxtContrasena.TabIndex = 8;
            this.TxtContrasena.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nueva contraseña:";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(107, 193);
            this.TxtUsuario.MaxLength = 100;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(174, 20);
            this.TxtUsuario.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usuario:";
            // 
            // TxtContrasena2
            // 
            this.TxtContrasena2.Location = new System.Drawing.Point(107, 301);
            this.TxtContrasena2.MaxLength = 100;
            this.TxtContrasena2.Name = "TxtContrasena2";
            this.TxtContrasena2.Size = new System.Drawing.Size(174, 20);
            this.TxtContrasena2.TabIndex = 10;
            this.TxtContrasena2.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Repetir contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 31);
            this.label4.TabIndex = 11;
            this.label4.Text = "Olvidé mi contraseña";
            // 
            // BtnLogin
            // 
            this.BtnLogin.AutoSize = true;
            this.BtnLogin.LinkArea = new System.Windows.Forms.LinkArea(26, 40);
            this.BtnLogin.Location = new System.Drawing.Point(102, 461);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(181, 17);
            this.BtnLogin.TabIndex = 13;
            this.BtnLogin.TabStop = true;
            this.BtnLogin.Text = "Recordaste tu contraseña? Ingresá";
            this.BtnLogin.UseCompatibleTextRendering = true;
            this.BtnLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BtnLogin_LinkClicked);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BtnSave.FlatAppearance.BorderSize = 0;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Location = new System.Drawing.Point(107, 352);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(174, 35);
            this.BtnSave.TabIndex = 12;
            this.BtnSave.Text = "Guardar";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // FrmRecupero
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtContrasena2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtContrasena);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRecupero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Olvidé mi contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtContrasena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtContrasena2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel BtnLogin;
        private System.Windows.Forms.Button BtnSave;
    }
}