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

            if (this.txtUsuario.Text == "User" || this.txtContraseña.Text == "1234")
            {
                RegisCliente frmR = new RegisCliente();
                frmR.Show();
                this.Hide();
            }
            else
            {

                MessageBox.Show("Usuario invalido");

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