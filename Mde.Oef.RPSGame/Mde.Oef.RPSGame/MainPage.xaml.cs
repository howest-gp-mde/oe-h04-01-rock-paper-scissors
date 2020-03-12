using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Mde.Oef.RPSGame
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }


        private async void Play_Clicked(object sender, EventArgs e)
        {
            var gamePage = new GamePage();
            await Navigation.PushAsync(gamePage, true);
        }

        private async void Settings_Clicked(object sender, EventArgs e)
        {
            var settingsPage = new SettingsPage();
            await Navigation.PushAsync(settingsPage, true);
        }

    }
}
