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
            this.btRegisClient = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picEmpleados = new System.Windows.Forms.PictureBox();
            this.picTrayctoria = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridJefe = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTrayctoria)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridJefe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MediumBlue;
            this.panel5.Controls.Add(this.btClose);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1349, 50);
            this.panel5.TabIndex = 38;
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.MediumBlue;
            this.btClose.BackgroundImage = global::PRESENTACION.Properties.Resources.icons8_cerrar_ventana_48;
            this.btClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btClose.Location = new System.Drawing.Point(1298, 0);
            this.btClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(51, 50);
            this.btClose.TabIndex = 0;
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkBlue;
            this.panel2.Controls.Add(this.btRegisClient);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(1069, 54);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 601);
            this.panel2.TabIndex = 39;
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
            this.btRegisClient.Click += new System.EventHandler(this.btRegisClient_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.AliceBlue;
            this.panel3.Controls.Add(this.picEmpleados);
            this.panel3.Controls.Add(this.picTrayctoria);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(13, 103);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(255, 481);
            this.panel3.TabIndex = 0;
            // 
            // picEmpleados
            // 
            this.picEmpleados.BackColor = System.Drawing.Color.DarkGray;
            this.picEmpleados.BackgroundImage = global::PRESENTACION.Properties.Resources.clasificacion;
            this.picEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEmpleados.Location = new System.Drawing.Point(40, 305);
            this.picEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.picEmpleados.Name = "picEmpleados";
            this.picEmpleados.Size = new System.Drawing.Size(170, 148);
            this.picEmpleados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEmpleados.TabIndex = 23;
            this.picEmpleados.TabStop = false;
            // 
            // picTrayctoria
            // 
            this.picTrayctoria.BackColor = System.Drawing.Color.DarkBlue;
            this.picTrayctoria.BackgroundImage = global::PRESENTACION.Properties.Resources.grafico_diagramas;
            this.picTrayctoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picTrayctoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picTrayctoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picTrayctoria.Location = new System.Drawing.Point(40, 106);
            this.picTrayctoria.Margin = new System.Windows.Forms.Padding(4);
            this.picTrayctoria.Name = "picTrayctoria";
            this.picTrayctoria.Size = new System.Drawing.Size(170, 148);
            this.picTrayctoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTrayctoria.TabIndex = 22;
            this.picTrayctoria.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12.2F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(64, 258);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 30);
            this.label12.TabIndex = 21;
            this.label12.Text = "Empleados";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12.2F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(63, 72);
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
            this.label10.Location = new System.Drawing.Point(15, 14);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1077, 706);
            this.panel1.TabIndex = 29;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.btVolver);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.dataGridJefe);
            this.panel4.Location = new System.Drawing.Point(26, 37);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1012, 548);
            this.panel4.TabIndex = 28;
            // 
            // btVolver
            // 
            this.btVolver.BackColor = System.Drawing.Color.SteelBlue;
            this.btVolver.CausesValidation = false;
            this.btVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btVolver.Image = global::PRESENTACION.Properties.Resources.icons8_regreso_50;
            this.btVolver.Location = new System.Drawing.Point(3, 491);
            this.btVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(61, 57);
            this.btVolver.TabIndex = 28;
            this.btVolver.UseVisualStyleBackColor = false;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(398, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 42);
            this.label1.TabIndex = 22;
            this.label1.Text = "Empleados";
            // 
            // dataGridJefe
            // 
            this.dataGridJefe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridJefe.Location = new System.Drawing.Point(19, 80);
            this.dataGridJefe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridJefe.Name = "dataGridJefe";
            this.dataGridJefe.RowHeadersWidth = 51;
            this.dataGridJefe.RowTemplate.Height = 24;
            this.dataGridJefe.Size = new System.Drawing.Size(975, 395);
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
            // InterfazJefe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 650);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InterfazJefe";
            this.Text = "InterfazJefe";
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTrayctoria)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridJefe)).EndInit();
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
        private System.Windows.Forms.Button btVolver;
        private System.Windows.Forms.PictureBox picEmpleados;
        private System.Windows.Forms.PictureBox picTrayctoria;
    }
}