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
    public partial class AboutUs : ContentPage
    {
        public AboutUs()
        {
            InitializeComponent();
        }

        async void onLeadersClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Leaders { });
        }

        async void onTestimonialsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Testimonials { });
        }
    }
}