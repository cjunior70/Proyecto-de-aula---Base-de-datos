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
    public partial class ClienteReservacion : Form
    {
        public ClienteReservacion()
        {
            InitializeComponent();

            llenar_datos_del_tiempo();

        }

        private void llenar_datos_del_tiempo()
        {
            // Agregar opciones al ComboBox hora desde las 7 de la mañana hasta las 5 de la tarde

            for(int i = 7; i<15; i ++)
            {
                cbxHora.Items.Add(i.ToString("D2"));
            }

            // Agregar opciones al ComboBox minutos
            for (int i = 1; i < 60; i++)
            {
                cbxMinutos.Items.Add(i.ToString("D2"));
            }

            for (int i = 1; i < 60; i++)
            {
                cbxSegundos.Items.Add(i.ToString("D2"));
            }

        }

        //Logica de los servicios de uan empresa
        logica_de_los_servicios_de_una_empresa Logica_De_Los_Servicios_De_Una_Empresa = new logica_de_los_servicios_de_una_empresa();

        //Datos de conexion
        Datos_login datos_de_la_conexion_globales = new Datos_login();

        //Datos de la empresa seleccionda
        Empresa datos_de_la_empresa_globales = new Empresa();

        //Datos del cliente
        Cliente datos_del_cliente_globales = new Cliente();

        //Datos de la reservacion
        Reservacion datos_de_la_reservacion_globales = new Reservacion();

        //logica de las reservaciones del dll
        logica_de_las_reservaciones Logica_De_Las_Reservaciones = new logica_de_las_reservaciones();

        //para poder llenar los datos 
        DataTable datos_de_los_servicos_de_la_empresa_selecionada;

        //Funcion para guardar los datos de conexion
        public void datos_de_conexion(Datos_login datos_De_conexion)
        {
            datos_de_la_conexion_globales.usuario = datos_De_conexion.usuario;
            datos_de_la_conexion_globales.constraseña = datos_De_conexion.constraseña;
            datos_de_la_conexion_globales.quien_esta = datos_De_conexion.quien_esta;

        }

        //Funcion para guardar el codigo de la empresa seleccionada
        public void datos_de_la_empresa(Empresa datos_de_la_empresa)
        {
            datos_de_la_empresa_globales.codigo = datos_de_la_empresa.codigo;

            lblNombreDeLaEmpresa.Text = datos_de_la_empresa.nombre_de_la_empresa;

        }

        //Funcion para poder guardar los datos de la reservacion del cliente
        public void guardar_datos_de_la_reservacion()
        {
            //odtener_datos_de_la_reservacion();

           // odtener_datos_de_los_servcios_de_la_empresa();

        }


        //Datos de los servicios de la empresa
        public void odtener_datos_de_los_servcios_de_la_empresa()
        {

            Servicio_de_una_Empresa servicio_De_Una_Empresa = new Servicio_de_una_Empresa();

            servicio_De_Una_Empresa.codigo_de_la_empresa = datos_de_la_empresa_globales.codigo;

            datos_de_los_servicos_de_la_empresa_selecionada =  Logica_De_Los_Servicios_De_Una_Empresa.traer_los_servicios_de_una_empresa(datos_de_la_conexion_globales, servicio_De_Una_Empresa);

            //Mostrar los servicios de la empresa registrados
            dtgServiciosDisponibles.DataSource = datos_de_los_servicos_de_la_empresa_selecionada;


            modificarcion_del_datagrip();
        }

        //Funcion para modificar el datagrip
        private void modificarcion_del_datagrip()
        {

            // Eliminar el cuadro vacío inicial (selector de filas)
            dtgServiciosDisponibles.RowHeadersVisible = false;

            // Ajustar las columnas para ocupar todo el espacio disponible
            dtgServiciosDisponibles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Opcional: Ajustar el diseño de las filas para que ocupen menos espacio
            dtgServiciosDisponibles.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Opcional: Ajustar bordes y diseño general
            dtgServiciosDisponibles.BorderStyle = BorderStyle.None;
            dtgServiciosDisponibles.AllowUserToAddRows = false;  // Deshabilitar fila de nueva adición
            dtgServiciosDisponibles.AllowUserToResizeRows = false; // Deshabilitar el cambio de tamaño de filas
            dtgServiciosDisponibles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgServiciosDisponibles.MultiSelect = false;

        }

        private void odtener_datos_de_la_reservacion()
        {
            int hora = Convert.ToInt32(cbxHora.SelectedItem);   // Hora seleccionada
            int minutos = Convert.ToInt32(cbxMinutos.SelectedItem); // Minutos seleccionados
            int segundos = Convert.ToInt32(cbxSegundos.SelectedItem); // Segundos seleccionados

            if ( hora > 7 && hora < 5 )
            {
                // Guardar la hora a string
                string hora_seleccionada = string.Format("{0:D2}:{1:D2}:{2:D2}", hora, minutos, segundos);

                //Fecha para la reservacion 
                datos_de_la_reservacion_globales.fecha_de_la_reservacion = dtpFechaSeleccionada.Value;

                //Guardar la hora de la reservacion
                datos_de_la_reservacion_globales.hora = hora_seleccionada;

                //Guardar el estado de esa reservacion
                datos_de_la_reservacion_globales.estado = "Reservado";
            }
            else
            {
                MessageBox.Show("lo siento debe escoger un hora dentro del rango de trabajos");
            }
        }

        private void odtener_datos_del_cliente()
        {

        }

        private void btAgregarEmpleado_Click(object sender, EventArgs e)
        {
            //Mostrar la interfaz de los empleados deseados y que tiene la empresa
            TrabajadorCliente TrabajadorCli = new TrabajadorCliente();
            TrabajadorCli.Show();

            //Cerrar la interfaz actual
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btHReservacion_Click(object sender, EventArgs e)
        {
            if (datos_de_los_servicos_de_la_empresa_selecionada.Rows.Count == 0)
            {
                MessageBox.Show("No puede hacer una reservacion si la empresa no tienes servicos para ofrecerle ");
            }
            else
            {
                guardar_datos_de_la_reservacion();
            }
        }

        private void VolvarADatosDeLaEmpresa(object sender, EventArgs e)
        {
            EmpresaCliente principialCliente=new EmpresaCliente();

            principialCliente.datos_de_conexion(datos_de_la_conexion_globales);

            principialCliente.datos_de_la_empresa_seleccionada(datos_de_la_empresa_globales.codigo);

            principialCliente.Show();

            this.Hide();

        }
    }
}
