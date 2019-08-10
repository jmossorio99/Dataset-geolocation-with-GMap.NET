using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;

namespace Project3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Creating the map and setting position
            gmap.MapProvider = GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gmap.Position = new PointLatLng(48.866383, 2.323575);
            gmap.ShowCenter = false;

            //Creating an overlay, adding the marker to the overlay and adding the overlay to the map
            //I also added text to the marker and the text shows when the mouse hovers the marker
            GMapOverlay markers = new GMapOverlay("Markers");
            GMapMarker homeMarker =
                new GMarkerGoogle(new PointLatLng(3.458199, -76.551711),
                GMarkerGoogleType.blue_pushpin);
            homeMarker.ToolTipText = "Holo";
            homeMarker.ToolTip.Fill = Brushes.Black;
            homeMarker.ToolTip.Foreground = Brushes.White;
            homeMarker.ToolTip.Stroke = Pens.Black;
            homeMarker.ToolTip.TextPadding = new Size(20, 20);
            homeMarker.Tag = 0; //A tag can also be given to the marker
            markers.Markers.Add(homeMarker);
            gmap.Overlays.Add(markers);

            //Creating an overlay, adding the coordinates for the polygon to a generic list and then creating and adding
            //the polygon to the map
            GMapOverlay polygons = new GMapOverlay("polygons");
            List<PointLatLng> pointsP1 = new List<PointLatLng>();
            pointsP1.Add(new PointLatLng(48.866383, 2.323575));
            pointsP1.Add(new PointLatLng(48.863868, 2.321554));
            pointsP1.Add(new PointLatLng(48.861017, 2.330030));
            pointsP1.Add(new PointLatLng(48.863727, 2.331918));
            GMapPolygon polygon = new GMapPolygon(pointsP1, "Jardin des Tuileries");
            polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            polygon.Stroke = new Pen(Color.Red, 1);
            polygons.Polygons.Add(polygon);
            gmap.Overlays.Add(polygons);

            //Creating an overlay, adding the coordinates for the route and creating and adding the route
            GMapOverlay routes = new GMapOverlay("routes");
            List<PointLatLng> pointsR1 = new List<PointLatLng>();
            pointsR1.Add(new PointLatLng(48.866383, 2.323575));
            pointsR1.Add(new PointLatLng(48.863868, 2.321554));
            pointsR1.Add(new PointLatLng(48.861017, 2.330030));
            GMapRoute route1 = new GMapRoute(pointsR1, "A walk in the park");
            route1.Stroke = new Pen(Color.Red, 3);
            routes.Routes.Add(route1);
            gmap.Overlays.Add(routes);

            //Creating a route between homeMarker and parisMarker to measure the distance
            GMapMarker parisMarker = new GMarkerGoogle(new PointLatLng(48.866383, 2.323575), GMarkerGoogleType.blue_dot);
            markers.Markers.Add(parisMarker);
            List<PointLatLng> pointsR2 = new List<PointLatLng>();
            pointsR2.Add(parisMarker.Position);
            pointsR2.Add(homeMarker.Position);
            GMapRoute route2 = new GMapRoute(pointsR2, "paris-home");
            routes.Routes.Add(route2);
            route2.Stroke = new Pen(Color.Black, 4);
            double distance = route2.Distance;
            parisMarker.ToolTipText = "" + distance + " km";

        }

        //This method is called when a marker is clicked
        private void gmap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {

        }

        //This method gets the longitude and latitude of where the left mouse button double clicks
        private void gmap_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                double latitude = gmap.FromLocalToLatLng(e.X, e.Y).Lat;
                double longitude = gmap.FromLocalToLatLng(e.X, e.Y).Lng;
            }
        }
    }
}
