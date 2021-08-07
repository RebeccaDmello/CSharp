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
    public partial class FrmAddConversion : Form
    {
        public FrmAddConversion()
        {
            InitializeComponent();
        }

        private ConversionItem convItem = null;

        public ConversionItem GetNewConversionItem()
        {
            this.ShowDialog();
            return convItem;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                convItem = new ConversionItem(
                    txtFrom.Text,
                    txtTo.Text,
                    float.Parse(txtMultiplier.Text)
                );
                this.Close();
            }
        }

        private bool IsValidData()
        {
            return Validator.IsPresent(txtFrom) &&
                   Validator.IsPresent(txtTo) &&
                   Validator.IsPresent(txtMultiplier) &&
                   Validator.IsFloat(txtMultiplier);
        }
    }
}
