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

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void lbEntrar_Click(object sender, EventArgs e)
        {
            

            if (this.TboxUsuario.Texts == "User" || this.TboxContraseña.Texts == "1234" )
            {
                RegistrarCliente frm = new RegistrarCliente();
                frm.Show();
                this.Hide();
            }
            else
            {

                MessageBox.Show("Usuario invalido");

            }
        }
    }
}
