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
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dt.Rows.Add(txtDescripcion.Text,txtLatitud.Text,txtLongitud.Text);
        }

        private void Google_Maps_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add(new DataColumn("Descripcion", typeof(string)));
            dt.Columns.Add(new DataColumn("Lat", typeof(double)));
            dt.Columns.Add(new DataColumn("Long", typeof(double)));

            //Insertando datos al dt para mostrar en la lista
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
            gMapControl1.Zoom = 13;
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

            //Recuperamos los datos del grid y los asignamos a los texbox
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
            //Se obtiente los datos de lat y lng del mapa donde el usuario presiono

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
            //procedimiento para eliminar de una base de datos.
        }

        private void btnUbicacion_Click(object sender, EventArgs e)
        {
            Ubicacion datos_De_la_ubicacion = new Ubicacion();

            datos_De_la_ubicacion.latitud = txtLatitud.Text;
            datos_De_la_ubicacion.longitud = txtLongitud.Text;

            Boolean confirmacion;

            logica_de_las_ubicaciones logica_De_Las_Ubicaciones = new logica_de_las_ubicaciones();

            confirmacion = logica_De_Las_Ubicaciones.registrar_una_ubicacion(datos_De_la_ubicacion);

            //Logica para abiri la interfaz de login
            RegisUsuario registro_usuario = new RegisUsuario();
            registro_usuario.guardar_datos_de_la_ubicacion(datos_De_la_ubicacion);
            registro_usuario.Show();

            //Cerrar interfaz del mapa
            this.Hide();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Logica para abiri la interfaz de login
            RegisUsuario registro_usuario = new RegisUsuario();
            registro_usuario.Show();

            //Cerrar interfaz del mapa
            this.Hide();
        }
    }
}
