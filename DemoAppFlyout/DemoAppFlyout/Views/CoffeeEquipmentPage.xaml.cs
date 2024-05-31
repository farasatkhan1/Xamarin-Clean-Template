using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            BindingContext = this;
        }

        int count = 0;
        string countDisplay = "Click Me!";
        public string CountDisplay
        {
            get => countDisplay;
            set
            {
                if (value == countDisplay) return;

                countDisplay = value;
                OnPropertyChanged();
            }
        }

        private void onButtonClicked(object sender, EventArgs e) {
            count++;
            CountDisplay = $"You Clicked {count} times.";
        }
    }
}