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
    public partial class FrmManageConversions : Form
    {
        public FrmManageConversions()
        {
            InitializeComponent();
        }

        private List<ConversionItem> convItems = null;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddConversion addConversion = new FrmAddConversion();
            ConversionItem convItem = addConversion.GetNewConversionItem();
            if (convItem != null)
            {
                convItems.Add(convItem);
                FillConversionsListBox();
            }
        }

        private void FrmManageConversions_Load(object sender, EventArgs e)
        {
            convItems = ConversionsDB.GetItems();
            FillConversionsListBox();
        }

        private void FillConversionsListBox()
        {
            lstConversions.Items.Clear();
            foreach (ConversionItem item in convItems)
            {
                lstConversions.Items.Add(item.From + "|" + item.To + "|" + item.Multiplier);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int rmvItem = lstConversions.SelectedIndex;
            if (rmvItem != -1)
            {
                ConversionItem convItem = (ConversionItem)convItems[rmvItem];
                string message = $"Are you sure you want to delete conversion: '{convItem.From} to {convItem.To}'?";
                DialogResult button =
                    MessageBox.Show(message, "Confirm Delete",
                    MessageBoxButtons.YesNo);
                if (button == DialogResult.Yes)
                {
                    convItems.Remove(convItem);
                    FillConversionsListBox();
                }
            }
        }

        private void btnRestoreDefaults_Click(object sender, EventArgs e)
        {
            convItems = ConversionsDB.GetDefaultItems();
            FillConversionsListBox();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ConversionsDB.SaveItems(convItems);
            this.Close();
        }

        public bool UpdateConversionItemList()
        {
            this.ShowDialog();
            return true;
        }
    }
}
