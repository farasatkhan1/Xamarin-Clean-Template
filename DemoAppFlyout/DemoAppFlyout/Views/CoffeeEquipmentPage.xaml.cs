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
        int count = 0;

        public CoffeeEquipmentPage()
        {
            InitializeComponent();
        }

        private void onButtonClicked(object sender, EventArgs e) {
            count++;
            CountLabel.Text = $"You Clicked {count} times.";
        }
    }
}