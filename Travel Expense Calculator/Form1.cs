using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double companyConstant = 2810.54;
        public Form1()
        {
            InitializeComponent();
            lstBxDays.SelectedIndex = 0;
            lstBxEvents.SelectedIndex = 0;
            lstBxCRD.SelectedIndex = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();            
            chkBxOS.Checked = false;
            chkBxEncry.Checked = false;
            chkBxAttack.Checked = false;           
        }

        private void ClearTextBoxes()
        {
            txtBxAmtDay.Text = "";
            txtBxAirFare.Text = "";
            txtBxCRD.Text = "";
            txtBxPriPark.Text = "";
            txtBxRentPark.Text = "";
            txtBxPriMiles.Text = "";
            txtBxTaxiFare.Text = "";
            txtBxTExpn.Text = "";
            txtBxReimburse.Text = "";
            txtBxYouPay.Text = "";
            lstBxDays.SelectedIndex = 0;
            lstBxEvents.SelectedIndex = 0;
            lstBxCRD.SelectedIndex = 0;
        }

        private void lstBxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {         
            if(lstBxEvents.SelectedIndex==3)
            {
                grpBxITSecu.Visible = true;
                chkBxOS.Checked = true;
            }
            else
            {
                grpBxITSecu.Visible = false;
                chkBxOS.Checked = false;
            }
        }

        private void btnResetEvt_Click(object sender, EventArgs e)
        {
            ClearITSecurity();
            ClearResults();
        }

        private void ClearITSecurity()
        {
            lstBxEvents.SelectedIndex = 0;
            chkBxOS.Checked = false;
            chkBxEncry.Checked = false;
            chkBxAttack.Checked = false;
            grpBxITSecu.Visible = false;

        }

        private void lstBxDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstBxCRD.Items.Clear();
            AddDays(lstBxCRD,lstBxDays.SelectedIndex);
        }

        private void AddDays(ListBox lstNew,int a)
        {          
            for (int i = 0; i <=a; i++)
            {
                lstBxCRD.Items.Add((i + 1).ToString() + " Day(s)");
            }
            lstBxCRD.SelectedIndex = 0;
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            ClearResults();
            double airFare, taxiFare, carRental, carPrivate, eventCal, ITSemi, lodCal, min=10.7,max=17.5,total=0;
            airFare=CalculateAirFare();
            taxiFare = CalculateTaxiFare();
            carRental = CalculateCarRental();
            carPrivate = CalculateCarPrivate();
            eventCal = CalculateEvent();
            ITSemi = CalculateITSeminar();
            lodCal = CalculateLodging();
            if(ITSemi > 0) 
                total = airFare + taxiFare + carRental + carPrivate + ITSemi + lodCal;
            else if(lstBxEvents.SelectedIndex!=3)
                total = airFare + taxiFare + carRental + carPrivate + eventCal + lodCal;
            CalculateReimbursement(total,min,max);
        }

        private void ClearResults()
        {
            txtBxTExpn.Text = "";
            txtBxReimburse.Text = "";
            txtBxYouPay.Text = "";
        }

        private double CalculateAirFare()
        {
            double.TryParse((txtBxAirFare.Text),out double airFare);
            return airFare;
        }
        private double CalculateTaxiFare()
        {
            double.TryParse((txtBxTaxiFare.Text), out double taxiFare);
            return taxiFare;
        }
        private double CalculateCarRental()
        {
            double.TryParse((txtBxCRD.Text), out double carRent);
            double.TryParse((txtBxRentPark.Text), out double parkRent);
            int daysRent=lstBxCRD.SelectedIndex+1;
            return ((carRent*daysRent)+ parkRent); 
        }

        private double CalculateCarPrivate()
        {
            double.TryParse((txtBxPriMiles.Text), out double  miles);
            miles *= 0.43;
            double.TryParse((txtBxPriPark.Text), out double parkPri); 
            return (miles+parkPri);
        }
        // string related method start with 1 and Anything related to array,collection,stack starts with 0 
        private double CalculateEvent()
        {
            double.TryParse(lstBxEvents.Text.Substring(lstBxEvents.Text.IndexOf("$") + 1), out double events);
            return events;
        }

        private double CalculateITSeminar()
        {
            double OS=0, Encry=0, Attack=0;
            if (lstBxEvents.SelectedIndex == 3)
            {
                if ((chkBxOS.Checked == false) && (chkBxEncry.Checked == false) && (chkBxAttack.Checked == false))
                {
                    MessageBox.Show("Please Select an Event !!");
                    txtBxTExpn.Text="$0.00";
                    txtBxReimburse.Text = "$0.00";
                    txtBxYouPay.Text = "$0.00";                   
                }
                else
                {
                    if (chkBxOS.Checked == true)
                        double.TryParse(chkBxOS.Text.Substring(chkBxOS.Text.IndexOf("$") + 1),out OS);
                    if (chkBxEncry.Checked == true)
                        double.TryParse(chkBxEncry.Text.Substring(chkBxEncry.Text.IndexOf("$") + 1),out Encry);         
                    if(chkBxAttack.Checked==true)
                        double.TryParse(chkBxAttack.Text.Substring(chkBxAttack.Text.IndexOf("$") + 1),out Attack);
                }
            }
           return (OS+Encry+Attack);
        }

        private double CalculateLodging()
        {
            double.TryParse((txtBxAmtDay.Text), out double amount);
            int daysLog = lstBxDays.SelectedIndex + 1;
            return (amount * daysLog);
        }

        private void CalculateReimbursement(double total, double min, double max)
        {
            ClearResults();
            txtBxTExpn.Text = total.ToString("C");
            if (total <= companyConstant)
            {
                min = total * (min / 100);
                txtBxReimburse.Text = total.ToString("C");
                txtBxYouPay.Text = (total - min).ToString("C");
            }
            else
            {
                min = companyConstant * (min / 100);
                max = (total - companyConstant) * (max/100);
                txtBxReimburse.Text = (min+max).ToString("C");
                txtBxYouPay.Text = (total - (min+max)).ToString("C");
            }     
        }

    }
}
