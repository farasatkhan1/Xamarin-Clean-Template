using DemoAppFlyout.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace DemoAppFlyout.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}