using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace lab09
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void PanDemo_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PanDemo());
        }
        private async void PinchDemoo_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PinchDemo());
        }
        private async void SwipeDemo_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SwipeDemo());
        }
        private async void TapDemo_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TapDemo());
        }
    }
}
