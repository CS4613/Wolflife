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
    public partial class Lessons : ContentPage
    {
        public Lessons()
        {
            InitializeComponent();
        }

        async private void Unfiltered_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WebViewPage("https://soundcloud.com/user-309912955/sets/unfiltered-series"));
        }

        async private void Whats_The_Point_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WebViewPage("https://soundcloud.com/user-309912955/sets/whats-the-point-series"));
        }
    }
    
}