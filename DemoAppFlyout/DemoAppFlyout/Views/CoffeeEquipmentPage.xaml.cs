using DemoAppFlyout.Models;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoAppFlyout.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CoffeeEquipmentPage : ContentPage
    {
        public CoffeeEquipmentPage()
        {
            InitializeComponent();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e) { 
            var coffee = ((ListView) sender).SelectedItem as Coffee;
            if (coffee == null) return;
            await DisplayAlert("Coffee Selected", coffee.Title, "OK");
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e) {
            ((ListView)sender).SelectedItem = null;
        }

        private void Menuutem_Clicked(object sender, EventArgs e) {
        }
    }
}