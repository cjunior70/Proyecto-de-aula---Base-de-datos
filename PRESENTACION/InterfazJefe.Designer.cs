namespace PRESENTACION
{
    partial class InterfazJefe
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.btClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btRegisClient = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridJefe = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridJefe)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkBlue;
            this.panel2.Controls.Add(this.btRegisClient);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(1070, 54);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 600);
            this.panel2.TabIndex = 39;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.AliceBlue;
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(13, 103);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(255, 481);
            this.panel3.TabIndex = 0;
            // 
            // btRegisClient
            // 
            this.btRegisClient.BackColor = System.Drawing.Color.DarkBlue;
            this.btRegisClient.CausesValidation = false;
            this.btRegisClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRegisClient.Image = global::PRESENTACION.Properties.Resources.icons8_usuario_501;
            this.btRegisClient.Location = new System.Drawing.Point(117, 25);
            this.btRegisClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btRegisClient.Name = "btRegisClient";
            this.btRegisClient.Size = new System.Drawing.Size(61, 57);
            this.btRegisClient.TabIndex = 27;
            this.btRegisClient.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12.2F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(66, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 30);
            this.label12.TabIndex = 21;
            this.label12.Text = "Empleados";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12.2F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(65, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 30);
            this.label11.TabIndex = 20;
            this.label11.Text = "Trayectoria";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 18.2F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(15, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(225, 42);
            this.label10.TabIndex = 19;
            this.label10.Text = "Reservaciones";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnVolver);
            this.panel1.Location = new System.Drawing.Point(0, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1077, 706);
            this.panel1.TabIndex = 29;
            // 
            // dataGridJefe
            // 
            this.dataGridJefe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridJefe.Location = new System.Drawing.Point(17, 95);
            this.dataGridJefe.Name = "dataGridJefe";
            this.dataGridJefe.RowHeadersWidth = 51;
            this.dataGridJefe.RowTemplate.Height = 24;
            this.dataGridJefe.Size = new System.Drawing.Size(976, 403);
            this.dataGridJefe.TabIndex = 27;
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
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.dataGridJefe);
            this.panel4.Location = new System.Drawing.Point(25, 61);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1014, 523);
            this.panel4.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(356, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 42);
            this.label1.TabIndex = 22;
            this.label1.Text = "Empleados";
            // 
            // InterfazJefe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 650);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InterfazJefe";
            this.Text = "InterfazJefe";
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridJefe)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btRegisClient;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridJefe;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
    }
}