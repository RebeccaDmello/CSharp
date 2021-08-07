using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConversions
{
    public class ConversionItem
    {
        public ConversionItem() { }

        public ConversionItem(string from, string to, float multiplier)
        {
            From = from;
            To = to;
            Multiplier = multiplier;
        }

        public string From { get; set; }
        public string To { get; set; }
        public float Multiplier { get; set; }

        public string GetDisplayText() => $"{From} to {To}";
    }
}
