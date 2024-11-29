using DLL;
using ENTITY;
using System;
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
    public partial class TrabajadorCliente : Form
    {
        public TrabajadorCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Variable global para poder saber la ubicacion de la coleccion de los datos de las empresas
        int Fila_Actual = 0;

        //Variable pára poder tener el valor de las filas del la primera empresa
        int Primer_valor_de_las_filas = 0;

        //Variable pára poder tener el valor de las filas del la segunda empresa
        int Segunda_valor_de_las_filas = 0;

        //Variable pára poder tener el valor de las filas del la tercera empresa
        int Tercera_valor_de_las_filas = 0;


        //lista de los empleados que estan en la empreesa
        List<Empleados> lista_de_los_empleados_de_la_empresa_globales = new List<Empleados>();

        //Logica de los empleados
        logica_de_los_empleados Logica_De_Los_Empleados = new logica_de_los_empleados();

        //Datos de la empresa seleccionda
        Empresa datos_de_la_empresa_globales = new Empresa();

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

        public void datos_de_la_empresa(Empresa datos_de_la_empresa)
        {
            datos_de_la_empresa_globales = datos_de_la_empresa;
        }

        public void buscar_todos_los_empleado_de_la_empreesa()
        {
            lista_de_los_empleados_de_la_empresa_globales = Logica_De_Los_Empleados.consultar_todos_los_empleados_de_una_empresa_y_devolver_una_lista(datos_de_la_conexion_globales, datos_de_la_empresa_globales);

            MessageBox.Show("empleados : " + lista_de_los_empleados_de_la_empresa_globales.Count);

            mostrar_empleados_de_la_empresa();
        }

        private void mostrar_empleados_de_la_empresa()
        {
            pnl1.Visible = true;
            lblNombre1.Visible = true;
            pnl2.Visible = true;
            lblNombre2.Visible = true;
            pnl3.Visible = true;
            lblNombre3.Visible = true;

            if( Fila_Actual <= lista_de_los_empleados_de_la_empresa_globales.Count -1 )
            {
                var empleado = lista_de_los_empleados_de_la_empresa_globales[Fila_Actual];

                lblNombre1.Text = empleado.Primer_nombre + "  " +  empleado.Primer_apellido;

                Primer_valor_de_las_filas = Fila_Actual;

                Fila_Actual++;

                

                if(Fila_Actual <= lista_de_los_empleados_de_la_empresa_globales.Count - 1 && empleado.Primer_nombre != null)
                {
                    var empleado2 = lista_de_los_empleados_de_la_empresa_globales[Fila_Actual];

                    lblNombre2.Text = empleado.Primer_nombre + "  " + empleado.Primer_apellido;

                    Primer_valor_de_las_filas = Fila_Actual;

                    Fila_Actual++;

                    

                    if(Fila_Actual <= lista_de_los_empleados_de_la_empresa_globales.Count - 1 && empleado.Primer_nombre != null)
                    {
                        var empleado3 = lista_de_los_empleados_de_la_empresa_globales[Fila_Actual];

                        lblNombre3.Text = empleado.Primer_nombre + "  " + empleado.Primer_apellido;

                        Primer_valor_de_las_filas = Fila_Actual;

                        Fila_Actual++;

                       
                    }
                    else
                    {
                        pnl3.Visible = false;
                    }

                }
                else
                {
                    pnl2.Visible = false;
                    pnl3.Visible = false;
                }

            }
            else
            {
                pnl1.Visible = false;
                pnl2.Visible = false;
                pnl3.Visible = false;

                MessageBox.Show("No hay mas Empresas Disponbiles");
            }
           
        }

        private void DatosEmpleados1(object sender, EventArgs e)
        {
            //Abre la interfez de datosempleado
            DatosEmpleado datosEmpleado=new DatosEmpleado();
            datosEmpleado.Show();

            //Cerrar interfaz actual
            this.Hide();
        }

        private void DatosEmpleados2(object sender, EventArgs e)
        {
            //Abre la interfez de datosempleado
            DatosEmpleado datosEmpleado = new DatosEmpleado();
            datosEmpleado.Show();

            //Cerrar interfaz actual
            this.Hide();
        }

        private void DatosEmpleados3(object sender, EventArgs e)
        {
            //Abre la interfez de datosempleado
            DatosEmpleado datosEmpleado = new DatosEmpleado();
            datosEmpleado.Show();

            //Cerrar interfaz actual
            this.Hide();
        }
    }
}
