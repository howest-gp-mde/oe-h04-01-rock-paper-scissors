using Mde.Oef.RPSGame.Domain;
using Mde.Oef.RPSGame.Domain.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mde.Oef.RPSGame
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage : ContentPage
    {
        private readonly SettingsService settingsService;
        private Settings settings;

        public SettingsPage()
        {
            InitializeComponent();

            settingsService = new SettingsService();
        }

        protected async override void OnAppearing()
        {

            settings = await settingsService.GetSettings();
            txtUserName.Text = settings.UserName;
            txtEmail.Text = settings.Email;
            chkReceiveStats.IsToggled = settings.ReceiveWeeklyStats;
        }

        private async void Save_Clicked(object sender, EventArgs e)
        {
            settings.UserName = txtUserName.Text;
            settings.Email = txtEmail.Text;
            settings.ReceiveWeeklyStats = chkReceiveStats.IsToggled;
            await settingsService.SaveSettings(settings);

            await Navigation.PopAsync(true);
        }
    }
}