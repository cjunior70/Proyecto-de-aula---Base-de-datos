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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblModificarServicios = new System.Windows.Forms.Label();
            this.lblServico3 = new System.Windows.Forms.Label();
            this.lblServico2 = new System.Windows.Forms.Label();
            this.lblServico1 = new System.Windows.Forms.Label();
            this.lblServciosSeleccionados = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblServico4 = new System.Windows.Forms.Label();
            this.lblServico8 = new System.Windows.Forms.Label();
            this.lblServico7 = new System.Windows.Forms.Label();
            this.lblServico6 = new System.Windows.Forms.Label();
            this.lblServico5 = new System.Windows.Forms.Label();
            this.lblListaDeServicosEscodigos = new System.Windows.Forms.Label();
            this.lblListaDeLosPreciosDeLosServicios = new System.Windows.Forms.Label();
            this.lblPrecioDelServico1 = new System.Windows.Forms.Label();
            this.lblPrecioDelServico6 = new System.Windows.Forms.Label();
            this.lblPrecioDelServico5 = new System.Windows.Forms.Label();
            this.lblPrecioDelServico4 = new System.Windows.Forms.Label();
            this.lblPrecioDelServico3 = new System.Windows.Forms.Label();
            this.lblPrecioDelServico2 = new System.Windows.Forms.Label();
            this.lblPrecioDelServico8 = new System.Windows.Forms.Label();
            this.lblPrecioDelServico7 = new System.Windows.Forms.Label();
            this.dgEmpleadosSeleccionados = new System.Windows.Forms.DataGridView();
            this.lblFechaActual = new System.Windows.Forms.Label();
            this.dtpFechaSeleccionada = new System.Windows.Forms.DateTimePicker();
            this.lblHoraSeleccionada = new System.Windows.Forms.Label();
            this.dtpFechaActual = new System.Windows.Forms.DateTimePicker();
            this.cbxHora = new System.Windows.Forms.ComboBox();
            this.cbxSegundos = new System.Windows.Forms.ComboBox();
            this.cbxMinutos = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleadosSeleccionados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.lblDatosDeLaReservacion);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(362, 42);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 567);
            this.panel1.TabIndex = 0;
            // 
            // lblDatosDeLaReservacion
            // 
            this.lblDatosDeLaReservacion.AutoSize = true;
            this.lblDatosDeLaReservacion.BackColor = System.Drawing.Color.Transparent;
            this.lblDatosDeLaReservacion.Font = new System.Drawing.Font("Segoe UI", 18.2F, System.Drawing.FontStyle.Bold);
            this.lblDatosDeLaReservacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDatosDeLaReservacion.Location = new System.Drawing.Point(172, 16);
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
            this.panel4.Controls.Add(this.dtpFechaActual);
            this.panel4.Controls.Add(this.lblHoraSeleccionada);
            this.panel4.Controls.Add(this.dtpFechaSeleccionada);
            this.panel4.Controls.Add(this.lblFechaActual);
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
            this.panel4.Location = new System.Drawing.Point(29, 53);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(408, 507);
            this.panel4.TabIndex = 0;
            // 
            // btnAgregarEmpleadoYSusServicios
            // 
            this.btnAgregarEmpleadoYSusServicios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEmpleadoYSusServicios.Location = new System.Drawing.Point(218, 334);
            this.btnAgregarEmpleadoYSusServicios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.btnReservacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.txtHoraDisponibles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHoraDisponibles.Name = "txtHoraDisponibles";
            this.txtHoraDisponibles.Size = new System.Drawing.Size(127, 20);
            this.txtHoraDisponibles.TabIndex = 36;
            this.txtHoraDisponibles.Text = "7am - 5pm ";
            this.txtHoraDisponibles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPago
            // 
            this.txtPago.Location = new System.Drawing.Point(170, 382);
            this.txtPago.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.label5.Location = new System.Drawing.Point(22, 376);
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
            this.lblFecha.Location = new System.Drawing.Point(64, 13);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(72, 30);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.lblPrecioDelServico7);
            this.panel3.Controls.Add(this.lblPrecioDelServico8);
            this.panel3.Controls.Add(this.lblPrecioDelServico2);
            this.panel3.Controls.Add(this.lblPrecioDelServico3);
            this.panel3.Controls.Add(this.lblPrecioDelServico4);
            this.panel3.Controls.Add(this.lblPrecioDelServico5);
            this.panel3.Controls.Add(this.lblPrecioDelServico6);
            this.panel3.Controls.Add(this.lblPrecioDelServico1);
            this.panel3.Controls.Add(this.lblServico8);
            this.panel3.Controls.Add(this.lblServico7);
            this.panel3.Controls.Add(this.lblServico6);
            this.panel3.Controls.Add(this.lblServico5);
            this.panel3.Controls.Add(this.lblServico4);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.lblModificarServicios);
            this.panel3.Controls.Add(this.lblServico3);
            this.panel3.Controls.Add(this.lblServico2);
            this.panel3.Controls.Add(this.lblServico1);
            this.panel3.Controls.Add(this.lblServciosSeleccionados);
            this.panel3.Controls.Add(this.lblListaDeServicosEscodigos);
            this.panel3.Controls.Add(this.lblListaDeLosPreciosDeLosServicios);
            this.panel3.Location = new System.Drawing.Point(0, 42);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(378, 567);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::PRESENTACION.Properties.Resources.icons8_regreso_50;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(9, 522);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(37, 37);
            this.panel2.TabIndex = 33;
            // 
            // lblModificarServicios
            // 
            this.lblModificarServicios.AutoSize = true;
            this.lblModificarServicios.BackColor = System.Drawing.Color.Transparent;
            this.lblModificarServicios.Font = new System.Drawing.Font("Segoe UI", 12.2F, System.Drawing.FontStyle.Bold);
            this.lblModificarServicios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblModificarServicios.Location = new System.Drawing.Point(211, 536);
            this.lblModificarServicios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModificarServicios.Name = "lblModificarServicios";
            this.lblModificarServicios.Size = new System.Drawing.Size(164, 23);
            this.lblModificarServicios.TabIndex = 32;
            this.lblModificarServicios.Text = "Modificar Servircio";
            // 
            // lblServico3
            // 
            this.lblServico3.AutoSize = true;
            this.lblServico3.BackColor = System.Drawing.Color.Transparent;
            this.lblServico3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServico3.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblServico3.Location = new System.Drawing.Point(11, 203);
            this.lblServico3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServico3.Name = "lblServico3";
            this.lblServico3.Size = new System.Drawing.Size(219, 32);
            this.lblServico3.TabIndex = 31;
            this.lblServico3.Text = "Lavado de cabello";
            // 
            // lblServico2
            // 
            this.lblServico2.AutoSize = true;
            this.lblServico2.BackColor = System.Drawing.Color.Transparent;
            this.lblServico2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServico2.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblServico2.Location = new System.Drawing.Point(11, 159);
            this.lblServico2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServico2.Name = "lblServico2";
            this.lblServico2.Size = new System.Drawing.Size(73, 32);
            this.lblServico2.TabIndex = 30;
            this.lblServico2.Text = "Cejas";
            // 
            // lblServico1
            // 
            this.lblServico1.AutoSize = true;
            this.lblServico1.BackColor = System.Drawing.Color.Transparent;
            this.lblServico1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServico1.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblServico1.Location = new System.Drawing.Point(11, 113);
            this.lblServico1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServico1.Name = "lblServico1";
            this.lblServico1.Size = new System.Drawing.Size(169, 32);
            this.lblServico1.TabIndex = 29;
            this.lblServico1.Text = "Corte de pelo";
            // 
            // lblServciosSeleccionados
            // 
            this.lblServciosSeleccionados.AutoSize = true;
            this.lblServciosSeleccionados.BackColor = System.Drawing.Color.Transparent;
            this.lblServciosSeleccionados.Font = new System.Drawing.Font("Segoe UI", 18.2F, System.Drawing.FontStyle.Bold);
            this.lblServciosSeleccionados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblServciosSeleccionados.Location = new System.Drawing.Point(50, 16);
            this.lblServciosSeleccionados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServciosSeleccionados.Name = "lblServciosSeleccionados";
            this.lblServciosSeleccionados.Size = new System.Drawing.Size(291, 35);
            this.lblServciosSeleccionados.TabIndex = 21;
            this.lblServciosSeleccionados.Text = "Servicios Seleccionados";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MediumBlue;
            this.panel5.Controls.Add(this.button1);
            this.panel5.Location = new System.Drawing.Point(4, 2);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(806, 35);
            this.panel5.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumBlue;
            this.button1.BackgroundImage = global::PRESENTACION.Properties.Resources.icons8_cerrar_ventana_48;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(768, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 35);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblServico4
            // 
            this.lblServico4.AutoSize = true;
            this.lblServico4.BackColor = System.Drawing.Color.Transparent;
            this.lblServico4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServico4.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblServico4.Location = new System.Drawing.Point(11, 251);
            this.lblServico4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServico4.Name = "lblServico4";
            this.lblServico4.Size = new System.Drawing.Size(219, 32);
            this.lblServico4.TabIndex = 34;
            this.lblServico4.Text = "Lavado de cabello";
            // 
            // lblServico8
            // 
            this.lblServico8.AutoSize = true;
            this.lblServico8.BackColor = System.Drawing.Color.Transparent;
            this.lblServico8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServico8.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblServico8.Location = new System.Drawing.Point(11, 435);
            this.lblServico8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServico8.Name = "lblServico8";
            this.lblServico8.Size = new System.Drawing.Size(219, 32);
            this.lblServico8.TabIndex = 38;
            this.lblServico8.Text = "Lavado de cabello";
            // 
            // lblServico7
            // 
            this.lblServico7.AutoSize = true;
            this.lblServico7.BackColor = System.Drawing.Color.Transparent;
            this.lblServico7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServico7.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblServico7.Location = new System.Drawing.Point(11, 384);
            this.lblServico7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServico7.Name = "lblServico7";
            this.lblServico7.Size = new System.Drawing.Size(73, 32);
            this.lblServico7.TabIndex = 37;
            this.lblServico7.Text = "Cejas";
            // 
            // lblServico6
            // 
            this.lblServico6.AutoSize = true;
            this.lblServico6.BackColor = System.Drawing.Color.Transparent;
            this.lblServico6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServico6.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblServico6.Location = new System.Drawing.Point(11, 338);
            this.lblServico6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServico6.Name = "lblServico6";
            this.lblServico6.Size = new System.Drawing.Size(169, 32);
            this.lblServico6.TabIndex = 36;
            this.lblServico6.Text = "Corte de pelo";
            // 
            // lblServico5
            // 
            this.lblServico5.AutoSize = true;
            this.lblServico5.BackColor = System.Drawing.Color.Transparent;
            this.lblServico5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServico5.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblServico5.Location = new System.Drawing.Point(11, 297);
            this.lblServico5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServico5.Name = "lblServico5";
            this.lblServico5.Size = new System.Drawing.Size(90, 32);
            this.lblServico5.TabIndex = 35;
            this.lblServico5.Text = "Barbar";
            // 
            // lblListaDeServicosEscodigos
            // 
            this.lblListaDeServicosEscodigos.AutoSize = true;
            this.lblListaDeServicosEscodigos.BackColor = System.Drawing.Color.Transparent;
            this.lblListaDeServicosEscodigos.Font = new System.Drawing.Font("Segoe UI", 18.2F, System.Drawing.FontStyle.Bold);
            this.lblListaDeServicosEscodigos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblListaDeServicosEscodigos.Location = new System.Drawing.Point(50, 66);
            this.lblListaDeServicosEscodigos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblListaDeServicosEscodigos.Name = "lblListaDeServicosEscodigos";
            this.lblListaDeServicosEscodigos.Size = new System.Drawing.Size(120, 35);
            this.lblListaDeServicosEscodigos.TabIndex = 21;
            this.lblListaDeServicosEscodigos.Text = "Servicios";
            // 
            // lblListaDeLosPreciosDeLosServicios
            // 
            this.lblListaDeLosPreciosDeLosServicios.AutoSize = true;
            this.lblListaDeLosPreciosDeLosServicios.BackColor = System.Drawing.Color.Transparent;
            this.lblListaDeLosPreciosDeLosServicios.Font = new System.Drawing.Font("Segoe UI", 18.2F, System.Drawing.FontStyle.Bold);
            this.lblListaDeLosPreciosDeLosServicios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblListaDeLosPreciosDeLosServicios.Location = new System.Drawing.Point(270, 66);
            this.lblListaDeLosPreciosDeLosServicios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblListaDeLosPreciosDeLosServicios.Name = "lblListaDeLosPreciosDeLosServicios";
            this.lblListaDeLosPreciosDeLosServicios.Size = new System.Drawing.Size(88, 35);
            this.lblListaDeLosPreciosDeLosServicios.TabIndex = 39;
            this.lblListaDeLosPreciosDeLosServicios.Text = "Precio";
            // 
            // lblPrecioDelServico1
            // 
            this.lblPrecioDelServico1.AutoSize = true;
            this.lblPrecioDelServico1.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecioDelServico1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioDelServico1.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblPrecioDelServico1.Location = new System.Drawing.Point(270, 113);
            this.lblPrecioDelServico1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecioDelServico1.Name = "lblPrecioDelServico1";
            this.lblPrecioDelServico1.Size = new System.Drawing.Size(86, 32);
            this.lblPrecioDelServico1.TabIndex = 40;
            this.lblPrecioDelServico1.Text = "Precio";
            // 
            // lblPrecioDelServico6
            // 
            this.lblPrecioDelServico6.AutoSize = true;
            this.lblPrecioDelServico6.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecioDelServico6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioDelServico6.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblPrecioDelServico6.Location = new System.Drawing.Point(272, 338);
            this.lblPrecioDelServico6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecioDelServico6.Name = "lblPrecioDelServico6";
            this.lblPrecioDelServico6.Size = new System.Drawing.Size(86, 32);
            this.lblPrecioDelServico6.TabIndex = 41;
            this.lblPrecioDelServico6.Text = "Precio";
            // 
            // lblPrecioDelServico5
            // 
            this.lblPrecioDelServico5.AutoSize = true;
            this.lblPrecioDelServico5.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecioDelServico5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioDelServico5.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblPrecioDelServico5.Location = new System.Drawing.Point(272, 295);
            this.lblPrecioDelServico5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecioDelServico5.Name = "lblPrecioDelServico5";
            this.lblPrecioDelServico5.Size = new System.Drawing.Size(86, 32);
            this.lblPrecioDelServico5.TabIndex = 42;
            this.lblPrecioDelServico5.Text = "Precio";
            // 
            // lblPrecioDelServico4
            // 
            this.lblPrecioDelServico4.AutoSize = true;
            this.lblPrecioDelServico4.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecioDelServico4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioDelServico4.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblPrecioDelServico4.Location = new System.Drawing.Point(272, 251);
            this.lblPrecioDelServico4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecioDelServico4.Name = "lblPrecioDelServico4";
            this.lblPrecioDelServico4.Size = new System.Drawing.Size(86, 32);
            this.lblPrecioDelServico4.TabIndex = 43;
            this.lblPrecioDelServico4.Text = "Precio";
            // 
            // lblPrecioDelServico3
            // 
            this.lblPrecioDelServico3.AutoSize = true;
            this.lblPrecioDelServico3.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecioDelServico3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioDelServico3.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblPrecioDelServico3.Location = new System.Drawing.Point(272, 203);
            this.lblPrecioDelServico3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecioDelServico3.Name = "lblPrecioDelServico3";
            this.lblPrecioDelServico3.Size = new System.Drawing.Size(86, 32);
            this.lblPrecioDelServico3.TabIndex = 44;
            this.lblPrecioDelServico3.Text = "Precio";
            // 
            // lblPrecioDelServico2
            // 
            this.lblPrecioDelServico2.AutoSize = true;
            this.lblPrecioDelServico2.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecioDelServico2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioDelServico2.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblPrecioDelServico2.Location = new System.Drawing.Point(272, 159);
            this.lblPrecioDelServico2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecioDelServico2.Name = "lblPrecioDelServico2";
            this.lblPrecioDelServico2.Size = new System.Drawing.Size(86, 32);
            this.lblPrecioDelServico2.TabIndex = 45;
            this.lblPrecioDelServico2.Text = "Precio";
            // 
            // lblPrecioDelServico8
            // 
            this.lblPrecioDelServico8.AutoSize = true;
            this.lblPrecioDelServico8.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecioDelServico8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioDelServico8.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblPrecioDelServico8.Location = new System.Drawing.Point(272, 435);
            this.lblPrecioDelServico8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecioDelServico8.Name = "lblPrecioDelServico8";
            this.lblPrecioDelServico8.Size = new System.Drawing.Size(86, 32);
            this.lblPrecioDelServico8.TabIndex = 46;
            this.lblPrecioDelServico8.Text = "Precio";
            // 
            // lblPrecioDelServico7
            // 
            this.lblPrecioDelServico7.AutoSize = true;
            this.lblPrecioDelServico7.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecioDelServico7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioDelServico7.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblPrecioDelServico7.Location = new System.Drawing.Point(272, 384);
            this.lblPrecioDelServico7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecioDelServico7.Name = "lblPrecioDelServico7";
            this.lblPrecioDelServico7.Size = new System.Drawing.Size(86, 32);
            this.lblPrecioDelServico7.TabIndex = 47;
            this.lblPrecioDelServico7.Text = "Precio";
            // 
            // dgEmpleadosSeleccionados
            // 
            this.dgEmpleadosSeleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmpleadosSeleccionados.Location = new System.Drawing.Point(20, 171);
            this.dgEmpleadosSeleccionados.Name = "dgEmpleadosSeleccionados";
            this.dgEmpleadosSeleccionados.Size = new System.Drawing.Size(369, 159);
            this.dgEmpleadosSeleccionados.TabIndex = 39;
            // 
            // lblFechaActual
            // 
            this.lblFechaActual.AutoSize = true;
            this.lblFechaActual.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaActual.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaActual.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFechaActual.Location = new System.Drawing.Point(235, 13);
            this.lblFechaActual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaActual.Name = "lblFechaActual";
            this.lblFechaActual.Size = new System.Drawing.Size(144, 30);
            this.lblFechaActual.TabIndex = 40;
            this.lblFechaActual.Text = "Fecha Actual";
            // 
            // dtpFechaSeleccionada
            // 
            this.dtpFechaSeleccionada.Location = new System.Drawing.Point(3, 46);
            this.dtpFechaSeleccionada.Name = "dtpFechaSeleccionada";
            this.dtpFechaSeleccionada.Size = new System.Drawing.Size(197, 20);
            this.dtpFechaSeleccionada.TabIndex = 41;
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
            // dtpFechaActual
            // 
            this.dtpFechaActual.Location = new System.Drawing.Point(204, 46);
            this.dtpFechaActual.Name = "dtpFechaActual";
            this.dtpFechaActual.Size = new System.Drawing.Size(197, 20);
            this.dtpFechaActual.TabIndex = 43;
            // 
            // cbxHora
            // 
            this.cbxHora.FormattingEnabled = true;
            this.cbxHora.Location = new System.Drawing.Point(18, 110);
            this.cbxHora.Name = "cbxHora";
            this.cbxHora.Size = new System.Drawing.Size(45, 21);
            this.cbxHora.TabIndex = 44;
            // 
            // cbxSegundos
            // 
            this.cbxSegundos.FormattingEnabled = true;
            this.cbxSegundos.Location = new System.Drawing.Point(140, 110);
            this.cbxSegundos.Name = "cbxSegundos";
            this.cbxSegundos.Size = new System.Drawing.Size(45, 21);
            this.cbxSegundos.TabIndex = 45;
            // 
            // cbxMinutos
            // 
            this.cbxMinutos.FormattingEnabled = true;
            this.cbxMinutos.Location = new System.Drawing.Point(80, 110);
            this.cbxMinutos.Name = "cbxMinutos";
            this.cbxMinutos.Size = new System.Drawing.Size(45, 21);
            this.cbxMinutos.TabIndex = 46;
            // 
            // ClienteReservacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(810, 612);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ClienteReservacion";
            this.Text = "ClienteReservacion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleadosSeleccionados)).EndInit();
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
        private System.Windows.Forms.Label lblServciosSeleccionados;
        private System.Windows.Forms.Button btnReservacion;
        private System.Windows.Forms.Label lblServico3;
        private System.Windows.Forms.Label lblServico2;
        private System.Windows.Forms.Label lblServico1;
        private System.Windows.Forms.Label lblModificarServicios;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAgregarEmpleadoYSusServicios;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblServico8;
        private System.Windows.Forms.Label lblServico7;
        private System.Windows.Forms.Label lblServico6;
        private System.Windows.Forms.Label lblServico5;
        private System.Windows.Forms.Label lblServico4;
        private System.Windows.Forms.Label lblPrecioDelServico7;
        private System.Windows.Forms.Label lblPrecioDelServico8;
        private System.Windows.Forms.Label lblPrecioDelServico2;
        private System.Windows.Forms.Label lblPrecioDelServico3;
        private System.Windows.Forms.Label lblPrecioDelServico4;
        private System.Windows.Forms.Label lblPrecioDelServico5;
        private System.Windows.Forms.Label lblPrecioDelServico6;
        private System.Windows.Forms.Label lblPrecioDelServico1;
        private System.Windows.Forms.Label lblListaDeServicosEscodigos;
        private System.Windows.Forms.Label lblListaDeLosPreciosDeLosServicios;
        private System.Windows.Forms.DataGridView dgEmpleadosSeleccionados;
        private System.Windows.Forms.Label lblFechaActual;
        private System.Windows.Forms.Label lblHoraSeleccionada;
        private System.Windows.Forms.DateTimePicker dtpFechaSeleccionada;
        private System.Windows.Forms.DateTimePicker dtpFechaActual;
        private System.Windows.Forms.ComboBox cbxMinutos;
        private System.Windows.Forms.ComboBox cbxSegundos;
        private System.Windows.Forms.ComboBox cbxHora;
    }
}