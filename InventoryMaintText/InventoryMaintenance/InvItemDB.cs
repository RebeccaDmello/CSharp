using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace InventoryMaintenance
{
    public static class InvItemDB
    {
        private const string Path = @"..\..\..\InventoryItems.txt";

        public static List<InvItem> GetItems()
        {
            // create the list
            List<InvItem> items = new List<InvItem>();

            // Add code here to read the text file into the List<InvItem> object.
            using var fs = new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Read);
            using var sr = new StreamReader(fs, Encoding.UTF8);

            String s = "";
            while ((s = sr.ReadLine()) != null)
            {
                String[] col = s.Split('|');
                InvItem item = new InvItem(int.Parse(col[0]), col[1], decimal.Parse(col[2]));

                items.Add(item);
            }
            sr.Close();
            return items;
        }

        public static void SaveItems(List<InvItem> items)
        {
            // Add code here to write the List<InvItems> object to a text file.
            using var fs = new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Write);
            using var sw = new StreamWriter(fs, Encoding.UTF8);

            for (int i = 0; i < items.Count; i++)
            {
                String s = items[i].ItemNo + "|" + items[i].Description + "|" + items[i].Price;
                sw.WriteLine(s);
            }
            sw.Close();
        }
    }
}

