﻿using DemoAppFlyout.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace DemoAppFlyout.Services
{
    class CoffeeService
    {
        static SQLiteAsyncConnection db;
        static async Task Init()
        {
            if (db != null) return;

            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "MyData.db");
            db = new SQLiteAsyncConnection(databasePath);

            await db.CreateTableAsync<Coffee>();
        }

        public static async Task AddCoffee(string title, string description)
        {
            await Init();
            var image = "https://www.yesplz.coffee/app/uploads/2020/11/emptybag-min.png";
            var coffee = new Coffee
            {
                Title = title,
                Description = description,
                ImageUrl = image
            };

            var id = await db.InsertAsync(coffee);
        }

        public static async Task RemoveCoffee(int id)
        {

            await Init();

            await db.DeleteAsync<Coffee>(id);
        }

        public static async Task<IEnumerable<Coffee>> GetCoffee()
        {
            await Init();

            var coffee = await db.Table<Coffee>().ToListAsync();
            return coffee;
        }
    }
}
