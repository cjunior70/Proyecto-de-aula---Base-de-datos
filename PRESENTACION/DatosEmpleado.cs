using DLL;
using ENTITY;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRESENTACION
{
    public partial class DatosEmpleado : Form
    {
        public DatosEmpleado()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Datos de la empresa seleccionda
        Empresa datos_de_la_empresa_globales = new Empresa();

        //Datos del empleado
        Empleados datos_Del_empleado_gloables = new Empleados();

        //logica de los servicios de un empleado
        logica_de_los_servicios_de_un_empleado Logica_De_Los_Servicios_De_Un_Empleado = new logica_de_los_servicios_de_un_empleado();

        DataTable lista_de_servicios_de_interes=new DataTable();

        DataTable lista_de_servicios_disponibles= new DataTable();

        //Datos de conexion
        Datos_login datos_de_la_conexion_globales = new Datos_login();

        //Funcion para guardar los datos de conexion
        public void datos_de_conexion(Datos_login datos_De_conexion)
        {
            datos_de_la_conexion_globales.usuario = datos_De_conexion.usuario;
            datos_de_la_conexion_globales.constraseña = datos_De_conexion.constraseña;
            datos_de_la_conexion_globales.cedula_del_usuario = datos_De_conexion.cedula_del_usuario;
            datos_de_la_conexion_globales.quien_esta = datos_De_conexion.quien_esta;

        }

        public void datos_del_empleado(Empleados datos_del_empleado)
        {
            datos_Del_empleado_gloables = datos_del_empleado;
        }

        public void datos_de_la_empresa(Empresa datos_de_la_empresa)
        {
            datos_de_la_empresa_globales = datos_de_la_empresa;
        }

        public void mostrar_datos_del_empleado()
        {

            using (MemoryStream ms = new MemoryStream(datos_Del_empleado_gloables.Foto))
            {
                picFoto.Image = Image.FromStream(ms); // Convertir el byte[] a una imagen y asignarlo al PictureBox
            }

            lbPrimerNombre.Text = datos_Del_empleado_gloables.Primer_nombre;
            lbSegundoNombre.Text = datos_Del_empleado_gloables.Segundo_apellido;
            lbCedula.Text = datos_Del_empleado_gloables.cedula;
            lbSexo.Text = datos_Del_empleado_gloables.sexo.ToString();
            lbTelefono.Text = datos_Del_empleado_gloables.telefono.ToString();
            lbCorreoElec.Text = datos_Del_empleado_gloables.correo_electronico.ToString();
            lbEstado.Text = datos_Del_empleado_gloables.estado.ToString();

        }

        public void mostrar_los_servicios_de_ese_empleado()
        {

            Servicio_de_un_empleado datos_del_servicio_del_empleado = new Servicio_de_un_empleado();

            datos_del_servicio_del_empleado.codigo_del_empleado = datos_Del_empleado_gloables.codigo;

            lista_de_servicios_disponibles = Logica_De_Los_Servicios_De_Un_Empleado.traer_los_servicios_de_un_empleado(datos_de_la_conexion_globales, datos_del_servicio_del_empleado);

            dtgServicosDisponibles.DataSource = lista_de_servicios_disponibles;

            // Agregar columnas manualmente
            lista_de_servicios_de_interes.Columns.Add("codigo", typeof(int));  // Agregar la columna 'codigo' con tipo 'int'
            lista_de_servicios_de_interes.Columns.Add("nombre", typeof(string)); // Agregar la columna 'nombre' con tipo 'string'
            
        }

        private void btGuardarDatosReservacion_Click(object sender, EventArgs e)
        {

            //Funcion para poder ir a la interfaz de la reservacion     
            ClienteReservacion reserva = new ClienteReservacion();
            reserva.datos_de_conexion(datos_de_la_conexion_globales);
            reserva.datos_de_la_empresa(datos_de_la_empresa_globales);
            reserva.odtener_datos_de_los_servcios_de_la_empresa();
            reserva.odtener_datos_de_los_empleados_de_una_empresa();
            reserva.lista_de_servicios_queridos(lista_de_servicios_de_interes);
            reserva.guardar_datos_del_empleado(datos_Del_empleado_gloables);
            reserva.Show();

             //Cerrar interfaz actual
             this.Hide();

        }

        private void CogerDatosDelServicio(object sender, DataGridViewCellEventArgs e)
        {

            int rowIndex = e.RowIndex; // Índice de la fila
            int columnIndex = e.ColumnIndex; // Índice de la columna

            // Crear una copia de la fila y agregarla a la lista de servicios de interés
            DataRow nuevaFila = lista_de_servicios_de_interes.NewRow();
            nuevaFila["codigo"] = lista_de_servicios_disponibles.Rows[rowIndex]["codigo"];
            nuevaFila["nombre"] = lista_de_servicios_disponibles.Rows[rowIndex]["nombre"];

            lista_de_servicios_de_interes.Rows.Add(nuevaFila);

            nuevaFila = null;

            dataGridListaServiciosSeleccionado.DataSource = lista_de_servicios_de_interes;

        }
    }
}
