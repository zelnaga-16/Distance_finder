
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
//Windows.UI.Xaml.Controls.Maps

namespace Distance_finder
{

    public partial class Form1 : Form
    {
        private int Get_lat_and_long(String text, ref double latitude, ref double longitude)
        {
            //Запрос к API геокодирования Google.
            string url = string.Format(
            "https://maps.googleapis.com/maps/api/geocode/xml?address={0}&key=AIzaSyDrLdfidigCgTYWTN4l6T2N0J6pNRqZArY&sensor=true_or_false&language=ru",
            Uri.EscapeDataString(text));

            //Выполняем запрос к универсальному коду ресурса (URI).
            System.Net.HttpWebRequest request =
            (System.Net.HttpWebRequest)System.Net.WebRequest.Create(url);

            //Получаем ответ от интернет-ресурса.
            System.Net.WebResponse response =
            request.GetResponse();

            //Экземпляр класса System.IO.Stream
            //для чтения данных из интернет-ресурса.
            System.IO.Stream dataStream =
            response.GetResponseStream();

            //Инициализируем новый экземпляр класса
            //System.IO.StreamReader для указанного потока.
            System.IO.StreamReader sreader =
            new System.IO.StreamReader(dataStream);

            //Считывает поток от текущего положения до конца.
            string responsereader = sreader.ReadToEnd();

            //Закрываем поток ответа.
            response.Close();

            System.Xml.XmlDocument xmldoc =
            new System.Xml.XmlDocument();

            xmldoc.LoadXml(responsereader);

            if (xmldoc.GetElementsByTagName("status")[0].ChildNodes[0].InnerText == "OK")
            {

                //Получение широты и долготы.
                System.Xml.XmlNodeList nodes =
                xmldoc.SelectNodes("//location");

                //Переменные широты и долготы.


                //Получаем широту и долготу.
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
            return deg * (Math.PI / 180d);
        }
        private double Find_distance()
        {
            double latitude_1 = 0.0;
            double longitude_1 = 0.0;
            double latitude_2 = 0.0;
            double longitude_2 = 0.0;
            int Check_1 = Get_lat_and_long(address_1.Text, ref latitude_1, ref longitude_1);
            int Check_2 = Get_lat_and_long(address_2.Text, ref latitude_2, ref longitude_2);
            if (Check_1 == 1 && Check_2 == 1)
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


            return -1;
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, EventArgs e)
        {
            if (address_1.Text != "" && address_2.Text != "")
            {
                double result = Find_distance();
                if (result == -1)
                {
                    result_lable.Text = "One of the addresses is wrong";

                }
                else
                {

                    result_lable.Text = "result: " + string.Format("{0:F2}", result) + " kilometers";

                }
            }
            else
            {
                result_lable.Text = "One of the addresses is wrong";
            }

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


    }
}