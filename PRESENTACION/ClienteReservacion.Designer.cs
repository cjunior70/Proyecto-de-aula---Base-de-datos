namespace PRESENTACION
{
    partial class ClienteReservacion
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
            this.lblDatosDeLaReservacion = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbxMinutos = new System.Windows.Forms.ComboBox();
            this.cbxSegundos = new System.Windows.Forms.ComboBox();
            this.cbxHora = new System.Windows.Forms.ComboBox();
            this.lblHoraSeleccionada = new System.Windows.Forms.Label();
            this.dtpFechaSeleccionada = new System.Windows.Forms.DateTimePicker();
            this.dgEmpleadosSeleccionados = new System.Windows.Forms.DataGridView();
            this.btnAgregarEmpleadoYSusServicios = new System.Windows.Forms.Button();
            this.btnReservacion = new System.Windows.Forms.Button();
            this.txtHoraDisponibles = new System.Windows.Forms.TextBox();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEmpleadoDeseadosYServiciosDisponibles = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHoraDisponibles = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblEmpleadosDisponibles = new System.Windows.Forms.Label();
            this.dtgEmpleadosDisponibles = new System.Windows.Forms.DataGridView();
            this.dtgServiciosDisponibles = new System.Windows.Forms.DataGridView();
            this.pnlAtras = new System.Windows.Forms.Panel();
            this.lblModificarServicios = new System.Windows.Forms.Label();
            this.lblNombreDeLaEmpresa = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleadosSeleccionados)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleadosDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgServiciosDisponibles)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.lblDatosDeLaReservacion);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(382, 42);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 567);
            this.panel1.TabIndex = 0;
            // 
            // lblDatosDeLaReservacion
            // 
            this.lblDatosDeLaReservacion.AutoSize = true;
            this.lblDatosDeLaReservacion.BackColor = System.Drawing.Color.Transparent;
            this.lblDatosDeLaReservacion.Font = new System.Drawing.Font("Segoe UI", 18.2F, System.Drawing.FontStyle.Bold);
            this.lblDatosDeLaReservacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDatosDeLaReservacion.Location = new System.Drawing.Point(162, 16);
            this.lblDatosDeLaReservacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatosDeLaReservacion.Name = "lblDatosDeLaReservacion";
            this.lblDatosDeLaReservacion.Size = new System.Drawing.Size(156, 35);
            this.lblDatosDeLaReservacion.TabIndex = 20;
            this.lblDatosDeLaReservacion.Text = "Reservacion";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel4.Controls.Add(this.cbxMinutos);
            this.panel4.Controls.Add(this.cbxSegundos);
            this.panel4.Controls.Add(this.cbxHora);
            this.panel4.Controls.Add(this.lblHoraSeleccionada);
            this.panel4.Controls.Add(this.dtpFechaSeleccionada);
            this.panel4.Controls.Add(this.dgEmpleadosSeleccionados);
            this.panel4.Controls.Add(this.btnAgregarEmpleadoYSusServicios);
            this.panel4.Controls.Add(this.btnReservacion);
            this.panel4.Controls.Add(this.txtHoraDisponibles);
            this.panel4.Controls.Add(this.txtPago);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.lblEmpleadoDeseadosYServiciosDisponibles);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.lblHoraDisponibles);
            this.panel4.Controls.Add(this.lblFecha);
            this.panel4.Location = new System.Drawing.Point(28, 52);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(408, 507);
            this.panel4.TabIndex = 0;
            // 
            // cbxMinutos
            // 
            this.cbxMinutos.FormattingEnabled = true;
            this.cbxMinutos.Location = new System.Drawing.Point(80, 110);
            this.cbxMinutos.Name = "cbxMinutos";
            this.cbxMinutos.Size = new System.Drawing.Size(45, 21);
            this.cbxMinutos.TabIndex = 46;
            // 
            // cbxSegundos
            // 
            this.cbxSegundos.FormattingEnabled = true;
            this.cbxSegundos.Location = new System.Drawing.Point(140, 110);
            this.cbxSegundos.Name = "cbxSegundos";
            this.cbxSegundos.Size = new System.Drawing.Size(45, 21);
            this.cbxSegundos.TabIndex = 45;
            // 
            // cbxHora
            // 
            this.cbxHora.FormattingEnabled = true;
            this.cbxHora.Location = new System.Drawing.Point(18, 110);
            this.cbxHora.Name = "cbxHora";
            this.cbxHora.Size = new System.Drawing.Size(45, 21);
            this.cbxHora.TabIndex = 44;
            // 
            // lblHoraSeleccionada
            // 
            this.lblHoraSeleccionada.AutoSize = true;
            this.lblHoraSeleccionada.BackColor = System.Drawing.Color.Transparent;
            this.lblHoraSeleccionada.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblHoraSeleccionada.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHoraSeleccionada.Location = new System.Drawing.Point(15, 71);
            this.lblHoraSeleccionada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoraSeleccionada.Name = "lblHoraSeleccionada";
            this.lblHoraSeleccionada.Size = new System.Drawing.Size(180, 30);
            this.lblHoraSeleccionada.TabIndex = 42;
            this.lblHoraSeleccionada.Text = "Hora Disponible";
            // 
            // dtpFechaSeleccionada
            // 
            this.dtpFechaSeleccionada.Location = new System.Drawing.Point(64, 48);
            this.dtpFechaSeleccionada.Name = "dtpFechaSeleccionada";
            this.dtpFechaSeleccionada.Size = new System.Drawing.Size(291, 20);
            this.dtpFechaSeleccionada.TabIndex = 41;
            // 
            // dgEmpleadosSeleccionados
            // 
            this.dgEmpleadosSeleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmpleadosSeleccionados.Location = new System.Drawing.Point(20, 171);
            this.dgEmpleadosSeleccionados.Name = "dgEmpleadosSeleccionados";
            this.dgEmpleadosSeleccionados.Size = new System.Drawing.Size(369, 159);
            this.dgEmpleadosSeleccionados.TabIndex = 39;
            // 
            // btnAgregarEmpleadoYSusServicios
            // 
            this.btnAgregarEmpleadoYSusServicios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEmpleadoYSusServicios.Location = new System.Drawing.Point(223, 346);
            this.btnAgregarEmpleadoYSusServicios.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarEmpleadoYSusServicios.Name = "btnAgregarEmpleadoYSusServicios";
            this.btnAgregarEmpleadoYSusServicios.Size = new System.Drawing.Size(171, 32);
            this.btnAgregarEmpleadoYSusServicios.TabIndex = 38;
            this.btnAgregarEmpleadoYSusServicios.Text = "Seleccionar";
            this.btnAgregarEmpleadoYSusServicios.UseVisualStyleBackColor = true;
            this.btnAgregarEmpleadoYSusServicios.Click += new System.EventHandler(this.btAgregarEmpleado_Click);
            // 
            // btnReservacion
            // 
            this.btnReservacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservacion.Location = new System.Drawing.Point(204, 459);
            this.btnReservacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnReservacion.Name = "btnReservacion";
            this.btnReservacion.Size = new System.Drawing.Size(195, 37);
            this.btnReservacion.TabIndex = 21;
            this.btnReservacion.Text = "Hacer la reservacion";
            this.btnReservacion.UseVisualStyleBackColor = true;
            this.btnReservacion.Click += new System.EventHandler(this.btHReservacion_Click);
            // 
            // txtHoraDisponibles
            // 
            this.txtHoraDisponibles.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtHoraDisponibles.Location = new System.Drawing.Point(228, 106);
            this.txtHoraDisponibles.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoraDisponibles.Name = "txtHoraDisponibles";
            this.txtHoraDisponibles.Size = new System.Drawing.Size(127, 20);
            this.txtHoraDisponibles.TabIndex = 36;
            this.txtHoraDisponibles.Text = "7am - 5pm ";
            this.txtHoraDisponibles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPago
            // 
            this.txtPago.Location = new System.Drawing.Point(180, 419);
            this.txtPago.Margin = new System.Windows.Forms.Padding(2);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(219, 20);
            this.txtPago.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(22, 414);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total a pagar";
            // 
            // lblEmpleadoDeseadosYServiciosDisponibles
            // 
            this.lblEmpleadoDeseadosYServiciosDisponibles.AutoSize = true;
            this.lblEmpleadoDeseadosYServiciosDisponibles.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpleadoDeseadosYServiciosDisponibles.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblEmpleadoDeseadosYServiciosDisponibles.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEmpleadoDeseadosYServiciosDisponibles.Location = new System.Drawing.Point(22, 138);
            this.lblEmpleadoDeseadosYServiciosDisponibles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpleadoDeseadosYServiciosDisponibles.Name = "lblEmpleadoDeseadosYServiciosDisponibles";
            this.lblEmpleadoDeseadosYServiciosDisponibles.Size = new System.Drawing.Size(372, 30);
            this.lblEmpleadoDeseadosYServiciosDisponibles.TabIndex = 5;
            this.lblEmpleadoDeseadosYServiciosDisponibles.Text = "Empleado deseados y sus servicos ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(125, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 30);
            this.label3.TabIndex = 4;
            // 
            // lblHoraDisponibles
            // 
            this.lblHoraDisponibles.AutoSize = true;
            this.lblHoraDisponibles.BackColor = System.Drawing.Color.Transparent;
            this.lblHoraDisponibles.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblHoraDisponibles.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHoraDisponibles.Location = new System.Drawing.Point(199, 71);
            this.lblHoraDisponibles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoraDisponibles.Name = "lblHoraDisponibles";
            this.lblHoraDisponibles.Size = new System.Drawing.Size(190, 30);
            this.lblHoraDisponibles.TabIndex = 3;
            this.lblHoraDisponibles.Text = "Hora Disponibles";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblFecha.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFecha.Location = new System.Drawing.Point(165, 10);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(72, 30);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.lblEmpleadosDisponibles);
            this.panel3.Controls.Add(this.dtgEmpleadosDisponibles);
            this.panel3.Controls.Add(this.dtgServiciosDisponibles);
            this.panel3.Controls.Add(this.pnlAtras);
            this.panel3.Controls.Add(this.lblModificarServicios);
            this.panel3.Controls.Add(this.lblNombreDeLaEmpresa);
            this.panel3.Location = new System.Drawing.Point(0, 42);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(406, 567);
            this.panel3.TabIndex = 1;
            // 
            // lblEmpleadosDisponibles
            // 
            this.lblEmpleadosDisponibles.AutoSize = true;
            this.lblEmpleadosDisponibles.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpleadosDisponibles.Font = new System.Drawing.Font("Segoe UI", 12.2F, System.Drawing.FontStyle.Bold);
            this.lblEmpleadosDisponibles.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEmpleadosDisponibles.Location = new System.Drawing.Point(103, 312);
            this.lblEmpleadosDisponibles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpleadosDisponibles.Name = "lblEmpleadosDisponibles";
            this.lblEmpleadosDisponibles.Size = new System.Drawing.Size(195, 23);
            this.lblEmpleadosDisponibles.TabIndex = 48;
            this.lblEmpleadosDisponibles.Text = "Empleados Disponibles";
            // 
            // dtgEmpleadosDisponibles
            // 
            this.dtgEmpleadosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEmpleadosDisponibles.Location = new System.Drawing.Point(20, 347);
            this.dtgEmpleadosDisponibles.Name = "dtgEmpleadosDisponibles";
            this.dtgEmpleadosDisponibles.Size = new System.Drawing.Size(369, 159);
            this.dtgEmpleadosDisponibles.TabIndex = 47;
            // 
            // dtgServiciosDisponibles
            // 
            this.dtgServiciosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgServiciosDisponibles.Location = new System.Drawing.Point(20, 63);
            this.dtgServiciosDisponibles.Name = "dtgServiciosDisponibles";
            this.dtgServiciosDisponibles.Size = new System.Drawing.Size(369, 237);
            this.dtgServiciosDisponibles.TabIndex = 40;
            // 
            // pnlAtras
            // 
            this.pnlAtras.BackgroundImage = global::PRESENTACION.Properties.Resources.icons8_regreso_50;
            this.pnlAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlAtras.Location = new System.Drawing.Point(9, 522);
            this.pnlAtras.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAtras.Name = "pnlAtras";
            this.pnlAtras.Size = new System.Drawing.Size(37, 37);
            this.pnlAtras.TabIndex = 33;
            this.pnlAtras.Click += new System.EventHandler(this.VolvarADatosDeLaEmpresa);
            this.pnlAtras.DoubleClick += new System.EventHandler(this.VolvarADatosDeLaEmpresa);
            // 
            // lblModificarServicios
            // 
            this.lblModificarServicios.AutoSize = true;
            this.lblModificarServicios.BackColor = System.Drawing.Color.Transparent;
            this.lblModificarServicios.Font = new System.Drawing.Font("Segoe UI", 12.2F, System.Drawing.FontStyle.Bold);
            this.lblModificarServicios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblModificarServicios.Location = new System.Drawing.Point(225, 536);
            this.lblModificarServicios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModificarServicios.Name = "lblModificarServicios";
            this.lblModificarServicios.Size = new System.Drawing.Size(164, 23);
            this.lblModificarServicios.TabIndex = 32;
            this.lblModificarServicios.Text = "Modificar Servircio";
            // 
            // lblNombreDeLaEmpresa
            // 
            this.lblNombreDeLaEmpresa.AutoSize = true;
            this.lblNombreDeLaEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreDeLaEmpresa.Font = new System.Drawing.Font("Segoe UI", 18.2F, System.Drawing.FontStyle.Bold);
            this.lblNombreDeLaEmpresa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombreDeLaEmpresa.Location = new System.Drawing.Point(58, 16);
            this.lblNombreDeLaEmpresa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreDeLaEmpresa.Name = "lblNombreDeLaEmpresa";
            this.lblNombreDeLaEmpresa.Size = new System.Drawing.Size(283, 35);
            this.lblNombreDeLaEmpresa.TabIndex = 21;
            this.lblNombreDeLaEmpresa.Text = "Nombre de la Empresa";
            this.lblNombreDeLaEmpresa.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MediumBlue;
            this.panel5.Controls.Add(this.button1);
            this.panel5.Location = new System.Drawing.Point(4, 2);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(827, 35);
            this.panel5.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumBlue;
            this.button1.BackgroundImage = global::PRESENTACION.Properties.Resources.icons8_cerrar_ventana_48;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(789, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 35);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClienteReservacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(832, 612);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ClienteReservacion";
            this.Text = "ClienteReservacion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleadosSeleccionados)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleadosDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgServiciosDisponibles)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblDatosDeLaReservacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEmpleadoDeseadosYServiciosDisponibles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHoraDisponibles;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.TextBox txtHoraDisponibles;
        private System.Windows.Forms.Label lblNombreDeLaEmpresa;
        private System.Windows.Forms.Button btnReservacion;
        private System.Windows.Forms.Label lblModificarServicios;
        private System.Windows.Forms.Panel pnlAtras;
        private System.Windows.Forms.Button btnAgregarEmpleadoYSusServicios;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgEmpleadosSeleccionados;
        private System.Windows.Forms.Label lblHoraSeleccionada;
        private System.Windows.Forms.DateTimePicker dtpFechaSeleccionada;
        private System.Windows.Forms.ComboBox cbxMinutos;
        private System.Windows.Forms.ComboBox cbxSegundos;
        private System.Windows.Forms.ComboBox cbxHora;
        private System.Windows.Forms.DataGridView dtgServiciosDisponibles;
        private System.Windows.Forms.Label lblEmpleadosDisponibles;
        private System.Windows.Forms.DataGridView dtgEmpleadosDisponibles;
    }
}