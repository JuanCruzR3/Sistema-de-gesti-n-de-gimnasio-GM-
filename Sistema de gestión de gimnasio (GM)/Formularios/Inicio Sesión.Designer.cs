namespace Sistema_de_gestión_de_gimnasio__GM_
{
    partial class InicioSesion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFormas = new System.Windows.Forms.Label();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.lblcontraseña = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblOlvideContraseña = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblFormas
            // 
            this.lblFormas.AutoSize = true;
            this.lblFormas.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblFormas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblFormas.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormas.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblFormas.Location = new System.Drawing.Point(34, 9);
            this.lblFormas.Name = "lblFormas";
            this.lblFormas.Size = new System.Drawing.Size(264, 38);
            this.lblFormas.TabIndex = 0;
            this.lblFormas.Text = "FORMAS STUDIO";
            this.lblFormas.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btnIniciarSesion.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnIniciarSesion.Location = new System.Drawing.Point(71, 164);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(102, 36);
            this.btnIniciarSesion.TabIndex = 1;
            this.btnIniciarSesion.Text = "Iniciar Sesión ";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(71, 82);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(147, 20);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.ForeColor = System.Drawing.SystemColors.Info;
            this.LblUsuario.Location = new System.Drawing.Point(67, 59);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(64, 20);
            this.LblUsuario.TabIndex = 3;
            this.LblUsuario.Text = "Usuario";
            // 
            // lblcontraseña
            // 
            this.lblcontraseña.AutoSize = true;
            this.lblcontraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontraseña.ForeColor = System.Drawing.SystemColors.Info;
            this.lblcontraseña.Location = new System.Drawing.Point(67, 105);
            this.lblcontraseña.Name = "lblcontraseña";
            this.lblcontraseña.Size = new System.Drawing.Size(92, 20);
            this.lblcontraseña.TabIndex = 4;
            this.lblcontraseña.Text = "Contraseña";
            this.lblcontraseña.Click += new System.EventHandler(this.lblcontraseña_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(71, 128);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(147, 20);
            this.txtContraseña.TabIndex = 5;
            // 
            // lblOlvideContraseña
            // 
            this.lblOlvideContraseña.AutoSize = true;
            this.lblOlvideContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOlvideContraseña.LinkColor = System.Drawing.Color.White;
            this.lblOlvideContraseña.Location = new System.Drawing.Point(68, 215);
            this.lblOlvideContraseña.Name = "lblOlvideContraseña";
            this.lblOlvideContraseña.Size = new System.Drawing.Size(122, 15);
            this.lblOlvideContraseña.TabIndex = 6;
            this.lblOlvideContraseña.TabStop = true;
            this.lblOlvideContraseña.Text = "Olvide mi contraseña";
            this.lblOlvideContraseña.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblOlvideContraseña_LinkClicked);
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(330, 318);
            this.Controls.Add(this.lblOlvideContraseña);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lblcontraseña);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.lblFormas);
            this.Name = "InicioSesion";
            this.Text = "InicioSesion";
            this.Load += new System.EventHandler(this.Menú_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Label lblFormas;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label lblcontraseña;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.LinkLabel lblOlvideContraseña;
    }
}

