using Microsoft.Maui.Controls;

namespace Task6._8
{
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            // Navigate to MainPage when button is clicked
            await Navigation.PushAsync(new MainPage());
        }
    }
}
