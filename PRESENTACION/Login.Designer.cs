namespace PRESENTACION
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbContactos = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TboxContraseña = new RJCodeAdvance.RJControls.RJTextBox();
            this.TboxUsuario = new RJCodeAdvance.RJControls.RJTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbEntrar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbRegistrarme = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.lbContactos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(708, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 553);
            this.panel1.TabIndex = 0;
            // 
            // lbContactos
            // 
            this.lbContactos.AutoSize = true;
            this.lbContactos.Font = new System.Drawing.Font("Heebo", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContactos.ForeColor = System.Drawing.SystemColors.Control;
            this.lbContactos.Location = new System.Drawing.Point(61, 500);
            this.lbContactos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbContactos.Name = "lbContactos";
            this.lbContactos.Size = new System.Drawing.Size(162, 44);
            this.lbContactos.TabIndex = 3;
            this.lbContactos.Text = "contactos";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.TboxContraseña);
            this.panel2.Controls.Add(this.TboxUsuario);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lbEntrar);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(45, 48);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(788, 424);
            this.panel2.TabIndex = 1;
            // 
            // TboxContraseña
            // 
            this.TboxContraseña.BackColor = System.Drawing.SystemColors.Window;
            this.TboxContraseña.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TboxContraseña.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TboxContraseña.BorderRadius = 0;
            this.TboxContraseña.BorderSize = 2;
            this.TboxContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TboxContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TboxContraseña.Location = new System.Drawing.Point(479, 234);
            this.TboxContraseña.Multiline = false;
            this.TboxContraseña.Name = "TboxContraseña";
            this.TboxContraseña.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.TboxContraseña.PasswordChar = true;
            this.TboxContraseña.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TboxContraseña.PlaceholderText = "";
            this.TboxContraseña.Size = new System.Drawing.Size(243, 33);
            this.TboxContraseña.TabIndex = 7;
            this.TboxContraseña.Texts = "";
            this.TboxContraseña.UnderlinedStyle = false;
            // 
            // TboxUsuario
            // 
            this.TboxUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.TboxUsuario.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TboxUsuario.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TboxUsuario.BorderRadius = 0;
            this.TboxUsuario.BorderSize = 2;
            this.TboxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TboxUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TboxUsuario.Location = new System.Drawing.Point(479, 161);
            this.TboxUsuario.Multiline = false;
            this.TboxUsuario.Name = "TboxUsuario";
            this.TboxUsuario.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.TboxUsuario.PasswordChar = true;
            this.TboxUsuario.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TboxUsuario.PlaceholderText = "";
            this.TboxUsuario.Size = new System.Drawing.Size(243, 33);
            this.TboxUsuario.TabIndex = 6;
            this.TboxUsuario.Texts = "";
            this.TboxUsuario.UnderlinedStyle = false;
            this.TboxUsuario._TextChanged += new System.EventHandler(this.rjTextBox1__TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(118, 221);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 46);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(118, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario";
            // 
            // lbEntrar
            // 
            this.lbEntrar.AutoSize = true;
            this.lbEntrar.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lbEntrar.ForeColor = System.Drawing.SystemColors.Control;
            this.lbEntrar.Location = new System.Drawing.Point(335, 344);
            this.lbEntrar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEntrar.Name = "lbEntrar";
            this.lbEntrar.Size = new System.Drawing.Size(118, 46);
            this.lbEntrar.TabIndex = 2;
            this.lbEntrar.Text = "Entrar";
            this.lbEntrar.Click += new System.EventHandler(this.lbEntrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(28, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 112);
            this.label2.TabIndex = 1;
            this.label2.Text = "QR8";
            // 
            // lbRegistrarme
            // 
            this.lbRegistrarme.AutoSize = true;
            this.lbRegistrarme.Font = new System.Drawing.Font("Heebo", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegistrarme.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbRegistrarme.Location = new System.Drawing.Point(316, 500);
            this.lbRegistrarme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRegistrarme.Name = "lbRegistrarme";
            this.lbRegistrarme.Size = new System.Drawing.Size(191, 44);
            this.lbRegistrarme.TabIndex = 4;
            this.lbRegistrarme.Text = "Registrarme";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.lbRegistrarme);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbEntrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbContactos;
        private System.Windows.Forms.Label lbRegistrarme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label3;
        private RJCodeAdvance.RJControls.RJTextBox TboxUsuario;
        private RJCodeAdvance.RJControls.RJTextBox TboxContraseña;
    }
}

