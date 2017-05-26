using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DataTest_MS
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            GetData();

        }
        private void GetData()
        {

            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString("https://facebook.github.io/react-native/movies.json");

                var J2 = JsonConvert.DeserializeObject<RootObject>(json);

                L1.Text = J2.title;
                L2.Text = J2.description;
                MyListView.ItemsSource = J2.movies.ToList();
            }
        }

        
    }
}
