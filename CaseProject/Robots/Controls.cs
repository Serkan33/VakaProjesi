using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using CaseProject.LinkedList;
using System.Diagnostics;

namespace CaseProject.Robots
{
    class Controls
    {
        public RoList roList;
        private RotationNode east;
        private RotationNode south;
        private RotationNode west;
     
        private bool vergeBool;
        public Controls()
        {
            vergeBool = true;
            roList = new RoList(new RotationNode((char)Enums.NORTH, null));
            east = new RotationNode((char)Enums.EAST, roList.firstNode);
            south = new RotationNode((char)Enums.SOUTH, east);
            west = new RotationNode((char)Enums.WEST, south);
            roList.addNode(east);
            roList.addNode(south);
            roList.addNode(west);
            roList.lastNode.next = roList.firstNode;
            roList.firstNode.prev = roList.lastNode;
            roList.currentNode = roList.firstNode;
        }
        
        public void setState(Robot r,char charKey)
        {
            if (!r.isDone)
            {
                switch (charKey)
                {
                    case (char)Enums.LEFT:
                        r.state = roList.currentNode.next.state;
                        roList.currentNode = roList.currentNode.next;
                        if (r.location.X<1)
                        {
                            r.location = new Point(r.location.X+15,r.location.Y);
                        }
                        else if (r.location.X>Start.rec.Size.Width)
                        {
                            r.location = new Point(r.location.X - 15, r.location.Y);
                        }
                        r.angle += 90;
                        break;
                    case (char)Enums.RIGHT:
                        r.state = roList.currentNode.prev.state;
                        roList.currentNode = roList.currentNode.prev;
                        r.angle -= 90;
                        break;
                }
            }
           
        }

        public Point move(Robot r)
        {
            
           Point p = vergeControl(r,Start.rec.Size);
            if (!vergeBool)
            {
                vergeBool = true;
                return p; }
            Point newP=new Point();
            switch(r.state)
            {
                case  (char)Enums.NORTH :
                    newP = new Point(r.location.X,r.location.Y-1);
                    break;
                case (char)Enums.EAST:
                    newP = new Point(r.location.X + 1, r.location.Y);
                    break;
                case (char)Enums.SOUTH:
                    newP = new Point(r.location.X, r.location.Y+1);
                    break;
                case (char)Enums.WEST:
                    newP = new Point(r.location.X-1, r.location.Y);
                    break;
            }
            return newP;
        }
        
        public Point vergeControl(Robot r,Size size)
        {
            if (r.isDone)
            {
                r.location = r.location;
                vergeBool = false;
            }
            else if (r.location.X < 15 &&(r.state==(char)Enums.EAST|| r.state == (char)Enums.WEST))
            {
                r.location = new Point(r.location.X + 1, r.location.Y);
                vergeBool = false;
            }
             else if (r.location.X < 0)
            {
                r.location = new Point(r.location.X + 1, r.location.Y);
                vergeBool = false;
            }
            else if (r.location.X > (size.Width-(r.size.Height+4)))
            {
                r.location = new Point(r.location.X - 1, r.location.Y);
                vergeBool = false;
            }
            else if (r.location.Y < 0)
            {
                 r.location = new Point(r.location.X, r.location.Y+1);
                vergeBool = false;
            }
            else if (r.location.Y > (size.Height-120))
            {
                 r.location = new Point(r.location.X, r.location.Y - 1);
                vergeBool = false;
            }

            return r.location;
        }
        

    }
}
