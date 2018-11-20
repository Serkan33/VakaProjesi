using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaseProject.Robots
{
    class Robot 
    {
       public Point location { set; get; }
       public Point firstLocation { set; get; } 
       public Size size { set; get; }
       private Rectangle robot;
       public int angle { set; get; }
       public char state { set; get; }
       public bool isDone { set; get; } 
       public Robot()
        {
            robot = new Rectangle();
            angle = 0;
            isDone = false;
        }

       public Robot(Point p,Size s)
        {
            location = p;
            size = s;
        }
        public Robot(int x , int y, int width, int height)
        {
            location = new Point(x,y);
            size = new Size(width,height);
        }

        public Rectangle buildRobot()
        {
            robot.Location = location;
            robot.Size = size;
            return robot;
        }
    }
}
