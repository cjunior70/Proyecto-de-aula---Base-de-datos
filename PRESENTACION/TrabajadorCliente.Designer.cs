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
            this.btnDerecha = new System.Windows.Forms.Button();
            this.btnIzquierda = new System.Windows.Forms.Button();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.lblNombre3 = new System.Windows.Forms.Label();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.lblNombre1 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btCancelarReservacion = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btSeleccionarEmple = new System.Windows.Forms.Button();
            this.btAgregarEmpleados = new System.Windows.Forms.Button();
            this.lblAgregarEmpleado = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            this.pnl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            this.pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(509, 70);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 260);
            this.panel1.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(40, 78);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 123);
            this.label10.TabIndex = 21;
            this.label10.Text = "Conoce al\r\nequipo\r\n<----";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.btnDerecha);
            this.panel2.Controls.Add(this.btnIzquierda);
            this.panel2.Controls.Add(this.pnl3);
            this.panel2.Controls.Add(this.pnl2);
            this.panel2.Controls.Add(this.pnl1);
            this.panel2.Controls.Add(this.btnVolver);
            this.panel2.Location = new System.Drawing.Point(-42, 33);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(540, 584);
            this.panel2.TabIndex = 1;
            // 
            // btnDerecha
            // 
            this.btnDerecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDerecha.Image = global::PRESENTACION.Properties.Resources.Derecha;
            this.btnDerecha.Location = new System.Drawing.Point(455, 525);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDerecha.Size = new System.Drawing.Size(57, 34);
            this.btnDerecha.TabIndex = 36;
            this.btnDerecha.UseVisualStyleBackColor = true;
            this.btnDerecha.Click += new System.EventHandler(this.btnDerecha_Click);
            // 
            // btnIzquierda
            // 
            this.btnIzquierda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIzquierda.Image = global::PRESENTACION.Properties.Resources.Izquierda;
            this.btnIzquierda.Location = new System.Drawing.Point(392, 525);
            this.btnIzquierda.Name = "btnIzquierda";
            this.btnIzquierda.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnIzquierda.Size = new System.Drawing.Size(57, 34);
            this.btnIzquierda.TabIndex = 37;
            this.btnIzquierda.UseVisualStyleBackColor = true;
            this.btnIzquierda.Click += new System.EventHandler(this.btnIzquierda_Click);
            // 
            // pnl3
            // 
            this.pnl3.BackColor = System.Drawing.Color.DarkBlue;
            this.pnl3.Controls.Add(this.pic3);
            this.pnl3.Controls.Add(this.lblNombre3);
            this.pnl3.Location = new System.Drawing.Point(80, 343);
            this.pnl3.Margin = new System.Windows.Forms.Padding(2);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(446, 156);
            this.pnl3.TabIndex = 35;
            this.pnl3.Click += new System.EventHandler(this.DatosEmpleados3);
            this.pnl3.DoubleClick += new System.EventHandler(this.DatosEmpleados3);
            // 
            // pic3
            // 
            this.pic3.BackColor = System.Drawing.Color.DarkBlue;
            this.pic3.BackgroundImage = global::PRESENTACION.Properties.Resources.fix_beard_home_diy_1_1600x900_1_1024x576;
            this.pic3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic3.Location = new System.Drawing.Point(24, 16);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(128, 121);
            this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic3.TabIndex = 31;
            this.pic3.TabStop = false;
            this.pic3.Click += new System.EventHandler(this.DatosEmpleados2);
            this.pic3.DoubleClick += new System.EventHandler(this.DatosEmpleados2);
            // 
            // lblNombre3
            // 
            this.lblNombre3.AutoSize = true;
            this.lblNombre3.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblNombre3.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombre3.Location = new System.Drawing.Point(208, 54);
            this.lblNombre3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre3.Name = "lblNombre3";
            this.lblNombre3.Size = new System.Drawing.Size(183, 30);
            this.lblNombre3.TabIndex = 30;
            this.lblNombre3.Text = "Thiago Gonzales";
            this.lblNombre3.Click += new System.EventHandler(this.DatosEmpleados2);
            this.lblNombre3.DoubleClick += new System.EventHandler(this.DatosEmpleados2);
            // 
            // pnl2
            // 
            this.pnl2.BackColor = System.Drawing.Color.DarkBlue;
            this.pnl2.Controls.Add(this.pic2);
            this.pnl2.Controls.Add(this.lblNombre2);
            this.pnl2.Location = new System.Drawing.Point(80, 187);
            this.pnl2.Margin = new System.Windows.Forms.Padding(2);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(446, 135);
            this.pnl2.TabIndex = 34;
            this.pnl2.Click += new System.EventHandler(this.DatosEmpleados2);
            this.pnl2.DoubleClick += new System.EventHandler(this.DatosEmpleados2);
            // 
            // pic2
            // 
            this.pic2.BackColor = System.Drawing.Color.DarkBlue;
            this.pic2.BackgroundImage = global::PRESENTACION.Properties.Resources.young_hipster_female_barber_holding_sharp_razor_and_looking_at_camera_while_standing_in_barbershop_ADSF17153;
            this.pic2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic2.Location = new System.Drawing.Point(24, 11);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(128, 113);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic2.TabIndex = 31;
            this.pic2.TabStop = false;
            this.pic2.Click += new System.EventHandler(this.DatosEmpleados2);
            this.pic2.DoubleClick += new System.EventHandler(this.DatosEmpleados2);
            // 
            // lblNombre2
            // 
            this.lblNombre2.AutoSize = true;
            this.lblNombre2.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblNombre2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombre2.Location = new System.Drawing.Point(208, 51);
            this.lblNombre2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre2.Name = "lblNombre2";
            this.lblNombre2.Size = new System.Drawing.Size(174, 30);
            this.lblNombre2.TabIndex = 30;
            this.lblNombre2.Text = "Angela Fragozo";
            this.lblNombre2.Click += new System.EventHandler(this.DatosEmpleados2);
            this.lblNombre2.DoubleClick += new System.EventHandler(this.DatosEmpleados2);
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.Color.Navy;
            this.pnl1.Controls.Add(this.pic1);
            this.pnl1.Controls.Add(this.lblNombre1);
            this.pnl1.Location = new System.Drawing.Point(80, 20);
            this.pnl1.Margin = new System.Windows.Forms.Padding(2);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(446, 147);
            this.pnl1.TabIndex = 33;
            this.pnl1.Click += new System.EventHandler(this.DatosEmpleados1);
            this.pnl1.DoubleClick += new System.EventHandler(this.DatosEmpleados1);
            // 
            // pic1
            // 
            this.pic1.BackColor = System.Drawing.Color.DarkBlue;
            this.pic1.BackgroundImage = global::PRESENTACION.Properties.Resources.Black_Owned_Barber_Shops_in_Orlando_768x536;
            this.pic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic1.Location = new System.Drawing.Point(24, 16);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(128, 121);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 31;
            this.pic1.TabStop = false;
            this.pic1.Click += new System.EventHandler(this.DatosEmpleados1);
            this.pic1.DoubleClick += new System.EventHandler(this.DatosEmpleados1);
            // 
            // lblNombre1
            // 
            this.lblNombre1.AutoSize = true;
            this.lblNombre1.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblNombre1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombre1.Location = new System.Drawing.Point(208, 57);
            this.lblNombre1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre1.Name = "lblNombre1";
            this.lblNombre1.Size = new System.Drawing.Size(195, 30);
            this.lblNombre1.TabIndex = 30;
            this.lblNombre1.Text = "Benjamin Herrera";
            this.lblNombre1.Click += new System.EventHandler(this.DatosEmpleados1);
            this.lblNombre1.DoubleClick += new System.EventHandler(this.DatosEmpleados1);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnVolver.BackgroundImage = global::PRESENTACION.Properties.Resources.icons8_regreso_50;
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVolver.Location = new System.Drawing.Point(43, 504);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(55, 55);
            this.btnVolver.TabIndex = 26;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btCancelarReservacion
            // 
            this.btCancelarReservacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelarReservacion.Location = new System.Drawing.Point(525, 559);
            this.btCancelarReservacion.Margin = new System.Windows.Forms.Padding(2);
            this.btCancelarReservacion.Name = "btCancelarReservacion";
            this.btCancelarReservacion.Size = new System.Drawing.Size(187, 33);
            this.btCancelarReservacion.TabIndex = 23;
            this.btCancelarReservacion.Text = "Cancelar reservacion";
            this.btCancelarReservacion.UseVisualStyleBackColor = true;
            this.btCancelarReservacion.Click += new System.EventHandler(this.btCancelarReservacion_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MediumBlue;
            this.panel5.Controls.Add(this.button1);
            this.panel5.Location = new System.Drawing.Point(1, -6);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(734, 42);
            this.panel5.TabIndex = 35;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumBlue;
            this.button1.BackgroundImage = global::PRESENTACION.Properties.Resources.icons8_cerrar_ventana_48;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(696, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 42);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btSeleccionarEmple
            // 
            this.btSeleccionarEmple.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSeleccionarEmple.Location = new System.Drawing.Point(525, 482);
            this.btSeleccionarEmple.Margin = new System.Windows.Forms.Padding(2);
            this.btSeleccionarEmple.Name = "btSeleccionarEmple";
            this.btSeleccionarEmple.Size = new System.Drawing.Size(187, 33);
            this.btSeleccionarEmple.TabIndex = 22;
            this.btSeleccionarEmple.Text = "Seleccionar empleado";
            this.btSeleccionarEmple.UseVisualStyleBackColor = true;
            // 
            // btAgregarEmpleados
            // 
            this.btAgregarEmpleados.BackColor = System.Drawing.Color.MidnightBlue;
            this.btAgregarEmpleados.BackgroundImage = global::PRESENTACION.Properties.Resources.agregar_usuario;
            this.btAgregarEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btAgregarEmpleados.Location = new System.Drawing.Point(589, 397);
            this.btAgregarEmpleados.Name = "btAgregarEmpleados";
            this.btAgregarEmpleados.Size = new System.Drawing.Size(55, 55);
            this.btAgregarEmpleados.TabIndex = 38;
            this.btAgregarEmpleados.UseVisualStyleBackColor = false;
            this.btAgregarEmpleados.Click += new System.EventHandler(this.btAgregarEmpleados_Click);
            // 
            // lblAgregarEmpleado
            // 
            this.lblAgregarEmpleado.AutoSize = true;
            this.lblAgregarEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.lblAgregarEmpleado.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblAgregarEmpleado.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAgregarEmpleado.Location = new System.Drawing.Point(520, 363);
            this.lblAgregarEmpleado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAgregarEmpleado.Name = "lblAgregarEmpleado";
            this.lblAgregarEmpleado.Size = new System.Drawing.Size(207, 30);
            this.lblAgregarEmpleado.TabIndex = 32;
            this.lblAgregarEmpleado.Text = "Agregar empleado";
            // 
            // TrabajadorCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(736, 612);
            this.Controls.Add(this.lblAgregarEmpleado);
            this.Controls.Add(this.btAgregarEmpleados);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btCancelarReservacion);
            this.Controls.Add(this.btSeleccionarEmple);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TrabajadorCliente";
            this.Text = "TrabajadorCliente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnl3.ResumeLayout(false);
            this.pnl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            this.pnl2.ResumeLayout(false);
            this.pnl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblNombre1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btCancelarReservacion;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btSeleccionarEmple;
        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.Label lblNombre3;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.Label lblNombre2;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.Button btnIzquierda;
        private System.Windows.Forms.Button btAgregarEmpleados;
        private System.Windows.Forms.Label lblAgregarEmpleado;
    }
}