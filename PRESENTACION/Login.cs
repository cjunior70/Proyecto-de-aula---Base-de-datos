using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLL;
using ENTITY;

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
            //Estamos en el boton
            Boolean confirmacion;

            Funcion_de_conexion conexion_general = new Funcion_de_conexion();

            Datos_login datos= new Datos_login();

            datos.usuario = txtUsuario.Text;
            datos.constraseña = txtContraseña.Text;

            confirmacion = conexion_general.conexion(datos);

            if (confirmacion == true)
            {
                RegisCliente frmR = new RegisCliente();
                frmR.Show();
                this.Hide();
                MessageBox.Show("estoy dentro del sistema");
            }
            else
            {

                MessageBox.Show("Usuario Invalido");

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Se quiere registrar como cliente o como usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                
                // Lógica para la opción "Sí"
                RegisCliente regisCliente = new RegisCliente();
                regisCliente.Show();

                this.Hide();

            }
            else if (result == DialogResult.No)
            {
                // Lógica para la opción "No"
                RegisUsuario regisUsuario = new RegisUsuario();
                regisUsuario.Show();

                this.Hide();
            }
        }

        private void lbContactos_Click(object sender, EventArgs e)
        {
             Contactos FrmC = new Contactos();
            FrmC.Show();
            this.Hide();
        }
    }
}