using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobotForm
{
    class Robot
    {
        public string curDir = "N";
        int x = 0, y = 0;

        public Point curPosition
        {
            get;set;
        }

        public Robot(int x, int y, string curDir)
        {
            this.x = x;
            this.y = y;
            this.curPosition = new Point(x,y);
            this.curDir = curDir;
        }

        public void move(string curDirin, int move)
        {
            this.curDir = curDirin;
            switch (curDir)
            {
                case "N":
                    x = curPosition.X;
                    y = curPosition.Y;
                    if (y > 0)
                    {
                        y -= move;
                        curPosition = new Point(x, y);
                    }
                    else
                    {
                        MessageBox.Show("It has reached the maximum range of 0 to 100");
                    }
                    break;
                case "E":
                    x = curPosition.X;
                    y = curPosition.Y;
                    if (x < 100)
                    {
                        x += move;
                        curPosition = new Point(x, y);
                    }
                    else
                    {
                        MessageBox.Show("It has reached the maximum range of 0 to 100");
                    }
                    break;
                case "W":
                    x = curPosition.X;
                    y = curPosition.Y;
                    if (x > 0)
                    {
                        x -= move;
                        curPosition = new Point(x, y);
                    }
                    else
                    {
                        MessageBox.Show("It has reached the maximum range of 0 to 100");
                    }
                    break;
                case "S":
                    x = curPosition.X;
                    y = curPosition.Y;
                    if (y < 100)
                    {
                        y += move;
                        curPosition = new Point(x, y);
                    }
                    else
                    {
                        MessageBox.Show("It has reached the maximum range of 0 to 100");
                    }
                    break;
                default:
                    break;
            }

        }
    }
}
