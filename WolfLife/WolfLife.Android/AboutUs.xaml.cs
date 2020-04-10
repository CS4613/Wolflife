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
        bool mediaIsPlaying = true;
        public AboutUs()
        {
            
            InitializeComponent();

        }

        //pauses the video upon pausing the activity
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            videoPlayer.Pause();
        }

        //plays the video upon the activity resuming
        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (mediaIsPlaying)
                videoPlayer.Play();
        }

        async void onLeadersClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Leaders { });
        }

        async void onTestimonialsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Testimonials { });
        }

        //controls the play and pause tap gesture of the video
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            if (mediaIsPlaying)
            {
                videoPlayer.Pause();
                mediaIsPlaying = false;
            }
            else
            {
                videoPlayer.Play();
                mediaIsPlaying = true;
            }

        }
    }
}