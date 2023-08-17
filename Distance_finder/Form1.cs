using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;

namespace Distance_finder
{

    public partial class Form1 : Form
    {
        private int Get_lat_and_long(String text, ref double latitude, ref double longitude)
        {
            //Request to the Google Geocoding API.
            string url = string.Format(
            "https://maps.googleapis.com/maps/api/geocode/xml?address={0}&key=AIzaSyDrLdfidigCgTYWTN4l6T2N0J6pNRqZArY&sensor=true_or_false&language=ru",
            Uri.EscapeDataString(text));

            //Making a request to a Uniform Resource Identifier (URI).
            System.Net.HttpWebRequest request =
            (System.Net.HttpWebRequest)System.Net.WebRequest.Create(url);

            //We receive a response from an Internet resource.
            System.Net.WebResponse response =
            request.GetResponse();

            //An instance of the System.IO.Stream class
            //to read data from an Internet resource.
            System.IO.Stream dataStream =
            response.GetResponseStream();

            //Initializing a new class instance
            //System.IO.StreamReader for the specified stream.
            System.IO.StreamReader sreader =
            new System.IO.StreamReader(dataStream);

            //Reads the stream from the current position to the end.
            string responsereader = sreader.ReadToEnd();

            //Closing the response stream.
            response.Close();

            System.Xml.XmlDocument xmldoc =
            new System.Xml.XmlDocument();

            xmldoc.LoadXml(responsereader);

            if (xmldoc.GetElementsByTagName("status")[0].ChildNodes[0].InnerText == "OK")
            {

                //Getting latitude and longitude.
                System.Xml.XmlNodeList nodes =
                xmldoc.SelectNodes("//location");
                //Get latitude and longitude.
                foreach (System.Xml.XmlNode node in nodes)
                {
                    latitude =
                    System.Xml.XmlConvert.ToDouble(node.SelectSingleNode("lat").InnerText.ToString());
                    longitude =
                    System.Xml.XmlConvert.ToDouble(node.SelectSingleNode("lng").InnerText.ToString());
                }
                return 1;
            }
            return 0;

        }
        private double Deg2Rad(double deg)
        {
            //from degree to radius
            return deg * (Math.PI / 180d);
        }
        private double Find_distance()
        {
            //first adress
            double latitude_1 = 0.0;
            double longitude_1 = 0.0;
            //second adress
            double latitude_2 = 0.0;
            double longitude_2 = 0.0;
            //Check result

            bool Check_1 = Convert.ToBoolean(Get_lat_and_long(address_1.Text, ref latitude_1, ref longitude_1));
            if (Check_1)
            {
                gMapControl1.Position = new GMap.NET.PointLatLng(latitude_1, longitude_1);
                gMapControl1.Zoom = 20;

                List<Marker> markers_1 = new List<Marker>//marker on first map
                {
                    new Marker()
                };
                markers_1[0].Set(address_1.Text, latitude_1, longitude_1);//info for first map

                gMapControl1.Overlays.Add(GetOverlayMarkers(markers_1, "First map"));//marker for first map
                gMapControl1.Update();// update first control
            }

            bool Check_2 = Convert.ToBoolean(Get_lat_and_long(address_2.Text, ref latitude_2, ref longitude_2));
            if (Check_2)
            {
                gMapControl2.Position = new GMap.NET.PointLatLng(latitude_2, longitude_2);
                gMapControl2.Zoom = 20;
                List<Marker> markers_2 = new List<Marker>//marker on second map
                {
                    new Marker()
                };
                markers_2[0].Set(address_2.Text, latitude_2, longitude_2);//info for second map

                gMapControl2.Overlays.Add(GetOverlayMarkers(markers_2, "Second map"));//marker for second map
                gMapControl2.Update();// update second control
            }
            //find distance
            if (Check_1 && Check_2)
            {
                var R = 6371d;
                var dLat = Deg2Rad(latitude_2 - latitude_1);
                var dLon = Deg2Rad(longitude_2 - longitude_1);
                var a =
                    Math.Sin(dLat / 2d) * Math.Sin(dLat / 2d) +
                    Math.Cos(Deg2Rad(latitude_1)) * Math.Cos(Deg2Rad(latitude_2)) *
                    Math.Sin(dLon / 2d) * Math.Sin(dLon / 2d);
                var c = 2d * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1d - a));
                var d = R * c;

                return d;
            }

            //if Check was failed
            return -1;
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, EventArgs e)
        {
            //print result
            if (address_1.Text != "" && address_2.Text != "")
            {
                double result = Find_distance();
                //check result
                if (result == -1)
                { result_lable.Text = "One of the addresses is wrong"; }
                else
                { result_lable.Text = "result: " + string.Format("{0:F3}", result) + " kilometers"; }
            }
            else { result_lable.Text = "One of the addresses is wrong"; }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
        private GMapOverlay GetOverlayMarkers(List<Marker> markers, string name, GMarkerGoogleType gMarkerGoogleType = GMarkerGoogleType.red)
        {
            GMapOverlay gMapMarkers = new GMapOverlay(name);// creating a named layer
            foreach (Marker marker in markers)
            {
                gMapMarkers.Markers.Add(GetMarker(marker, gMarkerGoogleType));// adding markers to a layer
            }
            return gMapMarkers;
        }
        private GMarkerGoogle GetMarker(Marker marker, GMarkerGoogleType gMarkerGoogleType = GMarkerGoogleType.red)
        {
            GMarkerGoogle mapMarker = new GMarkerGoogle(new GMap.NET.PointLatLng(marker.Get_latitude(), marker.Get_longitude()), gMarkerGoogleType);//latitude, longitude, marker type
            mapMarker.ToolTip = new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(mapMarker);//marker info popup
            mapMarker.ToolTipText = marker.Get_text(); // text inside the popup
            mapMarker.ToolTipMode = MarkerTooltipMode.OnMouseOver; //popup display (on hover)
            return mapMarker;
        }
        private void gMapControl1_Load(object sender, EventArgs e)
        {
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache; //choice of map loading - online or from resources
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance; //which map provider is used (in our case, Google) 
            gMapControl1.MinZoom = 2; //minimum zoom
            gMapControl1.MaxZoom = 24; //maximum zoom
            gMapControl1.Zoom = 4; // what zoom is used when opening
            gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter; // how it zooms in (just to the center of the map or by mouse position)
            gMapControl1.CanDragMap = true; // dragging the map with the mouse
            gMapControl1.DragButton = MouseButtons.Left; // which button is used for dragging
            gMapControl1.ShowCenter = false; //show or hide the red cross in the center
            gMapControl1.ShowTileGridLines = false; //show or hide tiles
        }
        private void gMapControl2_Load(object sender, EventArgs e)
        {
            // second map, like first 
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache; 
            gMapControl2.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance; 
            gMapControl2.MinZoom = 2; 
            gMapControl2.MaxZoom = 24; 
            gMapControl2.Zoom = 4; 
            gMapControl2.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter; 
            gMapControl2.CanDragMap = true; 
            gMapControl2.DragButton = MouseButtons.Left; 
            gMapControl2.ShowCenter = false; 
            gMapControl2.ShowTileGridLines = false; 
        }
    }
    public class Marker// class with info for marker
    {
        string text;
        double latitude;
        double longitude;

        public void Set(string text, double latitude, double longitude)
        {
            this.text = text;
            this.latitude = latitude;
            this.longitude = longitude;
        }
        public string Get_text()
        {
            return text;
        }
        public double Get_latitude()
        {
            return latitude;
        }
        public double Get_longitude()
        {
            return longitude;
        }
    }
}