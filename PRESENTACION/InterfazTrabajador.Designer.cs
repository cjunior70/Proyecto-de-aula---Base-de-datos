namespace PRESENTACION
{
    partial class InterfazTrabajador
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btComenzarServicio = new System.Windows.Forms.Button();
            this.textFecha = new System.Windows.Forms.TextBox();
            this.textNomb = new System.Windows.Forms.TextBox();
            this.txtTiemp = new System.Windows.Forms.TextBox();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btRegisClient = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridTrabajdor = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTrabajdor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkBlue;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(1052, 54);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(298, 603);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.btRegisClient);
            this.panel3.Controls.Add(this.btComenzarServicio);
            this.panel3.Controls.Add(this.textFecha);
            this.panel3.Controls.Add(this.textNomb);
            this.panel3.Controls.Add(this.txtTiemp);
            this.panel3.Controls.Add(this.txtPago);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(13, 23);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(273, 550);
            this.panel3.TabIndex = 0;
            // 
            // btComenzarServicio
            // 
            this.btComenzarServicio.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btComenzarServicio.Location = new System.Drawing.Point(76, 457);
            this.btComenzarServicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btComenzarServicio.Name = "btComenzarServicio";
            this.btComenzarServicio.Size = new System.Drawing.Size(132, 63);
            this.btComenzarServicio.TabIndex = 19;
            this.btComenzarServicio.Text = "Comenzar Servicio";
            this.btComenzarServicio.UseVisualStyleBackColor = true;
            // 
            // textFecha
            // 
            this.textFecha.Location = new System.Drawing.Point(61, 172);
            this.textFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textFecha.Name = "textFecha";
            this.textFecha.Size = new System.Drawing.Size(148, 22);
            this.textFecha.TabIndex = 26;
            // 
            // textNomb
            // 
            this.textNomb.Location = new System.Drawing.Point(61, 242);
            this.textNomb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textNomb.Name = "textNomb";
            this.textNomb.Size = new System.Drawing.Size(148, 22);
            this.textNomb.TabIndex = 25;
            // 
            // txtTiemp
            // 
            this.txtTiemp.Location = new System.Drawing.Point(60, 313);
            this.txtTiemp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTiemp.Name = "txtTiemp";
            this.txtTiemp.Size = new System.Drawing.Size(148, 22);
            this.txtTiemp.TabIndex = 24;
            // 
            // txtPago
            // 
            this.txtPago.Location = new System.Drawing.Point(60, 394);
            this.txtPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(148, 22);
            this.txtPago.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12.2F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(99, 353);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 30);
            this.label14.TabIndex = 23;
            this.label14.Text = "Precio";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12.2F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(27, 282);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(226, 30);
            this.label13.TabIndex = 22;
            this.label13.Text = "Tiempo para terminar";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12.2F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(88, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 30);
            this.label12.TabIndex = 21;
            this.label12.Text = "Nombre";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12.2F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(60, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 30);
            this.label11.TabIndex = 20;
            this.label11.Text = "Fecha y hora";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 18.2F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(23, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(247, 42);
            this.label10.TabIndex = 19;
            this.label10.Text = "Proximo cliente";
            // 
            // btRegisClient
            // 
            this.btRegisClient.BackColor = System.Drawing.Color.DarkBlue;
            this.btRegisClient.CausesValidation = false;
            this.btRegisClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRegisClient.Image = global::PRESENTACION.Properties.Resources.icons8_usuario_501;
            this.btRegisClient.Location = new System.Drawing.Point(112, 16);
            this.btRegisClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btRegisClient.Name = "btRegisClient";
            this.btRegisClient.Size = new System.Drawing.Size(61, 57);
            this.btRegisClient.TabIndex = 27;
            this.btRegisClient.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MediumBlue;
            this.panel5.Controls.Add(this.btClose);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1350, 52);
            this.panel5.TabIndex = 38;
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.MediumBlue;
            this.btClose.BackgroundImage = global::PRESENTACION.Properties.Resources.icons8_cerrar_ventana_48;
            this.btClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btClose.Location = new System.Drawing.Point(1300, 0);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(50, 52);
            this.btClose.TabIndex = 0;
            this.btClose.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnVolver);
            this.panel1.Location = new System.Drawing.Point(0, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1059, 706);
            this.panel1.TabIndex = 28;
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.dataGridTrabajdor);
            this.panel4.Location = new System.Drawing.Point(32, 61);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1014, 523);
            this.panel4.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 42);
            this.label1.TabIndex = 22;
            this.label1.Text = "Servicios de hoy";
            // 
            // dataGridTrabajdor
            // 
            this.dataGridTrabajdor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTrabajdor.Location = new System.Drawing.Point(17, 95);
            this.dataGridTrabajdor.Name = "dataGridTrabajdor";
            this.dataGridTrabajdor.RowHeadersWidth = 51;
            this.dataGridTrabajdor.RowTemplate.Height = 24;
            this.dataGridTrabajdor.Size = new System.Drawing.Size(976, 403);
            this.dataGridTrabajdor.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(365, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 42);
            this.label2.TabIndex = 28;
            this.label2.Text = "Total de Clientes";
            // 
            // InterfazTrabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 650);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InterfazTrabajador";
            this.Text = "InterfazTrabajador";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTrabajdor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btRegisClient;
        private System.Windows.Forms.Button btComenzarServicio;
        private System.Windows.Forms.TextBox textFecha;
        private System.Windows.Forms.TextBox textNomb;
        private System.Windows.Forms.TextBox txtTiemp;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridTrabajdor;
    }
}