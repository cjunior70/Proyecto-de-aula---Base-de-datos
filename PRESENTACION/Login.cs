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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        //Entrada del sistema
        Datos_login datos_de_conexion = new Datos_login();

        //Datatable para poder saber la exixstencia de la persona que quiere entrar al programa
        DataTable existencia = new DataTable();

        logica_de_los_clientes logica_De_Los_Clientes = new logica_de_los_clientes();

        logica_de_los_usuarios logica_De_Los_Usuarios = new logica_de_los_usuarios();

        logica_de_los_empleados logica_De_Los_Empleados = new logica_de_los_empleados();

        private void lbEntrarB_Click(object sender, EventArgs e)
        {
            datos_de_conexion.usuario = txtUsuario.Text;
            datos_de_conexion.constraseña = txtContraseña.Text;
            datos_de_conexion.cedula_del_usuario = txtContraseña.Text;

            Boolean confirmacion;

            Funcion_de_conexion funcion_De_Conexion = new Funcion_de_conexion();


           if (datos_de_conexion.usuario == "admin" && datos_de_conexion.constraseña == "admin")
           {
                datos_de_conexion.quien_esta = 'A';

                confirmacion = funcion_De_Conexion.conexion(datos_de_conexion);

                if (confirmacion == false)
                {
                    MessageBox.Show("Usuario o datos Invalidos");
                }
                else
                {
                    interfaz_principal_cliente();
                }
                
           }
           else
           {
               consultar_quien_entra();
           } 


        }

        private void consultar_quien_entra()
        {

            //Variable para la confirmacion de datos
            Boolean confirmacion;

            datos_de_conexion.usuario = "cliente";
            datos_de_conexion.constraseña = "cliente";  

            confirmacion =  buscar_existencia_del_cliente();

            if( confirmacion == true )
            {
                //Si el datatatble no esta vacio entonces entro un cliente
                datos_de_conexion.quien_esta = 'C';

                interfaz_principal_cliente();

            }
            else
            {
                datos_de_conexion.usuario = "empleado";
                datos_de_conexion.constraseña = "empleado1";

                confirmacion = buscar_existencia_del_usuario();

                if( confirmacion == true )
                {
                    //Si el datatatble no esta vacio entonces entro un cliente
                    datos_de_conexion.quien_esta = 'U';

                    interfaz_principal_usuario();

                }
                else
                {
                    confirmacion = buscar_existencia_del_empleado();

                    if( confirmacion == true)
                    {
                        //Si el datatatble no esta vacio entonces entro un cliente
                        datos_de_conexion.quien_esta = 'E';

                        //interfaz_principal_empleado();

                        MessageBox.Show("Aun falta la interfaz del empleado");
                    }
                    else
                    {
                        MessageBox.Show("Usuario invalido");
                    }
                }

            }

            
        }

        //Interfaz para poder entrar a la interfaz del cliente
        private void interfaz_principal_cliente()
        {

            //Funcion para entrar a la interfaz principal
            PrincipialCliente Interfaz_del_cliente_principal = new PrincipialCliente();
            Interfaz_del_cliente_principal.datos_de_conexion(datos_de_conexion);
            Interfaz_del_cliente_principal.Show();
            Interfaz_del_cliente_principal.buscar_todas_las_empresa();

            //Para cerrar la interfaz actual
            this.Hide();

        }

        //Interfaz para poder entrar a la interfaz del usuario
        private void interfaz_principal_usuario()
        {

            //Funcion para entrar a la interfaz principal
            PrincipalUsuario interfaz_del_usuario_principal = new PrincipalUsuario();
            interfaz_del_usuario_principal.datos_de_conexion(datos_de_conexion);
            interfaz_del_usuario_principal.Show();

            //Para cerrar la interfaz actual
            this.Hide();

        }

        //Interfaz para poder entrar a la interfaz del empleado
        private void interfaz_principal_empleado()
        {

            //Funcion para entrar a la interfaz principal
           

        }

        //Funcion para buscar si los datos que se ingreso son de un cliente
        private Boolean buscar_existencia_del_cliente()
        {
            Boolean confirmacion;

            Cliente datos_del_cliente = new Cliente();
            datos_del_cliente.cedula = datos_de_conexion.cedula_del_usuario;

            existencia = logica_De_Los_Clientes.consulta_De_datos_personales(datos_del_cliente, datos_de_conexion);


            if( existencia == null )
            {
                confirmacion = false;
            }
            else
            {
                confirmacion = true;
            }

            return confirmacion;

        }

        //Funcion para buscar si los datos que se ingreso son de un usuario
        private Boolean buscar_existencia_del_usuario()
        {
            Boolean confirmacion;

            Usuario datos_del_usuario = new Usuario();
            datos_del_usuario.cedula = datos_de_conexion.constraseña;

            existencia = logica_De_Los_Usuarios.consulta_De_datos_personales(datos_del_usuario, datos_de_conexion);

            if (existencia == null)
            {
                confirmacion = false;
            }
            else
            {
                confirmacion = true;
            }

            return confirmacion;

        }

        //Funcion para buscar si los datos que se ingreso son de un empleado
        private Boolean buscar_existencia_del_empleado()
        {
            Boolean confirmacion;

            Empleados datos_del_empleado = new Empleados();
            datos_del_empleado.cedula = datos_de_conexion.constraseña;

            existencia = logica_De_Los_Empleados.consultar_datos_de_un_empleado(datos_del_empleado, datos_de_conexion);

            if (existencia == null)
            {
                confirmacion = false;
            }
            else
            {
                confirmacion = true;
            }

            return confirmacion;

        }

        private void btnRegistrarme_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Tiene una empresa para registrar ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //Datos de conexion
            Datos_login datos_de_la_conexion = new Datos_login();

            datos_de_la_conexion.usuario = "admin";
            datos_de_la_conexion.constraseña = "admin";

            if (result == DialogResult.No)
            {

                // Lógica para la opción "No"
                RegisCliente regisCliente = new RegisCliente();
                regisCliente.datos_de_conexion(datos_de_la_conexion);
                regisCliente.Show();

                // Ocultar el formulario actual
                this.Hide();
            }
            else if (result == DialogResult.Yes)
            {
                // Lógica para la opción "Yes"
                RegisUsuario regisUsuario = new RegisUsuario();
                regisUsuario.datos_de_conexion(datos_de_la_conexion);
                regisUsuario.Show();

                // Ocultar el formulario actual
                this.Hide();
            }
        }

        private void btnContactos_Click(object sender, EventArgs e)
        {
            //Es para poder abiri la interfaz de contactos
            Contactos contactos=new Contactos();
            contactos.Show();

            //Es para poder cerrar la interfaz actual
            this.Hide();
        }
    }
}