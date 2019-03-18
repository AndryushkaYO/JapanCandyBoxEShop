﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CandyEShopData.Models
{
    public class ItemsTable
    {
        public int Id { get; set; }
        public string ImgPath { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double price { get; set; }
        public double weight {get;set;}
        public string type { get; set; }
    }
}
