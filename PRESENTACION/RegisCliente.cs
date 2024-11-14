using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITY;
using DLL;
using System.IO;
using System.Drawing.Imaging;

namespace PRESENTACION
{
    public partial class RegisCliente : Form
    {
        public RegisCliente()
        {
            InitializeComponent();

            // Agregar opciones al ComboBox
            cbxGenero.Items.Add("Masculino");
            cbxGenero.Items.Add("Femenino");

        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {

            Cliente datos_Personales = new Cliente();


            MemoryStream imagen=new MemoryStream();

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

            logica_de_los_clientes logica_De_Los_Clientes = new logica_de_los_clientes();

            Boolean confirmacion;

            confirmacion = logica_De_Los_Clientes.registro_de_cliente(datos_Personales);

            MessageBox.Show("Estado :" + confirmacion);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdSeleccionar=new OpenFileDialog();

            ofdSeleccionar.Filter = "Imagenes | *.jpg; *.png";
            ofdSeleccionar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            ofdSeleccionar.Title = "Seleccionar Imagen";

            if(ofdSeleccionar.ShowDialog() == DialogResult.OK)
            {
                picFotodePerfil.Image = Image.FromFile(ofdSeleccionar.FileName);
            }

        }
    }
}
