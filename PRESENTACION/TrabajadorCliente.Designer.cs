namespace PRESENTACION
{
    partial class TrabajadorCliente
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombreDeLaEmpresa = new System.Windows.Forms.Label();
            this.btSeleccionarEmple = new System.Windows.Forms.Button();
            this.btCancelarReservacion = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(679, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 493);
            this.panel1.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(55, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(192, 100);
            this.label10.TabIndex = 21;
            this.label10.Text = "Conoce al\r\nequipo\r\n";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.btnVolver);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblNombreDeLaEmpresa);
            this.panel2.Location = new System.Drawing.Point(-56, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(729, 706);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(420, 517);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 38);
            this.label2.TabIndex = 32;
            this.label2.Text = "Yair Pérez";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(420, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 38);
            this.label1.TabIndex = 31;
            this.label1.Text = "Jimena Domech";
            // 
            // lblNombreDeLaEmpresa
            // 
            this.lblNombreDeLaEmpresa.AutoSize = true;
            this.lblNombreDeLaEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreDeLaEmpresa.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblNombreDeLaEmpresa.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombreDeLaEmpresa.Location = new System.Drawing.Point(420, 69);
            this.lblNombreDeLaEmpresa.Name = "lblNombreDeLaEmpresa";
            this.lblNombreDeLaEmpresa.Size = new System.Drawing.Size(227, 38);
            this.lblNombreDeLaEmpresa.TabIndex = 30;
            this.lblNombreDeLaEmpresa.Text = "Jimena Domech";
            // 
            // btSeleccionarEmple
            // 
            this.btSeleccionarEmple.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSeleccionarEmple.Location = new System.Drawing.Point(700, 564);
            this.btSeleccionarEmple.Name = "btSeleccionarEmple";
            this.btSeleccionarEmple.Size = new System.Drawing.Size(249, 41);
            this.btSeleccionarEmple.TabIndex = 22;
            this.btSeleccionarEmple.Text = "Seleccionar empleado";
            this.btSeleccionarEmple.UseVisualStyleBackColor = true;
            // 
            // btCancelarReservacion
            // 
            this.btCancelarReservacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelarReservacion.Location = new System.Drawing.Point(700, 647);
            this.btCancelarReservacion.Name = "btCancelarReservacion";
            this.btCancelarReservacion.Size = new System.Drawing.Size(249, 41);
            this.btCancelarReservacion.TabIndex = 23;
            this.btCancelarReservacion.Text = "Cancelar reservacion";
            this.btCancelarReservacion.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnVolver.BackgroundImage = global::PRESENTACION.Properties.Resources.icons8_regreso_50;
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVolver.Location = new System.Drawing.Point(57, 620);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(73, 68);
            this.btnVolver.TabIndex = 26;
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MediumBlue;
            this.panel5.Controls.Add(this.button1);
            this.panel5.Location = new System.Drawing.Point(1, -8);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(979, 52);
            this.panel5.TabIndex = 35;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumBlue;
            this.button1.BackgroundImage = global::PRESENTACION.Properties.Resources.icons8_cerrar_ventana_48;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(929, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 52);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TrabajadorCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumBlue;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btCancelarReservacion);
            this.Controls.Add(this.btSeleccionarEmple);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TrabajadorCliente";
            this.Text = "TrabajadorCliente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombreDeLaEmpresa;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btSeleccionarEmple;
        private System.Windows.Forms.Button btCancelarReservacion;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button1;
    }
}