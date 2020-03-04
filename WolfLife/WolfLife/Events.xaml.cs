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

            StackLayout sl = new StackLayout { };
            for (int i = 0; i < 20; ++i)
                sl.Children.Add(new Label
                {
                    Text = "Detailed List entry",
                    TextColor = Color.FromHex("#000000"),
                    FontFamily = "CollegiateFLF.ttf#CollegiateFLF",
                    FontSize = 20
                });
            MainScrollView.Content = sl;
        }

    }
}