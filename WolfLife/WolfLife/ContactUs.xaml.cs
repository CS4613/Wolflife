using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WolfLife
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactUs : ContentPage
    {
        public ContactUs()
        {
            InitializeComponent();
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