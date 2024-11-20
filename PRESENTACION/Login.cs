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

        private void lbEntrarB_Click(object sender, EventArgs e)
        {

            //Entrada del sistema
            Datos_login datos = new Datos_login();

            datos.constraseña = txtContraseña.Text;
            datos.usuario = txtUsuario.Text;

            Boolean confirmacion;

            Funcion_de_conexion funcion_De_Conexion = new Funcion_de_conexion();

            confirmacion = funcion_De_Conexion.conexion(datos);

            if (confirmacion == true)
            {
                MessageBox.Show("Bienvenido");

                PrincipialCliente frm = new PrincipialCliente();
                frm.Show();
                this.Hide();
            }
            else
            {

                MessageBox.Show("Usuario invalido");

            }

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