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

        //Datos de la empresa seleccionda
        Empresa datos_de_la_empresa_globales = new Empresa();

        //Datos del empleado
        Empleados datos_del_empleado_gloables=new Empleados();

        //Datos del cliente
        Cliente datos_del_cliente_globales = new Cliente();

        //Datos de la reservacion
        Reservacion datos_de_la_reservacion_globales = new Reservacion();

        //logica de las reservaciones del dll
        logica_de_las_reservaciones Logica_De_Las_Reservaciones = new logica_de_las_reservaciones();

        //Logica de los empleados
        logica_de_los_empleados Logica_De_Los_Empleados = new logica_de_los_empleados();

        //Datos del cliente
        logica_de_los_clientes logica_De_Los_Clientes = new logica_de_los_clientes();

        //para poder llenar los datos 
        DataTable datos_de_los_servicos_de_la_empresa_selecionada;

        //para poder llenar los datos
        DataTable datos_del_cliente;

        //para poder llenar los datos 
        DataTable datos_de_los_empleados_de_la_empresa_selecionada;

        //Datos de conexion
        Datos_login datos_de_la_conexion_globales = new Datos_login();

        //Funcion para guardar los datos de conexion
        public void datos_de_conexion(Datos_login datos_De_conexion)
        {
            datos_de_la_conexion_globales.usuario = datos_De_conexion.usuario;
            datos_de_la_conexion_globales.constraseña = datos_De_conexion.constraseña;
            datos_de_la_conexion_globales.cedula_del_usuario = datos_De_conexion.cedula_del_usuario;
            datos_de_la_conexion_globales.quien_esta = datos_De_conexion.quien_esta;

            datos_del_cliente_globales.cedula = datos_De_conexion.cedula_del_usuario;

        }

        //Funcion para guardar el codigo de la empresa seleccionada
        public void datos_de_la_empresa(Empresa datos_de_la_empresa)
        {
            datos_de_la_empresa_globales.codigo = datos_de_la_empresa.codigo;

            lblNombreDeLaEmpresa.Text = datos_de_la_empresa.nombre_de_la_empresa;

        }

        //Funcion para guardar la lista de los servicios queridos
        public void lista_de_servicios_queridos(DataTable lista_de_servicios_de_interes)
        {
            dgEmpleadosSeleccionados.DataSource = lista_de_servicios_de_interes;
        }


        //Funcion para poder guardar los datos de la reservacion del cliente
        public void guardar_datos_de_la_reservacion()
        {
            Boolean confirmacion;

            DataTable datos_de_reservacion_de_la_base;

            odtener_datos_de_la_reservacion();

            confirmacion = Logica_De_Las_Reservaciones.registrar_una_reservacion(datos_de_la_conexion_globales, datos_de_la_reservacion_globales);

            if ( confirmacion == true)
            {

                datos_del_cliente = logica_De_Los_Clientes.consulta_De_datos_personales(datos_del_cliente_globales, datos_de_la_conexion_globales);

                datos_de_reservacion_de_la_base = Logica_De_Las_Reservaciones.buscar_una_reservacion(datos_de_la_conexion_globales, datos_de_la_reservacion_globales);

                datos_de_la_reservacion_globales.empresa.codigo = datos_de_la_empresa_globales.codigo;

                datos_de_la_reservacion_globales.Cliente.codigo = Convert.ToInt16( datos_del_cliente.Rows[0]["codigo"] );

                datos_de_la_reservacion_globales.codigo = Convert.ToString( datos_de_reservacion_de_la_base.Rows[0]["codigo"] );

                guardar_datos_del_empleado_de_la_reservacion();
                guardar_datos_del_cliente_de_la_reservacion();
                guardar_datos_del_servicio_de_la_reservacion();
            }
            else
            {
                MessageBox.Show("Error al hacer la reservaciones");
            }

        }


        private void guardar_datos_del_empleado_de_la_reservacion()
        {
            logica_de_los_empleados_de_una_reservacion logica_De_Los_Empleados_De_Una_Reservacion = new logica_de_los_empleados_de_una_reservacion();

            Boolean confirmacion;

            Empleados_de_una_reservacion empleados_De_Una_Reservacion = new Empleados_de_una_reservacion();

            // empleados_De_Una_Reservacion.codigo_de_reservacion = Convert.ToInt16( datos_de_la_reservacion_globales.codigo );
            empleados_De_Una_Reservacion.codigo_de_reservacion = 3;
            empleados_De_Una_Reservacion.codigo_de_empleado = datos_del_empleado_gloables.codigo;

            confirmacion = logica_De_Los_Empleados_De_Una_Reservacion.registrar_un_empleado_a_una_reservacion(empleados_De_Una_Reservacion, datos_de_la_conexion_globales);

            
        }

        private void guardar_datos_del_cliente_de_la_reservacion()
        {
            Logica_de_la_reservacion_de_un_cliente logica_De_La_Reservacion_De_Un_Cliente = new Logica_de_la_reservacion_de_un_cliente();

            Boolean confirmacion;

            Reservacion datos_del_cliente = new Reservacion();

            datos_del_cliente_globales.codigo = 8;

            datos_del_cliente.Cliente = datos_del_cliente_globales; //datos_del_cliente_globales.codigo;
            datos_del_cliente.codigo = "3" ;

            confirmacion = logica_De_La_Reservacion_De_Un_Cliente.registrar_un_empleado_a_una_reservacion(datos_de_la_conexion_globales, datos_del_cliente);

            MessageBox.Show("Estado : " + confirmacion);
        }

        private void guardar_datos_del_servicio_de_la_reservacion()
        {
            logica_De_los_servicios_de_una_reservacion logica_De_Los_Servicios_De_Una_Reservacion = new logica_De_los_servicios_de_una_reservacion();

            Boolean confirmacion;

            Reservacion datos_del_cliente = new Reservacion();

            datos_del_cliente_globales.codigo = 8;

            Servicio_de_una_reservacion servicio_De_Una_Reservacion = new Servicio_de_una_reservacion();

            servicio_De_Una_Reservacion.codigo_de_reservacion = 8;

          //  servicio_De_Una_Reservacion.

            //confirmacion = logica_De_Los_Servicios_De_Una_Reservacion.registrar_servicio_a_una_reservacion(datos_de_la_conexion_globales)

        }

        //Datos de los servicios de la empresa
        public void odtener_datos_de_los_servcios_de_la_empresa()
        {

            Servicio_de_una_Empresa servicio_De_Una_Empresa = new Servicio_de_una_Empresa();

            servicio_De_Una_Empresa.codigo_de_la_empresa = datos_de_la_empresa_globales.codigo;

            datos_de_los_servicos_de_la_empresa_selecionada =  Logica_De_Los_Servicios_De_Una_Empresa.traer_los_servicios_de_una_empresa(datos_de_la_conexion_globales, servicio_De_Una_Empresa);

            //Mostrar los servicios de la empresa registrados
            dtgServiciosDisponibles.DataSource = datos_de_los_servicos_de_la_empresa_selecionada;

            modificarcion_del_datagrip_de_los_servicios_disponibles();
        }

        //Datos de los empleados de la empresa
        public void odtener_datos_de_los_empleados_de_una_empresa()
        {

            Empresa datos_de_empresa = new Empresa();

            datos_de_empresa.codigo = datos_de_la_empresa_globales.codigo;

            datos_de_los_empleados_de_la_empresa_selecionada = Logica_De_Los_Empleados.consultar_todos_los_empleados_de_una_empresa(datos_de_la_conexion_globales, datos_de_empresa);

            //Mostrar los servicios de la empresa registrados
            dtgEmpleadosDisponibles.DataSource = datos_de_los_empleados_de_la_empresa_selecionada;


            modificarcion_del_datagripempleados_disponibles();
        }

        //Funcion para modificar el datagrip
        private void modificarcion_del_datagripempleados_disponibles()
        {

            // Eliminar el cuadro vacío inicial (selector de filas)
            dtgEmpleadosDisponibles.RowHeadersVisible = false;

            // Ajustar las columnas para ocupar todo el espacio disponible
            dtgEmpleadosDisponibles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Opcional: Ajustar el diseño de las filas para que ocupen menos espacio
            dtgEmpleadosDisponibles.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Opcional: Ajustar bordes y diseño general
            dtgEmpleadosDisponibles.BorderStyle = BorderStyle.None;
            dtgEmpleadosDisponibles.AllowUserToAddRows = false;  // Deshabilitar fila de nueva adición
            dtgEmpleadosDisponibles.AllowUserToResizeRows = false; // Deshabilitar el cambio de tamaño de filas
            dtgEmpleadosDisponibles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgEmpleadosDisponibles.MultiSelect = false;

            // Ocultar columnas no deseadas
            dtgEmpleadosDisponibles.Columns["SEGUNDO_NOMBRE"].Visible = false;
            dtgEmpleadosDisponibles.Columns["SEGUNDO_APELLIDO"].Visible = false;
            dtgEmpleadosDisponibles.Columns["TELEFONO"].Visible = false;
            dtgEmpleadosDisponibles.Columns["CORREO_ELECTRONICO"].Visible = false;
            dtgEmpleadosDisponibles.Columns["FOTO"].Visible = false;
            dtgEmpleadosDisponibles.Columns["CUPOS_DISPONIBLES_POR_DIA"].Visible = false;
            dtgEmpleadosDisponibles.Columns["FECHA_DE_INICIO"].Visible = false;
            dtgEmpleadosDisponibles.Columns["FECHA_FINAL"].Visible = false;
            dtgEmpleadosDisponibles.Columns["CARGO"].Visible = false;
            dtgEmpleadosDisponibles.Columns["EMPRESA_CODIGO"].Visible = false;
            dtgEmpleadosDisponibles.Columns["SEXO"].Visible = false;

            // Cambiar el encabezado de la columna "PRIMER_NOMBRE" a "Nombre"
            dtgEmpleadosDisponibles.Columns["PRIMER_NOMBRE"].HeaderText = "Nombre";

            // Si tienes más columnas que renombrar, simplemente añade más líneas
            dtgEmpleadosDisponibles.Columns["PRIMER_APELLIDO"].HeaderText = "Apellido";
            dtgEmpleadosDisponibles.Columns["CEDULA"].HeaderText = "Cédula";
            dtgEmpleadosDisponibles.Columns["ESTADO"].HeaderText = "Estado";

            // Autoajustar el ancho de todas las columnas al contenido
            dtgEmpleadosDisponibles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        //Funcion para modificar el datagrip
        private void modificarcion_del_datagrip_de_los_servicios_disponibles()
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

            odtener_datos_del_cliente();

            int hora = Convert.ToInt32(cbxHora.SelectedItem);   // Hora seleccionada
            int minutos = Convert.ToInt32(cbxMinutos.SelectedItem); // Minutos seleccionados
            int segundos = Convert.ToInt32(cbxSegundos.SelectedItem); // Segundos seleccionados

            if ( hora > 7 && hora < 16 )
            {
                // Guardar la hora a string
                string hora_seleccionada = string.Format("{0:D2}:{1:D2}:{2:D2}", hora, minutos, segundos);

                //Fecha para la reservacion 
                datos_de_la_reservacion_globales.fecha_de_la_reservacion = dtpFechaSeleccionada.Value;

                MessageBox.Show("fecha : " + dtpFechaSeleccionada.Value);

                datos_de_la_reservacion_globales.empresa = datos_de_la_empresa_globales;

                datos_de_la_reservacion_globales.Cliente = datos_del_cliente_globales;
                
                //Guardar el estado de esa reservacion
                datos_de_la_reservacion_globales.estado = "Reservado";

                //Guardar la hora de la reservacion
                datos_de_la_reservacion_globales.hora = hora_seleccionada;
            }
            else
            {
                MessageBox.Show("lo siento debe escoger un hora dentro del rango de trabajos");
            }
        }

        private void odtener_datos_del_cliente()
        {

            datos_del_cliente_globales.cedula = datos_de_la_conexion_globales.cedula_del_usuario;

            DataTable datos_cliente;

            datos_cliente = logica_De_Los_Clientes.consulta_De_datos_personales(datos_del_cliente_globales, datos_de_la_conexion_globales);

            datos_del_cliente_globales.codigo = int.Parse(datos_cliente.Rows[0]["CODIGO"].ToString());

        }

        public void guardar_datos_del_empleado(Empleados datos_del_empleado)
        {
            datos_del_empleado_gloables = datos_del_empleado;

        }

        private void btAgregarEmpleado_Click(object sender, EventArgs e)
        {
            //Mostrar la interfaz de los empleados deseados y que tiene la empresa
            TrabajadorCliente TrabajadorCli = new TrabajadorCliente();
            TrabajadorCli.datos_de_conexion(datos_de_la_conexion_globales);
            TrabajadorCli.datos_de_la_empresa(datos_de_la_empresa_globales);
            TrabajadorCli.buscar_todos_los_empleado_de_la_empreesa();
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
