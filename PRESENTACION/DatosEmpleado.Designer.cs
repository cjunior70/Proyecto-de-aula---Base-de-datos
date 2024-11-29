namespace PRESENTACION
{
    partial class DatosEmpleado
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.picTrayctoria = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridListaServicioEmpleado = new System.Windows.Forms.DataGridView();
            this.dataGridListaServiciosSeleccionado = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbPrimerNombre = new System.Windows.Forms.Label();
            this.lbCedula = new System.Windows.Forms.Label();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.lbEstado = new System.Windows.Forms.Label();
            this.lbSegundoNombre = new System.Windows.Forms.Label();
            this.lbSexo = new System.Windows.Forms.Label();
            this.lbCorreoElec = new System.Windows.Forms.Label();
            this.btGuardarDatosReservacion = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTrayctoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListaServicioEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListaServiciosSeleccionado)).BeginInit();
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
            this.panel5.Size = new System.Drawing.Size(1209, 50);
            this.panel5.TabIndex = 39;
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.MediumBlue;
            this.btClose.BackgroundImage = global::PRESENTACION.Properties.Resources.icons8_cerrar_ventana_48;
            this.btClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btClose.Location = new System.Drawing.Point(1158, 0);
            this.btClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(51, 50);
            this.btClose.TabIndex = 0;
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lbCorreoElec);
            this.panel1.Controls.Add(this.lbSexo);
            this.panel1.Controls.Add(this.lbSegundoNombre);
            this.panel1.Controls.Add(this.lbEstado);
            this.panel1.Controls.Add(this.lbTelefono);
            this.panel1.Controls.Add(this.lbCedula);
            this.panel1.Controls.Add(this.lbPrimerNombre);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.picTrayctoria);
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1212, 299);
            this.panel1.TabIndex = 40;
            // 
            // picTrayctoria
            // 
            this.picTrayctoria.BackColor = System.Drawing.Color.DarkBlue;
            this.picTrayctoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picTrayctoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picTrayctoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picTrayctoria.Location = new System.Drawing.Point(33, 35);
            this.picTrayctoria.Margin = new System.Windows.Forms.Padding(4);
            this.picTrayctoria.Name = "picTrayctoria";
            this.picTrayctoria.Size = new System.Drawing.Size(198, 201);
            this.picTrayctoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTrayctoria.TabIndex = 41;
            this.picTrayctoria.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(358, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 31);
            this.label1.TabIndex = 42;
            this.label1.Text = "Primer nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(358, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 31);
            this.label2.TabIndex = 43;
            this.label2.Text = "Telefono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(358, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 31);
            this.label3.TabIndex = 44;
            this.label3.Text = "Cedula:";
            // 
            // dataGridListaServicioEmpleado
            // 
            this.dataGridListaServicioEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListaServicioEmpleado.Location = new System.Drawing.Point(12, 396);
            this.dataGridListaServicioEmpleado.Name = "dataGridListaServicioEmpleado";
            this.dataGridListaServicioEmpleado.RowHeadersWidth = 51;
            this.dataGridListaServicioEmpleado.RowTemplate.Height = 24;
            this.dataGridListaServicioEmpleado.Size = new System.Drawing.Size(590, 242);
            this.dataGridListaServicioEmpleado.TabIndex = 41;
            // 
            // dataGridListaServiciosSeleccionado
            // 
            this.dataGridListaServiciosSeleccionado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListaServiciosSeleccionado.Location = new System.Drawing.Point(637, 396);
            this.dataGridListaServiciosSeleccionado.Name = "dataGridListaServiciosSeleccionado";
            this.dataGridListaServiciosSeleccionado.RowHeadersWidth = 51;
            this.dataGridListaServiciosSeleccionado.RowTemplate.Height = 24;
            this.dataGridListaServiciosSeleccionado.Size = new System.Drawing.Size(560, 187);
            this.dataGridListaServiciosSeleccionado.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(109, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(393, 31);
            this.label4.TabIndex = 45;
            this.label4.Text = "Servicios de empleados disponibles";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(788, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 31);
            this.label5.TabIndex = 46;
            this.label5.Text = "Servicios seleccionados";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(358, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 31);
            this.label6.TabIndex = 45;
            this.label6.Text = "Estado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(775, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 31);
            this.label7.TabIndex = 46;
            this.label7.Text = "Sexo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(775, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 31);
            this.label8.TabIndex = 47;
            this.label8.Text = "Sgundo nombre:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(763, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(218, 31);
            this.label9.TabIndex = 48;
            this.label9.Text = "Correo Electronico:";
            // 
            // lbPrimerNombre
            // 
            this.lbPrimerNombre.AutoSize = true;
            this.lbPrimerNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbPrimerNombre.Location = new System.Drawing.Point(540, 52);
            this.lbPrimerNombre.Name = "lbPrimerNombre";
            this.lbPrimerNombre.Size = new System.Drawing.Size(74, 28);
            this.lbPrimerNombre.TabIndex = 49;
            this.lbPrimerNombre.Text = "label10";
            // 
            // lbCedula
            // 
            this.lbCedula.AutoSize = true;
            this.lbCedula.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbCedula.Location = new System.Drawing.Point(461, 116);
            this.lbCedula.Name = "lbCedula";
            this.lbCedula.Size = new System.Drawing.Size(71, 28);
            this.lbCedula.TabIndex = 50;
            this.lbCedula.Text = "label11";
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbTelefono.Location = new System.Drawing.Point(483, 182);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(74, 28);
            this.lbTelefono.TabIndex = 51;
            this.lbTelefono.Text = "label12";
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbEstado.Location = new System.Drawing.Point(461, 252);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(74, 28);
            this.lbEstado.TabIndex = 52;
            this.lbEstado.Text = "label13";
            // 
            // lbSegundoNombre
            // 
            this.lbSegundoNombre.AutoSize = true;
            this.lbSegundoNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbSegundoNombre.Location = new System.Drawing.Point(977, 53);
            this.lbSegundoNombre.Name = "lbSegundoNombre";
            this.lbSegundoNombre.Size = new System.Drawing.Size(75, 28);
            this.lbSegundoNombre.TabIndex = 53;
            this.lbSegundoNombre.Text = "label14";
            // 
            // lbSexo
            // 
            this.lbSexo.AutoSize = true;
            this.lbSexo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbSexo.Location = new System.Drawing.Point(858, 120);
            this.lbSexo.Name = "lbSexo";
            this.lbSexo.Size = new System.Drawing.Size(74, 28);
            this.lbSexo.TabIndex = 54;
            this.lbSexo.Text = "label15";
            // 
            // lbCorreoElec
            // 
            this.lbCorreoElec.AutoSize = true;
            this.lbCorreoElec.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbCorreoElec.Location = new System.Drawing.Point(981, 195);
            this.lbCorreoElec.Name = "lbCorreoElec";
            this.lbCorreoElec.Size = new System.Drawing.Size(74, 28);
            this.lbCorreoElec.TabIndex = 55;
            this.lbCorreoElec.Text = "label16";
            // 
            // btGuardarDatosReservacion
            // 
            this.btGuardarDatosReservacion.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardarDatosReservacion.Location = new System.Drawing.Point(666, 589);
            this.btGuardarDatosReservacion.Name = "btGuardarDatosReservacion";
            this.btGuardarDatosReservacion.Size = new System.Drawing.Size(514, 48);
            this.btGuardarDatosReservacion.TabIndex = 47;
            this.btGuardarDatosReservacion.Text = "Guardar datos en la reservacion";
            this.btGuardarDatosReservacion.UseVisualStyleBackColor = true;
            // 
            // DatosEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 650);
            this.Controls.Add(this.btGuardarDatosReservacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridListaServiciosSeleccionado);
            this.Controls.Add(this.dataGridListaServicioEmpleado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DatosEmpleado";
            this.Text = "DatosEmpleado";
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTrayctoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListaServicioEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListaServiciosSeleccionado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picTrayctoria;
        private System.Windows.Forms.DataGridView dataGridListaServicioEmpleado;
        private System.Windows.Forms.DataGridView dataGridListaServiciosSeleccionado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbSexo;
        private System.Windows.Forms.Label lbSegundoNombre;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.Label lbCedula;
        private System.Windows.Forms.Label lbPrimerNombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbCorreoElec;
        private System.Windows.Forms.Button btGuardarDatosReservacion;
    }
}