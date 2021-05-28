using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreCalculator
{ 
    public partial class Form1 : Form
    {
        private int total, count;
        private double score, scoreTotal, scoreCount, average;
     
        public Form1()
        {
            InitializeComponent();
        }

        //user pressing enter button from keyboard
        private void txtBoxScore_KeyDown(object sender, KeyEventArgs a)
        {
            if(a.KeyCode == Keys.Enter)
            {
                button1_Click(sender, a);
            }
        }
      
        //user pressing esc key from keyboard

        //clear button
        private void button3_Click(object sender, EventArgs e)
        {
            total = 0;
            count = 0;
            foreach(Control txtBoxScore in Controls)
            {
                if (txtBoxScore is TextBox)
                {
                    txtBoxScore.Text = " ";
                    txtBoxScore.Focus();
                }
            }
        }

        //Add button
        private void button1_Click(object sender, EventArgs e)
        {
           score = Convert.ToInt32(txtBoxScore.Text);
           txtBoxScore.Text = "";
            
        }

        //exit button
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
