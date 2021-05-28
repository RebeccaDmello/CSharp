using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeCalculator
{
    public partial class Form1 : Form
    {
        private int amount, qua, dim, nic, pen;
        //Calculate Button
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                try
                {
                    amount = Convert.ToInt32(textBox1.Text);
                    qua = amount / 25;
                    amount -= (qua * 25);
                    dim = amount / 10;
                    amount -= (dim * 10);
                    nic = amount / 5;
                    amount -= (nic * 5);
                    pen = amount;
                    textBox2.Text = qua.ToString();
                    textBox3.Text = dim.ToString();
                    textBox4.Text = nic.ToString();
                    textBox5.Text = pen.ToString();

                }catch(Exception err)
                {
                    Console.WriteLine("Error: Invalid Number");
                    textBox1.Focus();
                }
            }
        }
        //user pressing enter button from keyboard
        private void textBox1_KeyDown(object sender, KeyEventArgs a)
        {
            if(a.KeyCode == Keys.Enter)
            {
                btnCalculate_Click(sender,a);
            }
        }
        public Form1()
        {
            InitializeComponent();
            this.CancelButton = button2; //when user press "ESC" key on keyboard
            this.AcceptButton = btnCalculate;
        }

        //exit button
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
