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
    public partial class Contactos : Form
    {
        public Contactos()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Login FrmLog = new Login();
            FrmLog.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
