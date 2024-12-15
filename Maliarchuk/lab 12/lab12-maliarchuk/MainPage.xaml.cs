using Microsoft.Maui.Controls;

namespace lab12_maliarchuk
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnHelloButtonClicked(object sender, EventArgs e)
        {
            HelloButton.Text = "Ви натиснули на кнопку!";
        }
    }
}