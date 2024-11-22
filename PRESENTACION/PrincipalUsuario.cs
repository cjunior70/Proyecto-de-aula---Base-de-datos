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
    public partial class PrincipalUsuario : Form
    {
        public PrincipalUsuario()
        {
            InitializeComponent();
        }

        //Datos de conexion
        Datos_login datos_de_la_conexion = new Datos_login();

        public void datos_de_conexion(Datos_login datos_De_conexion)
        {
            datos_de_la_conexion.usuario = datos_De_conexion.usuario;
            datos_de_la_conexion.constraseña = datos_De_conexion.constraseña;

        }

        private void btGuardarDatos_Click(object sender, EventArgs e)
        {

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
