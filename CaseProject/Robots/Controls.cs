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
        public RotationNode east;
        public RotationNode south;
        public RotationNode west;

        public Controls()
        {
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
            switch(charKey)
            {
                case (char)Enums.LEFT: r.state = roList.currentNode.next.state;
                    roList.currentNode = roList.currentNode.next;
                    r.angle += 90;
                    break;
                case (char)Enums.RIGHT: r.state = roList.currentNode.prev.state;
                    roList.currentNode= roList.currentNode.prev;
                    r.angle -= 90;
                    break;
            }
        }

        public Point move(Robot r)
        {
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
    }
}
