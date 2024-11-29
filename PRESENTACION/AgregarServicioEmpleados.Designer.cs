namespace PRESENTACION
{
    partial class AgregarServicioEmpleados
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
            this.dataGridListaServicioEmpresa = new System.Windows.Forms.DataGridView();
            this.dataGridListaServicioEmpleado = new System.Windows.Forms.DataGridView();
            this.btAsignarServiciosEmpleado = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListaServicioEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListaServicioEmpleado)).BeginInit();
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
            this.panel5.Size = new System.Drawing.Size(1350, 50);
            this.panel5.TabIndex = 40;
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.MediumBlue;
            this.btClose.BackgroundImage = global::PRESENTACION.Properties.Resources.icons8_cerrar_ventana_48;
            this.btClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btClose.Location = new System.Drawing.Point(1299, 0);
            this.btClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(51, 50);
            this.btClose.TabIndex = 0;
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // dataGridListaServicioEmpresa
            // 
            this.dataGridListaServicioEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListaServicioEmpresa.Location = new System.Drawing.Point(29, 146);
            this.dataGridListaServicioEmpresa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridListaServicioEmpresa.Name = "dataGridListaServicioEmpresa";
            this.dataGridListaServicioEmpresa.RowHeadersWidth = 51;
            this.dataGridListaServicioEmpresa.RowTemplate.Height = 24;
            this.dataGridListaServicioEmpresa.Size = new System.Drawing.Size(620, 388);
            this.dataGridListaServicioEmpresa.TabIndex = 42;
            // 
            // dataGridListaServicioEmpleado
            // 
            this.dataGridListaServicioEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListaServicioEmpleado.Location = new System.Drawing.Point(702, 146);
            this.dataGridListaServicioEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridListaServicioEmpleado.Name = "dataGridListaServicioEmpleado";
            this.dataGridListaServicioEmpleado.RowHeadersWidth = 51;
            this.dataGridListaServicioEmpleado.RowTemplate.Height = 24;
            this.dataGridListaServicioEmpleado.Size = new System.Drawing.Size(620, 388);
            this.dataGridListaServicioEmpleado.TabIndex = 43;
            // 
            // btAsignarServiciosEmpleado
            // 
            this.btAsignarServiciosEmpleado.BackColor = System.Drawing.Color.Lavender;
            this.btAsignarServiciosEmpleado.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAsignarServiciosEmpleado.Location = new System.Drawing.Point(844, 571);
            this.btAsignarServiciosEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAsignarServiciosEmpleado.Name = "btAsignarServiciosEmpleado";
            this.btAsignarServiciosEmpleado.Size = new System.Drawing.Size(478, 52);
            this.btAsignarServiciosEmpleado.TabIndex = 48;
            this.btAsignarServiciosEmpleado.Text = "Asignar servicios del empleado";
            this.btAsignarServiciosEmpleado.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(76, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(517, 46);
            this.label5.TabIndex = 49;
            this.label5.Text = "Lista de servicios de la empresa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(752, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(513, 46);
            this.label1.TabIndex = 50;
            this.label1.Text = "Lista de servicios del empleado";
            // 
            // AgregarServicioEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1350, 650);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btAsignarServiciosEmpleado);
            this.Controls.Add(this.dataGridListaServicioEmpleado);
            this.Controls.Add(this.dataGridListaServicioEmpresa);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarServicioEmpleados";
            this.Text = "AgregarServicioEmpleados";
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListaServicioEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListaServicioEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.DataGridView dataGridListaServicioEmpresa;
        private System.Windows.Forms.DataGridView dataGridListaServicioEmpleado;
        private System.Windows.Forms.Button btAsignarServiciosEmpleado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}