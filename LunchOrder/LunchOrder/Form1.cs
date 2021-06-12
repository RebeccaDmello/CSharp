using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunchOrder
{
    public partial class Form1 : Form
    {
        private double subTotal , tax, ordTotal;
        private int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearTotals()
        {
            txtSubtotal.Text = "";
            txtSalesTax.Text = "";
            txtOrderTotal.Text = "";
            count = 0;
        }

        private void ClearAddOns()
        {
            chkbxLettuce.Checked = false;
            chkbxKetchup.Checked = false;
            chkbxFrench.Checked = false;
        }

        private void rdoHam_CheckedChanged(object sender, EventArgs e)
        {
            ClearTotals();
            ClearAddOns();
            gbxAddon.Text = "Add-on items ($.75/each)";
            chkbxLettuce.Text = "Lettuce, tomatoes, and onions";
            chkbxKetchup.Text = "Ketchup, mustard, and mayo";
            chkbxFrench.Text = "French fries";
        }

        private void rdoPizza_CheckedChanged(object sender, EventArgs e)
        {
            ClearTotals();
            ClearAddOns();
            gbxAddon.Text = "Add-on items ($.50/each)";
            chkbxLettuce.Text = "Pepperoni";
            chkbxKetchup.Text = "Sausage";
            chkbxFrench.Text = "Olives";
        }

        private void rdoSal_CheckedChanged(object sender, EventArgs e)
        {
            ClearTotals();
            ClearAddOns();
            gbxAddon.Text = "Add-on items ($.25/each)";
            chkbxLettuce.Text = "Cruotons";
            chkbxKetchup.Text = "Bacon bits";
            chkbxFrench.Text = "Bread sticks";
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if(rdoHam.Checked == true )
            {
                if(chkbxLettuce.Checked == true)
                {
                    count++;
                }
                if (chkbxKetchup.Checked == true)
                {
                    count++;
                }
                if(chkbxFrench.Checked == true)
                {
                    count++;
                }
                subTotal = 6.95 + (0.75 * count);
                tax = (7.75 / 100) * subTotal;
                ordTotal = subTotal + tax;
                txtSubtotal.Text = subTotal.ToString("C");
                txtSalesTax.Text = tax.ToString("C");
                txtOrderTotal.Text = ordTotal.ToString("C");
            }else if(rdoPizza.Checked == true)
            {
                if (chkbxLettuce.Checked == true)
                {
                    count++;
                }
                if (chkbxKetchup.Checked == true)
                {
                    count++;
                }
                if (chkbxFrench.Checked == true)
                {
                    count++;
                }
                subTotal = 5.95 + (0.50 * count);
                tax = (7.75 / 100) * subTotal;
                ordTotal = subTotal + tax;
                txtSubtotal.Text = subTotal.ToString("C");
                txtSalesTax.Text = tax.ToString("C");
                txtOrderTotal.Text = ordTotal.ToString("C");
            }
            else if(rdoSal.Checked == true)
            {
                if (chkbxLettuce.Checked == true)
                {
                    count++;
                }
                if (chkbxKetchup.Checked == true)
                {
                    count++;
                }
                if (chkbxFrench.Checked == true)
                {
                    count++;
                }
                subTotal = 4.95 + (0.25 * count);
                tax = (7.75 / 100) * subTotal;
                ordTotal = subTotal + tax;
                txtSubtotal.Text = subTotal.ToString("C");
                txtSalesTax.Text = tax.ToString("C");
                txtOrderTotal.Text = ordTotal.ToString("C");
            }
        }

    }
}
