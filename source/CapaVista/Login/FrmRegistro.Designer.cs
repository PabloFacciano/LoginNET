
namespace CapaVista
{
    partial class FrmRegistro
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
            this.BtnVolver = new System.Windows.Forms.LinkLabel();
            this.BtnRegistrarse = new System.Windows.Forms.Button();
            this.TxtContrasena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtContrasena2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnVolver
            // 
            this.BtnVolver.AutoSize = true;
            this.BtnVolver.Location = new System.Drawing.Point(141, 468);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(102, 13);
            this.BtnVolver.TabIndex = 6;
            this.BtnVolver.TabStop = true;
            this.BtnVolver.Text = "Ya tengo un usuario";
            this.BtnVolver.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BtnVolver_LinkClicked);
            // 
            // BtnRegistrarse
            // 
            this.BtnRegistrarse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BtnRegistrarse.FlatAppearance.BorderSize = 0;
            this.BtnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrarse.ForeColor = System.Drawing.Color.White;
            this.BtnRegistrarse.Location = new System.Drawing.Point(107, 387);
            this.BtnRegistrarse.Name = "BtnRegistrarse";
            this.BtnRegistrarse.Size = new System.Drawing.Size(174, 35);
            this.BtnRegistrarse.TabIndex = 5;
            this.BtnRegistrarse.Text = "Registrarme";
            this.BtnRegistrarse.UseVisualStyleBackColor = false;
            this.BtnRegistrarse.Click += new System.EventHandler(this.BtnRegistrarse_Click);
            // 
            // TxtContrasena
            // 
            this.TxtContrasena.Location = new System.Drawing.Point(107, 282);
            this.TxtContrasena.MaxLength = 100;
            this.TxtContrasena.Name = "TxtContrasena";
            this.TxtContrasena.Size = new System.Drawing.Size(174, 20);
            this.TxtContrasena.TabIndex = 3;
            this.TxtContrasena.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Contraseña:";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(107, 228);
            this.TxtUsuario.MaxLength = 100;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(174, 20);
            this.TxtUsuario.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Registro";
            // 
            // TxtContrasena2
            // 
            this.TxtContrasena2.Location = new System.Drawing.Point(107, 333);
            this.TxtContrasena2.MaxLength = 100;
            this.TxtContrasena2.Name = "TxtContrasena2";
            this.TxtContrasena2.Size = new System.Drawing.Size(174, 20);
            this.TxtContrasena2.TabIndex = 4;
            this.TxtContrasena2.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Repetir contraseña:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(107, 178);
            this.TxtNombre.MaxLength = 100;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(174, 20);
            this.TxtNombre.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Nombre:";
            // 
            // FrmRegistro
            // 
            this.AcceptButton = this.BtnRegistrarse;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtContrasena2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.BtnRegistrarse);
            this.Controls.Add(this.TxtContrasena);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel BtnVolver;
        private System.Windows.Forms.Button BtnRegistrarse;
        private System.Windows.Forms.TextBox TxtContrasena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtContrasena2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label5;
    }
}