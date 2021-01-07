using System;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Double[] sales;
        String[] names, lineValue = new String[20];
        StreamReader inputFile = File.OpenText("GameSalesW2020.txt");

        public Form1()
        {
            InitializeComponent();
            ReadIntoArray();
        }

        private void ReadIntoArray()
        {
            int count = 0;
            char[] del = { '#', '&' };
            while (inputFile.EndOfStream == false)
            {
                lineValue[count] = inputFile.ReadLine().Trim();
                count++;
            }
            names = new String[count];
            sales = new Double[count];
            for(int cpy = 0; cpy < names.Length; cpy++)
            {
                String[] input = lineValue[cpy].Split(del, StringSplitOptions.RemoveEmptyEntries);
                double.TryParse(input[0].Trim(), out double val);
                sales[cpy] = val;
                names[cpy] = input[1].Trim();
                //Array.Resize(ref arrayName,incr(it is an integer value));
            }
            for (int prt = 0; prt < names.Length; prt++)
                lstRes.Items.Add(names[prt] + " ==> " + sales[prt].ToString("C"));
            inputFile.Close();
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            SelectionSortByName();
            for (int r = 0; r < names.Length; r++)
                lstRes.Items.Add(names[r] + " ==> " + sales[r].ToString("C"));
        }

        private void SelectionSortByName()
        {
            lstRes.Items.Clear();
            for (int i = 0; i < names.Length; i++)
            {
                for (int j = i + 1; j < names.Length; j++)
                {
                    if (names[i].CompareTo(names[j]) > 0)
                    {
                        String tempN = names[i];
                        names[i] = names[j];
                        names[j] = tempN;

                        double tempS = sales[i];
                        sales[i] = sales[j];
                        sales[j] = tempS;
                    }
                }
            }
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            SelectionSortBySales();
            for (int g = 0; g < sales.Length; g++)
                    lstRes.Items.Add(sales[g].ToString("C") + " ==> " + names[g]);
        }

        private void SelectionSortBySales()
        {
            lstRes.Items.Clear();
            for (int i = 0; i < sales.Length; i++)
            {
                for (int j = i + 1; j < sales.Length; j++)
                {
                    if (sales[i] < sales[j])
                    {
                        double tempS = sales[i];
                        sales[i] = sales[j];
                        sales[j] = tempS;

                        String tempN = names[i];
                        names[i] = names[j];
                        names[j] = tempN;
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lstRes.Items.Clear();
            if (string.IsNullOrEmpty(txtBxSearch.Text.Trim()))       
                MessageBox.Show("Please enter some text to search \nbesides spaces or nothing");
            if (rbStart.Checked == true)
                SearchWith(txtBxSearch.Text.Trim(), "Start");
            else if (rbEnd.Checked == true)
                SearchWith(txtBxSearch.Text.Trim(), "End");
            else if (rbExact.Checked == true)
            {
                int pos = BinSrchByName(txtBxSearch.Text.Trim());
                if (pos == -1)
                    SearchWith(txtBxSearch.Text.Trim(), "All");
                else
                    lstRes.Items.Add(names[pos] + " ==> " + sales[pos].ToString("C"));
            }
            if (lstRes.Items.Count == 0)
                lstRes.Items.Add("No game with that search criteria");
        }

        private void SearchWith(string findText, string method)
        {
            if (method.Equals("Start") == true)
            {
                for (int sea = 0; sea < names.Length; sea++)
                {
                    if (names[sea].ToLower().StartsWith(findText.ToLower()))
                        lstRes.Items.Add(names[sea] + " ==> " + sales[sea].ToString("C") + " |*--|");
                }
            }
            else if (method.Equals("End") == true)
            {
                for (int sea = 0; sea < names.Length; sea++)
                {
                     if (names[sea].ToLower().EndsWith(findText.ToLower()))
                         lstRes.Items.Add(names[sea] + " ==> " + sales[sea].ToString("C") + " |--*|");
                }
            }
            else if (method.Equals("All") == true)
            {
                for (int sea = 0; sea < names.Length; sea++)
                {
                    if (names[sea].ToLower().StartsWith(findText.ToLower()))
                        lstRes.Items.Add(names[sea] + " ==> " + sales[sea].ToString("C") + " |*--|");
                    else if (names[sea].ToLower().EndsWith(findText.ToLower()))
                        lstRes.Items.Add(names[sea] + " ==> " + sales[sea].ToString("C") + " |--*|");
                    else if (names[sea].ToLower().Contains(findText.ToLower()))
                        lstRes.Items.Add(names[sea] + " ==> " + sales[sea].ToString("C") + " |-*-|");
                }
            }
        }

        private int BinSrchByName(string textGame)
        {
            SelectionSortByName();
            int first = 0, last = names.Length - 1, mid, pos = -1;
            while (first <= last)
            {
                mid = (first + last) / 2;
                if (textGame.ToLower().CompareTo(names[mid].ToLower()) == 0)
                {
                    pos = mid;
                    break;
                }
                else if (textGame.ToLower().CompareTo(names[mid].ToLower()) > 0)
                    first = mid + 1;
                else 
                    last = mid - 1;
            }
            return pos;
        }
    }
}
