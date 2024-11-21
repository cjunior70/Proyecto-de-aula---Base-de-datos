namespace PRESENTACION
{
    partial class TrabajadorUsuario
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btGuardarDatosT = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btCerrar = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.MediumBlue;
            this.flowLayoutPanel1.Controls.Add(this.btnVolver);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 49);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(282, 732);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btGuardarDatosT);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(428, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 545);
            this.panel1.TabIndex = 1;
            // 
            // btGuardarDatosT
            // 
            this.btGuardarDatosT.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardarDatosT.Location = new System.Drawing.Point(209, 484);
            this.btGuardarDatosT.Name = "btGuardarDatosT";
            this.btGuardarDatosT.Size = new System.Drawing.Size(202, 44);
            this.btGuardarDatosT.TabIndex = 20;
            this.btGuardarDatosT.Text = "Guardar Datos";
            this.btGuardarDatosT.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(74, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 31);
            this.label4.TabIndex = 14;
            this.label4.Text = "Estado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(74, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 31);
            this.label3.TabIndex = 13;
            this.label3.Text = "Experiencias";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(74, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "limite de cupos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(145, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 45);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.MediumBlue;
            this.btnVolver.BackgroundImage = global::PRESENTACION.Properties.Resources.icons8_regreso_50;
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVolver.Location = new System.Drawing.Point(4, 4);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(73, 68);
            this.btnVolver.TabIndex = 26;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MediumBlue;
            this.panel5.Controls.Add(this.btCerrar);
            this.panel5.Location = new System.Drawing.Point(1, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(987, 43);
            this.panel5.TabIndex = 35;
            // 
            // btCerrar
            // 
            this.btCerrar.BackColor = System.Drawing.Color.MediumBlue;
            this.btCerrar.BackgroundImage = global::PRESENTACION.Properties.Resources.icons8_cerrar_ventana_48;
            this.btCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btCerrar.Location = new System.Drawing.Point(937, 0);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(50, 43);
            this.btCerrar.TabIndex = 0;
            this.btCerrar.UseVisualStyleBackColor = false;
            this.btCerrar.Click += new System.EventHandler(this.btCerrar_Click);
            // 
            // TrabajadorUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TrabajadorUsuario";
            this.Text = "TrabajadorUsuario";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btGuardarDatosT;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btCerrar;
    }
}