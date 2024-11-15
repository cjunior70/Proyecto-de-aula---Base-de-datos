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

        private void btnSeleccionarFotodePerfil_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdseleccionar = new OpenFileDialog();
            ofdSeleccionar.Filter = "Imagenes | *.jpg; *png";
            ofdSeleccionar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            ofdSeleccionar.Title = "Seleccionar Imagen";

            if(ofdSeleccionar.ShowDialog() == DialogResult.OK)
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

            guardar_datos();

        }

        private Boolean guardar_datos()
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

            logica_de_los_usuarios logica_De_Los_Clientes = new logica_de_los_usuarios();

            Boolean confirmacion;

            confirmacion = logica_De_Los_Clientes.registro_de_un_usuario(datos_Personales);

            if (confirmacion == false)
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
    }
}
