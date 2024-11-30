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
            this.btnVolver = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGuardarDatos = new System.Windows.Forms.Button();
            this.cbxGenero = new System.Windows.Forms.ComboBox();
            this.cbxCargo = new System.Windows.Forms.ComboBox();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.cbxLimiteDeCuposPorDia = new System.Windows.Forms.ComboBox();
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.txtSegundoNombre = new System.Windows.Forms.TextBox();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpFechaActual = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaIncio = new System.Windows.Forms.DateTimePicker();
            this.lblFechaActual = new System.Windows.Forms.Label();
            this.lblFechaDeInicio = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblPrimerNombre = new System.Windows.Forms.Label();
            this.lblSegundoNombre = new System.Windows.Forms.Label();
            this.lblPrimerApellido = new System.Windows.Forms.Label();
            this.lblSegundoApellido = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.btAsignarServiciosAUnEmpleado = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.lblLimitePorDia = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btCerrar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.MediumBlue;
            this.flowLayoutPanel1.Controls.Add(this.btnVolver);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 40);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(87, 595);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.MediumBlue;
            this.btnVolver.BackgroundImage = global::PRESENTACION.Properties.Resources.icons8_regreso_50;
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVolver.Location = new System.Drawing.Point(3, 3);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(55, 55);
            this.btnVolver.TabIndex = 26;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btnSeleccionar);
            this.panel1.Controls.Add(this.btnGuardarDatos);
            this.panel1.Controls.Add(this.cbxGenero);
            this.panel1.Controls.Add(this.cbxCargo);
            this.panel1.Controls.Add(this.cbxEstado);
            this.panel1.Controls.Add(this.cbxLimiteDeCuposPorDia);
            this.panel1.Controls.Add(this.txtPrimerNombre);
            this.panel1.Controls.Add(this.txtSegundoNombre);
            this.panel1.Controls.Add(this.txtPrimerApellido);
            this.panel1.Controls.Add(this.txtSegundoApellido);
            this.panel1.Controls.Add(this.txtCorreo);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.txtCedula);
            this.panel1.Controls.Add(this.lblCargo);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblSexo);
            this.panel1.Controls.Add(this.lblCorreo);
            this.panel1.Controls.Add(this.lblTelefono);
            this.panel1.Controls.Add(this.lblPrimerNombre);
            this.panel1.Controls.Add(this.lblSegundoNombre);
            this.panel1.Controls.Add(this.lblPrimerApellido);
            this.panel1.Controls.Add(this.lblSegundoApellido);
            this.panel1.Controls.Add(this.lblCedula);
            this.panel1.Controls.Add(this.picFoto);
            this.panel1.Controls.Add(this.btAsignarServiciosAUnEmpleado);
            this.panel1.Controls.Add(this.lbl);
            this.panel1.Controls.Add(this.lblLimitePorDia);
            this.panel1.Location = new System.Drawing.Point(104, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 531);
            this.panel1.TabIndex = 1;
            // 
            // btnGuardarDatos
            // 
            this.btnGuardarDatos.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarDatos.Location = new System.Drawing.Point(458, 479);
            this.btnGuardarDatos.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarDatos.Name = "btnGuardarDatos";
            this.btnGuardarDatos.Size = new System.Drawing.Size(152, 36);
            this.btnGuardarDatos.TabIndex = 51;
            this.btnGuardarDatos.Text = "Guardar Datos";
            this.btnGuardarDatos.UseVisualStyleBackColor = true;
            this.btnGuardarDatos.Click += new System.EventHandler(this.btnGuardarDatos_Click);
            // 
            // cbxGenero
            // 
            this.cbxGenero.FormattingEnabled = true;
            this.cbxGenero.Location = new System.Drawing.Point(221, 298);
            this.cbxGenero.Name = "cbxGenero";
            this.cbxGenero.Size = new System.Drawing.Size(155, 21);
            this.cbxGenero.TabIndex = 50;
            // 
            // cbxCargo
            // 
            this.cbxCargo.FormattingEnabled = true;
            this.cbxCargo.Location = new System.Drawing.Point(164, 424);
            this.cbxCargo.Name = "cbxCargo";
            this.cbxCargo.Size = new System.Drawing.Size(131, 21);
            this.cbxCargo.TabIndex = 49;
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Location = new System.Drawing.Point(164, 386);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(131, 21);
            this.cbxEstado.TabIndex = 48;
            // 
            // cbxLimiteDeCuposPorDia
            // 
            this.cbxLimiteDeCuposPorDia.FormattingEnabled = true;
            this.cbxLimiteDeCuposPorDia.Location = new System.Drawing.Point(253, 346);
            this.cbxLimiteDeCuposPorDia.Name = "cbxLimiteDeCuposPorDia";
            this.cbxLimiteDeCuposPorDia.Size = new System.Drawing.Size(45, 21);
            this.cbxLimiteDeCuposPorDia.TabIndex = 47;
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.Location = new System.Drawing.Point(221, 79);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(155, 20);
            this.txtPrimerNombre.TabIndex = 40;
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.Location = new System.Drawing.Point(221, 115);
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Size = new System.Drawing.Size(155, 20);
            this.txtSegundoNombre.TabIndex = 39;
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.Location = new System.Drawing.Point(221, 152);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(155, 20);
            this.txtPrimerApellido.TabIndex = 38;
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.Location = new System.Drawing.Point(221, 186);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(155, 20);
            this.txtSegundoApellido.TabIndex = 37;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(221, 261);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(155, 20);
            this.txtCorreo.TabIndex = 36;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(221, 222);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(155, 20);
            this.txtTelefono.TabIndex = 34;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(221, 39);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(155, 20);
            this.txtCedula.TabIndex = 33;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.BackColor = System.Drawing.Color.Transparent;
            this.lblCargo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCargo.Location = new System.Drawing.Point(28, 418);
            this.lblCargo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(66, 25);
            this.lblCargo.TabIndex = 32;
            this.lblCargo.Text = "Cargo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(485, 312);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 25);
            this.label12.TabIndex = 31;
            this.label12.Text = "Experiencia";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtpFechaActual);
            this.panel2.Controls.Add(this.dtpFechaIncio);
            this.panel2.Controls.Add(this.lblFechaActual);
            this.panel2.Controls.Add(this.lblFechaDeInicio);
            this.panel2.Location = new System.Drawing.Point(313, 340);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 120);
            this.panel2.TabIndex = 30;
            // 
            // dtpFechaActual
            // 
            this.dtpFechaActual.Location = new System.Drawing.Point(150, 72);
            this.dtpFechaActual.Name = "dtpFechaActual";
            this.dtpFechaActual.Size = new System.Drawing.Size(152, 20);
            this.dtpFechaActual.TabIndex = 35;
            // 
            // dtpFechaIncio
            // 
            this.dtpFechaIncio.Location = new System.Drawing.Point(150, 28);
            this.dtpFechaIncio.Name = "dtpFechaIncio";
            this.dtpFechaIncio.Size = new System.Drawing.Size(152, 20);
            this.dtpFechaIncio.TabIndex = 34;
            // 
            // lblFechaActual
            // 
            this.lblFechaActual.AutoSize = true;
            this.lblFechaActual.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaActual.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaActual.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFechaActual.Location = new System.Drawing.Point(2, 67);
            this.lblFechaActual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaActual.Name = "lblFechaActual";
            this.lblFechaActual.Size = new System.Drawing.Size(123, 25);
            this.lblFechaActual.TabIndex = 32;
            this.lblFechaActual.Text = "Fecha Actual";
            // 
            // lblFechaDeInicio
            // 
            this.lblFechaDeInicio.AutoSize = true;
            this.lblFechaDeInicio.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaDeInicio.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDeInicio.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFechaDeInicio.Location = new System.Drawing.Point(2, 25);
            this.lblFechaDeInicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaDeInicio.Name = "lblFechaDeInicio";
            this.lblFechaDeInicio.Size = new System.Drawing.Size(143, 25);
            this.lblFechaDeInicio.TabIndex = 33;
            this.lblFechaDeInicio.Text = "Fecha de Inicio";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.BackColor = System.Drawing.Color.Transparent;
            this.lblSexo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSexo.Location = new System.Drawing.Point(28, 292);
            this.lblSexo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(56, 25);
            this.lblSexo.TabIndex = 29;
            this.lblSexo.Text = "Sexo";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = System.Drawing.Color.Transparent;
            this.lblCorreo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCorreo.Location = new System.Drawing.Point(28, 255);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(74, 25);
            this.lblCorreo.TabIndex = 28;
            this.lblCorreo.Text = "Correo";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTelefono.Location = new System.Drawing.Point(28, 216);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(89, 25);
            this.lblTelefono.TabIndex = 27;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblPrimerNombre
            // 
            this.lblPrimerNombre.AutoSize = true;
            this.lblPrimerNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblPrimerNombre.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPrimerNombre.Location = new System.Drawing.Point(28, 73);
            this.lblPrimerNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrimerNombre.Name = "lblPrimerNombre";
            this.lblPrimerNombre.Size = new System.Drawing.Size(151, 25);
            this.lblPrimerNombre.TabIndex = 26;
            this.lblPrimerNombre.Text = "Primer Nombre";
            // 
            // lblSegundoNombre
            // 
            this.lblSegundoNombre.AutoSize = true;
            this.lblSegundoNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblSegundoNombre.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSegundoNombre.Location = new System.Drawing.Point(28, 109);
            this.lblSegundoNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSegundoNombre.Name = "lblSegundoNombre";
            this.lblSegundoNombre.Size = new System.Drawing.Size(172, 25);
            this.lblSegundoNombre.TabIndex = 25;
            this.lblSegundoNombre.Text = "Segundo Nombre";
            // 
            // lblPrimerApellido
            // 
            this.lblPrimerApellido.AutoSize = true;
            this.lblPrimerApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblPrimerApellido.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerApellido.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPrimerApellido.Location = new System.Drawing.Point(28, 146);
            this.lblPrimerApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(151, 25);
            this.lblPrimerApellido.TabIndex = 24;
            this.lblPrimerApellido.Text = "Primer Apellido";
            // 
            // lblSegundoApellido
            // 
            this.lblSegundoApellido.AutoSize = true;
            this.lblSegundoApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblSegundoApellido.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoApellido.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSegundoApellido.Location = new System.Drawing.Point(28, 180);
            this.lblSegundoApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSegundoApellido.Name = "lblSegundoApellido";
            this.lblSegundoApellido.Size = new System.Drawing.Size(172, 25);
            this.lblSegundoApellido.TabIndex = 23;
            this.lblSegundoApellido.Text = "Segundo Apellido";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.BackColor = System.Drawing.Color.Transparent;
            this.lblCedula.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCedula.Location = new System.Drawing.Point(28, 34);
            this.lblCedula.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(73, 25);
            this.lblCedula.TabIndex = 22;
            this.lblCedula.Text = "Cedula";
            // 
            // picFoto
            // 
            this.picFoto.Location = new System.Drawing.Point(402, 45);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(208, 199);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFoto.TabIndex = 21;
            this.picFoto.TabStop = false;
            // 
            // btAsignarServiciosAUnEmpleado
            // 
            this.btAsignarServiciosAUnEmpleado.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAsignarServiciosAUnEmpleado.Location = new System.Drawing.Point(15, 479);
            this.btAsignarServiciosAUnEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.btAsignarServiciosAUnEmpleado.Name = "btAsignarServiciosAUnEmpleado";
            this.btAsignarServiciosAUnEmpleado.Size = new System.Drawing.Size(152, 36);
            this.btAsignarServiciosAUnEmpleado.TabIndex = 20;
            this.btAsignarServiciosAUnEmpleado.Text = "Asignar Servicios";
            this.btAsignarServiciosAUnEmpleado.UseVisualStyleBackColor = true;
            this.btAsignarServiciosAUnEmpleado.Click += new System.EventHandler(this.btGuardarDatosT_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.Transparent;
            this.lbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl.Location = new System.Drawing.Point(28, 380);
            this.lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(71, 25);
            this.lbl.TabIndex = 14;
            this.lbl.Text = "Estado";
            // 
            // lblLimitePorDia
            // 
            this.lblLimitePorDia.AutoSize = true;
            this.lblLimitePorDia.BackColor = System.Drawing.Color.Transparent;
            this.lblLimitePorDia.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimitePorDia.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLimitePorDia.Location = new System.Drawing.Point(28, 340);
            this.lblLimitePorDia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLimitePorDia.Name = "lblLimitePorDia";
            this.lblLimitePorDia.Size = new System.Drawing.Size(217, 25);
            this.lblLimitePorDia.TabIndex = 12;
            this.lblLimitePorDia.Text = "limite de cupos por Dia";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MediumBlue;
            this.panel5.Controls.Add(this.btCerrar);
            this.panel5.Location = new System.Drawing.Point(1, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(740, 35);
            this.panel5.TabIndex = 35;
            // 
            // btCerrar
            // 
            this.btCerrar.BackColor = System.Drawing.Color.MediumBlue;
            this.btCerrar.BackgroundImage = global::PRESENTACION.Properties.Resources.icons8_cerrar_ventana_48;
            this.btCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btCerrar.Location = new System.Drawing.Point(702, 0);
            this.btCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(38, 35);
            this.btCerrar.TabIndex = 0;
            this.btCerrar.UseVisualStyleBackColor = false;
            this.btCerrar.Click += new System.EventHandler(this.btCerrar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(402, 255);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(208, 30);
            this.btnSeleccionar.TabIndex = 52;
            this.btnSeleccionar.Text = "Seleccionar Imagen";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // TrabajadorUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(744, 612);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TrabajadorUsuario";
            this.Text = "TrabajadorUsuario";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLimitePorDia;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btAsignarServiciosAUnEmpleado;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btCerrar;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblPrimerNombre;
        private System.Windows.Forms.Label lblSegundoNombre;
        private System.Windows.Forms.Label lblPrimerApellido;
        private System.Windows.Forms.Label lblSegundoApellido;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblFechaActual;
        private System.Windows.Forms.Label lblFechaDeInicio;
        private System.Windows.Forms.TextBox txtPrimerNombre;
        private System.Windows.Forms.TextBox txtSegundoNombre;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.DateTimePicker dtpFechaActual;
        private System.Windows.Forms.DateTimePicker dtpFechaIncio;
        private System.Windows.Forms.ComboBox cbxGenero;
        private System.Windows.Forms.ComboBox cbxCargo;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.ComboBox cbxLimiteDeCuposPorDia;
        private System.Windows.Forms.Button btnGuardarDatos;
        private System.Windows.Forms.Button btnSeleccionar;
    }
}