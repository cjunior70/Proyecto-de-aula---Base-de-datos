using DLL;
using ENTITY;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        //Variable global para poder saber la ubicacion de la coleccion de los datos de las empresas
        int Fila_Actual = 0;

        //Variable pára poder tener el valor de las filas del la primera empresa
        int Primer_valor_de_las_filas = 0;

        //Variable pára poder tener el valor de las filas del la segunda empresa
        int Segunda_valor_de_las_filas = 0;

        //Variable pára poder tener el valor de las filas del la tercera empresa
        int Tercera_valor_de_las_filas = 0;


        //Codigo para poder acceder a la capa dll
        logica_de_las_empresas logica_De_Las_Empresas = new logica_de_las_empresas();

        //Datatable para poder guardar todas las empresas
        List<Empresa> lista_de_las_empresas_globales = new List<Empresa>();

        //Datos de conexion
        Datos_login datos_de_la_conexion = new Datos_login();

        public void datos_de_conexion(Datos_login datos_De_conexion)
        {
            datos_de_la_conexion.usuario = datos_De_conexion.usuario;
            datos_de_la_conexion.constraseña = datos_De_conexion.constraseña;
            datos_de_la_conexion.quien_esta = datos_De_conexion.quien_esta;

        }

        private void btRegisClient_Click(object sender, EventArgs e)
        {
            RegisCliente RegCliente = new RegisCliente();
            RegCliente.Show();
             this.Hide();
        }

        public void buscar_todas_las_empresa()
        {

            lista_de_las_empresas_globales =  logica_De_Las_Empresas.consultar_todas_las_empresas(datos_de_la_conexion);

            dgListaDeEmpresa.DataSource = lista_de_las_empresas_globales;

            mostrar_datos_de_las_empresa();

        }

        private void mostrar_datos_de_las_empresa()
        {

            pnl1.Visible = true;
            lblTurnosDisponibles1.Visible = true;
            pnl2.Visible = true;
            lblTurnosDisponibles2.Visible = true;
            pnl3.Visible = true;
            lblTurnosDisponibles3.Visible = true;

            if (Fila_Actual <= lista_de_las_empresas_globales.Count - 1)
            {

                var empresa = lista_de_las_empresas_globales[Fila_Actual]; // Acceder a la empresa por su índice

                lblNombredelaEmpresa1.Text = empresa.nombre_de_la_empresa.ToString();

                Primer_valor_de_las_filas = Fila_Actual;

                Fila_Actual++;

                using (MemoryStream ms = new MemoryStream(empresa.imagen_miniatura))
                {
                    pic1.Image = Image.FromStream(ms); // Convertir el byte[] a una imagen y asignarlo al PictureBox
                }

                if (Fila_Actual <= lista_de_las_empresas_globales.Count - 1 && empresa.nombre_de_la_empresa != null)
                {
                    var empresa2 = lista_de_las_empresas_globales[Fila_Actual];

                    lblNombredelaEmpresa2.Text = empresa2.nombre_de_la_empresa.ToString();

                    Segunda_valor_de_las_filas = Fila_Actual;

                    Fila_Actual++;

                    using (MemoryStream ms = new MemoryStream(empresa2.imagen_miniatura))
                    {
                        pic2.Image = Image.FromStream(ms); // Convertir el byte[] a una imagen y asignarlo al PictureBox
                    }


                    if (Fila_Actual <= lista_de_las_empresas_globales.Count - 1 && empresa.nombre_de_la_empresa != null)
                    {
                        var empresa3 = lista_de_las_empresas_globales[Fila_Actual];

                        lblNombredelaEmpresa3.Text = empresa3.nombre_de_la_empresa.ToString();

                        Tercera_valor_de_las_filas = Fila_Actual;

                        using (MemoryStream ms = new MemoryStream(empresa3.imagen_miniatura))
                        {
                            pic3.Image = Image.FromStream(ms); // Convertir el byte[] a una imagen y asignarlo al PictureBox
                        }
                    }
                    else
                    {

                        pnl3.Visible = false;

                    }

                }
                else
                {

                    pnl2.Visible = false;
                    pnl3.Visible = false;

                }

            }
            else
            {
                pnl1.Visible = false;
                pnl2.Visible = false;
                pnl3.Visible = false;

                MessageBox.Show("No hay mas Empresas Disponbiles");
            }
                
        }

        private void btnCerrarSeecion_Click(object sender, EventArgs e)
        {
            //Funcion para ir al logn
            Login FrmLog = new Login();
            FrmLog.Show();

            //Cerrar interfaz actual
            this.Hide();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            //Codigo para poder regresar al login
            Login FrmLog = new Login();
            FrmLog.Show();

            //Codigo para cerrar la interfac actual
            this.Hide();
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {

            Fila_Actual++;

            limpieza_de_datos();

            mostrar_datos_de_las_empresa();

        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            
            Fila_Actual = 0;

            Primer_valor_de_las_filas = 0;
            Segunda_valor_de_las_filas = 0;
            Tercera_valor_de_las_filas = 0;

            limpieza_de_datos();

            mostrar_datos_de_las_empresa();

        }

        private void limpieza_de_datos()
        {
            //Primer panel
            lblNombredelaEmpresa1.Text = " ";
            txtTurnosDisponibles1.Text = " ";
            pic1.Image = null;

            //Segundo panel
            lblNombredelaEmpresa2.Text = " ";
            txtTurnosDisponibles2.Text = " ";
            pic2.Image = null;

            //Tercer panel
            lblNombredelaEmpresa3.Text = " ";
            txtTurnosDisponibles3.Text = " ";
            pic3.Image = null;
        }

        private void EntrarALaEmpresa(object sender, EventArgs e)
        {
            int codigo_de_la_empresa;

            codigo_de_la_empresa =  lista_de_las_empresas_globales[Primer_valor_de_las_filas].codigo;

            //Funcion para ir al logn
            EmpresaCliente FrmLog = new EmpresaCliente();
            FrmLog.datos_de_conexion(datos_de_la_conexion);
            FrmLog.datos_de_la_empresa_seleccionada(codigo_de_la_empresa);
            FrmLog.Show();

            //Cerrar interfaz actual
            this.Hide();

        }

        private void EntrarALaSegundaEmpresa(object sender, EventArgs e)
        {
            int codigo_de_la_empresa;

            codigo_de_la_empresa = lista_de_las_empresas_globales[Segunda_valor_de_las_filas].codigo;

            //Funcion para ir al logn
            EmpresaCliente FrmLog = new EmpresaCliente();
            FrmLog.datos_de_conexion(datos_de_la_conexion);
            FrmLog.datos_de_la_empresa_seleccionada(codigo_de_la_empresa);
            FrmLog.Show();

            //Cerrar interfaz actual
            this.Hide();
        }

        private void EntrarALaTerceraEmpresa(object sender, EventArgs e)
        {
            int codigo_de_la_empresa;

            codigo_de_la_empresa = lista_de_las_empresas_globales[Tercera_valor_de_las_filas].codigo;

            //Funcion para ir al login
            EmpresaCliente FrmLog = new EmpresaCliente();
            FrmLog.datos_de_conexion(datos_de_la_conexion);
            FrmLog.datos_de_la_empresa_seleccionada(codigo_de_la_empresa);
            FrmLog.Show();

            //Cerrar interfaz actual
            this.Hide();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
