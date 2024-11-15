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
    public partial class RegisUsuario : Form
    {
        public RegisUsuario()
        {
            InitializeComponent();
        }

        private void btnSeleccionarFotodePerfil_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdseleccionar = new OpenFileDialog();
            ofdSeleccionar.Filter = "Imagenes | *.jpg; *png";
            ofdSeleccionar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            ofdSeleccionar.Title = "Seleccionar Imagen";

            if(ofdSeleccionar.ShowDialog() == DialogResult.OK)
            {
                picFotodePerfil.Image = Image.FromFile(ofdSeleccionar.FileName);
            }

        }

        private void btnSeleccionarFotoMiniatura_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdseleccionar = new OpenFileDialog();
            ofdSeleccionar.Filter = "Imagenes | *.jpg; *png";
            ofdSeleccionar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            ofdSeleccionar.Title = "Seleccionar Imagen";

            if (ofdSeleccionar.ShowDialog() == DialogResult.OK)
            {
                picFotoMiniatura.Image = Image.FromFile(ofdSeleccionar.FileName);
            }
        }

        private void btnSeleccionarFotoNormal_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdseleccionar = new OpenFileDialog();
            ofdSeleccionar.Filter = "Imagenes | *.jpg; *png";
            ofdSeleccionar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            ofdSeleccionar.Title = "Seleccionar Imagen";

            if (ofdSeleccionar.ShowDialog() == DialogResult.OK)
            {
                picFotoNormal.Image = Image.FromFile(ofdSeleccionar.FileName);
            }
        }

        private void btRegistro_Click(object sender, EventArgs e)
        {

        }
    }
}
