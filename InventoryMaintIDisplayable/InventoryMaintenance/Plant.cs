﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryMaintenance
{
    public class Plant : InvItem
    {
        public Plant() { }

        public Plant(int itemNo, string description, decimal price, string size) :
            base(itemNo, description, price)
        {
            Size = size;
        }

        public string Size { get; set; }

        public override string GetDisplayText() => 
            $"{ItemNo}    {Size} {Description} ({Price:c})";
    }
}
