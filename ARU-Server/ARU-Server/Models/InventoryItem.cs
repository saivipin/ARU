﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ARU_Server.Models
{
    public class InventoryItem
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public string Imagepath { get; set; }
    }      
}
