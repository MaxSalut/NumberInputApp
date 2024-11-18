using Microsoft.Maui.Controls;

namespace NumberInputApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnShowNumberClicked(object sender, EventArgs e)
        {
            if (int.TryParse(NumberEntry.Text, out int number))
            {
                DisplayAlert("Результат", $"Ви ввели число {number}", "OK");
            }
            else
            {
                DisplayAlert("Помилка", "Будь ласка, введіть коректне ціле число.", "OK");
            }
        }
    }
}
