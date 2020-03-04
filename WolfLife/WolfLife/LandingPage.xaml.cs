﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WolfLife
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LandingPage : ContentPage
    {
        public LandingPage()
        {
            InitializeComponent();

            const int NUMBEROFIMAGES = 3;
            Slideshow.ItemsSource = new string[]
            {
               "will.jpeg",
               "staff.jpg",
               "sliding.jpeg"
            };

            Device.StartTimer(TimeSpan.FromSeconds(5), (Func<bool>)(() =>
            {
                if (Slideshow.Position < NUMBEROFIMAGES)
                    Slideshow.Position += 1;
                else
                    Slideshow.Position = 0;
                return true;
            }));
        }

        async void onEventsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Events { });
        }
        async void onAboutUsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutUs { });
        }
        async void onLessonsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Lessons { });
        }
        async void onContactUsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContactUs { });
        }
        

    }
}