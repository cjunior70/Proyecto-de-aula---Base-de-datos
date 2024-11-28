using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITY;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using DLL;

namespace PRESENTACION
{
    public partial class Google_Maps : Form
    {
        GMarkerGoogle marker;
        GMapOverlay markeroverlay;
        DataTable dt;

        int filaseleccionada = 0;
        double LatInicial = 10.4715228768461 ;
        double LngInicial = -73.2442188262939;

        public Google_Maps()
        {
            InitializeComponent();

            btnUbicacion.Visible = true;
            btnAgregar.Visible = true;
            btnEliminar.Visible = true;
            dataGridView1.Visible = true;
        }

        //Variable para usar los datos para la conexion
        Datos_login datos_de_la_conexion = new Datos_login();

        //variable para guardar las coordenadas de la empresa
        Ubicacion datos_de_la_ubicacion_globales = new Ubicacion();

        //Variable para poder tener el control del zoom 
         int zoom = 0;

        //Funcion para poder entrar al dll de las ubicaciones
        logica_de_las_ubicaciones Logica_De_Las_Ubicaciones = new logica_de_las_ubicaciones();
        public void datos_de_conexion(Datos_login datos_De_conexion)
        {
            datos_de_la_conexion.usuario = datos_De_conexion.usuario;
            datos_de_la_conexion.constraseña = datos_De_conexion.constraseña;
            datos_de_la_conexion.quien_esta = datos_De_conexion.quien_esta;

        }

        //Funcion para poder tener el codigo de la ubicacion de la empresa
        public void guardar_codigo_de_la_ubicacion_de_la_empresa_seleccionada(Ubicacion datos_actuales_de_la_empresa)
        {
            datos_de_la_ubicacion_globales = datos_actuales_de_la_empresa;

            buscar_codigo_de_la_ubicacion_en_la_base();

        }

        private void buscar_codigo_de_la_ubicacion_en_la_base()
        {
            DataTable datos_recolectados = new DataTable();

            datos_recolectados = Logica_De_Las_Ubicaciones.buscar_una_ubicacion_por_codigo(datos_de_la_ubicacion_globales, datos_de_la_conexion);

            Ubicacion datos_de_la_ubicacion = new Ubicacion();

            datos_de_la_ubicacion.codigo = Convert.ToInt32(datos_recolectados.Rows[0]["CODIGO"]);
            datos_de_la_ubicacion.latitud = datos_recolectados.Rows[0]["LATITUD"].ToString();
            datos_de_la_ubicacion.longitud = datos_recolectados.Rows[0]["LONGITUD"].ToString();

            LatInicial = Convert.ToDouble(datos_de_la_ubicacion.latitud);
            LngInicial = Convert.ToDouble(datos_de_la_ubicacion.longitud);

            txtDescripcion.Text = datos_de_la_ubicacion.codigo.ToString();
            txtLatitud.Text = datos_de_la_ubicacion.latitud.ToString();
            txtLongitud.Text = datos_de_la_ubicacion.longitud.ToString();

            zoom = 1;

            btnUbicacion.Visible = false;
            btnAgregar.Visible = false;
            btnEliminar.Visible = false;
            dataGridView1.Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dt.Rows.Add(txtDescripcion.Text,txtLatitud.Text,txtLongitud.Text);
        }

        private void Google_Maps_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add(new DataColumn("Codigo", typeof(string)));
            dt.Columns.Add(new DataColumn("Lat", typeof(double)));
            dt.Columns.Add(new DataColumn("Long", typeof(double)));

            //Insertando datos_de_conexion al dt para mostrar en la lista
            dt.Rows.Add("Ubicacion", LatInicial, LngInicial);
            dataGridView1.DataSource = dt;

            //dasactivar las columnas de lat y long
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;


            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(LatInicial, LngInicial);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            
            if( zoom == 0 )
            {
                gMapControl1.Zoom = 13;
            }
            else
            {
                gMapControl1.Zoom = 14;
            }

            gMapControl1.AutoScroll = true;

            //Marcador 
            markeroverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(LatInicial, LngInicial), GMarkerGoogleType.green);
            markeroverlay.Markers.Add(marker); //Agregamos al mapa

            //Agregamos un tooltip de texto a los marcadores
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format("Ubicacion: \n latitud:{0} \n longitud{1}", LatInicial, LngInicial);

