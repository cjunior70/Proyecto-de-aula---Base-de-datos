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
    public partial class ClienteReservacion : Form
    {
        public ClienteReservacion()
        {
            InitializeComponent();
        }

        private void btAgregarEmpleado_Click(object sender, EventArgs e)
        {

            TrabajadorCliente TrabajadorCli = new TrabajadorCliente();
            TrabajadorCli.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
