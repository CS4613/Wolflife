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
    public partial class Events : ContentPage
    {
        public Events()
        {
            InitializeComponent();
        }

        async private void Calendar_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WebViewPage(/*insert link to calendar*/""));
        }
    }
}