            //Ahora agregamos el mapa y el marcador al map control
            gMapControl1.Overlays.Add(markeroverlay);

        }

        private void SeleccionarRegistr(object sender, DataGridViewCellMouseEventArgs e)
        {
            filaseleccionada = e.RowIndex; // fila seleccionada

            //Recuperamos los datos_de_conexion del grid y los asignamos a los texbox
            txtDescripcion.Text = dataGridView1.Rows[filaseleccionada].Cells[0].Value.ToString();
            txtLatitud.Text = dataGridView1.Rows[filaseleccionada].Cells[1].Value.ToString();
            txtLongitud.Text = dataGridView1.Rows[filaseleccionada].Cells[2].Value.ToString();

            //Se asigna los valore del grip al marcador
            marker.Position = new PointLatLng(Convert.ToDouble(txtLatitud.Text), Convert.ToDouble(txtLongitud.Text));

            //Se posiciona el foco del mapa en ese punto
            gMapControl1.Position = marker.Position;


        }

        private void gMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Se obtiente los datos_de_conexion de lat y lng del mapa donde el usuario presiono

            double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;

            //se posiciona en el txt de la latitud y longitud
            txtLatitud.Text = lat.ToString();
            txtLongitud.Text = lng.ToString();

            //Creamos el marcador para moverlo al lugar indicado
            marker.Position = new PointLatLng(lat,lng);

            //Tambien se va a agregar el mensaje al marcador(tooltip)
            marker.ToolTipText = string.Format("Ubicacion: \n latitud: {0} \n longitud: {1}", lat, lng);



        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(filaseleccionada); //remover la tabla
            //procedimiento para eliminar de una base de datos_de_conexion.
        }

        private void btnUbicacion_Click(object sender, EventArgs e)
        {
            Ubicacion datos_De_la_ubicacion = new Ubicacion();

            datos_De_la_ubicacion.latitud = txtLatitud.Text;
            datos_De_la_ubicacion.longitud = txtLongitud.Text;

            Boolean confirmacion;

            logica_de_las_ubicaciones logica_De_Las_Ubicaciones = new logica_de_las_ubicaciones();

            confirmacion = logica_De_Las_Ubicaciones.registrar_una_ubicacion(datos_De_la_ubicacion, datos_de_la_conexion);

            //Logica para abiri la interfaz de login
            interf registro_usuario = new interf();
            registro_usuario.guardar_datos_de_la_ubicacion(datos_De_la_ubicacion);
            registro_usuario.Show();

            //Cerrar interfaz del mapa
            this.Hide();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            MessageBox.Show(datos_de_la_conexion.quien_esta.ToString());

            if ( datos_de_la_conexion.quien_esta == ' ' )
            {
                //Logica para abiri la interfaz de login
                interf registro_usuario = new interf();
                registro_usuario.Show();

                //Cerrar interfaz del mapa
                this.Hide();
            }
            else
            {
                if(datos_de_la_conexion.quien_esta == 'A')
                {
                    //Logica para abiri la interfaz de login
                    PrincipialCliente principal_cliente = new PrincipialCliente();
                    principal_cliente.Show();
                    principal_cliente.datos_de_conexion(datos_de_la_conexion);
                    principal_cliente.buscar_todas_las_empresa();

                    //Cerrar interfaz del mapa
                    this.Hide();
                }
                else
                {

                    if (datos_de_la_conexion.quien_esta == 'C')
                    {
                        //Logica para abiri la interfaz de login
                        PrincipialCliente principal_cliente = new PrincipialCliente();
                        principal_cliente.Show();
                        principal_cliente.datos_de_conexion(datos_de_la_conexion);
                        principal_cliente.buscar_todas_las_empresa();

                        //Cerrar interfaz del mapa
                        this.Hide();
                    }
                    else
                    {

                        if (datos_de_la_conexion.quien_esta == 'U')
                        {
                            //Logica para abiri la interfaz de login
                            InterfazJefe principal_jefe = new InterfazJefe();
                            principal_jefe.Show();
                            

                            //Cerrar interfaz del mapa
                            this.Hide();
                        }
                        else
                        {

                            if (datos_de_la_conexion.quien_esta == 'E')
                            {
                                //Logica para abiri la interfaz de login
                                InterfazTrabajador principal_trabajador = new InterfazTrabajador();
                                principal_trabajador.Show();

                                //Cerrar interfaz del mapa
                                this.Hide();
                            }
                        }

                    }

                }
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
