using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using DemoAppFlyout.Models;

namespace DemoAppFlyout.ViewModels
{
    public class CoffeeEquipmentViewModel : BindableObject {
        public ObservableCollection<Coffee> Items { get; set; }

        public CoffeeEquipmentViewModel()
        {
            var image = "https://images.pexels.com/photos/312418/pexels-photo-312418.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500";

            Items = new ObservableCollection<Coffee>
            {
                new Coffee { ImageUrl = image, Title = "Title 1", Description = "Description 1" },
                new Coffee { ImageUrl = image, Title = "Title 2", Description = "Description 2" },
                new Coffee { ImageUrl = image, Title = "Title 3", Description = "Description 3" },
                new Coffee { ImageUrl = image, Title = "Title 4", Description = "Description 4" },
                new Coffee { ImageUrl = image, Title = "Title 5", Description = "Description 5" },
                new Coffee { ImageUrl = image, Title = "Title 6", Description = "Description 6" },
                new Coffee { ImageUrl = image, Title = "Title 7", Description = "Description 7" },
                new Coffee { ImageUrl = image, Title = "Title 8", Description = "Description 8" },
                new Coffee { ImageUrl = image, Title = "Title 9", Description = "Description 9" },
                new Coffee { ImageUrl = image, Title = "Title 10", Description = "Description 10" },
            };

            RefreshCommand = new Command(OnRefresh);
            FavoriteCommand = new Command<Coffee>(OnFavorite);
        }

        Coffee previouslySelected;
        Coffee selectedCoffee;
        public Coffee SelectedCoffee
        {
            get => selectedCoffee;
            set
            {
                if (value != null)
                {
                    Application.Current.MainPage.DisplayAlert("Selected", value.Title, "OK");
                    previouslySelected = value;
                    value = null;
                }

                selectedCoffee = value;
                OnPropertyChanged();
            }
        }

        private bool _isRefreshing;
        public bool IsRefreshing
        {
            get => _isRefreshing;
            set
            {
                _isRefreshing = value;
                OnPropertyChanged();
            }
        }

        public ICommand RefreshCommand { get; }

        private void OnRefresh()
        {
            Device.StartTimer(TimeSpan.FromSeconds(2), () =>
            {
                var image = "https://images.pexels.com/photos/312418/pexels-photo-312418.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500";

                var newItem = new Coffee
                {
                    ImageUrl = image,
                    Title = "New Title",
                    Description = "New Description"
                };

                var newItem2 = new Coffee
                {
                    ImageUrl = image,
                    Title = "New Title 2",
                    Description = "New Description 2"
                };

                Items.Insert(0, newItem);
                Items.Insert(0, newItem2);
                IsRefreshing = false;
                return false;
            });
        }


        public ICommand FavoriteCommand { get; }

        public void OnFavorite(Coffee coffee)
        {
            Application.Current.MainPage.DisplayAlert("Favorite", $"You have favorited {coffee.Title}", "OK");
        }
    }
}
