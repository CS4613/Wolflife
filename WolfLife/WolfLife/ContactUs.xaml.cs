using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.GoogleMaps;


namespace WolfLife
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactUs : ContentPage
    {
        public ContactUs()
        {
            InitializeComponent();

            //creating elements for map such as starting position
            Position position = new Position(35.846686, -90.676525);
            MapSpan mapSpan = new MapSpan(position, 0.01, 0.01);
            Pin pin = new Pin
            {
                Label = "WolfLife Campus Ministy",
                Address = "2304 Shelton St, Jonesboro, AR 72401",
                Position = new Position(35.846686, -90.676525),
                Type = PinType.Place
            };

            //instantiating the map and adjusting its view and adding a pin
            Map map = new Map();
            map.MyLocationEnabled = false;
            map.MoveToRegion(mapSpan);
            map.Pins.Add(pin);
            map.MapType = MapType.Hybrid;

            //setting the frame to hold the map
            mapFrame.Content = map;
        }
        async private void Instagram_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WebViewPage("https://www.instagram.com/wolflifecampusministry/"));
        }

        async private void Twitter_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WebViewPage("https://twitter.com/WOLFLIFE_CM"));
        }

        async private void Facebook_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WebViewPage("https://www.facebook.com/WolflifeCampusMinistry/"));
        }

        async private void Youtube_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WebViewPage("https://www.youtube.com/channel/UCg2DCcbgsPiI-57TqQ6jQrA/" ));
        }

    }
}