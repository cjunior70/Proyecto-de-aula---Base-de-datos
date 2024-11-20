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
    public partial class EmpresaCliente : Form
    {
        public EmpresaCliente()
        {
            InitializeComponent();
        }

        private void btHReservacion_Click(object sender, EventArgs e)
        {
            
              
                ClienteReservacion reserva = new ClienteReservacion();
                reserva.Show();

                this.Hide();
            }
    }
}
