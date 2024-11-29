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
    public partial class EmpresaCliente : Form
    {
        public EmpresaCliente()
        {
            InitializeComponent();
        }

        //Datos de conexion
        Datos_login datos_de_la_conexion_globales = new Datos_login();

        //Codigo de la empresa que se queiere conocer
        int codigo_de_la_empresa_global ;

        //Datos de la empresa globales
        List<Empresa> datos_de_la_empresa_globales = new List<Empresa>();

        //Funciones de la capa logica de la empresa
        logica_de_las_empresas Logica_De_Las_Empresas = new logica_de_las_empresas();

        //Funciones de la capa logica del usuario
        logica_de_los_usuarios Logica_De_Los_Usuarios = new logica_de_los_usuarios();

        //Variable para poder tener el codigo de la ubicacion
        Ubicacion datos_de_la_ubicacion_global = new Ubicacion();

        public void datos_de_conexion(Datos_login datos_De_conexion)
        {
            datos_de_la_conexion_globales.usuario = datos_De_conexion.usuario;
            datos_de_la_conexion_globales.constraseña = datos_De_conexion.constraseña;
            datos_de_la_conexion_globales.cedula_del_usuario = datos_De_conexion.cedula_del_usuario;
            datos_de_la_conexion_globales.quien_esta = datos_De_conexion.quien_esta;

        }

        public void datos_de_la_empresa_seleccionada(int codigo_de_la_empresa_seleccionada)
        {

            if (datos_de_la_conexion_globales.quien_esta == 'E')
            {
                btHReservacion.Visible = false;
            }

            codigo_de_la_empresa_global = codigo_de_la_empresa_seleccionada;

            buscar_datos_de_la_empresa_seleccionada();
        }

        private void buscar_datos_de_la_empresa_seleccionada()
        {
            Empresa datos_de_la_empresa = new Empresa();

            datos_de_la_empresa.codigo = codigo_de_la_empresa_global;

            datos_de_la_empresa_globales =  Logica_De_Las_Empresas.consultar_datos_de_una_empresa(datos_de_la_empresa, datos_de_la_conexion_globales);

            mostrar_datos_de_la_empresa();
        }

        private void mostrar_datos_de_la_empresa()
        {
            lblNombreDeLaEmpresa.Text = datos_de_la_empresa_globales[0].nombre_de_la_empresa.ToString();
            txtUbicacionDemaneraLocal.Text = datos_de_la_empresa_globales[0].descripcion_de_la_localizacion.ToString();
            txtDescripcionDeLaEmpresa.Text = datos_de_la_empresa_globales[0].descripcion_de_la_empresa.ToString();

            using (MemoryStream ms = new MemoryStream(datos_de_la_empresa_globales[0].imagen_miniatura))
            {
                picImagenGeneral.Image = Image.FromStream(ms); // Convertir el byte[] a una imagen y asignarlo al PictureBox
            }

            buscar_datos_del_propietario();

            datos_de_la_ubicacion_global.codigo = datos_de_la_empresa_globales[0].ubicaion.codigo;

        }

        private void buscar_datos_del_propietario()
        {
            Usuario datos_del_usuario = new Usuario();

            datos_del_usuario.codigo = datos_de_la_empresa_globales[0].usuario.codigo;

            DataTable datos_recolectados = new DataTable();

            datos_recolectados =  Logica_De_Los_Usuarios.consulta_De_datos_personales_por_codigo( datos_del_usuario, datos_de_la_conexion_globales);

            Usuario recolecion_de_datos_del_usuario = new Usuario();

            recolecion_de_datos_del_usuario.Primer_nombre = Convert.ToString(datos_recolectados.Rows[0]["PRIMER_NOMBRE"]);
            recolecion_de_datos_del_usuario.Primer_apellido = Convert.ToString(datos_recolectados.Rows[0]["PRIMER_APELLIDO"]);

            txtNombreDelUsuario.Text = recolecion_de_datos_del_usuario.Primer_nombre + " " + recolecion_de_datos_del_usuario.Primer_apellido;
        }

        private void btHReservacion_Click(object sender, EventArgs e)
        {
            //Variable para poder guardar el codigo de la empresa y enviarla a la interfaz de la reservacion
            Empresa datos_de_la_empresa = new Empresa();

            datos_de_la_empresa.codigo = datos_de_la_empresa_globales[0].codigo;
            datos_de_la_empresa.nombre_de_la_empresa = datos_de_la_empresa_globales[0].nombre_de_la_empresa;

            //Funcion para poder ir a la interfaz de la reservacion     
            ClienteReservacion reserva = new ClienteReservacion();
            reserva.datos_de_conexion(datos_de_la_conexion_globales);
            reserva.datos_de_la_empresa(datos_de_la_empresa);
            reserva.odtener_datos_de_los_servcios_de_la_empresa();
            reserva.odtener_datos_de_los_empleados_de_una_empresa();
            reserva.Show();

             //Cerrar interfaz actual
             this.Hide();
         }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            //Funcion para ir al logn
            PrincipialCliente FrmLog = new PrincipialCliente();
            FrmLog.datos_de_conexion(datos_de_la_conexion_globales);
            FrmLog.buscar_todas_las_empresa();
            FrmLog.Show();

            //Cerrar interfaz actual
            this.Hide();
        }

        private void btGoogleMaps_Click(object sender, EventArgs e)
        {
            //Para abir la interfaz del mapa y mostrar la ubicacion
            Google_Maps frm = new Google_Maps();
            frm.datos_de_conexion(datos_de_la_conexion_globales);
            frm.guardar_codigo_de_la_ubicacion_de_la_empresa_seleccionada(datos_de_la_ubicacion_global);
            frm.Show();

            //Para cerrar la interfaz actual
            this.Hide();
        }
        
        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void IrAContantos(object sender, EventArgs e)
        {
            //Abiri la interfaz de contacos de la empresa
            Contactos contactos = new Contactos();
            contactos.Show();

            //Cerrar la interfaz actual
            this.Hide();

        }
    }
}
