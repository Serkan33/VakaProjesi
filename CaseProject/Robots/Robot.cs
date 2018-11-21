using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaseProject.Robots
{

    //Robot model 
    class Robot 
    {
       public Point location { set; get; }
       public Point firstLocation { set; get; } 
       public Size size { set; get; }
       private Rectangle robot;
       public int angle { set; get; }
       public char state = (char)Enums.NORTH;
        public bool isDone { set; get; }
       
        public Robot()
        {
            robot = new Rectangle();
            angle = 0;
            isDone = false;
            location = new Point(new Random().Next(15, Start.rec.Width), new Random().Next(50, Start.rec.Height)-50);
            size = new Size(30,60);
           
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
        // Robot is building this method
        public Rectangle buildRobot()
        {
            robot.Location = location;
            robot.Size = size;
            
            return robot;
        }

    }
}
