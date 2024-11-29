using DLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRESENTACION
{
    public partial class TrabajadorUsuario : Form
    {
        public TrabajadorUsuario()
        {
            InitializeComponent();

            for (int i = 1; i < 15; i++)
            {
                cbxLimiteDeCuposPorDia.Items.Add(i);
            }

            cbxGenero.Items.Add("Masculino");
            cbxGenero.Items.Add("Femenino");

            cbxEstado.Items.Add("Disponible");
            cbxEstado.Items.Add("No Disponbiles");

            cbxCargo.Items.Add("Jefe");
            cbxCargo.Items.Add("Empledo");


        }

        //Datos de conexion
        Datos_login datos_de_la_conexion_globales = new Datos_login();

        //logica de los empleados
        logica_de_los_empleados logica_De_Los_Empleados = new logica_de_los_empleados();

        public void datos_de_conexion(Datos_login datos_De_conexion)
        {
            datos_de_la_conexion_globales.usuario = datos_De_conexion.usuario;
            datos_de_la_conexion_globales.constraseña = datos_De_conexion.constraseña;
            datos_de_la_conexion_globales.cedula_del_usuario = datos_De_conexion.cedula_del_usuario;
            datos_de_la_conexion_globales.quien_esta = datos_De_conexion.quien_esta;
        }


        public void guardar_datos_del_empleado()
        {

        }

        public void registrar_datos_de_un_empleado()
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btGuardarDatosT_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarDatos_Click(object sender, EventArgs e)
        {
            Empleados datos_del_empleado = new Empleados();

            datos_del_empleado.cedula = txtCedula.Text;
            datos_del_empleado.Primer_nombre = txtPrimerNombre.Text;
            datos_del_empleado.Segundo_nombre = txtSegundoNombre.Text;
            datos_del_empleado.Primer_apellido = txtPrimerApellido.Text;
            datos_del_empleado.Segundo_apellido = txtSegundoApellido.Text;
            datos_del_empleado.telefono = txtTelefono.Text;
            datos_del_empleado.correo_electronico = txtCorreo.Text;
            datos_del_empleado.fecha_de_final =  dtpFechaActual.Value;
            datos_del_empleado.fecha_de_inicio =   dtpFechaIncio.Value;
            datos_del_empleado.estado = cbxEstado.Text;
            datos_del_empleado.cupos_disponibles =  Convert.ToInt16 ( cbxLimiteDeCuposPorDia.Text );
            datos_del_empleado.cargo = cbxCargo.Text;

            MessageBox.Show(datos_del_empleado.estado);

        }
    }
}
