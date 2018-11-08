using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace CheckOn
{
    public partial class FrmGenerarMapa : Form
    {
        FrmCallCenterMaleta frmCallCenterMaleta = new FrmCallCenterMaleta();
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        DataTable dt;

        //Ruta automatizada
        bool trazarRuta = false;
        int ContadorIndicadoresRuta = 0;
        PointLatLng inicio;
        PointLatLng final;

        string descripcion = "dispositivo";
        string LatInicial = "6.357453503394623";
        string LongInicial = "-75.21332167567407";

        private MySqlDataAdapter insercion = new MySqlDataAdapter();
        private MySqlConnection conexion = new MySqlConnection();

        int filaSeleccionada = 0;


        public FrmGenerarMapa()
        {
            InitializeComponent();
        }

        private void FrmGenerarMapa_Load(object sender, EventArgs e)
        {
            conexion.ConnectionString = "server=localhost; database=check - on; Uid=root; Pwd =; SslMode=none;";


            //----------------------dataGrid
            //Añadiendo columnas
            dt = new DataTable();
            dt.Columns.Add(new DataColumn("Descripción", typeof(string)));
            dt.Columns.Add(new DataColumn("Latitud", typeof(string)));
            dt.Columns.Add(new DataColumn("Longitud", typeof(string)));

            dt.Rows.Add(descripcion, LatInicial, LongInicial);
            dtgListaUbicacion.DataSource = dt;

            double latInicial = Convert.ToDouble(LatInicial);
            gmapControl1.DragButton = MouseButtons.Left;
            gmapControl1.CanDragMap = true;
            gmapControl1.MapProvider = GMapProviders.GoogleMap;
            double longInicial = Convert.ToDouble(LongInicial);
            gmapControl1.Position = new PointLatLng(latInicial, longInicial);
            gmapControl1.MinZoom = 0;
            gmapControl1.MaxZoom = 24;
            gmapControl1.Zoom = 8;
            gmapControl1.AutoScroll = true;

            //Desactivar las columnas de longitud y latitud.
            //dtgListaUbicacion.Columns[1].Visible = false;
            //dtgListaUbicacion.Columns[2].Visible = false;

            //--------------------------------------Marcador

            markerOverlay = new GMapOverlay("Marcador");
            //crear el marcador encima del mapa de color verde
            marker = new GMarkerGoogle(new PointLatLng(latInicial, longInicial), GMarkerGoogleType.green);
            markerOverlay.Markers.Add(marker); // agregar marcador al mapa

            //Agregar un tooltip de texto a los marcadores
            marker.ToolTipMode = MarkerTooltipMode.Always; // el marcador aparece siempre
            marker.ToolTipText = string.Format("Ubicación: \n Latitud: {0} \n Longitud: {1}", LatInicial, LongInicial);

            //Agregar el mapa y el marcador al map control
            gmapControl1.Overlays.Add(markerOverlay);

        }

        private void btnPolygono_Click(object sender, EventArgs e)
        {
            GMapOverlay Polygono = new GMapOverlay("Poligono");
            List<PointLatLng> puntos = new List<PointLatLng>();

            //variables para almacenar los datos.
            double lng, lat;

            //Agarramos los datos del grid
            for (int filas = 0; filas < dtgListaUbicacion.Rows.Count; filas++)
            {
                lat = Convert.ToDouble(dtgListaUbicacion.Rows[filas].Cells[1].Value);
                lng = Convert.ToDouble(dtgListaUbicacion.Rows[filas].Cells[2].Value);
                puntos.Add(new PointLatLng(lat, lng));
            }
            GMapPolygon PolygonoPuntos = new GMapPolygon(puntos, "Poligono");
            Polygono.Polygons.Add(PolygonoPuntos);
            gmapControl1.Overlays.Add(Polygono);

            //Actualizar el mapa
            gmapControl1.Zoom = gmapControl1.Zoom + 1;
            gmapControl1.Zoom = gmapControl1.Zoom - 1;
        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            GMapOverlay Ruta = new GMapOverlay("CapaRuta");
            List<PointLatLng> puntos = new List<PointLatLng>();

            //variables para almacenar los datos.
            double lng, lat;

            //Agarramos los datos del grid
            for (int filas = 0; filas < dtgListaUbicacion.Rows.Count; filas++)
            {
                lat = Convert.ToDouble(dtgListaUbicacion.Rows[filas].Cells[1].Value);
                lng = Convert.ToDouble(dtgListaUbicacion.Rows[filas].Cells[2].Value);
                puntos.Add(new PointLatLng(lat, lng));
            }
            GMapRoute PuntosRuta = new GMapRoute(puntos, "Ruta");
            Ruta.Routes.Add(PuntosRuta);
            gmapControl1.Overlays.Add(Ruta);

            //Actualizar el mapa
            gmapControl1.Zoom = gmapControl1.Zoom + 1;
            gmapControl1.Zoom = gmapControl1.Zoom - 1;
        }

        private void btnLlegar_Click(object sender, EventArgs e)
        {
            trazarRuta = true;
            btnLlegar.Enabled = false;
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            dt.Rows.Add(lbDispositivo.Text, lbILatitud.Text, lblLongitud.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dtgListaUbicacion.Rows.RemoveAt(filaSeleccionada);
        }

        private void CrearDireccionTrazarRuta(double lat, double lng)
        {
            if (trazarRuta)
            {

                switch (ContadorIndicadoresRuta)
                {
                    case 0:
                        //primer marcador de inicio
                        ContadorIndicadoresRuta++;
                        inicio = new PointLatLng(lat, lng);
                        break;
                    case 1:
                        //Segundo marcador de inicio
                        ContadorIndicadoresRuta++;
                        final = new PointLatLng(lat, lng);

                        GDirections direccion;

                        var RutasDireccion = GMapProviders.GoogleMap.GetDirections(out direccion, inicio, final, false, false, false, false, false);
                        GMapRoute RutaObtenida = new GMapRoute(direccion.Route, "Ruta Ubicacion");
                        GMapOverlay CapaRutas = new GMapOverlay("Capa de la ruta");
                        CapaRutas.Routes.Add(RutaObtenida);
                        gmapControl1.Overlays.Add(CapaRutas);
                        gmapControl1.Zoom = gmapControl1.Zoom + 1;
                        gmapControl1.Zoom = gmapControl1.Zoom - 1;
                        ContadorIndicadoresRuta = 0;
                        trazarRuta = false;
                        btnLlegar.Enabled = true;

                        break;
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cmbOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            conexion.ConnectionString = "server=localhost; database=check - on; Uid=root; Pwd =; SslMode=none;";

            if (cmbOpciones.Text.Equals("Cedula del pasajero"))
            {
                MySqlCommand comando = new MySqlCommand("select p.IdDivaice, Latitud, Longitud from passenger p JOIN divaice d where p.CC_Passenger = @CC_Passenger and p.IdDivaice = d.IdDivaice; ", conexion);
                //MySqlCommand Num = new MySqlCommand("select COUNT(*) from InfoVuelo", conexion);
                comando.Parameters.AddWithValue("@CC_Passenger", txtDocumentoUsuario.Text);
                conexion.Open();

                MySqlDataReader Registro = comando.ExecuteReader();

                if (Registro.Read())
                {
                    lbILatitud.Items.Add(Registro["Latitud"].ToString());
                    lblLongitud.Items.Add(Registro["Longitud"].ToString());
                    lbDispositivo.Items.Add(Registro["IdDivaice"].ToString());

                    descripcion = Registro["IdDivaice"].ToString();
                    LatInicial = Registro["Latitud"].ToString();
                    LongInicial = Registro["Longitud"].ToString();
                    dt.Rows.Add(descripcion, LatInicial, LongInicial);
                    dtgListaUbicacion.DataSource = dt;

                    gmapControl1.DragButton = MouseButtons.Left;
                    gmapControl1.CanDragMap = true;
                    gmapControl1.MapProvider = GMapProviders.GoogleMap;
                    gmapControl1.Position = new PointLatLng(Convert.ToDouble(LatInicial), Convert.ToDouble(LongInicial));
                    gmapControl1.MinZoom = 0;
                    gmapControl1.MaxZoom = 24;
                    gmapControl1.Zoom = 8;
                    gmapControl1.AutoScroll = true;

                    markerOverlay = new GMapOverlay("Marcador");
                    //crear el marcador encima del mapa de color verde
                    marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(LatInicial), Convert.ToDouble(LongInicial)), GMarkerGoogleType.green);
                    markerOverlay.Markers.Add(marker); // agregar marcador al mapa

                    //Agregar un tooltip de texto a los marcadores
                    marker.ToolTipMode = MarkerTooltipMode.Always; // el marcador aparece siempre
                    marker.ToolTipText = string.Format("Dispositivo: {0} \n Latitud: {1} \n Longitud: {2}", descripcion, LatInicial, LongInicial);

                    //Agregar el mapa y el marcador al map control
                    gmapControl1.Overlays.Add(markerOverlay);

                }
            }
            else
            {
                MySqlCommand comando = new MySqlCommand("select p.IdDivaice, Latitud, Longitud from passenger p JOIN divaice d where d.IdDivaice = p.IdDivaice and p.idDivaice = @IdDivaice ", conexion);
                comando.Parameters.AddWithValue("@IdDivaice", txtDocumentoUsuario.Text);
                conexion.Open();

                MySqlDataReader Registro = comando.ExecuteReader();

                if (Registro.Read())
                {
                    lbILatitud.Items.Add(Registro["Latitud"].ToString());
                    lblLongitud.Items.Add(Registro["Longitud"].ToString());
                    lbDispositivo.Items.Add(Registro["IdDivaice"].ToString());

                    descripcion = Registro["IdDivaice"].ToString();
                    LatInicial = Registro["Latitud"].ToString();
                    LongInicial = Registro["Longitud"].ToString();
                    dt.Rows.Add(descripcion, LatInicial, LongInicial);
                    dtgListaUbicacion.DataSource = dt;

                    gmapControl1.DragButton = MouseButtons.Left;
                    gmapControl1.CanDragMap = true;
                    gmapControl1.MapProvider = GMapProviders.GoogleMap;
                    gmapControl1.Position = new PointLatLng(Convert.ToDouble(LatInicial), Convert.ToDouble(LongInicial));
                    gmapControl1.MinZoom = 0;
                    gmapControl1.MaxZoom = 24;
                    gmapControl1.Zoom = 8;
                    gmapControl1.AutoScroll = true;

                    markerOverlay = new GMapOverlay("Marcador");
                    //crear el marcador encima del mapa de color verde
                    marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(LatInicial), Convert.ToDouble(LongInicial)), GMarkerGoogleType.green);
                    markerOverlay.Markers.Add(marker); // agregar marcador al mapa

                    //Agregar un tooltip de texto a los marcadores
                    marker.ToolTipMode = MarkerTooltipMode.Always; // el marcador aparece siempre
                    marker.ToolTipText = string.Format("Dispositivo: {0}  \n Latitud: {1} \n Longitud: {2}", descripcion, LatInicial, LongInicial);

                    //Agregar el mapa y el marcador al map control
                    gmapControl1.Overlays.Add(markerOverlay);

                }

            }

            conexion.Close();

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            txtDocumentoUsuario.Clear();

            conexion.ConnectionString = "server=localhost; database=check - on; Uid=root; Pwd =; SslMode=none;";
            conexion.Open();

            lbILatitud.Items.Clear();
            lbDispositivo.Items.Clear();
            lblLongitud.Items.Clear();

            dt.Clear();

            conexion.Close();
        }
    }


}
