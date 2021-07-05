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
    public partial class frmMain : Form
    {
        public int remTickets = 7, count = 1, MAX_TICKETS = 5, iniTicketNo = 0, MAX_GUESTS = 5, minperWindow = 0;
        public DateTime nxtSlot = DateTime.Parse("06:00:00 PM");
        public DateTime startSlot = DateTime.Parse("06:00:00 PM");
        public DateTime endSlot = DateTime.Parse("06:30:00 PM");
        public DateTime titleTime = new DateTime();
        public Timer titUpdate;
        public bool flag = false;
        Ticket ticket;
        TimeSlot timeSlot;
        
        frmOption frmopt;
       
        public frmMain()
        {
            InitializeComponent();
        }

        private void Title_Update(object sender, EventArgs e)
        {
            titleTime = DateTime.Parse(DateTime.Now.ToString("h:mm:ss tt"));
            if (titleTime >= startSlot && titleTime <= endSlot)
            {
                this.Text = titleTime.ToString("h:mm:ss tt") + " (Open)";
                this.btnIssue.Enabled = true;
            }
            else
            {
                this.Text = titleTime.ToString("h:mm:ss tt") + " (Closed)";
                this.btnIssue.Enabled = false;
            }
                
            this.Update();
        }
              
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString("h:mm:ss tt");
            this.Update();
            //lblTckRes.Text = remTickets.ToString();
            //lblNextSlot.Text = (nxtSlot.AddMinutes(MAX_GUESTS)).ToString("h:mm tt");
            titUpdate = new Timer();
            titUpdate.Tick += new EventHandler(Title_Update);
            titUpdate.Interval = 1000;
            this.Activated += AfterLoading;
            if(flag == true)
                titUpdate.Start();
        }

        private void AfterLoading(object sender, EventArgs e)
        {
            this.Activated -= AfterLoading;
            Load_OptionForm();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("All outstanding tickets will be deleted!!!\nYou want to continue?", "Confirm", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                this.lblGuests.Text = "1 - " + MAX_GUESTS;
                Load_OptionForm();
            }
        }

        private void Load_OptionForm()
        {
            frmopt = new frmOption();
            frmopt.Show();
            frmopt.Focus();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (count != MAX_TICKETS + 1 && remTickets != -1)
            {
                ticket = new Ticket(count, startSlot);
                lstResult.Items.Add("Ticket " + count + ": " + startSlot.ToString("h:mm tt"));
                count++;
                remTickets--;
                //ticket.setNxtTicketNumber(count);
                ticket.NextTicketNumber = count; //SET

                lblTckRes.Text = remTickets.ToString();
            }
        }

        public void frmMain_Update(DateTime iniSTime, DateTime iniETime, DateTime iniNTime, int minPerWindow, int guestPerWindow, int firstTicketNo, bool flag)
        {
            startSlot = iniSTime;
            endSlot = iniETime;
            nxtSlot = iniNTime;
            lblNextSlot.Text = iniNTime.ToString("h:mm tt");
            count = firstTicketNo;
            MAX_TICKETS = guestPerWindow;
            MAX_GUESTS = guestPerWindow;
            remTickets = guestPerWindow;
            minperWindow = minPerWindow;
            this.flag = flag;
            
            if (flag == true)
                titUpdate.Start();

            lstResult.Items.Clear();
            this.lblTckRes.Text = remTickets.ToString();
            timeSlot = new TimeSlot(iniSTime, minPerWindow, guestPerWindow); 
            Console.WriteLine(iniSTime + " " + iniETime + " " + iniNTime + " " + firstTicketNo);
        }
    }
}
