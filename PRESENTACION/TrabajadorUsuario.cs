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
    public partial class TrabajadorUsuario : Form
    {
        public TrabajadorUsuario()
        {
            InitializeComponent();
        }

        //Datos de conexion
        Datos_login datos_de_conexion_globales=new Datos_login();

        public void datos_de_conexion(Datos_login datos_de_conexion)
        {
            datos_de_conexion_globales = datos_de_conexion;
        }


        public void guardar_datos_del_empleado()
        {

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
    }
}
