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
    public partial class InterfazJefe : Form
    {
        public InterfazJefe()
        {
            InitializeComponent();
        }

        //Datos de conexion globales
        Datos_login datos_de_conexion_globales = new Datos_login();

        //Funcion para poder guardar la conexion
        public void datos_de_conexion(Datos_login datos_de_conexion)
        {
            datos_de_conexion_globales = datos_de_conexion;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btRegisClient_Click(object sender, EventArgs e)
        {
            //Funcion para entrar a la interfaz principal
            PrincipalUsuario interfaz_del_usuario_principal = new PrincipalUsuario();
            interfaz_del_usuario_principal.datos_de_conexion(datos_de_conexion_globales);
            interfaz_del_usuario_principal.Show();

            //Para cerrar la interfaz actual
            this.Hide();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            Login FrmLogin = new Login();
            FrmLogin.Show();
            this.Hide();
        }
    }
}
