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
    public partial class PrincipialCliente : Form
    {
        public PrincipialCliente()
        {
            InitializeComponent();
        }

        private void btRegisClient_Click(object sender, EventArgs e)
        {
            RegisCliente RegCliente = new RegisCliente();
            RegCliente.Show();
             this.Hide();
        }
    }
}
