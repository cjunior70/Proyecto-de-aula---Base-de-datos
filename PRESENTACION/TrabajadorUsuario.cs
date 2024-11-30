using DLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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

        //Datos de la empresa
        Empresa datos_de_la_empresa_globales = new Empresa();

        public void datos_de_conexion(Datos_login datos_De_conexion)
        {
            datos_de_la_conexion_globales.usuario = datos_De_conexion.usuario;
            datos_de_la_conexion_globales.constraseña = datos_De_conexion.constraseña;
            datos_de_la_conexion_globales.cedula_del_usuario = datos_De_conexion.cedula_del_usuario;
            datos_de_la_conexion_globales.quien_esta = datos_De_conexion.quien_esta;
        }


        public void guardar_datos_de_la_empresa(Empresa datos_de_la_empresa)
        {
            datos_de_la_empresa_globales = datos_de_la_empresa;
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

        private void guardar_foto()
        {
            Empleados datos_de_la_foto = new Empleados();

            MemoryStream imagen = new MemoryStream();

            picFoto.Image.Save(imagen, ImageFormat.Jpeg);
            byte[] foto_De_perfil = imagen.ToArray();

            datos_de_la_foto.Foto = foto_De_perfil;
            datos_de_la_foto.cedula = txtCedula.Text;

            Boolean confirmacion;

            confirmacion =  logica_De_Los_Empleados.guardar_foto( datos_de_la_foto, datos_de_la_conexion_globales);

            MessageBox.Show("estado de la fot : " + confirmacion);
        }

        private void btnGuardarDatos_Click(object sender, EventArgs e)
        {
            Empleados datos_del_empleado = new Empleados();

            MemoryStream imagen = new MemoryStream();

            picFoto.Image.Save(imagen, ImageFormat.Jpeg);
            byte[] foto_De_perfil = imagen.ToArray();

            datos_del_empleado.Foto = foto_De_perfil;

            datos_del_empleado.cedula = txtCedula.Text;
            datos_del_empleado.Primer_nombre = txtPrimerNombre.Text;
            datos_del_empleado.Segundo_nombre = txtSegundoNombre.Text;
            datos_del_empleado.Primer_apellido = txtPrimerApellido.Text;
            datos_del_empleado.Segundo_apellido = txtSegundoApellido.Text;
            datos_del_empleado.telefono = txtTelefono.Text;
            datos_del_empleado.correo_electronico = txtCorreo.Text;
            datos_del_empleado.fecha_de_final =  dtpFechaActual.Value;
            datos_del_empleado.fecha_de_inicio =   dtpFechaIncio.Value;
            
            if( cbxEstado.Text == "Disponible")
            {
                datos_del_empleado.estado = "Y";
            }
            else
            {
                datos_del_empleado.estado = "N";
            }

            datos_del_empleado.cupos_disponibles =  int.Parse( cbxLimiteDeCuposPorDia.Text );
            datos_del_empleado.cargo = cbxCargo.Text;
            datos_del_empleado.codigo_empresa = datos_de_la_empresa_globales.codigo;

            if (cbxEstado.Text == "Masculino")
            {
                datos_del_empleado.sexo = 'M';
            }
            else
            {
                datos_del_empleado.sexo = 'F';
            }

            Boolean confrimacon;

            confrimacon = logica_De_Los_Empleados.ingresar_un_empleado(datos_del_empleado,datos_de_la_conexion_globales);

            MessageBox.Show("estado  : " + confrimacon);

           // guardar_foto();

           limpienza();

        }

        private void limpienza()
        {
            txtCedula.Text = " ";
            txtPrimerNombre.Text = " ";
            txtSegundoNombre.Text = " ";
            txtPrimerApellido.Text = " ";
            txtSegundoApellido.Text = " ";
            txtCorreo.Text = " ";
            txtTelefono.Text = " ";
            picFoto = null;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdSeleccionar = new OpenFileDialog();

            ofdSeleccionar.Filter = "Imagenes | *.jpg; *.png";
            ofdSeleccionar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            ofdSeleccionar.Title = "Seleccionar Imagen";

            if (ofdSeleccionar.ShowDialog() == DialogResult.OK)
            {
                picFoto.Image = Image.FromFile(ofdSeleccionar.FileName);
            }
        }
    }
}
