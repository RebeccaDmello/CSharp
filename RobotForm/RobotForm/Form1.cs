using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobotForm
{
    public partial class Form1 : Form
    {
        private int x = 0, y = 0;
        int move = 10;
        Robot robot = new Robot(0, 0, "N");

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo1_Click(object sender, EventArgs e)
        {
            move = 1;
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            //robot.curPosition = new Point(x,y);
            robot.move("W", move);
            lblArrow.Text = "ç";
            x = robot.curPosition.X;
            y= robot.curPosition.Y;
            lblArrow.SetBounds(x, y, 0, 0);
            lblRes.Text = "{X=" + x + ",Y=" + y + "}";

        }

        private void btnN_Click(object sender, EventArgs e)
        {
            //robot.curPosition = new Point(x, y);
            robot.move("N", move);
            lblArrow.Text = "é";
            x = robot.curPosition.X;
            y = robot.curPosition.Y;
            lblArrow.SetBounds(x, y, 0, 0);
            lblRes.Text = "{X=" + x + ",Y=" + y + "}";
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            //robot.curPosition = new Point(x, y);
            robot.move("E", move);
            lblArrow.Text = "è";
            x = robot.curPosition.X;
            y = robot.curPosition.Y;
            lblArrow.SetBounds(x, y, 0, 0);
            lblRes.Text = "{X=" + x + ",Y=" + y + "}";
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            //robot.curPosition = new Point(x, y);
            robot.move("S", move);
            lblArrow.Text = "ê";
            x = robot.curPosition.X;
            y = robot.curPosition.Y;
            lblArrow.SetBounds(x, y, 0, 0);
            lblRes.Text = "{X=" + x + ",Y=" + y + "}";
        }

        private void btnGo10_Click(object sender, EventArgs e)
        {
            move = 10;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private void Form1_Load(object sender, EventArgs e)
        {
            //lblArrow.SetBounds(x, y , 0 , 0);
            lblArrow.Location = new Point(panelArrow.Location.X / 4 + panelArrow.Width / 2 - lblArrow.Width / 2, 60);
        }
    }
}
