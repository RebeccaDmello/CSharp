using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketsForm
{
    public partial class frmOption : Form
    {
        frmMain frmain;
        TimeSlot timeSlot;
        public frmOption()
        {
            InitializeComponent();
            frmain = Application.OpenForms["frmMain"] as frmMain;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int minPerWindow = 5, guestPerWindow = 5, firstTicketNo = 1;
            DateTime iniSTime = DateTime.Parse(DateTime.Now.ToString("h:mm tt")),
                     iniNTime = DateTime.Parse(DateTime.Now.ToString("h:mm tt")).AddMinutes(5),
                     iniETime = DateTime.Parse(DateTime.Now.ToString("h:mm tt")).AddHours(4);

            if (frmain != null)
            {
                if (IsValidData())
                {
                    try
                    {
                        if (txtBxStart.Text != "" || txtBxEnd.Text != "")
                        {
                            iniSTime = DateTime.Parse(txtBxStart.Text);
                            iniNTime = iniSTime.AddMinutes(5);
                            iniETime = DateTime.Parse(txtBxEnd.Text);

                            int comp1 = DateTime.Compare(iniSTime, iniETime);
                            int comp2 = DateTime.Compare(iniETime, iniSTime.AddMinutes(minPerWindow * 2));

                            if (comp1 < 0 && comp2 < 0)
                            {
                                throw new Exception("Invalid Time Slot Selected!");
                            }
                        }
                        Console.WriteLine(iniSTime + " " + iniETime + " " + iniNTime + " " + firstTicketNo);
                        frmain.frmMain_Update(iniSTime, iniETime, iniNTime, minPerWindow, guestPerWindow, firstTicketNo, true);
                        frmain.Focus();
                        this.Close();
                    }
                    catch(Exception E)
                    {
                        MessageBox.Show(E.Message.ToString());
                    }
                }
            }
        }
        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";
            
            errorMessage += Validator.IsPresent(txtBxMinPerWindow.Text, txtBxMinPerWindow.Tag.ToString());
            errorMessage += Validator.IsPresent(txtBxGuestsPerWindow.Text, txtBxGuestsPerWindow.Tag.ToString());
            errorMessage += Validator.IsPresent(txtBxStart.Text, txtBxStart.Tag.ToString());
            errorMessage += Validator.IsPresent(txtBxEnd.Text, txtBxEnd.Tag.ToString());
            errorMessage += Validator.IsPresent(txtBxFstTckNo.Text, txtBxFstTckNo.Tag.ToString());

            errorMessage += Validator.IsInt32(txtBxMinPerWindow.Text, txtBxMinPerWindow.Tag.ToString());
            errorMessage += Validator.IsInt32(txtBxGuestsPerWindow.Text, txtBxGuestsPerWindow.Tag.ToString());
            errorMessage += Validator.IsInt32(txtBxFstTckNo.Text, txtBxFstTckNo.Tag.ToString());

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return success;
        }
    }
}