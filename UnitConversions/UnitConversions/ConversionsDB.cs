using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;


namespace UnitConversions
{
    public static class ConversionsDB
    {
        private const string Path = @"..\..\Conversions.txt";
        private const string RestorePath = @"..\..\ConversionsDefault.txt";

        public static List<ConversionItem> GetItems()
        {
            List<ConversionItem> items = new List<ConversionItem>();

            var fs = new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Read);
            var sr = new StreamReader(fs, Encoding.UTF8);

            String s = "";
            while ((s = sr.ReadLine()) != null)
            {
                String[] col = s.Split('|');
                ConversionItem item = new ConversionItem(col[0], col[1], float.Parse(col[2]));
                items.Add(item);
            }
            sr.Close();
            return items;
        }

        public static List<ConversionItem> GetDefaultItems()
        {
            List<ConversionItem> items = new List<ConversionItem>();

            var fs = new FileStream(RestorePath, FileMode.OpenOrCreate, FileAccess.Read);
            var sr = new StreamReader(fs, Encoding.UTF8);

            String s = "";
            while ((s = sr.ReadLine()) != null)
            {
                String[] col = s.Split('|');
                ConversionItem item = new ConversionItem(col[0], col[1], float.Parse(col[2]));
                items.Add(item);
            }
            sr.Close();
            return items;
        }

        public static void SaveItems(List<ConversionItem> items)
        {
            var fs = new FileStream(Path, FileMode.Create, FileAccess.Write);
            var sw = new StreamWriter(fs, Encoding.UTF8);

            for (int i = 0; i < items.Count; i++)
            {
                String s = items[i].From + "|" + items[i].To + "|" + items[i].Multiplier;
                sw.WriteLine(s);
            }
            sw.Close();
        }
    }
}

