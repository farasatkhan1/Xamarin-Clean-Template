﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoAppFlyout.Models
{
    public class Coffee
    {
        [PrimaryKey, AutoIncrement]
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
