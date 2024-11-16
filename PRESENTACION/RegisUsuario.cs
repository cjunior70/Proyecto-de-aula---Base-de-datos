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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRESENTACION
{
    public partial class RegisUsuario : Form
    {
        public RegisUsuario()
        {
            InitializeComponent();

            // Agregar opciones al ComboBox
            cbxGenero.Items.Add("Masculino");
            cbxGenero.Items.Add("Femenino");

        }

        //Datos del usuario globales para usarlo para el registro de la empresa
        Usuario datos_del_usuario_globales = new Usuario();

        //Datos de la empresa globales para usarlo para el registro de la empresa
        Empresa datos_de_la_empresa_globales = new Empresa();

        //Datos de la ubicacion globales para usarlo para el registro de la empresa
        Ubicacion datos_de_la_ubicacion_globales =new Ubicacion();

        public void guardar_datos_de_la_ubicacion(Ubicacion datos_de_la_ubicacion)
        {
            datos_de_la_ubicacion_globales = datos_de_la_ubicacion;
        }

        private void btnSeleccionarFotodePerfil_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdseleccionar = new OpenFileDialog();
            ofdSeleccionar.Filter = "Imagenes | *.jpg; *png";
            ofdSeleccionar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            ofdSeleccionar.Title = "Seleccionar Imagen";

            if (ofdSeleccionar.ShowDialog() == DialogResult.OK)
            {
                picFotodePerfil.Image = Image.FromFile(ofdSeleccionar.FileName);
            }

        }

        private void btnSeleccionarFotoMiniatura_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdseleccionar = new OpenFileDialog();
            ofdSeleccionar.Filter = "Imagenes | *.jpg; *png";
            ofdSeleccionar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            ofdSeleccionar.Title = "Seleccionar Imagen";

            if (ofdSeleccionar.ShowDialog() == DialogResult.OK)
            {
                picFotoMiniatura.Image = Image.FromFile(ofdSeleccionar.FileName);
            }
        }

        private void btnSeleccionarFotoNormal_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdseleccionar = new OpenFileDialog();
            ofdSeleccionar.Filter = "Imagenes | *.jpg; *png";
            ofdSeleccionar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            ofdSeleccionar.Title = "Seleccionar Imagen";

            if (ofdSeleccionar.ShowDialog() == DialogResult.OK)
            {
                picFotoNormal.Image = Image.FromFile(ofdSeleccionar.FileName);
            }
        }

        private void btRegistro_Click(object sender, EventArgs e)
        {
            //Variable para la confirmacion de datos personales y para la confirmacion de datos de la empresa
            Boolean confirmacion1, confirmacion2;

            //Codigo para guardar datos de la interfaz a variables
            guardar_datos_personales();

             logica_de_los_usuarios logica_De_Los_Clientes = new logica_de_los_usuarios();

            confirmacion1 = logica_De_Los_Clientes.registro_de_un_usuario(datos_del_usuario_globales);

            //Buscar codigo del usuario o el propietario de la empresa
            

            //Codigo para guardar datos de la interfaz a variables
            guardar_datos_De_la_empresa();

            logica_de_las_empresas logica_De_Las_Empresas = new logica_de_las_empresas();

            confirmacion2 = logica_De_Las_Empresas.registro_de_una_empresa(datos_de_la_empresa_globales);


            if ( confirmacion2 == false)
            {

                MessageBox.Show("Lo siento, ha ocurrido un error");
            }
            else
            {
                MessageBox.Show("Datos Guardados Correctamente");

                //Logica para abiri la interfaz de login
                Login login = new Login();
                login.Show();

                //Para ocultar la pestaña actual
                this.Hide();

            }

        }

        //Funcion para guardar los datos personales del usuario 
        private void guardar_datos_personales()
        {
            Usuario datos_Personales = new Usuario();

            MemoryStream imagen = new MemoryStream();

            picFotodePerfil.Image.Save(imagen, ImageFormat.Jpeg);
            byte[] foto_De_perfil = imagen.ToArray();


            datos_Personales.cedula = txtCedulaU.Text;
            datos_Personales.Primer_nombre = txtPrNombreU.Text;
            datos_Personales.Segundo_nombre = txtSgNombreU.Text;
            datos_Personales.Primer_apellido = txtPrApellidoU.Text;
            datos_Personales.Segundo_apellido = txtSgApellidoU.Text;
            datos_Personales.telefono = txtCelular.Text;
            datos_Personales.correo_electronico = txtCorreoElectronico.Text;
            datos_Personales.Foto = foto_De_perfil;

            string generoSeleccionado = cbxGenero.SelectedItem?.ToString();
            if (generoSeleccionado != "Masculino")
            {
                datos_Personales.sexo = 'F';
            }
            else
            {
                datos_Personales.sexo = 'M';
            }

            datos_del_usuario_globales = datos_Personales;

        }

        //Funcion para guardar los datos de la empresa del usuario que se quiere registrar
        private void guardar_datos_De_la_empresa()
        {
            //Conversion de la imagen general a byte para un trabajo mejor
            MemoryStream imagen_general = new MemoryStream();

            picFotoNormal.Image.Save(imagen_general, ImageFormat.Jpeg);
            byte[] Foto_General = imagen_general.ToArray();

            //Conversion de la imagen miniatura a byte para un trabajo mejor
            MemoryStream imagen_miniatura = new MemoryStream();

            picFotoMiniatura.Image.Save(imagen_miniatura, ImageFormat.Jpeg);
            byte[] Foto_Miniatura = imagen_miniatura.ToArray();

            //Recoleccion de datos de la empresa con la interfaz
            Empresa datos_de_la_empresa = new Empresa();

            datos_de_la_empresa.nombre_de_la_empresa = txtNombredelaPeluqueria.Text;
            datos_de_la_empresa.descripcion_de_la_empresa = txtDescripcion.Text;
            datos_de_la_empresa.extrellas = 1;
            datos_de_la_empresa.whatsapp = txtwhastsApp.Text;
            datos_de_la_empresa.correo = txtCorreoElectronicoDeLaEmpresa.Text;
            datos_de_la_empresa.instagram = txtInstagram.Text;
            datos_de_la_empresa.facebook = txtFacebook.Text;
            datos_de_la_empresa.descripcion_de_la_empresa = txtDescripiconDeLaUbicacionLocalemente.Text;
            datos_de_la_empresa.imagen_miniatura = Foto_Miniatura;
            datos_de_la_empresa.imagen_general = Foto_General;
            datos_de_la_empresa.usuario = datos_del_usuario_globales;
            datos_de_la_empresa.ubicaion = datos_de_la_ubicacion_globales;

            datos_de_la_empresa_globales = datos_de_la_empresa;

        }
    

        private void txtNombredelaPeluqueria_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void btGoogleMaps_Click(object sender, EventArgs e)
        {
            Google_Maps googlemaps = new Google_Maps();
            googlemaps.Show();

            // Ocultar el formulario actual
            this.Hide();
        }
    }
}
