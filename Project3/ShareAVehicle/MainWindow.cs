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

namespace ShareAVehicle
{
    public partial class MainWindow : Form
    {

        private GMapOverlay markers = new GMapOverlay();
        private GMapOverlay routes = new GMapOverlay();
        private GMapMarker currentPositionMarker;
        private List<Double> markersData;
        private PointLatLng currentPosition;
        private DataManager dm = new DataManager();
        private Boolean user;

        public MainWindow(Boolean user)
        {

            this.user = user;
            InitializeComponent();

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

            try
            {
                readFile();
                setMarkers();
                gmap.MapProvider = GoogleMapProvider.Instance;
                GMaps.Instance.Mode = AccessMode.ServerOnly;
                gmap.Position = new PointLatLng(32.206737, 34.896469);
                gmap.ShowCenter = false;
                gmap.Overlays.Add(markers);
                gmap.Overlays.Add(routes);
            }
            catch (Exception)
            {
                MessageBox.Show("File not found");
            }

        }

        private void setMarkers() {

            for (int i = 0; i < markersData.Count; i += 2)
            {
                GMapMarker marker = new GMarkerGoogle(new PointLatLng(markersData.ElementAt(i), markersData.ElementAt(i+1)), GMarkerGoogleType.blue_dot);
                markers.Markers.Add(marker);
            }

        }

        private void gmap_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (user)
            {
                if (e.Button == MouseButtons.Left)
                {
                    double latitude = gmap.FromLocalToLatLng(e.X, e.Y).Lat;
                    double longitude = gmap.FromLocalToLatLng(e.X, e.Y).Lng;
                    currentPosition = new PointLatLng(latitude, longitude);
                    findClosestMarker(currentPosition);
                }
            }
            else
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (MessageBox.Show("Do you want to add a car here?","Add car",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        double latitude = gmap.FromLocalToLatLng(e.X, e.Y).Lat;
                        double longitude = gmap.FromLocalToLatLng(e.X, e.Y).Lng;
                        write(System.DateTime.UtcNow,latitude,longitude, "[]");
                        this.Close();
                    }
                }
            }
            
            

        }

        private void findClosestMarker(PointLatLng currentPos) {

            if (currentPositionMarker != null)
            {
                markers.Markers.Remove(currentPositionMarker);
            }
            GMapRoute route;
            double shortestDistance = Double.MaxValue;
            GMapMarker closest = new GMarkerGoogle(currentPos, GMarkerGoogleType.black_small);
            for (int i = 0; i < markers.Markers.Count; i++)
            {
                List<PointLatLng> points = new List<PointLatLng>();
                points.Add(currentPos);
                points.Add(markers.Markers.ElementAt(i).Position);
                route = new GMapRoute(points, "");
                if (route.Distance < shortestDistance)
                {
                    closest = markers.Markers.ElementAt(i);
                    shortestDistance = route.Distance;
                }
            }
            currentPositionMarker = new GMarkerGoogle(currentPos, GMarkerGoogleType.black_small);
            markers.Markers.Add(currentPositionMarker);
            makeRoute(currentPositionMarker, closest);

        }

        private void makeRoute(GMapMarker pos1, GMapMarker pos2) {

            List<PointLatLng> points = new List<PointLatLng>();
            points.Add(pos1.Position);
            points.Add(pos2.Position);
            routes.Clear();
            GMapRoute route = new GMapRoute(points, "");
            route.Stroke = new Pen(Color.Black, 4);
            Double distance = findDistance(route);
            pos1.ToolTipText = distance + " km";
            pos2.ToolTipText = distance + " km";
            routes.Routes.Add(route);

        }

        private Double findDistance(GMapRoute route) {

            return route.Distance;

        }

        private void readFile() {

            try
            {
                markersData = dm.readFromFile();
            }
            catch (Exception)
            {
                MessageBox.Show("File not found");
            }
            

        }

        private void write(DateTime date, Double x, Double y, string extra) {

            String list = Environment.NewLine + date.ToString() + ", " + x.ToString() + ", " + y.ToString() + ", " + extra;
            dm.writeFile(list);

        }

        private void Gmap_Load(object sender, EventArgs e)
        {

        }
    }
}
