using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
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
            IncreaseCount = new Command(OnIncrease);
            BindingContext = this;
        }

        public ICommand IncreaseCount { get;  }

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

        void OnIncrease()
        {
            count++;
            CountDisplay = $"You Clicked {count} times.";
        }
    }
}