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
        }
    }
}
