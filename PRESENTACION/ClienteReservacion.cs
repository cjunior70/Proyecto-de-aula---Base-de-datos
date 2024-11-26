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

            // Agregar opciones al ComboBox
            cbxHora.Items.Add("11");
            cbxMinutos.Items.Add("2");
            cbxSegundos.Items.Add("3");

        }

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

        //Funcion para guardar los datos de conexion
        public void datos_de_conexion(Datos_login datos_De_conexion)
        {
            datos_de_la_conexion_globales.usuario = datos_De_conexion.usuario;
            datos_de_la_conexion_globales.constraseña = datos_De_conexion.constraseña;

        }

        //Funcion para guardar el codigo de la empresa seleccionada
        public void datos_de_la_empresa(Empresa datos_de_la_empresa)
        {
            datos_de_la_empresa_globales.codigo = datos_de_la_empresa.codigo;

        }

        //Funcion para poder guardar los datos de la reservacion del cliente
        public void guardar_datos_de_la_reservacion()
        {
            odtener_datos_de_la_reservacion();

            

        }

        private void odtener_datos_de_la_reservacion()
        {
            int hora = Convert.ToInt32(cbxHora.SelectedItem);   // Hora seleccionada
            int minutos = Convert.ToInt32(cbxMinutos.SelectedItem); // Minutos seleccionados
            int segundos = Convert.ToInt32(cbxSegundos.SelectedItem); // Segundos seleccionados

            // Guardar la hora a string
            string hora_seleccionada = string.Format("{0:D2}:{1:D2}:{2:D2}", hora, minutos, segundos);

            dtpFechaActual.Value = DateTime.Now;

            //Fecha para la reservacion en la que se esta haciendo
            datos_de_la_reservacion_globales.creacion_de_la_reservacion = dtpFechaActual.Value;

            //Fecha para la reservacion 
            datos_de_la_reservacion_globales.fecha_de_la_reservacion = dtpFechaSeleccionada.Value;

            //Guardar la hora de la reservacion
            datos_de_la_reservacion_globales.hora = hora_seleccionada;

            //Guardar el estado de esa reservacion
            datos_de_la_reservacion_globales.estado = "Reservado";
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
            guardar_datos_de_la_reservacion();
        }
    }
}
