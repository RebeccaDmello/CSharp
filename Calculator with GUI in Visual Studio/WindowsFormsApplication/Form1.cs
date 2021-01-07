using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationRebecca
{
    public partial class GUICalculator : Form
    {

        double fxdOrdCst, cryCstRate, untCst, cal;
        int dmdRate;
        string deciPt, rndUp;

        private void txtBxFOC_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBoxFOC_KeyPress(object sender, KeyPressEventArgs e)
        {
            char r = e.KeyChar;
            if (txtBxFOC.Text.IndexOf('.') != -1 && r == 46)
            {
                e.Handled = true;
                return;
            }
        }
        private void textBoxCCR_KeyPress(object sender, KeyPressEventArgs e)
        {
            char r = e.KeyChar;
            if (txtBxCCR.Text.IndexOf('.') != -1 && r == 46)
            {
                e.Handled = true;
                return;
            }
        }
        private void textBoxDR_KeyPress(object sender, KeyPressEventArgs e)
        {
            char r = e.KeyChar;
            if (txtBxDR.Text.IndexOf('.') != -1 && r == 46)
            {
                e.Handled = true;
                return;
            }
        }
        private void textBoxUC_KeyPress(object sender, KeyPressEventArgs e)
        {
            char r = e.KeyChar;
            if (txtBxUC.Text.IndexOf('.') != -1 && r == 46)
            {
                e.Handled = true;
                return;
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            
        }
        public GUICalculator()
        {
            InitializeComponent();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblUntCst_Click(object sender, EventArgs e)
        {

        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            try
            {
                fxdOrdCst = Convert.ToDouble(txtBxFOC.Text);
                cryCstRate = Convert.ToDouble(txtBxCCR.Text) / 100;
                dmdRate = Convert.ToInt32(txtBxDR.Text);
                untCst = Convert.ToDouble(txtBxUC.Text);

                cal = Math.Sqrt((2 * dmdRate * fxdOrdCst) / (cryCstRate * untCst));
                deciPt = cal.ToString("n1");
                rndUp = cal.ToString("n0");

                lblResult.Text=deciPt+" or "+rndUp +" ( rounded)";
               
            }
            catch (Exception )
            {
                MessageBox.Show("\nError while calculating the Economic Order Qty \nPlease check your inputs");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBxFOC.Clear();
            txtBxDR.Clear();
            txtBxCCR.Clear();
            txtBxUC.Clear();

            lblResult.Text = "";
            txtBxFOC.Focus();
        }
    }
}
