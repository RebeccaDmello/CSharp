using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileOperation
{
    public partial class DataFile : Form
    {

        public DataFile()
        {
            InitializeComponent();
            txtStockName.Focus();
        }
        int extCnt = 1, intCnt = 1;

        private void btnProcess_Click_1(object sender, EventArgs e)
        {
            
                lstResult.Items.Clear();
                StreamReader stName = File.OpenText("stockName.dat");
                StreamReader pPrice = File.OpenText("purchasePrice.dat");
                StreamReader cPrice = File.OpenText("currentPrice.dat");
                StreamReader shares = File.OpenText("shares.dat");
                StreamWriter log = File.AppendText("log.dat");
                double shre = 0.0d, curp = 0.0d, purp = 0.0d, selPrice = 0.0d, purPrice = 0.0d, gain = 0.0d;
                String line = "", stock = txtStockName.Text;
           

                while (stName.EndOfStream == false)
                {
                    line = (stName.ReadLine()).Trim();
                    if (string.Compare(line, stock) == 0)
                    {
                        while (intCnt != extCnt)
                        {
                            while (shares.EndOfStream == false && pPrice.EndOfStream == false && cPrice.EndOfStream == false)
                            {
                                String shr = shares.ReadLine().Trim();
                                String ppr = "$" + pPrice.ReadLine().Trim();
                                String cpr = cPrice.ReadLine().Trim();
                                if (intCnt == extCnt)
                                {
                                    txtShares.Text = shr;
                                    txtPurPrice.Text = ppr;
                                    txtCurPriceF.Text = cpr;
                                    break;
                                }
                                intCnt++;
                            }
                        }

                        if (!Double.TryParse(txtShares.Text, out shre))
                        {
                            MessageBox.Show("Error with Shares\nCalculation NOT Possible...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            log.WriteLine(stock + " === ERROR with Shares");
                        }
                        if (!Double.TryParse((txtPurPrice.Text).Substring(1), out purp))
                        {
                            MessageBox.Show("Error with Purchase Price\nCalculation NOT Possible...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            log.WriteLine(stock + " === ERROR with Purchase Price");
                        }
                        if (!String.IsNullOrEmpty(txtCurPriceN.Text))
                        {
                            if (Double.TryParse(txtCurPriceN.Text, out curp))
                            {
                                if (curp <= 0)
                                {
                                    if (!Double.TryParse(txtCurPriceF.Text, out curp))
                                    {
                                        MessageBox.Show("Error with Current Price (File)\nCalculation NOT Possible...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        log.WriteLine(stock + " === ERROR with Current Price");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Error with Current Price (New)\nCalculation NOT Possible...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                log.WriteLine(stock + " === ERROR with Current Price");
                                txtCurPriceN.Text = ""; txtCurPriceN.Focus();
                            }
                        }
                        else
                        {
                            if (!Double.TryParse(txtCurPriceF.Text, out curp))
                            {
                                MessageBox.Show("Error with Current Price (File)\nCalculation NOT Possible...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                log.WriteLine(stock + " === ERROR with Current Price");
                            }
                        }
                        if (shre > 0 && purp > 0 && curp > 0)
                        {
                            purPrice = purp * shre;
                            selPrice = curp * shre;
                            gain = selPrice - purPrice;
                            if (rdoDetails.Checked == true)
                            {
                                lstResult.Items.Add("Stock : " + stock);
                                lstResult.Items.Add("Purchase Price = " + purPrice.ToString("C"));
                                lstResult.Items.Add("Selling Price = " + selPrice.ToString("C"));
                                lstResult.Items.Add("Gain = " + gain.ToString("C"));
                                log.WriteLine(stock + " === " + gain.ToString("n2"));
                            }
                            else
                            {
                                lstResult.Items.Add("Stock : " + stock);
                                lstResult.Items.Add("Gain = " + gain.ToString("C"));
                                log.WriteLine(stock + " === " + gain.ToString("n2"));
                            }
                        }
                        break;
                    }
                    extCnt++;
                }
                if (intCnt == 1)
                {
                    MessageBox.Show("Stock Not Found...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtStockName.Text = ""; txtShares.Text = ""; txtPurPrice.Text = ""; txtCurPriceF.Text = ""; txtCurPriceN.Text = ""; txtStockName.Focus();
                    log.WriteLine(" === NOT FOUND");
                }
                stName.Close(); pPrice.Close(); cPrice.Close(); shares.Close(); log.Close();
                extCnt = 1; intCnt = 1;
            }
            }

    }



















      

        
        
   

    