using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitConversions
{
    public partial class FrmConversions : Form
    {
        string[] from = new string[10];
        string[] to = new string[10]; 
        float []multiplier = new float[10];
        int i = 0;
        
        public FrmConversions()
        {
            InitializeComponent();
        }

        private List<ConversionItem> convItems = null;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmConversions_Load(object sender, EventArgs e)
        {
            convItems = ConversionsDB.GetItems();
            FillConversionsListBox();
        }

        private void FillConversionsListBox()
        {
            lstConversions.Items.Clear();
            foreach (ConversionItem item in convItems)
            {
                lstConversions.Items.Add(item.GetDisplayText());
                from[i] = item.From;
                to[i] = item.To;
                multiplier[i] = item.Multiplier;
                i++;
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            float input = 0;
            if (IsValidData())
            {
                input = float.Parse(txtValConvert.Text);
            }
            
            lstResults.Items.Clear();
            if (lstConversions.SelectedIndices.Count > 0)
            {
                for (int i = 0; i < lstConversions.SelectedItems.Count; i++)
                {
                    float result = (float)Math.Round((input * multiplier[lstConversions.SelectedIndices[i]]) * 100f) / 100f;
                    //MessageBox.Show(input +" * "+ multiplier[lstConversions.SelectedIndices[i]] +" || "+ lstConversions.SelectedIndices[i]);
                    lstResults.Items.Add(input + " " + from[lstConversions.SelectedIndices[i]] + " = " + result + " " + to[lstConversions.SelectedIndices[i]]);
                }
            }
            else
            {
                MessageBox.Show("Atleast one item must be selected from the " + lstConversions.Tag, "Error");
                lstConversions.Focus();
            }
        }

        private bool IsValidData()
        {
            return Validator.IsPresent(txtValConvert) &&
                   Validator.IsFloat(txtValConvert);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtValConvert.Text = "";
            lstConversions.ClearSelected();
            lstResults.Items.Clear();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            FrmManageConversions manageConversions = new FrmManageConversions();
            if (manageConversions.UpdateConversionItemList())
            {
                convItems = ConversionsDB.GetItems();
                i = 0;
                lstConversions.ClearSelected();
                lstResults.Items.Clear();
                FillConversionsListBox();
            }
        }
    }
}
